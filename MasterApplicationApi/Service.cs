using MasterApplicationApi.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MasterApplicationApi
{
    public class Service
    {
        private readonly NeonDbContext _dbContext;
        public  Service(NeonDbContext dbContext)
        {
            _dbContext= dbContext;

        }
        public  async Task Log_api(string Api_Type,string Type , object Content,string req_id)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();
            var maxCode = await _dbContext.TblApiLogs.MaxAsync(x => (int?)x.SysCode) ?? 0;
            try
            {

                var LOG = new TblApiLog
                {
                    SysCode = maxCode + 1,
                    ApiType = Api_Type,
                    Type = Type,
                    Content = JsonSerializer.Serialize(Content),
                    RequestId = req_id,
                    CreatedOn = DateTime.Now
                };

                _dbContext.TblApiLogs.Add(LOG);
                await _dbContext.SaveChangesAsync();
                await transaction.CommitAsync();

            }
            catch (Exception ex )
            {
                await transaction.RollbackAsync();
                throw;
            }

        }
        public async Task WriteErrorLogAsync(string message)
        {
            try
            {
                var directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
                Directory.CreateDirectory(directory);

                var filePath = Path.Combine(directory, $"LogFile_{DateTime.Now:dd_MM_yyyy}.txt");

                var logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ==> {message}{Environment.NewLine}";

                await File.AppendAllTextAsync(filePath, logMessage);
            }
            catch
            {
                // Last fallback — never throw from logger
            }
        }

        public async Task WriteRequestLogAsync(string request, string apiName, string requestId, string reqResp)
        {
            try
            {
                var directory = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "RequestLog",
                    apiName,
                    DateTime.Now.ToString("yyyyMMdd"));

                Directory.CreateDirectory(directory);

                var filePath = Path.Combine(directory, $"{requestId}.txt");

                var content = $"{DateTime.Now:HH:mm:ss} {reqResp} ===> {request}{Environment.NewLine}";

                await File.AppendAllTextAsync(filePath, content);
            }
            catch (Exception ex)
            {
                await WriteErrorLogAsync($"{ex.Message} | {reqResp} | {apiName} | {requestId}");
            }
        }

    }
}

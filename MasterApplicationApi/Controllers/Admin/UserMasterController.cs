using MasterApplicationApi.DBContext;
using MasterApplicationApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace MasterApplicationApi.Controllers.Admin
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserMasterController : ControllerBase
    {

        private readonly NeonDbContext _DbContext;
        private readonly Service _service;
        public UserMasterController(NeonDbContext dbContext, Service service)
        {
            _DbContext = dbContext;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> UserList([FromBody] UserListRequest Request)
        {
            try
            {
                if (Request == null ||string.IsNullOrWhiteSpace(Request.Request_Id) ||Request.PageNumber <= 0 ||Request.PageSize <= 0 ||string.IsNullOrWhiteSpace(Request.LoginUserId))
                {
                    return BadRequest(new 
                    {
                        RequestId = Request?.Request_Id ?? "",
                        Success = false,
                        Message = "Invalid request parameters"
                    });
                }
               await  _service.WriteRequestLogAsync(JsonSerializer.Serialize(Request), "USER_LIST", Request.Request_Id + "_Req", "Request");
               await  _service.Log_api("USER_LIST", "REQUEST", Request, Request.Request_Id);

                if (Request.PageNumber <= 0)
                {
                    Request.PageNumber = 1;
                }
                if (Request.PageSize <= 0)
                {
                    Request.PageSize = 1;
                }

                var query = _DbContext.TblAdmUsermasters.AsQueryable();

                if (!string.IsNullOrWhiteSpace(Request.Username))
                {
                    query = query.Where(x => x.Username != null && x.Username.ToLower().Contains(Request.Username.Trim().ToLower()));
                }

                if (!string.IsNullOrWhiteSpace(Request.Fullname))
                {
                    query = query.Where(x => x.Fullname != null && x.Fullname.ToLower().Contains(Request.Fullname.Trim().ToLower()));
                }

                var totalrecords = await query.CountAsync();

                var users = await query.OrderBy(x => x.Code).Skip((Request.PageNumber - 1) * Request.PageSize).Take(Request.PageSize).Select(s => new { s.Code, s.Username, s.Fullname, s.Mobileno, s.Gender, s.Locked, s.Isadmin, s.Isaduser, s.Createdby, s.Createiondate, s.Designation, s.Dob, s.Doj }).ToListAsync();
                var Response = new
                {
                    TotalRecords = totalrecords,
                    Request.PageNumber,
                    Request.PageSize,
                    Data = users
                };
                await _service.WriteRequestLogAsync(JsonSerializer.Serialize(Response), "USER_LIST", Request.Request_Id + "_Res", "Response");
                await _service.Log_api("USER_LIST", "RESPONSE", Response, Request.Request_Id);

                return Ok(Response);


            }
            catch (Exception ex)
            {
                var errorResponse = new 
                {
                    RequestId = Request.Request_Id,
                    Success = false,
                    Message = "Internal server error"
                };
                await _service.WriteRequestLogAsync(ex.ToString(), "USER_LIST", Request.Request_Id + "_Res", "Response");
                await  _service.Log_api("USER_LIST", "RESPONSE", errorResponse, Request.Request_Id);
                return StatusCode(500, errorResponse);
            }

        }
    }
}

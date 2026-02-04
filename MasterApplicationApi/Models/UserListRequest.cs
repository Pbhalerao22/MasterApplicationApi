namespace MasterApplicationApi.Models
{
    public class UserListRequest
    {
        public string LoginUserId { get; set; }
        public string Request_Id { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public string? Username { get; set; }
        public string? Fullname { get; set; }
    }
 

}

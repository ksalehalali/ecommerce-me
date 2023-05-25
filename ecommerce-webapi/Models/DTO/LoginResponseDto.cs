namespace ecommerce_webapi.Models.DTO
{
    public class LoginResponseDto
    {
        public string JwtToken { get; set; }
        public string UserName { get; set; }
        public string[] Roles { get; set; }
    }
}

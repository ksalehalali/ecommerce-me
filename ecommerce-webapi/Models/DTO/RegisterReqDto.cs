using System.ComponentModel.DataAnnotations;

namespace ecommerce_webapi.Models.DTO
{
    public class RegisterReqDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string[] Roles  { get; set; }
    }
}

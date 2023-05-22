﻿using System.ComponentModel.DataAnnotations;

namespace ecommerce_webapi.Models.DTO
{
    public class LoginReqDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

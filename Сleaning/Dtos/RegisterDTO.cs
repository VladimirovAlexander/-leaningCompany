﻿using System.ComponentModel.DataAnnotations;

namespace Сleaning.Dtos
{
    public class RegisterDTO
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

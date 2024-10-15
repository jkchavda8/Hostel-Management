﻿using System.ComponentModel.DataAnnotations;

namespace Hostel_Management.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

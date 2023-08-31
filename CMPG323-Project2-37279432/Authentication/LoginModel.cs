﻿using System.ComponentModel.DataAnnotations;

namespace CMPG323_Project2_37279432.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

    }

}

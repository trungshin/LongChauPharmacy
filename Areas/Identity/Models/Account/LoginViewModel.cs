﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FptLongChauApp.Areas.Identity.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Must enter {0}")]
        [Display(Name = "UserName Or Email")]
        public string UserNameOrEmail { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember your login information?")]
        public bool RememberMe { get; set; }
    }
}

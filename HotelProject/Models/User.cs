﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Логин")]
        public string Email { get; set; }
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Роль")]
        public string RoleId { get; set; }

    }
}

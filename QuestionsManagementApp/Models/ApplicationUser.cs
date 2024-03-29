﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsManagementApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [ForeignKey("ForeignDepartment")]
        public int UserDepartment { get; set; }
        public QuestionsDepartments ForeignDepartment { get; set; }
    }
}

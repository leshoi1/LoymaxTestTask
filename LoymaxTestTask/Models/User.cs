using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoymaxTestTask.Models
{
    public class User
    {
        public int id { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FamilyName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int Funds { get; set; }
    }
}
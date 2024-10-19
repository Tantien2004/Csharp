﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyview
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }

        public string Address {  get; set; }
        public string KhoaHoc { get; set; } 
        public string MaLopHoc { get; set; }
        public string ImagePath { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

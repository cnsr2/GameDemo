﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int BirthYear { get; set; }
    }
}

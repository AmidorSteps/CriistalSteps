﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneCode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class ConditionUse
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}

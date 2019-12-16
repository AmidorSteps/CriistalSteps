using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Rapprochement
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Reliquat { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
    }
}

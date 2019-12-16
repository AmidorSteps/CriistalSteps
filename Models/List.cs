using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class List
    {
        [Key]
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime UpdateDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Remise
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        public int NumberIterationByClient { get; set; }
        public int TotalNumberIteration { get; set; }
        public double Amount { get; set; }
    }
}

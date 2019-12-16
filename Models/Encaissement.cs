using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Encaissement
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Client Company { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        public int CreatedBy { get; set; }
    }
}

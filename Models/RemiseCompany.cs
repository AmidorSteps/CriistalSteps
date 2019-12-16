using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class RemiseCompany
    {
        [Key]
        public int Id { get; set; }
        public int RemiseID { get; set; }
        public int CompanyID { get; set; }
        public int FactureID { get; set; }
        [ForeignKey("RemiseID")]
        public Remise Remise { get; set; }
        [ForeignKey("CompanyID")]
        public Client Company { get; set; }
        [ForeignKey("FactureID")]
        public Document Document { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class RapprochementDetail
    {
        [Key]
        public int Id { get; set; }
        public int RapprochementID { get; set; }
        public int EncaissementID { get; set; }
        public int FactureID { get; set; }
        [ForeignKey("RapprochementID")]
        public Rapprochement Rapprochement { get; set; }
        [ForeignKey("EncaissementID")]
        public Encaissement Encaissement { get; set; }
        [ForeignKey("FactureID")]
        public Document Document { get; set; }
    }
}

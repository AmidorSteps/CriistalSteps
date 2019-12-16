using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class UserIndemnisation
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int IndemnisationStateID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CodeVirement { get; set; }
    }
}

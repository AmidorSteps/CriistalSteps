using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class ParticipantList
    {
        [Key]
        public int Id { get; set; }
        public int ParticipantID { get; set; }
        public int ListID { get; set; }
        [ForeignKey("ParticipantID")]
        public virtual User Participant { get; set; }
        [ForeignKey("ListID")]
        public virtual List List { get; set; }
    }
}

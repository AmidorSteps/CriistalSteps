using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Indemnisation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        [DataType(DataType.Date)]
        public DateTime IndemnisationDate { get; set; }
        public string State { get; set; }
        public int FolderID { get; set; }
        [ForeignKey("FolderID")]
        public Folder Folder { get; set; }
    }
}

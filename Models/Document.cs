using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int IndemnisationID { get; set; }
        [ForeignKey("IndemnisationID")]
        public Indemnisation Indemnisation { get; set; }
        public double TaxFolder { get; set; }
        public double TVA { get; set; }
        public string Note { get; set; }
        public int FolderID { get; set; }
        [ForeignKey("FolderID")]
        public Folder Folder { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        public int CreatedBy { get; set; }
    }
}

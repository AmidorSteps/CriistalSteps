using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Reglement
    {
        [Key]
        public int Id { get; set; }
        public int FolderID { get; set; }
        [ForeignKey("FolderID")]
        public Folder Folder { get; set; }
        public string XMLName { get; set; }
        public string RIB { get; set; }
        public string PayPal { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        public double Amount { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ExploitationDate { get; set; }
    }
}

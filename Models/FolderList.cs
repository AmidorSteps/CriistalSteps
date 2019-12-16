using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class FolderList
    {
        [Key]
        public int Id { get; set; }
        public int FolderID { get; set; }
        public int ListID { get; set; }
        [ForeignKey("FolderID")]
        public Folder Folder { get; set; }
        [ForeignKey("ListID")]
        public List List { get; set; }
    }
}

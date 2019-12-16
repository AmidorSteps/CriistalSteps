using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public int FolderID { get; set; }
        [ForeignKey("FolderID")]
        public Folder Folder { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        public int NoteCategoryID { get; set; }
        [ForeignKey("NoteCategoryID")]
        public NoteCategory NoteCategory { get; set; }
        public bool Pinned { get; set; }
    }
}

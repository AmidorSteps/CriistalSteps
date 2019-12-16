using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Folder
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Client Company { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        public int SumParticipant { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ValidationDate { get; set; }
        public FolderState  FolderState { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ClosingDate { get; set; }
        public double PaidAmount { get; set; }
        public double UnpaidAmount { get; set; }
        public string Avoir { get; set; }
    }
    public enum FolderState
    {
        Ready,
        InProgress,
        Closed
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class UserRole
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }
    }
}

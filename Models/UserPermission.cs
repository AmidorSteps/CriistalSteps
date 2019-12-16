using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class UserPermission
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PermissionID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        [ForeignKey("PermissionID")]
        public virtual Permission Permission { get; set; }
        public bool Active { get; set; }
    }
}

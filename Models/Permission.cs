using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Permission
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<UserPermission> UserPermissions { get; set; }
    }
}

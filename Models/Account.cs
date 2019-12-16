using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string BankName { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        public int UpdatedBy { get; set; }
    }
}

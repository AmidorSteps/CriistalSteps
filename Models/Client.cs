using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tarification { get; set; }
        public string TarificationType { get; set; }
        public CompanyType CompanyType { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public int Mobile { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Website { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string EmailComptable { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public int PhoneComptable { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public int MobileComptable { get; set; }
        public string Siret { get; set; }
        public bool Exonored { get; set; }
        public string TVAnumber { get; set; }
        public string CodeNaf { get; set; }
        public string FirstAdress { get; set; }
        public string SecondAdress { get; set; }
        public string City { get; set; }

        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
        public Country Country { get; set; }
        public bool SimilarAdress { get; set; }
        public string FactureAdress { get; set; }
        public string BankAccount { get; set; }
        public DateTime RIBCreationDate { get; set; }
        public string Domiciliation { get; set; }
        public string BIC { get; set; }
        public string AccountOwner { get; set; }
    }
    public enum CompanyType
    {
        SA,
        SARL
    }
}

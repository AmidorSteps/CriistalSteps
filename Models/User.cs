using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Criistal.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Prénom")]
        public string FirstName { get; set; }
        [Display(Name = "Nom")]
        public string LastName { get; set; }
        [Display(Name = "Adresse 1")]
        public string FirstAdress { get; set; }
        [Display(Name = "Adresse 2")]
        public string SecondAdress { get; set; }
        [Display(Name = "Cité")]
        public string City { get; set; }
        [Display(Name = "Code Postal")]
        public int ZipCode { get; set; }
        [Display(Name = "Pays")]
        public Country Country { get; set; }
        [Display(Name = "Fonction")]
        public string Function { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Mot de passe")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Genre")]
        public Gender Gender { get; set; }
        [Display(Name = "Telephone fixe")]
        public int Phone { get; set; }
        [Display(Name = "Telephone mobile")]
        public int Mobile { get; set; }
        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Metode de paiement")]
        public PaymentMethod PaymentMethod { get; set; }
        public string RIB { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }
        public string PayPal { get; set; }
        public string Domiciliation { get; set; }
        public bool ValidateYN { get; set; }
        [Display(Name = "Etat")]
        public int State { get; set; }
        [Display(Name = "Date de creation")]
        public DateTime CreationDate { get; set; }
        [Display(Name = "Date de modification")]
        public DateTime UpdateDate { get; set; }
        [Display(Name = "Ajouté(e) par")]
        public int CreatedBy { get; set; }
        [Display(Name = "Modifié(e) par")]
        public int UpdatedBy { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
    public enum Gender
    {
        [Display(Name = "Homme")]
        Man,
        [Display(Name = "Femme")]
        Women
    }
    public enum PaymentMethod
    {
        Virement,
        PayPal
    }
}

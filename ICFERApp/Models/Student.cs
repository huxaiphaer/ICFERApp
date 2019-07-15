using System;
using System.ComponentModel.DataAnnotations;

namespace ICFERApp.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name="Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        [Display(Name="Nationality")]
        public string Nationality { get; set; }
        [Display(Name="Gender")]
        public string Gender { get; set; }
        [Display(Name="Religion")]
        public string Religion { get; set; }
        [Display(Name="Medical Condition")]
        public string MedicalCondition { get; set; }
        [Display(Name="Deceased")]
        public string Deceased { get; set; }
        [Display(Name="Home Address")]
        public string HomeAddress { get; set; }
        [Display(Name="Country Of Residence")]
        public string CountryOfResidence { get; set; }
        [Display(Name="City")]
        public string City { get; set; }
        [Display(Name="Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public virtual Parents Parents { get; set; }
        public virtual Education Education { get; set; }
        public virtual Guardian Guardian { get; set; }
        public virtual Siblings Siblings { get; set; }
    }
}
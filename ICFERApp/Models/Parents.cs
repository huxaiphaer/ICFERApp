using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICFERApp.Models
{
    public class Parents
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        [Display(Name="Religion Of Deceased Father")]
        public string ReligionOfDeceasedFather { get; set; }
        [Display(Name="Religion Of Deceased Mother")]
        public string ReligionOfDeceasedMother { get; set; }
        [Display(Name="Date Of Demise Father")]
        [DisplayFormat( DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfDemiseOfFather { get; set; }
        
        [DisplayFormat( DataFormatString = "{0:MM/dd/yyyy}")]
        
        public DateTime DateOfDemiseOfMother { get; set; }
        [Display(Name="Names of Mother")]
        public string NamesOfMother { get; set; }
        [Display(Name="Names of Father")]
        public string NamesOfFather { get; set; }
        [Display(Name="Religion of Mother")]
        public string ReligionOfMother { get; set; }
        [Display(Name="Marital Status of Mother")]
        public string MaritalStatusOfMother { get; set; }
        [Display(Name="Occupation of Mother")]
        public string OccupationOfMother { get; set; }
        [Display(Name="Monthly Income")]
        public double MonthlyIncome { get; set; }
        public virtual Student Student { get; set; }
      
        public long StudentId { get; set; }
        
    }
}
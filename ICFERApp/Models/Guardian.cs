using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICFERApp.Models
{
    public class Guardian
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        
        [Display(Name="Guardian First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name="Guardian Middle Name")]
        [Required]
        public string MiddleName { get; set; }
        [Display(Name="Guardian Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name="Guardian Relationship to Orphan")]
        [Required]
        public string RelationshipToOrphan { get; set; }
        [Display(Name="Guardian Occupation")]
        [Required]
        public string Occupation { get; set; }
        [Display(Name="Guardian Monthly Income")]
        [Required]
        public string MonthlyIncome { get; set; }
        [Display(Name="Guardian Employers Name")]
        [Required]
        public string EmployersName { get; set; }
        [Display(Name="Guardian Work Address")]
        [Required]
        public string WorkAddress { get; set; }
        [Display(Name="Guardian Mobile Number")]
        [Required]
        public string MobileNo { get; set; }
        [Display(Name="Guardian Physical Location")]
        [Required]
        public string PhysicalLocation { get; set; }
        [Display(Name="Guardian Comments")]
        [Required]
        public string Comments { get; set; }
        public virtual Student Student { get; set; }
     
        public  long StudentId { get; set; }
    }
}
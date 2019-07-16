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
        public string FirstName { get; set; }
        [Display(Name="Guardian Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name="Guardian Last Name")]
        public string LastName { get; set; }
        [Display(Name="Guardian Relationship to Orphan")]
        public string RelationshipToOrphan { get; set; }
        [Display(Name="Guardian Occupation")]
        public string Occupation { get; set; }
        [Display(Name="Guardian Monthly Income")]
        public string MonthlyIncome { get; set; }
        [Display(Name="Guardian Employers Name")]
        public string EmployersName { get; set; }
        [Display(Name="Guardian Work Address")]
        public string WorkAddress { get; set; }
        [Display(Name="Guardian Mobile Number")]
        public string MobileNo { get; set; }
        [Display(Name="Guardian Physical Location")]
        public string PhysicalLocation { get; set; }
        [Display(Name="Guardian Comments")]
        public string Comments { get; set; }
        public virtual Student Student { get; set; }
     
        public  long StudentId { get; set; }
    }
}
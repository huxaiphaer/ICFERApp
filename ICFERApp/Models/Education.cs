using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICFERApp.Models
{
    public class Education
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        [Display(Name="Education Level")]
        public string EducationLevel { get; set; }
        [Display(Name="School")]
        public string School { get; set; }
        [Display(Name="Address of School")]
        public string AddressOfSchool { get; set; }
        [Display(Name="Head Teacher")]
        public string HeadTeacher { get; set; }
        [Display(Name="Telephone")]
        public string Telephone { get; set; }
        public  virtual Student Student { get; set; }
        
     
        public long StudentId { get; set; }
    }
}
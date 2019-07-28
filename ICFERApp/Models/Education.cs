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
        [Required]
        public string EducationLevel { get; set; }
        [Display(Name="School")]
        [Required]
        public string School { get; set; }
        [Display(Name="Address of School")]
        [Required]
        public string AddressOfSchool { get; set; }
        [Display(Name="Head Teacher")]
        [Required]
        public string HeadTeacher { get; set; }
        [Display(Name="Telephone")]
        [Required]
        public string Telephone { get; set; }
        public  virtual Student Student { get; set; }
        
     
        public long StudentId { get; set; }
    }
}
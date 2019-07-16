using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICFERApp.Models
{
    public class Siblings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        [Display(Name="Number of Brothers")]
        public int NumberOfBrothers { get; set; }
        [Display(Name="Number of Sisters")]
        public int NumberOfSisters { get; set; }
        
        public Student Student { get; set; }
      
        public  long StudentId { get; set; }
    }
}
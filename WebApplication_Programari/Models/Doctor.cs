using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_Programari.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Nume { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Prenume { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Specializare { get; set; }
        [Required]
        public string Descriere {  get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get { return $"{Nume} {Prenume}"; } }
        public ICollection<Programare>? Programari { get; set; }
    }
}

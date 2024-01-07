using System.ComponentModel.DataAnnotations;

namespace WebApplication_Programari.Models
{
    public class Programare
    {
        public int ID{ get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Nume { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Prenume { get; set; }
        [Required]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "CNP-ul trebuie să conțină exact 13 cifre.")]

        public string CNP {  get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string TipAnimal {  get; set; }
        [Required]
        public DateTime? Data { get; set; }
        [Required]
        public int? DoctorID { get; set; }
        public Doctor? Doctor {  get; set; }

    }
}

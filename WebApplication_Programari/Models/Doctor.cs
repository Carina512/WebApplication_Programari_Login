using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_Programari.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Specializare { get; set; }
        public string Descriere {  get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get { return $"{Nume} {Prenume}"; } }
        public ICollection<Programare>? Programari { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebApplication_Programari.Models
{
    public class Review
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Opinie { get; set; }

        [Range(0, 5, ErrorMessage = "Nota trebuie să fie între 0 și 5")]
        public int Nota {  get; set; }
    }
}

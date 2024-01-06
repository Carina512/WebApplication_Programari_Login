namespace WebApplication_Programari.Models
{
    public class Programare
    {
        public int ID{ get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP {  get; set; }
        public string TipAnimal {  get; set; }
        public DateTime? Data { get; set; }

        public int? DoctorID { get; set; }
        public Doctor? Doctor {  get; set; }

    }
}

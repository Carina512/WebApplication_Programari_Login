namespace WebApplication_Programari.Models
{
    public class Notificare
    {
        public string id {  get; set; }
        public string Nume { get; set; }

        public string Prenume { get; set; }
        public string mesaj { get; set; }

        public DateTime data{ get; set; }
        public ICollection<Programare>? Programare { get; set; }

    }
}

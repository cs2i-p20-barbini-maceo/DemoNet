namespace demoNet
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne(string nom, string prenom) 
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

    }

    public class Dummy
    {
        public void demo() 
        {
            Personne p = new Personne("Barbini", "Macéo");
            List<Personne> personnes = new List<Personne>();
            var personnes2 = new List<Personne>();
            //p.Nom = "Barbini";
            //p.Prenom = "Macéo";
        }
    }
}
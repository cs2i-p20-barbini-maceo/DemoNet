namespace demoNet
{
    public class PersonneFormation
    {
        private Personne _personne;

        public PersonneFormation(string nom, string prenom, string formation)
        {
            this._personne = new Personne(nom, prenom);
            this.Formation = formation;
        }
        public string Formation { get; set; }

        public string Nom
        {
            get { return this._personne.Nom; }
            set { this._personne.Nom = value; }
        }
    }

}

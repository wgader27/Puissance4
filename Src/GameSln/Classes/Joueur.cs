namespace Classes
{
    public class Joueur
    {
        private string nom;
        private string status;
        private int nbr_gagne;
        private int nbr_perdu;
        private int nbr_egalite;
        private int nbr_jouer;
        private string choix_pion;

        private string Nom
        { 
            get 
            { 
                return nom; 
            }
            set 
            { 
                nom = value; 
            }
        }
        public string Status
        {
            get
            {
                return status ;
            }
            set
            {
                Status = value;
            }
        }
        public int NbrGagne
        {
            get { 
            return nbr_gagne;
            }
            set
            {
                nbr_gagne = value;
            }
        }

        public int NbrPerdu
        {
            get
            {
                return nbr_perdu;
            }
            set
            {
                nbr_perdu = value;
            }
        }

        public int NbrEgalite
        {
            get
            {
                return nbr_egalite;
            }
            set
            {
                nbr_egalite = value;
            }
        }

        public int NbrJouer
        {
            get
            {
                return nbr_jouer;
            }
            set
            {
                nbr_jouer = value;
            }
        }

        public Joueur(string nom , string status_joueur)
        {
            this.nom = nom;
            status = status_joueur;
            nbr_gagne = 0;
            nbr_egalite = 0;
            nbr_perdu = 0;
            nbr_jouer= 0;
            choix_pion = "jaune";
        }
        public Joueur(string nom)
        {
            this.nom = nom;
            status = "invite";
            nbr_gagne = 0;
            nbr_perdu = 0;
            nbr_egalite = 0;
            nbr_jouer = 0;
            choix_pion = "jaune";
        }
    }
}

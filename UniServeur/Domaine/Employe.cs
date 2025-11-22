using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domaine
{
  public  class Employe :Personne
    {
        private String Fonction;
        private int salaire;
        private String DateEmbauche;

        public Employe() { }

        public Employe(String nom, String prenom, String sexe, String nif, String adresse, String telephone, String email, String dateNaissance, String statut, String fonction, int salaire)
      : base(nom, prenom, sexe, nif, adresse, telephone, email, dateNaissance, statut)
        {
           
            this.Fonction = fonction;
            this.salaire = salaire;
            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");
            this.DateEmbauche = datedujour;
        }

        public String getFonction()
        {
            return Fonction;
        }


        public void setFonction(String Fonction)
        {
            this.Fonction = Fonction;
        }


        public int getSalaire()
        {
            return salaire;
        }


        public void setSalaire(int salaire)
        {
            this.salaire = salaire;
        }


        public String getDateEmbauche()
        {
            return DateEmbauche;
        }


        public void setDateEmbauche(String DateEmbauche)
        {
            this.DateEmbauche = DateEmbauche;
        }
    

   
    }
}

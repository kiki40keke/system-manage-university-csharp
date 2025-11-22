using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Utilisateur
    {
        private String codeUser;
        private String NomUser;
        private String MotPasse;
        private String Etat;
        private String Dateenreg;
        //constructeus par defaut
        public Utilisateur() { }

        //Creation du constructeurs normal
        public Utilisateur(String codeUser, String nomUser, String motPasse)
        {

            this.codeUser = codeUser;
            this.NomUser = nomUser;
            this.MotPasse = motPasse;
            this.Etat = "1";
            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");
            this.Dateenreg = datedujour;
        }

        public String getCodeUser()
        {
            return codeUser;
        }

        public void setCodeUser(String codeUser)
        {
            this.codeUser = codeUser;
        }



        public String getNomUser()
        {
            return NomUser;
        }

        /**
         * @param NomUser the NomUser to set
         */
        public void setNomUser(String NomUser)
        {
            this.NomUser = NomUser;
        }

        /**
         * @return the MotPasse
         */
        public String getMotPasse()
        {
            return MotPasse;
        }

        /**
         * @param MotPasse the MotPasse to set
         */
        public void setMotPasse(String MotPasse)
        {
            this.MotPasse = MotPasse;
        }

        /**
         * @return the Statut
         */


        /**
         * @param Statut the Statut to set
         */


        /**
         * @return the Etat
         */
        public String getEtat()
        {
            return Etat;
        }

        /**
         * @param Etat the Etat to set
         */
        public void setEtat(String Etat)
        {
            this.Etat = Etat;

        }

        public String getDateenreg()
        {
            return Dateenreg;
        }

        public void setDateenreg(String Dateenreg)
        {
            this.Dateenreg = Dateenreg;
        }
    
    }
}

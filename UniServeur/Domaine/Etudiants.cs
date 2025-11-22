using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Etudiants
    {

        private String CodeEtud;
        private String Nom;
        private String Prenom;
        private String Sexe;
        private String DateNaiss;
        private String Nif;
        private String Adresse;
        private String Email;
        private String Phone;
        private String NomResponsable;
        private String PhoneResponsable;
        private String Vacation;
        private String NomOption;
        private String datEnregistr;
        private String promotion;
        private String Niveau;

        public Etudiants() { }
        public Etudiants(String Nom, String Prenom, String Sexe, String DateNaiss, String Nif, String Adresse, String Email, String Phone, String NomResponsable, String PhoneResponsable, String Vacation, String NomOption)
        {
            Random rd = new Random();
            int val = rd.Next(1111 + 9999);
            this.CodeEtud = "Etud-" + val;

            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Sexe = Sexe;
            this.DateNaiss = DateNaiss;
            this.Nif = Nif;
            this.Adresse = Adresse;
            this.Email = Email;
            this.Phone = Phone;
            this.NomResponsable = NomResponsable;
            this.PhoneResponsable = PhoneResponsable;
            this.Vacation = Vacation;
            this.NomOption = NomOption;
            this.Niveau = "1";
            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");
            this.datEnregistr = datedujour;

           
            string datedujour2 = dt.ToString("yyyy");
            this.promotion = datedujour2;

        }


        //
        public void setCodeEtud(String CodeEtud)
        {
            this.CodeEtud = CodeEtud;
        }

        public void setNom(String Nom)
        {
            this.Nom = Nom;
        }

        public void setPrenom(String Prenom)
        {
            this.Prenom = Prenom;
        }

        public void setSexe(String Sexe)
        {
            this.Sexe = Sexe;
        }

        public void setDateNaiss(String DateNaiss)
        {
            this.DateNaiss = DateNaiss;
        }

        public void setNif(String Nif)
        {
            this.Nif = Nif;
        }

        public void setAdresse(String Adresse)
        {
            this.Adresse = Adresse;
        }

        public void setEmail(String Email)
        {
            this.Email = Email;
        }

        public void setPhone(String Phone)
        {
            this.Phone = Phone;
        }

        public void setNomResponsable(String NomResponsable)
        {
            this.NomResponsable = NomResponsable;
        }

        public void setPhoneResponsable(String PhoneResponsable)
        {
            this.PhoneResponsable = PhoneResponsable;
        }

        public void setVacation(String Vacation)
        {
            this.Vacation = Vacation;
        }

        public void setNomOption(String NomOption)
        {
            this.NomOption = NomOption;
        }



        public void setDatEnregistr(String datEnregistr)
        {
            this.datEnregistr = datEnregistr;
        }

        public void setPromotion(String promotion)
        {
            this.promotion = promotion;
        }


        //Accesseur

        public String getCodeEtud()
        {
            return CodeEtud;
        }

        public String getNom()
        {
            return Nom;
        }

        public String getPrenom()
        {
            return Prenom;
        }

        public String getSexe()
        {
            return Sexe;
        }

        public String getDateNaiss()
        {
            return DateNaiss;
        }

        public String getNif()
        {
            return Nif;
        }

        public String getAdresse()
        {
            return Adresse;
        }

        public String getEmail()
        {
            return Email;
        }

        public String getPhone()
        {
            return Phone;
        }

        public String getNomResponsable()
        {
            return NomResponsable;
        }

        public String getPhoneResponsable()
        {
            return PhoneResponsable;
        }

        public String getVacation()
        {
            return Vacation;
        }

        public String getNomOption()
        {
            return NomOption;
        }


        public String getDatEnregistr()
        {
            return datEnregistr;
        }

        public String getPromotion()
        {
            return promotion;
        }

        public String getNiveau()
        {
            return Niveau;
        }

        public void setNiveau(String Niveau)
        {
            this.Niveau = Niveau;
        }
    
    
    }
}

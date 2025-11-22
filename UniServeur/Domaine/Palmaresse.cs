using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Palmaresse
    {
        private String Codepalmares;
        private String Id_Opt;
        private String Id_Cours;
        private String NomVacation;
        private int Coeficienttotal;
        private String Promotion;
        private String Datepalmares;

        public Palmaresse()
        {
        }

        public Palmaresse(String Id_Opt, String Id_Cours, String NomVacation, String Promotion)
        {
            Random rd = new Random();
            int val = rd.Next(111111 + 999999);
            String code = "Palm-" + val;
            this.Codepalmares = code;
            this.Id_Opt = Id_Opt;
            this.Id_Cours = Id_Cours;
            this.NomVacation = NomVacation;
            this.Coeficienttotal = 100;
            this.Promotion = Promotion;


            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");
            this.Datepalmares = datedujour;
        }

        public String getCodepalmares()
        {
            return Codepalmares;
        }

        public void setCodepalmares(String Codepalmares)
        {
            this.Codepalmares = Codepalmares;
        }

        public String getId_Opt()
        {
            return Id_Opt;
        }

        public void setId_Opt(String Id_Opt)
        {
            this.Id_Opt = Id_Opt;
        }

        public String getId_Cours()
        {
            return Id_Cours;
        }

        public void setId_Cours(String Id_Cours)
        {
            this.Id_Cours = Id_Cours;
        }


        public String getNomVacation()
        {
            return NomVacation;
        }

        public void setNomVacation(String NomVacation)
        {
            this.NomVacation = NomVacation;
        }

        public int getCoeficienttotal()
        {
            return Coeficienttotal;
        }

        public void setCoeficienttotal(int Coeficienttotal)
        {
            this.Coeficienttotal = Coeficienttotal;
        }

        public String getPromotion()
        {
            return Promotion;
        }

        public void setPromotion(String Promotion)
        {
            this.Promotion = Promotion;
        }


        public String getDatepalmares()
        {
            return Datepalmares;
        }

        public void setDatepalmares(String Datepalmares)
        {
            this.Datepalmares = Datepalmares;
        }

  
             
    }
}

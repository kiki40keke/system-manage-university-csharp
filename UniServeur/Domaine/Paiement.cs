using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class ModalitePaiement
    {
        private String codepc;
        private String Id_Opt;
        private double fraisInscription;
        private double fraisDentres;
        private double fraisSession;
        private String Dateenreg;

        public ModalitePaiement()
        {
        }

        public ModalitePaiement(String Id_Opt, double fraisInscription, double fraisDentres, double fraisSession)
        {
            this.codepc = "Paie-" + Id_Opt;
            this.Id_Opt = Id_Opt;
            this.fraisInscription = fraisInscription;
            this.fraisDentres = fraisDentres;
            this.fraisSession = fraisSession;
            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");
            this.Dateenreg = datedujour;
        }

        public String getCodepc()
        {
            return codepc;
        }

        public void setCodepc(String codepc)
        {
            this.codepc = codepc;
        }

        public String getId_Opt()
        {
            return Id_Opt;
        }

        public void setId_Opt(String Id_Opt)
        {
            this.Id_Opt = Id_Opt;
        }

        public double getFraisInscription()
        {
            return fraisInscription;
        }

        public void setFraisInscription(double fraisInscription)
        {
            this.fraisInscription = fraisInscription;
        }

        public double getFraisDentres()
        {
            return fraisDentres;
        }

        public void setFraisDentres(double fraisDentres)
        {
            this.fraisDentres = fraisDentres;
        }

        public double getFraisSession()
        {
            return fraisSession;
        }

        public void setFraisSession(double fraisSession)
        {
            this.fraisSession = fraisSession;
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

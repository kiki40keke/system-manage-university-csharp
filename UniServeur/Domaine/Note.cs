using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public class Note
    {
        private String codenotnormal;
        private String codeEvaluationsNormal;
        private String Id_Etud;
        private double notenormal;
        private String Dateenregnormal;

        public Note()
        {
        }

        public Note(String codeEvaluationsNormal, String Id_Etud, double notenormal)
        {
            Random rd = new Random();
            int val = rd.Next(111111 + 999999);
            String code = "Notes-" + val;
            this.codenotnormal = code;
            this.codeEvaluationsNormal = codeEvaluationsNormal;
            this.Id_Etud = Id_Etud;
            this.notenormal = notenormal;
            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");
            this.Dateenregnormal = datedujour;
        }

        public String getCodenotnormal()
        {
            return codenotnormal;
        }

        public void setCodenotnormal(String codenotnormal)
        {
            this.codenotnormal = codenotnormal;
        }

        public String getCodeEvaluationsNormal()
        {
            return codeEvaluationsNormal;
        }

        public void setCodeEvaluationsNormal(String codeEvaluationsNormal)
        {
            this.codeEvaluationsNormal = codeEvaluationsNormal;
        }

        public String getId_Etud()
        {
            return Id_Etud;
        }

        public void setId_Etud(String Id_Etud)
        {
            this.Id_Etud = Id_Etud;
        }

        public double getNotenormal()
        {
            return notenormal;
        }

        public void setNotenormal(double notenormal)
        {
            this.notenormal = notenormal;
        }

        public String getDateenregnormal()
        {
            return Dateenregnormal;
        }

        public void setDateenregnormal(String Dateenregnormal)
        {
            this.Dateenregnormal = Dateenregnormal;
        }

   
    }
}

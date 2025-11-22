using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
  public  class EvaluationsNormal
    {
        private String codeEvaluationsNormal;
        private String Codepalmares;
        private String TypesNormal;
        private String DescriptionsNormal;
        private int CoeficientNormal;
        private String DateEvaluationsNormal;

        public EvaluationsNormal()
        {
        }

        public EvaluationsNormal(String Codepalmares, String TypesNormal, String DescriptionsNormal, int CoeficientNormal)
        {
            Random rd = new Random();
            int val = rd.Next(111111 + 999999);
            String code = "EvNor-" + val;
            this.codeEvaluationsNormal = code;
            this.Codepalmares = Codepalmares;
            this.TypesNormal = TypesNormal;
            this.DescriptionsNormal = DescriptionsNormal;
            this.CoeficientNormal = CoeficientNormal;
            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");
            this.DateEvaluationsNormal = datedujour;
        }

        public String getCodeEvaluationsNormal()
        {
            return codeEvaluationsNormal;
        }

        public void setCodeEvaluationsNormal(String codeEvaluationsNormal)
        {
            this.codeEvaluationsNormal = codeEvaluationsNormal;
        }

        public String getCodepalmares()
        {
            return Codepalmares;
        }

        public void setCodepalmares(String Codepalmares)
        {
            this.Codepalmares = Codepalmares;
        }

        public String getTypesNormal()
        {
            return TypesNormal;
        }

        public void setTypesNormal(String TypesNormal)
        {
            this.TypesNormal = TypesNormal;
        }

        public String getDescriptionsNormal()
        {
            return DescriptionsNormal;
        }

        public void setDescriptionsNormal(String DescriptionsNormal)
        {
            this.DescriptionsNormal = DescriptionsNormal;
        }

        public int getCoeficientNormal()
        {
            return CoeficientNormal;
        }

        public void setCoeficientNormal(int CoeficientNormal)
        {
            this.CoeficientNormal = CoeficientNormal;
        }

        public String getDateEvaluationsNormal()
        {
            return DateEvaluationsNormal;
        }

        public void setDateEvaluationsNormal(String DateEvaluationsNormal)
        {
            this.DateEvaluationsNormal = DateEvaluationsNormal;
        }



    }
}

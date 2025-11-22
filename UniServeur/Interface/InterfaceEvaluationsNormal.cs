using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Interface
{
  public  interface InterfaceEvaluationsNormal
    {
        String EnregistrerEvaluation(String Codepalmares, String TypesNormal, String DescriptionsNormal, int CoeficientNormal);
        ArrayList RechercherEvaluation(String codeEvaluationsNormal);
        String RechercherCodeEvaluation(String Codepalmares, String TypesNormal, String DescriptionsNormal);
        string[,] ListerEvaluation();
        string[,] ListerNotes(String codeEvaluationsNormal);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Interface
{
  public  interface InterfaceNote
    {
        String EnregistrerNotesNormalNote(String codeEvaluationsNormal, String Id_Etud, double notenormal);
        ArrayList FicheNote(String codeEvaluationsNormal, String Id_Etud);
        String ModifierNote(String codeEvaluationsNormal, String Id_Etud, double notenormal);
        String SupprimmerNote(String codeEvaluationsNormal, String Id_Etud);
        String[,] ListerBulletin(String Nom_Opt, String codeniv, String codesession, String Id_Etud, String NomVacation, String Promotion);
        ArrayList RechercherBulletin(String codeniv, String codesession, String Id_Etud);
    }
}

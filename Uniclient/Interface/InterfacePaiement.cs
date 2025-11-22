using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Interface
{
   public interface InterfacePaiement
    {
        String EnregistrerPaiement(String Nom_Opt, double fraisInscription, double fraisDentres, double fraisSession);
        ArrayList FichePaiement(String codepc);
        ArrayList FichePaiement2(String Nom_Opt);
        DataSet ListerPaiement();
        string ModifierPaiement(String codepc, String Nom_Opt, String Dateenreg, double fraisInscription, double fraisDentres, double fraisSession);
        String enregTransfert(String Id_Etud, double momtant);
        DataSet ListerAncienPaiement();
        DataSet Listertransactions(); 
    }
}

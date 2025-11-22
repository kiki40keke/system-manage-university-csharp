using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Interface
{
   public interface InterfacePalmares
    {
            String Palmaresse( String NomOption, String  NomCours, String NomVacation, String Promotions) ;
            string[,] ListerPalmares(String codepalmares);
   
      String RechercherCodePalmaresse(String NomOption, String NomCours, String NomVacation, String Promotions) ;
     ArrayList RechercherPalmares( String codepalmares) ;
       string[,] ListerPalmares2();
    }
}

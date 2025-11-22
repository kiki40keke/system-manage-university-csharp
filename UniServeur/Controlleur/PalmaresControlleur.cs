using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using Domaine;
using Dal;
using System.Data;
using System.Collections;

namespace Controlleur
{
    public class PalmaresControlleur : MarshalByRefObject, Interface.InterfacePalmares
    {
        public String Palmaresse(String NomOption, String  NomCours, String NomVacation, String Promotion) {
     ServicesCours ser =new ServicesCours();
        String message;
     
        String Idop=     ser.RechercherCodeOption(NomOption);
     
       String Nomc= ser.RechercherCodeCours(NomOption, NomCours);
           
           
        Palmaresse pa=new   Palmaresse(Idop, Nomc, NomVacation, Promotion);
        
        
       PalmaresseDal pad=new PalmaresseDal();
        message=     pad.RechercherCodePlamares(Idop, Nomc, NomVacation, Promotion);
                 
        if(message!=null){
        message ="il existe deja un palmares pour le meme option,cours,vacation,Promotion";
        
        }
        else{
        message=  pad.EnregistrerPalmares(pa);
        }

       

      
      return message;
        
    }
        //
         public String RechercherCodePalmaresse(String NomOption, String NomCours, String NomVacation, String Promotions)  {
      ServicesCours ser =new ServicesCours();
        
     
        String Idop=     ser.RechercherCodeOption(NomOption);
        
       String Nomc= ser.RechercherCodeCours(NomOption, NomCours);
             
           
        Palmaresse pa=new   Palmaresse(Idop, Nomc, NomVacation, Promotions);
        
        
       PalmaresseDal pad=new PalmaresseDal();
     String    message=     pad.RechercherCodePlamares(Idop, Nomc, NomVacation, Promotions);
          
         return message;
    }
        //
         public String[,] ListerPalmares2()  {
          PalmaresseDal pad=new PalmaresseDal();
         
          string[,] Palmares = pad.ListerPalmares2();
         // string[,] Palmares = tab2D;
          return Palmares;
    }

         public String[,] ListerPalmares(String codepalmares)
         {
             PalmaresseDal pad = new PalmaresseDal();

             string[,] Palmares = pad.ListerPalmares(codepalmares);
             return Palmares;
         }

         public ArrayList RechercherPalmares(String codepalmares)
         {
             ArrayList Al = new ArrayList();
             PalmaresseDal pad = new PalmaresseDal();
             Al = pad.RechercherPalmares2(codepalmares);
            
            return Al;

         }




    }
}

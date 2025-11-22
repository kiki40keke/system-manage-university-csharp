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
    public class ServicesControleur : MarshalByRefObject, Interface.InterfaceService
    {
          public string EnregistrerOption(String Nom_Opt)  {
            string message;
        ServicesCours ser=new ServicesCours(); 
       string Verfif=ser.RechercherCodeOption(Nom_Opt);
       if( "nada"!=Verfif){
       message="Il existe deja un option qui le meme nom";
       }
       else{
        message=ser.EnregistrerOption(Nom_Opt);
       }
       return message;
    }

          public DataSet listerOptions()
          {
              ServicesCours ser = new ServicesCours();
              DataSet vv = ser.listerOptions();
              return vv;
          }

          public ArrayList remplirComboOptions() {
              ArrayList Al = new ArrayList();
              ServicesCours ser = new ServicesCours();
              Al = ser.remplirComboOptions();
              return Al;
          
          }

        //

         public string EnregistrerCours(string Nom_Opt, string codeniv, string codesession,string Nomcours)  {
      string message;
        ServicesCours ser=new ServicesCours(); 
       string Verfif=ser.RechercherCodeCours(Nom_Opt, Nomcours);
        if("nada"!=Verfif){
       message="Il existe deja un Cours qui a le meme nom";
       }
        else{
       string Id_Opt=ser.RechercherCodeOption(Nom_Opt); 
        message=ser.EnregistrerCours(Id_Opt, codeniv, codesession, Nomcours);
        }
       return message;
    }
        //
         public DataSet listerCours()
         {
             ServicesCours ser = new ServicesCours();
             DataSet vv = ser.listerCours();
             return vv;
         }

        //
         public ArrayList remplirComboCours(String Nom_Opt, String Niveau, String Session)
         {
             ArrayList Al = new ArrayList();
             ServicesCours ser = new ServicesCours();
             String Id_Opt = ser.RechercherCodeOption(Nom_Opt);
             Al = ser.remplirComboCours(Id_Opt, Niveau, Session);
             return Al;

         }

        // selection
         public String EnregistrerCoursSelectionner(String IdProfesseur,String Nom_Opt, String Nom_Cours,String Vacation) {
      String message="";
        ServicesCours ser=new ServicesCours();
   String Idcours=ser.RechercherCodeCours(Nom_Opt, Nom_Cours);
     if("nada"==Idcours){
         
       message="ce cours n'existe pas";
       }
     else{
        String codecs=ser.RechercherAttributionCours(Idcours, Vacation);
        if(codecs==null){
        message=ser.EnregistrerCoursSelectionner(IdProfesseur, Nom_Opt, Nom_Cours,Vacation);
        }
        else{
               message="il extiste deja un professeur qui dispense ce cours dans la meme option et dans la  meme vacation";
        }
      
     }
   
   
   
   return message;
    }

        //
         public ArrayList remplirlisetecours(String Id_prof)
         {
             ArrayList Al = new ArrayList();
             ServicesCours ser = new ServicesCours();

             Al = ser.remplirlisetecours(Id_prof);
             return Al;

         }

         public String InformationCoursSelect(String codecs)  {
                 ServicesCours ser=new ServicesCours(); 
                 String mes=ser.InformationCoursSelect(codecs);
                 return  mes;
    }

         public String SuprimmerAttributionCours(String codecs)  {
          ServicesCours ser=new ServicesCours(); 
          String mes=ser.SuprimmerAttributionCours(codecs);
          return mes;
    }

    }
}

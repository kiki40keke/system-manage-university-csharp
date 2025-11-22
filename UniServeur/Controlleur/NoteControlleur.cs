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
    public class NoteControlleur : MarshalByRefObject, Interface.InterfaceNote
    {
         public String EnregistrerNotesNormalNote(String codeEvaluationsNormal, String Id_Etud,double notenormal)  {
        Note n=new Note(codeEvaluationsNormal, Id_Etud,notenormal);
        NoteDal dal=new NoteDal();
        String mes=dal.EnregistrerNotesNormal(n);
        return mes;
    }
        //
         public ArrayList FicheNote(String codeEvaluationsNormal, String Id_Etud)  {
        ArrayList Fiche=new ArrayList();
            Note n=new Note();
        NoteDal dal=new NoteDal();
        dal.RechercherNote(codeEvaluationsNormal, Id_Etud, n);
        Fiche.Add(n.getCodenotnormal());
        Fiche.Add(n.getCodeEvaluationsNormal());
        Fiche.Add(n.getId_Etud());
        Fiche.Add(n.getNotenormal());
        Fiche.Add(n.getDateenregnormal());
        
        return Fiche;
    }
        //
          public String ModifierNote(String codeEvaluationsNormal, String Id_Etud, double notenormal)  {
    NoteDal dal=new NoteDal();
    String message=dal.ModifierNotes(codeEvaluationsNormal, Id_Etud, notenormal);
    return message;
    }
        //
        public String SupprimmerNote(String codeEvaluationsNormal, String Id_Etud)  {
      NoteDal dal=new NoteDal();
      String message=dal.SuprimmerNotes(codeEvaluationsNormal, Id_Etud);
      return message;
    }
        //
        public string[,] ListerBulletin(String Nom_Opt,String codeniv,String codesession,String Id_Etud1,String NomVacation, String Promotion)
        {
            ServicesCours ser = new ServicesCours();
            String Id_Opt1 = ser.RechercherCodeOption(Nom_Opt);
            NoteDal dal = new NoteDal();

            string[,] ListerNotes = dal.ListerBulletin(Id_Opt1, codeniv, codesession, Id_Etud1, NomVacation, Promotion);
           

            string code = ListerNotes[0, 0].ToString();


            return ListerNotes;
        }
        //
        public ArrayList RechercherBulletin(String codeniv,String codesession, String Id_Etud)  {
       ArrayList RechercherBulletin=new ArrayList();
       NoteDal dal=new NoteDal();
       RechercherBulletin=dal.RechercherBulletin(codeniv, codesession, Id_Etud);
   //    String Options = (string)RechercherBulletin[0];
       return RechercherBulletin;
    }
    }
}

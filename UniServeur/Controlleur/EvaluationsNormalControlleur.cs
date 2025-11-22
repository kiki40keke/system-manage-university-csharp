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
    public class EvaluationsNormalControlleur : MarshalByRefObject, Interface.InterfaceEvaluationsNormal
    {
       public String EnregistrerEvaluation(String Codepalmares, String TypesNormal, String DescriptionsNormal, int CoeficientNormal)  {
        String message="";
    Palmaresse pal=new Palmaresse();
        PalmaresseDal palm=new PalmaresseDal();
        palm.RechercherPlamares(Codepalmares, pal);
        String gett=pal.getCodepalmares();

        if (gett != null)
        {


            EvaluationsNormal eval = new EvaluationsNormal(Codepalmares, TypesNormal, DescriptionsNormal, CoeficientNormal);
            EvaluationsNormalDal evd = new EvaluationsNormalDal();
            String Nombre = evd.RechercherSommationcoef(Codepalmares);
            String CodeEvaluation = evd.RechercherCodeEvaluation(Codepalmares, TypesNormal, DescriptionsNormal);
            message = CodeEvaluation;
            String Nom_Cours = evd.RechercherNomcours(Codepalmares);
            String Nom_Opt = evd.RechercherNomOption(Codepalmares);

            if (CodeEvaluation != null)
            {
                message = " Concernant le cours " + Nom_Cours + " de l'option " + Nom_Opt +
                        "\n il existe deja une Evaluation qui est de type " + TypesNormal + " et de description " + DescriptionsNormal +
                        " \n Veuillez changez le type ou la description ";
            }

            else if (Nombre == null)
            {
                // System.out.println("nombre la null");
                String messaga = evd.EnregistrerEvaluation(eval);
                Nombre = evd.RechercherSommationcoef(Codepalmares);
                String plus = "\n votre total de coefficiente pour le cours de " + Nom_Cours + " dans l'option " + Nom_Opt + "  est : " + Nombre + " sur 100";
                message = messaga + plus;
            }
            else
            {
                int coefficient = Int32.Parse(Nombre);
                int reste = 100 - coefficient;

                if (reste >= CoeficientNormal)
                {
                    // System.out.println("li ka pase");
                    String messaga = evd.EnregistrerEvaluation(eval);
                    Nombre = evd.RechercherSommationcoef(Codepalmares);
                    String plus = "\n votre total de coefficiente pour le cours de " + Nom_Cours + " dans l'option " + Nom_Opt + "  est : " + Nombre + " sur 100";
                    message = messaga + plus;
                }
                else
                {
                    //   System.out.println("li pa  ka pase");
                    message = "vous avez deja enregistrer plusieurs examen du meme cours et promotion le coefficient restant est : " + reste;
                }


            }



        }
        else
        {
            message = "le code du Palmaresse est introuvable";
        }
       
     
          
       return message;
    }
      public ArrayList RechercherEvaluation(String codeEvaluationsNormal)  {
      ArrayList Al=new ArrayList();
        EvaluationsNormalDal dal=new EvaluationsNormalDal();
        Al=dal.RechercherEvaluation(codeEvaluationsNormal);
        return Al;
    }
        //
         public String RechercherCodeEvaluation(String Codepalmares, String TypesNormal, String DescriptionsNormal)  {
  EvaluationsNormalDal dal=new EvaluationsNormalDal();
  String CodeEvaluation=dal.RechercherCodeEvaluation(Codepalmares, TypesNormal, DescriptionsNormal);
  return CodeEvaluation;
    }
        //
         public String[,] ListerEvaluation()
         {
             EvaluationsNormalDal pad = new EvaluationsNormalDal();

             string[,] ListerEvaluation = pad.ListerEvaluation();
             return ListerEvaluation;
         }
        //
         public string[,] ListerNotes(String codeEvaluationsNormal)
         {
             EvaluationsNormalDal pad = new EvaluationsNormalDal();

             string[,] ListerNotes = pad.ListedesNotes(codeEvaluationsNormal);
        //     string[,] ListerNotes = pad.ListerPalmares2();
             //string[,] Lis = new string[2, 5]{
             //{"1","2","3","4","5"},
             //  {"10","20","30","40","50"}
             //};

            
             //string d = "mama";
             //int ligne = ListerNotes.Length;
             //int div = ligne / 5;

           //  string code = ListerNotes[1, 1].ToString();


             return ListerNotes;
         }
    }
}

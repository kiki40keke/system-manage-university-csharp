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
    public class ControlleurPaiement : MarshalByRefObject, Interface.InterfacePaiement
    {
        public String EnregistrerPaiement(String Nom_Opt, double fraisInscription, double fraisDentres, double fraisSession)  {
  String message="";
        ServicesCours ser =new ServicesCours();
        String Idop=     ser.RechercherCodeOption(Nom_Opt);
  
          ModalitePaiement pai=new ModalitePaiement();
          
        ModalitePaiementDal dal=new ModalitePaiementDal();
         dal.RechercherPaiement2(Idop, pai);
         String codepc=pai.getCodepc();
         if(codepc==null){
              ModalitePaiement paie=new ModalitePaiement(Idop, fraisInscription, fraisDentres, fraisSession);
             message=dal.EnregistrerPaiement(paie);
         }
         else{
             
         message="Une modalide de cette Option existe deja vous pouvez la modifier";
         }
   return message;
    }
        //
        public ArrayList FichePaiement(String codepc)  {
   ArrayList Fiche=new ArrayList();
    ServicesCours ser =new ServicesCours();
         ModalitePaiement paie=new ModalitePaiement();
        ModalitePaiementDal dal=new ModalitePaiementDal();
        dal.RechercherPaiement(codepc, paie);
        Fiche.Add(paie.getCodepc());
        String Id_Opt=paie.getId_Opt();
        String Nom_Opt=ser.RechercherNomOptions(Id_Opt);
        Fiche.Add(Nom_Opt);
        
        Fiche.Add(paie.getFraisInscription().ToString());
        Fiche.Add(paie.getFraisDentres().ToString());
        Fiche.Add(paie.getFraisSession().ToString());
        Fiche.Add(paie.getDateenreg());
        
        return Fiche;
        
    }
        //
        public DataSet ListerPaiement()
        {
            ModalitePaiementDal Prodal = new ModalitePaiementDal();
            DataSet vv = Prodal.ListerPaiement();
            return vv;
        }
        //
        public string ModifierPaiement(String codepc, String Nom_Opt, String Dateenreg, double fraisInscription, double fraisDentres, double fraisSession){
            string message = null; ;
        ServicesCours ser =new ServicesCours();
    String Id_Opt=ser.RechercherCodeOption(Nom_Opt);   
             ModalitePaiement paie=new ModalitePaiement();
        ModalitePaiementDal dal=new ModalitePaiementDal();
     
         dal.RechercherPaiement2(Id_Opt, paie);
         String codepc2=paie.getCodepc();
         String Id_Opt2=paie.getId_Opt();
         double fraisInscription2=paie.getFraisInscription();
         double fraisDentres2 =paie.getFraisDentres();
         double fraisSession2=paie.getFraisSession();
         String Dateenreg2=paie.getDateenreg();


         int verif = dal.EnregistrerAncien(codepc2, Id_Opt2, Dateenreg2, fraisInscription2, fraisDentres2, fraisSession2);
         if (verif == 1)
         {
             message = dal.ModifierPaiement(codepc2, fraisInscription, fraisDentres, fraisSession);
         }



         else
         {
             message = "modification echouer";
         }
       
             return message;
    }
        //
        public ArrayList FichePaiement2(String Nom_Opt)  {
     ArrayList Fiche=new ArrayList();
    ServicesCours ser =new ServicesCours();
    String Id_Opt=ser.RechercherCodeOption(Nom_Opt);
         ModalitePaiement paie=new ModalitePaiement();
        ModalitePaiementDal dal=new ModalitePaiementDal();
        dal.RechercherPaiement2(Id_Opt, paie);
        Fiche.Add(paie.getCodepc());
        Id_Opt=paie.getId_Opt();
         Nom_Opt=ser.RechercherNomOptions(Id_Opt);
        Fiche.Add(Nom_Opt);

        Fiche.Add(paie.getFraisInscription().ToString());
        Fiche.Add(paie.getFraisDentres().ToString());
        Fiche.Add(paie.getFraisSession().ToString());
        Fiche.Add(paie.getDateenreg());
        
        return Fiche;
    }
        //
        public String enregTransfert(String Id_Etud, double momtant)  {
        String message="";
            Etudiants Etud=new Etudiants();
           EtudiantsDal etd=new EtudiantsDal();
           etd.RechercherEudiant(Id_Etud,Etud);
           Id_Etud=Etud.getCodeEtud();
          if(Id_Etud!=null){
          ModalitePaiementDal dal=new ModalitePaiementDal();
          String CodeCompte=dal.RechercherCodeCompte(Id_Etud);
          if(CodeCompte!=null){
              string Niv=Etud.getNiveau();
             int nivs=Int32.Parse(Niv);
               double Solde=Double.Parse( dal.RechercherSolde(CodeCompte));
               int ses2 = Int32.Parse(dal.RechercherFrais(Id_Etud));
    double Totalfrais=Double.Parse(dal.RechercherSommation(Id_Etud))*nivs;
    if(Solde==Totalfrais){
    message="La reglementation de paiement pour cette eleve est terminer";
    }
   
    else   if(Solde<Totalfrais){
        double reste=Totalfrais-Solde;
        if(momtant<=reste){
        dal.enregTransfert(CodeCompte, momtant);
         
             double montant3=Solde+momtant;
              dal.ModifierMontant(CodeCompte, montant3);
              message="Ce depot A ete Enregestre avec Succes";
        }
        
        else{
         message="Ce Montant est trop eleve Car la balance de cet etudiant pour son niveau actuelle est de "+reste;
        }

    }
        
    else{message="Une Erreur de paiemnt";} 
             
          }
          else{
            message="Ce Compte n'existe pas";
          }
          }
          
          else{
          message="Le code de cet etudiant est incorrect";
          }
       
           return message;
    }
        //
        public DataSet ListerAncienPaiement()
        {
            ModalitePaiementDal Prodal = new ModalitePaiementDal();
            DataSet vv = Prodal.ListerAncienPaiement();
            return vv;
        }
        //
        public DataSet Listertransactions()
        {
            ModalitePaiementDal Prodal = new ModalitePaiementDal();
            DataSet vv = Prodal.Listertransactions();
            return vv;
        }
    }
}

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
   public class ControlleurEtudiants : MarshalByRefObject, Interface.IEtudiants
    {
        public String EnregistrerEtudiant(String Nom, String Prenom, String Sexe, String DateNaiss, String Nif, String Adresse, String Email, String Phone,
            String NomResponsable, String PhoneResponsable, String Vacation, String NomOption)  {
       string message;
        Etudiants Etu=new Etudiants(); 
        EtudiantsDal etd=new EtudiantsDal();
         
            String req1="Select Id_Etud,Nom_Etud,Prenom_Etud,sexe,datNaiss,nif,adresse,email,phone,nomResponsable,numeroRefference,NomVacation,Nom_Opt"
                    + ",promotion,codeniv from Etudiant natural join options where nif='"+Nif+"' and Nom_Opt='"+NomOption+"'";
        String req2="Select Id_Etud,Nom_Etud,Prenom_Etud,sexe,datNaiss,nif,adresse,email,phone,nomResponsable,numeroRefference,NomVacation,Nom_Opt,promotion,codeniv"
                + " from Etudiant natural join options where nif='"+Nif+"' and NomVacation='"+Vacation+"'";
        etd.RechercherNifEudiant(req1, Etu);
         String code1=Etu.getCodeEtud();
        etd.RechercherNifEudiant(req2, Etu); 
         String code2=Etu.getCodeEtud();
         
          
         if(code1!=null){
          message="Cet Etudiant est deja inscrit dans la meme option nous avons pu l'indentifier grace a son nif";
          }
           
       else if(code2!=null){
          message="Cet Etudiant est deja inscrit dans une autre option de la meme vacation, veulleiz chnagez la vacation nous avons pu l'indentifier grace a son nif";
          }
     
       else{
         //  message="li ka enskri";
        ServicesCours ser =new ServicesCours();
        String Idop=     ser.RechercherCodeOption(NomOption);
        Etudiants Etud=new Etudiants(Nom,Prenom,Sexe,DateNaiss,Nif,Adresse,Email,Phone,NomResponsable,PhoneResponsable,Vacation,Idop);
       
       message=  etd.EnregistreEtudiant(Etud);
       }
       
      return  message;
    }
       //
       public ArrayList FicheEtudiant(String CodeEtud)  {
        ArrayList Fiche=new ArrayList();
          Etudiants Etud=new Etudiants();
           EtudiantsDal etd=new EtudiantsDal();
           
           etd.RechercherEudiant(CodeEtud,Etud);
           Fiche.Add(Etud.getCodeEtud());
           Fiche.Add(Etud.getNom());
           Fiche.Add(Etud.getPrenom());
           Fiche.Add(Etud.getSexe());
           Fiche.Add(Etud.getDateNaiss());
           String nif= Etud.getNif();
           Fiche.Add(nif);
           Fiche.Add(Etud.getAdresse());
           Fiche.Add(Etud.getEmail());
           String phone= Etud.getPhone();
           Fiche.Add(phone);
           
           Fiche.Add(Etud.getNomResponsable());
           String phoneRes=Etud.getPhoneResponsable();
           Fiche.Add(phoneRes);
           
           Fiche.Add(Etud.getVacation());
           Fiche.Add(Etud.getNomOption());
           Fiche.Add(Etud.getPromotion());
           Fiche.Add(Etud.getNiveau());
          
          
          return Fiche;
    }
        public String ModifierEtudiant(String CodeEtud, String Nom,String Prenom,String adresse,String email,String phone,String nomResponsable,String numeroRefference){
          EtudiantsDal etd=new EtudiantsDal();
     String message=  etd.ModifierEtudiant(CodeEtud, Nom, Prenom, adresse, email, phone, nomResponsable, numeroRefference);
      return  message;
    }
        public String SupprimmerEtudiant(String CodeEtud) {
            EtudiantsDal etd = new EtudiantsDal();
            String message = etd.SuprimmerEtudiant(CodeEtud);
            return message;
        }
        public DataSet ListerEtudiant()
        {
            EtudiantsDal Prodal = new EtudiantsDal();
            DataSet vv = Prodal.ListerEtudiant();
            return vv;
        }
           public String ReinscrireEtud(String Niv, String CodeEtud)  {
      //To change body of generated methods, choose Tools | Templates.
           
               Etudiants Etud = new Etudiants();
               EtudiantsDal etd = new EtudiantsDal();

               etd.RechercherEudiant(CodeEtud, Etud);
               string nomvacation = Etud.getVacation();
               string promotion = Etud.getPromotion();
      String message="";
               NoteDal d=new NoteDal();
               int nombre = d.RechercherBulletin2(Niv,CodeEtud,nomvacation,promotion);

               if (nombre >= 3)
               {
                   message = "L'etudiant n'est pas admissible pour passer au niveau superieur car il a un maximum de 3 reprises";
               }
               else
               {
                      int nivs=Int32.Parse(Niv);

                      if (nivs < 5)
                      {
                          ModalitePaiementDal dal = new ModalitePaiementDal();
                          String codeCompte = dal.RechercherCodeCompte(CodeEtud);
                          if (codeCompte != null)
                          {
                              double Solde = Double.Parse(dal.RechercherSolde(codeCompte));
                              double Totalfrais = Double.Parse(dal.RechercherSommation(CodeEtud)) * nivs;
                              int ses2 = Int32.Parse(dal.RechercherFrais(CodeEtud));

                              if (Solde < Totalfrais)
                              {
                                  double reste = Totalfrais - Solde;
                                  message = "L'etudiant ne peut pas inscrire au niveau superieur car il a une balance de " + reste;
                              }

                              else if (Solde == Totalfrais)
                              {
                                  //double reste=Totalfrais-Solde;
                                  // message="L'etudiant est aquite car il a une balance de "+reste;

                                  int nivs2 = nivs + 1;
                                  String niv3 = (nivs2).ToString();

                             
                                  message = etd.ReinscrireEtud(niv3, CodeEtud);
                              }



                          }

                          else
                          {
                              message = "Ce Compte n'existe pas";
                          }
                      }
                      else
                      {
                          message = "Cette Etudiant est deja au niveau 5";

                      }
               }
       return message; 
    }
           public int verifierpaie(String Niv, String CodeEtud,string session)
           {
               int permis = 0;
               //To change body of generated methods, choose Tools | Templates.
               String message = "";
               int nivs = Int32.Parse(Niv);
               int ses = Int32.Parse(session);
               
                   ModalitePaiementDal dal = new ModalitePaiementDal();
                   String codeCompte = dal.RechercherCodeCompte(CodeEtud);
                   if (codeCompte != null)
                   {
                       double Solde = Double.Parse(dal.RechercherSolde(codeCompte));
                       double Totalfrais = Double.Parse(dal.RechercherSommation(CodeEtud)) * nivs;
                       int ses2 = Int32.Parse(dal.RechercherFrais(CodeEtud));
                       if(ses==2){
                           if (Solde < Totalfrais)
                           {
                               double reste = Totalfrais - Solde;
                               message = "L'etudiant ne peut pas inscrire au niveau superieur car il a une balance de " + reste;
                               permis = 0;
                           }

                           else if (Solde >= Totalfrais)
                           {
                               permis = 1;
                           }
                       }

                       else if(ses==1){
                      
                         
                           if (Solde < Totalfrais-ses2)
                           {
                               double reste = Totalfrais - Solde;
                               message = "L'etudiant ne peut pas inscrire au niveau superieur car il a une balance de " + reste;
                               permis = 0;
                           }

                           else if (Solde >= Totalfrais-ses2)
                           {
                               permis = 1;
                           }
                       
                       }
                      



                   }

                   else
                   {
                       permis = 2;
                       message = "Ce Compte n'existe pas";
                   }
               
              

               return permis;
           }
    }
}

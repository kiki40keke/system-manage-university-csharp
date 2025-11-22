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
    public class ControlleurUtilisateur : MarshalByRefObject, Interface.InterfaceUtilisateur
    {
       public String EnregistrerUtilisateur(String codeUser,String nomUser,String motPasse)  {
   String message=null;
     
        UtilisateurDal dal=new UtilisateurDal ();
        String code=dal.RechercherCodeEmployer(codeUser);
        if(code!=null){
        message="Un Compte a ete deja Creer pour cet Employer";
        }
        else{
          Utilisateur Pro=new Utilisateur(codeUser, nomUser, motPasse);
         message=dal.EnregistrerUtilisateur(Pro);
        }
        return message;
    }

      //
        public ArrayList FicheUtilisateur(String code)  {
        Utilisateur Pro=new Utilisateur();
         UtilisateurDal dal=new UtilisateurDal ();
         ArrayList FicheUtilisateur=new ArrayList();
           dal.RechercherUtilisateur(code, Pro);
           FicheUtilisateur.Add(Pro.getCodeUser());
         FicheUtilisateur.Add(Pro.getNomUser());
         FicheUtilisateur.Add(Pro.getMotPasse());
         FicheUtilisateur.Add(Pro.getEtat());
         return FicheUtilisateur;
    }
      //
         public ArrayList FicheLogin(String nomUtilisateur, String MotPasse)  {
     Utilisateur Pro=new Utilisateur();
         UtilisateurDal dal=new UtilisateurDal ();
         ArrayList FicheLogin=new ArrayList();
           dal.Rechercherlogin(nomUtilisateur, MotPasse, Pro);
           FicheLogin.Add(Pro.getCodeUser());
         FicheLogin.Add(Pro.getNomUser());
         FicheLogin.Add(Pro.getMotPasse());
         FicheLogin.Add(Pro.getEtat());
         return FicheLogin;  
    }
      //
       public String ModifierUtilisateur(String nomUtilisateur, String MotPasse, String etat, String code)  {
         UtilisateurDal dal=new UtilisateurDal ();
         String message=dal.ModifierUtilisateur(nomUtilisateur, MotPasse, etat, code);
         return message;
    }
      //
       public DataSet ListerUtilisateur()
       {
           UtilisateurDal dal = new UtilisateurDal();
           DataSet vv = dal.ListerUtilisateur();
           return vv;
       }
        //
       public String TesteUtilisateur(String nomUtilisateur)
       {
           UtilisateurDal dal = new UtilisateurDal();
           String mes = dal.TestUtilisateur(nomUtilisateur);
           return mes;
       }


       public String EnregistrerTantative(String nomUser)
       {
           String message = null;
           UtilisateurDal dal = new UtilisateurDal();
           message = dal.EnregistrerTantative(nomUser);
           return message;
       }


       public int CompterTantative(String nomUtilisateur)
       {
           UtilisateurDal dal = new UtilisateurDal();
           int mes = dal.CompterTantative(nomUtilisateur);
           return mes;
       }

       public String BloqueUtilisateur(String nomUtilisateur)
       {
           UtilisateurDal dal = new UtilisateurDal();
           String message = dal.BloqueUtilisateur(nomUtilisateur);
           return message;
       }


       public int UtilisateurBloque(String nomUtilisateur)
       {
           UtilisateurDal dal = new UtilisateurDal();
           int mes = dal.UtilisateurBloque(nomUtilisateur);
           return mes;
       }


       public String DebloqueUtilisateur(String nomUtilisateur)
       {
           UtilisateurDal dal = new UtilisateurDal();
           String message = dal.DebloqueUtilisateur(nomUtilisateur);
           dal.supprimmerTantative(nomUtilisateur);
           return message;
       }
    }
}

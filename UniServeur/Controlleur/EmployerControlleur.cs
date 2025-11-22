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
    public class EmployerControlleur : MarshalByRefObject, Interface.InterfaceEmployer
    {
        public String EnregistrerEmployer(String nom, String prenom, String sexe, String nif, String adresse, String telephone, String email, String dateNaissance, String statut, String fonction, int salaire)
        {
         Employe Pro=new Employe(nom, prenom, sexe, nif, adresse, telephone, email, dateNaissance, statut, fonction, salaire);
        EmployerDal Prodal=new EmployerDal();
     String message=  Prodal.EnregistrerEmployer(Pro);
     return message;
    }
           
        public ArrayList FicheEmployer(String code)
        {
            Employe Pro = new Employe();
            ArrayList Fiche = new ArrayList();
            EmployerDal Prodal = new EmployerDal();
            Prodal.RechercherEmployer(code, Pro);
            Fiche.Add(Pro.getCode());
            Fiche.Add(Pro.getNom());
            Fiche.Add(Pro.getPrenom());
            Fiche.Add(Pro.getSexe());
            Fiche.Add(Pro.getNif());
            Fiche.Add(Pro.getAdresse());
            Fiche.Add(Pro.getTelephone());
            Fiche.Add(Pro.getEmail());

            Fiche.Add(Pro.getDateNaissance());
            Fiche.Add(Pro.getStatut());
            Fiche.Add(Pro.getFonction());
            Fiche.Add(Pro.getSalaire().ToString());
            return Fiche;
        }
        public String ModifierEmployer(String nom, String prenom, String telephone, String email, String adresse, String Statut,int salaire, String code)  {
        EmployerDal Prodal=new EmployerDal();
      String message=  Prodal.ModifierEmployer(nom, prenom, telephone, email, adresse, Statut,salaire, code);
      return message;
    }

        //
        public DataSet ListerEmployer()
        {
            EmployerDal Prodal = new EmployerDal();
            DataSet vv = Prodal.ListerEmployer();
            return vv;
        }
        public ArrayList remplirCombofonction() {

            EmployerDal Prodal = new EmployerDal();
            ArrayList Fiche = new ArrayList();
            Fiche = Prodal.remplirCombofonction();
            return Fiche;
        }
        public ArrayList recherchersalaire(string nomfonction)
        {

            EmployerDal Prodal = new EmployerDal();
            ArrayList Fiche = new ArrayList();
            Fiche = Prodal.recherchersalaire(nomfonction);
            return Fiche;
        }
    }
}

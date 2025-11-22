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
    public class ProfesseurControlleur : MarshalByRefObject, Interface.InterfaceProfesseur
    {

        public  string EnregistrerProfesseur(string Matricule_prof, string Nom_prof, string Prenom_prof, string Sexe_prof, string Tel_prof, string Email_prof, string Adresse_prof, string NumrefProf, string DateNaissance_prof, string professionprof, string Etat_prof)
        {
       Professeur Pro=new Professeur(Matricule_prof, Nom_prof, Prenom_prof, Sexe_prof, Tel_prof, Email_prof, Adresse_prof, NumrefProf, DateNaissance_prof, professionprof, Etat_prof);
       ProfesseurDal Prodal=new ProfesseurDal();
       string message = Prodal.EnregistrerProfesseur(Pro);
     return message;
    }

        public ArrayList FicheProfesseur(String Id_prof)
        {
     ArrayList Fiche=new ArrayList();
     Professeur Pro=new Professeur();
            ProfesseurDal Prodal=new ProfesseurDal();
            Prodal.rechercherProfesseur(Id_prof, Pro);
            Fiche.Add(Pro.getId_prof());
                 Fiche.Add(Pro.getMatricule_prof());
                      Fiche.Add(Pro.getNom_prof());
                           Fiche.Add(Pro.getPrenom_prof());
                                Fiche.Add(Pro.getSexe_prof());
                                     Fiche.Add(Pro.getTel_prof());
                                          Fiche.Add(Pro.getEmail_prof());
                                               Fiche.Add(Pro.getAdresse_prof());
                                               Fiche.Add(Pro.getNumrefProf());
                                               Fiche.Add(Pro.getDateNaissance_prof());
                                               Fiche.Add(Pro.getProfessionprof());
                                               Fiche.Add(Pro.getEtat_prof());
     
     return Fiche;
    }
        //
        public String ModifierProfesseur(string Nom_prof, string Prenom_prof, string Tel_prof, string Email_prof, string Adresse_prof, string Etat_prof, string Id_prof)
        {
       ProfesseurDal Prodal=new ProfesseurDal();
       string Message = Prodal.ModifierProfesseur(Nom_prof, Prenom_prof, Tel_prof, Email_prof, Adresse_prof, Etat_prof, Id_prof);
       return Message;
    }

        public DataSet listerProfesseur()
        {
              ProfesseurDal Prodal = new ProfesseurDal();
              DataSet vv = Prodal.listerProfesseur();
              return vv;
         }

    }
}

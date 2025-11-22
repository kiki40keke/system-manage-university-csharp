using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace Interface
{
   public interface InterfaceProfesseur
    {
        string EnregistrerProfesseur(string Matricule_prof, string Nom_prof, string Prenom_prof, string Sexe_prof, string Tel_prof, string Email_prof, string Adresse_prof, string NumrefProf, string DateNaissance_prof, string professionprof, string Etat_prof);
         ArrayList FicheProfesseur(string Id_prof);
         string ModifierProfesseur(string Nom_prof, string Prenom_prof, string Tel_prof, string Email_prof, string Adresse_prof, string Etat_prof, string Id_prof);
         DataSet listerProfesseur();
   }
}

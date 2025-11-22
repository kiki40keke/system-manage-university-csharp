using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Interface
{
   public interface IEtudiants
    {
        String EnregistrerEtudiant(String Nom, String Prenom, String Sexe, String DateNaiss, String Nif, String Adresse, String Email, String Phone, String NomResponsable, String PhoneResponsable, String Vacation, String NomOption);
        ArrayList FicheEtudiant(String CodeEtud);
        String ModifierEtudiant(String CodeEtud, String Nom, String Prenom, String adresse, String email, String phone, String nomResponsable, String numeroRefference);
        String SupprimmerEtudiant(String CodeEtud);
        DataSet ListerEtudiant();
        String ReinscrireEtud(String Niv, String CodeEtud);
        int verifierpaie(string Niv, string CodeEtud, string session);
    }
}

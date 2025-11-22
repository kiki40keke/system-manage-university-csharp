using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Interface
{
   public interface InterfaceEmployer
    {
          string EnregistrerEmployer(String nom,String prenom,String sexe,String nif,String adresse,String telephone,String email,String dateNaissance,String statut,String fonction,int salaire); 
         ArrayList FicheEmployer(String code); 
           String ModifierEmployer(String nom,String prenom,String telephone,String email,String adresse,String Statut,int salaire,String code);
           DataSet ListerEmployer();
           ArrayList remplirCombofonction();
           ArrayList recherchersalaire(string nomfonction);





    }
}

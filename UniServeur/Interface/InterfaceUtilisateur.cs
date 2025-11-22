using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Interface
{
   public interface InterfaceUtilisateur
    {
        String EnregistrerUtilisateur(String codeUser,String nomUser,String motPasse) ; 
          ArrayList FicheUtilisateur(String code);

          DataSet ListerUtilisateur(); 
         String ModifierUtilisateur(String nomUtilisateur, String MotPasse, String etat, String code);
         ArrayList FicheLogin(String nomUtilisateur,String MotPasse);
         String TesteUtilisateur(String nomUtilisateur);
         String EnregistrerTantative(String nomUser);
         int CompterTantative(String nomUtilisateur);
         String BloqueUtilisateur(String nomUtilisateur);
         int UtilisateurBloque(String nomUtilisateur);
         String DebloqueUtilisateur(String nomUtilisateur);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Interface
{
  public  interface InterfaceService
    {
      string EnregistrerOption(string Nom_Opt);
      DataSet listerOptions();
      ArrayList remplirComboOptions();

      //
      string EnregistrerCours(string Id_Opt, string codeniv, string codesession, string Nomcours);
      DataSet listerCours();
      ArrayList remplirComboCours(String Nom_Opt, String Niveau, String Session);
      String EnregistrerCoursSelectionner(String IdProfesseur, String Nom_Opt, String Nom_Cours, String Vacation);
      ArrayList remplirlisetecours(String Id_prof);
      string InformationCoursSelect(String codecs);
      string SuprimmerAttributionCours(String codecs);
     

    }
}

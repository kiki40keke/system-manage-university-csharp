using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
   public  class Professeur
    {
       private String Id_prof;
    private String Matricule_prof;
    private String Nom_prof;
    private String Prenom_prof;
    private String Sexe_prof;
    private String Tel_prof; 
    private String Email_prof;
    private String Adresse_prof;
    private String NumrefProf;
    private String DateNaissance_prof;
    private String professionprof;
    private String Etat_prof;
   private String DateInscription_prof;

    public Professeur() {
    }



    public Professeur(string Matricule_prof, string Nom_prof, string Prenom_prof, string Sexe_prof, string Tel_prof, string Email_prof, string Adresse_prof, string NumrefProf, string DateNaissance_prof, string professionprof, string Etat_prof)
    {
        this.Matricule_prof = Matricule_prof;
        this.Nom_prof = Nom_prof;
        this.Prenom_prof = Prenom_prof;
        this.Sexe_prof = Sexe_prof;
        this.Tel_prof = Tel_prof;
        this.Email_prof = Email_prof;
        this.Adresse_prof = Adresse_prof;
          this.NumrefProf = NumrefProf;
        this.DateNaissance_prof = DateNaissance_prof;
        this.professionprof = professionprof;
        this.Etat_prof = Etat_prof;
        
         Random rd=new Random();
        int val=rd.Next(111111+999999);
        string code="Prof-"+val;
            this.Id_prof = code;

            var dt = DateTime.Now;
         string datedujour=dt.ToString("yyyy/MM/dd");
             this.DateInscription_prof = datedujour;
    }

    public string getId_prof()
    {
        return Id_prof;
    }

    public void setId_prof(string Id_prof)
    {
        this.Id_prof = Id_prof;
    }

    public string getMatricule_prof()
    {
        return Matricule_prof;
    }

    public void setMatricule_prof(string Matricule_prof)
    {
        this.Matricule_prof = Matricule_prof;
    }

    public string getNom_prof()
    {
        return Nom_prof;
    }

    public void setNom_prof(string Nom_prof)
    {
        this.Nom_prof = Nom_prof;
    }

    public string getPrenom_prof()
    {
        return Prenom_prof;
    }

    public void setPrenom_prof(string Prenom_prof)
    {
        this.Prenom_prof = Prenom_prof;
    }

    public string getSexe_prof()
    {
        return Sexe_prof;
    }

    public void setSexe_prof(string Sexe_prof)
    {
        this.Sexe_prof = Sexe_prof;
    }

    public string getTel_prof()
    {
        return Tel_prof;
    }

    public void setTel_prof(string Tel_prof)
    {
        this.Tel_prof = Tel_prof;
    }

    public string getEmail_prof()
    {
        return Email_prof;
    }

    public void setEmail_prof(string Email_prof)
    {
        this.Email_prof = Email_prof;
    }

    public string getAdresse_prof()
    {
        return Adresse_prof;
    }

    public void setAdresse_prof(string Adresse_prof)
    {
        this.Adresse_prof = Adresse_prof;
    }

    public string getNumrefProf()
    {
        return NumrefProf;
    }

    public void setNumrefProf(string NumrefProf)
    {
        this.NumrefProf = NumrefProf;
    }

    public string getDateNaissance_prof()
    {
        return DateNaissance_prof;
    }

    public void setDateNaissance_prof(string DateNaissance_prof)
    {
        this.DateNaissance_prof = DateNaissance_prof;
    }

    public string getProfessionprof()
    {
        return professionprof;
    }

    public void setProfessionprof(string professionprof)
    {
        this.professionprof = professionprof;
    }

    public string getEtat_prof()
    {
        return Etat_prof;
    }

    public void setEtat_prof(string Etat_prof)
    {
        this.Etat_prof = Etat_prof;
    }

    public string getDateInscription_prof()
    {
        return DateInscription_prof;
    }

    public void setDateInscription_prof(string DateInscription_prof)
    {
        this.DateInscription_prof = DateInscription_prof;
    }
   
    }
}

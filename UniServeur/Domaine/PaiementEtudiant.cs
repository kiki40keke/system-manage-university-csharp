using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
  public  class PaiementEtudiant
    {
       //les atributs
    private String codeEtudiant;
    private DateTime DatePaiement;
    private float Montant;
    private String Niveau;
   
    public PaiementEtudiant(){}

    public PaiementEtudiant(String codeEtudiant, DateTime DatePaiement, float Montant, String Niveau)
    {
        this.codeEtudiant = codeEtudiant;
        this.DatePaiement = DatePaiement;
        this.Montant = Montant;
        this.Niveau=Niveau;
    }

    public String getNiveau() {
        return Niveau;
    }

    public void setNiveau(String Niveau) {
        this.Niveau = Niveau;
    }
   

    public String getCodeEtudiant() {
        return codeEtudiant;
    }

    public void setCodeEtudiant(String codeEtudiant) {
        this.codeEtudiant = codeEtudiant;
    }

    public DateTime getDatePaiement()
    {
        return DatePaiement;
    }

    public void setDatePaiement(DateTime DatePaiement)
    {
        this.DatePaiement = DatePaiement;
    }

    public float getMontant() {
        return Montant;
    }

    public void setMontant(float Montant) {
        this.Montant = Montant;
    }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using Domaine;
using System.Data;

namespace Dal
{
   public class ProfesseurDal : App
    {
       

        public  string EnregistrerProfesseur(Professeur Pro)
        {
            string msg = "";
            try
            {
                con.Open();
                string req = "Insert into  professeur values('" + Pro.getId_prof() + "','" + Pro.getMatricule_prof() + "','" + Pro.getNom_prof() + "','" + Pro.getPrenom_prof() + "','" + Pro.getSexe_prof() + "','" + Pro.getTel_prof() + "','" + Pro.getEmail_prof() + "','" + Pro.getAdresse_prof() + "',"
            + "'" + Pro.getNumrefProf() + "','" + Pro.getDateNaissance_prof() + "','" + Pro.getProfessionprof() + "','" + Pro.getEtat_prof() + "','" + Pro.getDateInscription_prof() + "')";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Le professeur a ete embauche, son Idendifiant unique est :" + Pro.getId_prof();
                }
            }
            catch (MySqlException ex)
            {
                msg = "" + ex.ToString();
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
            return msg;

        }
       //
        public Professeur rechercherProfesseur(String Id_prof, Professeur Pro)
        {
            
            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select * from professeur where Id_prof='" + Id_prof + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                   

                    Pro.setId_prof(rs.GetString(0));
                    Pro.setMatricule_prof(rs.GetString(1));
                    Pro.setNom_prof(rs.GetString(2));
                    Pro.setPrenom_prof(rs.GetString(3));
                    Pro.setSexe_prof(rs.GetString(4));
                    Pro.setTel_prof(rs.GetString(5));
                    Pro.setEmail_prof(rs.GetString(6));
                    Pro.setAdresse_prof(rs.GetString(7));
                    Pro.setNumrefProf(rs.GetString(8));
                    Pro.setDateNaissance_prof(rs.GetString(9));
                    Pro.setProfessionprof(rs.GetString(10));
                    Pro.setEtat_prof(rs.GetString(11)); 
                }
            }
            catch (Exception ex)
            {
                msg = "" + (ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return Pro;
        }
       //
        public string ModifierProfesseur(string Nom_prof, string Prenom_prof, string Tel_prof, string Email_prof, string Adresse_prof, string Etat_prof, string Id_prof)
        {
            string msg = "";
            try
            {
                con.Open();
                string req = "update professeur set Nom_prof='" + Nom_prof + "',Prenom_prof='" + Prenom_prof + "',Tel_prof='" + Tel_prof + "',Email_prof='" + Email_prof + "',Adresse_prof='" + Adresse_prof + "',Etat_prof='" + Etat_prof + "' where Id_prof='" + Id_prof + "'";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Modification reussi";
                }
            }
            catch (MySqlException ex)
            {
                msg = "" + ex.ToString();
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
            return msg;

        }
        public DataSet listerProfesseur()
        {

            DataSet mesaje = new DataSet();
            string req = "Select * from professeur";


            con.Open();

            MySqlDataAdapter myAdapter = new MySqlDataAdapter(req, con);
            myAdapter.Fill(mesaje, "professeur");
            con.Close();
            return mesaje;
        }
    }
}

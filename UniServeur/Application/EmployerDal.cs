using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using Domaine;
using System.Data;
using System.Collections;

namespace Dal
{
    public class EmployerDal
    {
        public static string conStr = "server=127.0.0.1;user=root;password='';database=GestionUniversite";
        public static MySqlConnection con = new MySqlConnection(conStr);
        public static MySqlCommand cmd = null;
        public static MySqlDataAdapter adapter = new MySqlDataAdapter();

        public string EnregistrerEmployer(Employe Pro)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "Insert into  personne values('" + Pro.getCode() + "','" + Pro.getNom() + "','" + Pro.getPrenom() + "','" + Pro.getSexe() + "','" + Pro.getNif() + "','" + Pro.getAdresse() + "','" + Pro.getTelephone() + "','" + Pro.getEmail() + "',"
                               + "'" + Pro.getDateNaissance() + "','" + Pro.getStatut() + "')";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    String req2 = "Insert into  employe values('" + Pro.getCode() + "','" + Pro.getFonction() + "','" + Pro.getSalaire() + "','" + Pro.getDateEmbauche() + "')";

                    cmd = new MySqlCommand(req2, con);
                    if (cmd.ExecuteNonQuery() != 0)
                    {


                        msg = "L'employer a ete embauche, son Idendifiant unique est :" + Pro.getCode();

                    }
                    
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

        public Employe RechercherEmployer(String code, Employe Pro)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select code, nom, prenom, sexe, nif, adresse, telephone, email, dateNaissance, statut, fonction, salaire from personne natural join employe where code='" + code + "'";

                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    Pro.setCode(rs.GetString(0));
                    Pro.setNom(rs.GetString(1));
                    Pro.setPrenom(rs.GetString(2));
                    Pro.setSexe(rs.GetString(3));
                    Pro.setNif(rs.GetString(4));
                    Pro.setAdresse(rs.GetString(5));
                    Pro.setTelephone(rs.GetString(6));
                    Pro.setEmail(rs.GetString(7));
                    Pro.setDateNaissance(rs.GetString(8));
                    Pro.setStatut(rs.GetString(9));
                    Pro.setFonction(rs.GetString(10));
                    Pro.setSalaire(rs.GetInt32(11)); 
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
        public string   ModifierEmployer( String nom,String prenom,String telephone,String email,String adresse,String Statut,int salaire,String code)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "update personne set nom='" + nom + "',prenom='" + prenom + "',telephone='" + telephone + "',email='" + email + "',adresse='" + adresse + "',Statut='" + Statut + "' where code='" + code + "'";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    String req2 = "update employe set salaire='" + salaire + "' where code='" + code + "'";

                    cmd = new MySqlCommand(req2, con);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        msg = "Modification reussi";

                    }
                    else { msg = "li pa bon 2"; }
                }

                else { msg = "li pa bon 1"; }
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
        public DataSet ListerEmployer()
        {

            DataSet mesaje = new DataSet();
            String req = "Select code, nom, prenom, sexe, nif, adresse, telephone, email, dateNaissance, statut, fonction, salaire from personne natural join employe";


            con.Open();

            MySqlDataAdapter myAdapter = new MySqlDataAdapter(req, con);
            myAdapter.Fill(mesaje, "personne");
            con.Close();
            return mesaje;
        }
        //
        public ArrayList remplirCombofonction()
        {

            //Preparer la requete
            string msg =null;

            ArrayList Al = new ArrayList();
            try
            {
                //Etablir la connexion
                con.Open();
                string req = "select nomfonction from fonction";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                int i = 0;
                while (rs.Read())
                {

                    Al.Add(rs.GetString("nomfonction"));
                    i++;

                }
            }
            catch (Exception ex)
            {
               // msg = "" + (ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return Al;
        }
        public ArrayList recherchersalaire(string nomfonction)
        {

            //Preparer la requete
            string msg = null;

            ArrayList Al = new ArrayList();
            try
            {
                //Etablir la connexion
                con.Open();
                string req = "select salaire_minimum,salaire_maximum from fonction where nomfonction='"+nomfonction+"' ";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
              
                if (rs.Read())
                {

                    Al.Add(rs.GetInt32("salaire_minimum"));
                    Al.Add(rs.GetInt32("salaire_maximum"));
                }
                
            }
            catch (Exception ex)
            {
                // msg = "" + (ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return Al;
        }
    }
}

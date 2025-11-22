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
   public class UtilisateurDal
    {
        public static string conStr = "server=127.0.0.1;user=root;password='';database=GestionUniversite";
        public static MySqlConnection con = new MySqlConnection(conStr);
        public static MySqlCommand cmd = null;
        public static MySqlDataAdapter adapter = new MySqlDataAdapter();

        public string EnregistrerUtilisateur(Utilisateur Pro)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "Insert into  utilisateur values('" + Pro.getCodeUser() + "','" + Pro.getNomUser() + "','" + Pro.getMotPasse() + "','" + Pro.getEtat() + "','" + Pro.getDateenreg() + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                 msg ="L'Utilisateur a ete Creer, son Idendifiant unique est :"+Pro.getCodeUser();

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

        public Utilisateur RechercherUtilisateur(String code, Utilisateur Pro)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select * from utilisateur where code='" + code + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    Pro.setCodeUser(rs.GetString(0));
                    Pro.setNomUser(rs.GetString(1));
                    Pro.setMotPasse(rs.GetString(2));
                    Pro.setEtat(rs.GetString(3));
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
        public Utilisateur Rechercherlogin(String nomUtilisateur,String MotPasse, Utilisateur Pro)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select * from utilisateur where nomUtilisateur='" + nomUtilisateur + "' and  MotPasse='" + MotPasse + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    Pro.setCodeUser(rs.GetString(0));
                    Pro.setNomUser(rs.GetString(1));
                    Pro.setMotPasse(rs.GetString(2));
                    Pro.setEtat(rs.GetString(3));
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
        public String RechercherCodeEmployer(String code)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "select code from  utilisateur where code='" + code + "'";                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("code");

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
            return msg;
        }
        //
        public string  ModifierUtilisateur( String nomUtilisateur,String MotPasse,String etat,String code)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "update utilisateur set nomUtilisateur='" + nomUtilisateur + "',MotPasse='" + MotPasse + "',etat='" + etat + "' where code='" + code + "'";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Modification reussi";
                  
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
        public DataSet ListerUtilisateur()
        {

            DataSet mesaje = new DataSet();
            String req = "Select * from utilisateur";

            con.Open();

            MySqlDataAdapter myAdapter = new MySqlDataAdapter(req, con);
            myAdapter.Fill(mesaje, "utilisateur");
            con.Close();
            return mesaje;
        }

        public String TestUtilisateur(String nomUtilisateur)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select * from utilisateur where nomUtilisateur='" + nomUtilisateur + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    msg = rs.GetString(1);
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
            return msg;
        }



        public string EnregistrerTantative(String nomUtilisateur)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "Insert into tantative(NomUser) values('" + nomUtilisateur + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Enregistrer avec succes";

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

        public string supprimmerTantative(String nomUtilisateur)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "delete from tantative  where NomUser='" + nomUtilisateur + "'";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "suppprimmer avec succes";

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
        public int CompterTantative(String nomUtilisateur)
        {

            //Preparer la requete
            int msg = 0;



            //Etablir la connexion
            con.Open();
            String req = "Select count(*) from tantative where NomUser='" + nomUtilisateur + "'";
            //Creer Statement
            cmd = new MySqlCommand(req, con);
            //Executer la requete
            //Creer un objet de type ResultSet
            MySqlDataReader rs = cmd.ExecuteReader();
            if (rs.Read())
            {
                msg = rs.GetInt32(0);

            }
            con.Close();
            return msg;
        }




        public string BloqueUtilisateur(String nomUtilisateur)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "update utilisateur set etat='0' where nomUtilisateur='" + nomUtilisateur + "'";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Bloque reussi";

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



        public int UtilisateurBloque(String nomUtilisateur)
        {

            //Preparer la requete
            int msag = 0;


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select etat from utilisateur where nomUtilisateur='" + nomUtilisateur + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    msag = rs.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                string msg = "" + (ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return msag;
        }



        public string DebloqueUtilisateur(String nomUtilisateur)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "update utilisateur set etat='1' where nomUtilisateur='" + nomUtilisateur + "'";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Debloque reussi";

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

    }
}

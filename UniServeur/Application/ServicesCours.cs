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
  public  class ServicesCours
    {
        public static string conStr = "server=127.0.0.1;user=root;password='';database=GestionUniversite";
        public static MySqlConnection con = new MySqlConnection(conStr);
        public static MySqlCommand cmd = null;
        public static MySqlDataAdapter adapter = new MySqlDataAdapter();

      public string EnregistrerOption(string Nom_Opt)
      {
          string msg = "";
          Random rd = new Random();
          int val = rd.Next(11 + 9999);
          String Id_Opt = "Options-" + val;

          var dt = DateTime.Now;
    
          string datedujour = dt.ToString("yyyy/MM/dd");
          try
          {
              con.Open();
              string req = "Insert into  options values('" + Id_Opt + "','" + Nom_Opt + "','" + datedujour + "')";
              cmd = new MySqlCommand(req, con);
              if (cmd.ExecuteNonQuery() != 0)
              {
                  msg = "L'Option  a ete Creer, son Idendifiant unique est :" + Id_Opt;
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
      public string RechercherCodeOption(string Nom_Opt)
      {

          //Preparer la requete
          string msg = "nada";


          try
          {
              //Etablir la connexion
              con.Open();
              string req = "select Id_Opt from  options where Nom_Opt='" + Nom_Opt + "'";
              //Creer Statement
              cmd = new MySqlCommand(req, con);
              //Executer la requete
              //Creer un objet de type ResultSet
              MySqlDataReader rs = cmd.ExecuteReader();
              if (rs.Read())
              {

                  msg = rs.GetString("Id_Opt"); 
                
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

      public DataSet listerOptions()
      {

          DataSet mesaje = new DataSet();
          string req = "Select * from options";

          con.Open();

          MySqlDataAdapter myAdapter = new MySqlDataAdapter(req, con);
          myAdapter.Fill(mesaje, "options");
          con.Close();
          return mesaje;
      }
      public string RechercherNomOptions(String Id_Opt)
      {

          //Preparer la requete
          string msg = "nada";


          try
          {
              //Etablir la connexion
              con.Open();
              String req = "select Nom_Opt from  options where Id_Opt='" + Id_Opt + "'";
              //Creer Statement
              cmd = new MySqlCommand(req, con);
              //Executer la requete
              //Creer un objet de type ResultSet
              MySqlDataReader rs = cmd.ExecuteReader();
              if (rs.Read())
              {

                  msg = rs.GetString("Nom_Opt");

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
  

            public ArrayList remplirComboOptions()
      {

          //Preparer la requete
          string msg = "nada";

          ArrayList Al = new ArrayList();
          try
          {
              //Etablir la connexion
              con.Open();
                string req = "select Nom_Opt from options";
              //Creer Statement
              cmd = new MySqlCommand(req, con);
              //Executer la requete
              //Creer un objet de type ResultSet
              MySqlDataReader rs = cmd.ExecuteReader();
              int i = 0;
              while (rs.Read())
              {

                  Al.Add(rs.GetString("Nom_Opt"));
                  i++;

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
          return Al;
      }

      // cours 

            public string EnregistrerCours(string Id_Opt, string codeniv, string codesession, string Nomcours)
            {
                string msg = "";
                Random rd = new Random();
                int val = rd.Next(11 + 9999);
                string Id_Cours = "Cours-" + val;

                var dt = DateTime.Now;

                string datedujour = dt.ToString("yyyy/MM/dd");
                try
                {
                    con.Open();
                    string req = "Insert into  cours values('" + Id_Cours + "','" + Id_Opt + "','" + codeniv + "','" + codesession + "','" + Nomcours + "','" + datedujour + "')";
                    cmd = new MySqlCommand(req, con);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        msg = "Le cours  a ete Creer, son Idendifiant unique est :" + Id_Cours;
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

            public string RechercherCodeCours(string Nom_Opt, string Nom_Cours)
            {

                //Preparer la requete
                string msg = "nada";
                string Id_Opt = RechercherCodeOption(Nom_Opt);

                try
                {
                    //Etablir la connexion
                    con.Open();
                    string req = "select Id_Cours from Cours where Id_Opt='" + Id_Opt + "' and Nom_Cours='" + Nom_Cours + "'";
                    //Creer Statement
                    cmd = new MySqlCommand(req, con);
                    //Executer la requete
                    //Creer un objet de type ResultSet
                    MySqlDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {

                        msg = rs.GetString("Id_Cours");

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
            public DataSet listerCours()
            {

                DataSet mesaje = new DataSet();
                string req = "select Id_Cours,Id_Opt,codeniv,codesession,Nom_Cours from cours  order by Id_Opt";

                con.Open();

                MySqlDataAdapter myAdapter = new MySqlDataAdapter(req, con);
                myAdapter.Fill(mesaje, "cours");
                con.Close();
                return mesaje;
            }
            public ArrayList remplirComboCours(String Id_Opt, String Niveau, String Session)
            {

                //Preparer la requete
                string msg = "nada";

                ArrayList Al = new ArrayList();
                try
                {
                    //Etablir la connexion
                    con.Open();
                    string req = "select Nom_Cours from Cours  where Id_Opt='" + Id_Opt + "'and codeniv='" + Niveau + "'and codesession='" + Session + "'";
                    //Creer Statement
                    cmd = new MySqlCommand(req, con);
                    //Executer la requete
                    //Creer un objet de type ResultSet
                    MySqlDataReader rs = cmd.ExecuteReader();
                    int i = 0;
                    while (rs.Read())
                    {

                        Al.Add(rs.GetString("Nom_Cours"));
                        i++;

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
                return Al;
            }
            public string RechercherCours(String Id_Cours)
            {

                //Preparer la requete
                string msg = "nada";
             

                try
                {
                    //Etablir la connexion
                    con.Open();
                    String req = "select Nom_Cours from  cours where Id_Cours='" + Id_Cours + "'";
                    //Creer Statement
                    cmd = new MySqlCommand(req, con);
                    //Executer la requete
                    //Creer un objet de type ResultSet
                    MySqlDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {

                        msg = rs.GetString("Nom_Cours");

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

      // selection
            public string EnregistrerCoursSelectionner(String IdProfesseur, String Nom_Opt, String Nom_Cours, String Vacation)
            {
                string msg = "";
                Random rd = new Random();
                String Idcours = RechercherCodeCours(Nom_Opt, Nom_Cours);
                int v = rd.Next(3838292);
                String CoursSelect = "Cs-" + v;

            
                try
                {
                    con.Open();
                    String req = "Insert into  CoursSelects values('" + CoursSelect + "','" + IdProfesseur + "','" + Idcours + "','" + Vacation + "')"; 
                    cmd = new MySqlCommand(req, con);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        msg = "Le cours  a ete associer, son Idendifiant unique est :" + CoursSelect;
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
            public string  InformationCoursSelect(String codecs)
            {

                //Preparer la requete
                string msg = null;


                try
                {
                    //Etablir la connexion
                    con.Open();
                    String req = "SELECT C.Nom_Cours,Cs.Vacations,O.Nom_Opt  from CoursSelects Cs, Cours C,options O\n" +
 "where O.Id_Opt=C.Id_Opt and C.Id_Cours=Cs.Id_Cours and Cs.codecs='" + codecs + "'";
                    //Creer Statement
                    cmd = new MySqlCommand(req, con);
                    //Executer la requete
                    //Creer un objet de type ResultSet
                    MySqlDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {

                        String Nomcours = rs.GetString(0);
                        String Vacations = rs.GetString(1);
                        String NomOptions = rs.GetString(2);

                        msg = "Options : " + NomOptions + "\n Cours : " + Nomcours + " \n Vacation : " + Vacations;

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
            public string RechercherAttributionCours(String Id_Cours, String Vacations)
            {

                //Preparer la requete
                string msg = null;
            

                try
                {
                    //Etablir la connexion
                    con.Open();
                    String req = "select codecs from  CoursSelects where Id_Cours='" + Id_Cours + "' and Vacations='" + Vacations + "'";
                    //Creer Statement
                    cmd = new MySqlCommand(req, con);
                    //Executer la requete
                    //Creer un objet de type ResultSet
                    MySqlDataReader rs = cmd.ExecuteReader();
                    if (rs.Read())
                    {

                        msg = rs.GetString("codecs");

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
            public ArrayList remplirlisetecours(String Id_prof)
            {

                //Preparer la requete
                string msg = "nada";

                ArrayList Al = new ArrayList();
                try
                {
                    //Etablir la connexion
                    con.Open();
                    String req = "SELECT codecs from CoursSelects where Id_prof='" + Id_prof + "'";
                    //Creer Statement
                    cmd = new MySqlCommand(req, con);
                    //Executer la requete
                    //Creer un objet de type ResultSet
                    MySqlDataReader rs = cmd.ExecuteReader();
                    int i = 0;
                    while (rs.Read())
                    {

                        Al.Add(rs.GetString("codecs"));
                        i++;

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
                return Al;
            }
            public string SuprimmerAttributionCours(String codecs)
            {
                string msg = "";
               

                try
                {
                    con.Open();
                    String req = "delete from CoursSelects  where codecs='" + codecs + "'";
                    cmd = new MySqlCommand(req, con);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        msg = "Suppression reussi";
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

    }
}

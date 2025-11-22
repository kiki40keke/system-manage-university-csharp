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
  public  class NoteDal
    {
        public static string conStr = "server=127.0.0.1;user=root;password='';database=GestionUniversite";
        public static MySqlConnection con = new MySqlConnection(conStr);
        public static MySqlCommand cmd = null;
        public static MySqlDataAdapter adapter = new MySqlDataAdapter();

        public string EnregistrerNotesNormal(Note N)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "Insert into  NotesNormal values('" + N.getCodenotnormal() + "','" + N.getCodeEvaluationsNormal() + "','" + N.getId_Etud() + "','" + N.getNotenormal() + "','" + N.getDateenregnormal() + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "La note a ete Creer, son Idendifiant unique est :" + N.getCodenotnormal();

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
        public Note RechercherNote(String codeEvaluationsNormal, String Id_Etud, Note N)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select * from NotesNormal where codeEvaluationsNormal='" + codeEvaluationsNormal + "' and Id_Etud='" + Id_Etud + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    N.setCodenotnormal(rs.GetString(0));
                    N.setCodeEvaluationsNormal(rs.GetString(1));
                    N.setId_Etud(rs.GetString(2));
                    N.setNotenormal(Double.Parse(rs.GetString(3)));
                    N.setDateenregnormal(rs.GetString(4));
               
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
            return N;
        }
      //
        public string ModifierNotes(String codeEvaluationsNormal, String Id_Etud, double notenormal)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "update NotesNormal set notenormal='" + notenormal + "' where codeEvaluationsNormal='" + codeEvaluationsNormal + "' and Id_Etud='" + Id_Etud + "'";
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
        public string SuprimmerNotes(String codeEvaluationsNormal, String Id_Etud)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "delete from NotesNormal  where codeEvaluationsNormal='" + codeEvaluationsNormal + "' and Id_Etu='" + Id_Etud + "'";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Suppression reussi";

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
        public int nombredeligne(String codeniv, String codesession, String Id_Etud)
        {

            //Preparer la requete
            string msg = null;

            String req = "select Count(*) as nombre from cours where codeniv='" + codeniv + "' and codesession='" + codesession + "' and Id_Opt in(select Id_Opt from etudiant where Id_Etud='" + Id_Etud + "')";
        

            int nom = 0;
            try
            {
                //Etablir la connexion
                con.Open();
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    nom = rs.GetInt32("nombre");


                }
                else {
                    nom = 99;
                }
            }
            catch (Exception ex)
            {
               //  msg = "" + (ex.ToString());
                 nom = 100;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return nom;
        }
      //
        public string[,] ListerBulletin(string Id_Opt, String codeniv, String codesession, String Id_Etud, String NomVacation, String Promotion)
        {

            //Preparer la requete
            string msg = null;
            String req = "select Id_Cours,Nom_Cours from cours where codeniv='" + codeniv + "' and codesession='" + codesession + "' and Id_Opt in(select Id_Opt from etudiant where Id_Etud='" + Id_Etud + "')";

            int r = nombredeligne( codeniv, codesession, Id_Etud);
            if (r == 0) { r = 100; }
            string[,] data = new string[r, 5];
            string lele = "" + r;


            try
            {
                int i = 0;
                //Etablir la connexion
                con.Open();
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();

                while (rs.Read())
                {

                    String Id_Cours = rs.GetString(0);
                    String Nom_Cours = rs.GetString(1);
                    PalmaresseDal da =new PalmaresseDal();
                    String note = da.RechercherCodePalmares(Id_Opt, Id_Cours, NomVacation, Promotion, Id_Etud);
                    String notereprise = "......";
                    String notereprise2 = "......";


                    data[i,0] = Nom_Cours;
                    data[i, 1] = note;
                    data[i,2] = "100";
                    data[i,3] = notereprise;
                    data[i,4] = notereprise2;
                    i++;


                }

                //else
                //{
                //    data = new string[1, 1]{
                //{"code la pa bon"}
                //};
                //}


            }
            catch (Exception ex)
            {
                msg = "" + (ex.ToString());
                data = new string[1, 1]{
                {"gwo ere "+lele+msg}
                };
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return data;
        }
    
      //
        public ArrayList RechercherBulletin(String codeniv, String codesession, String Id_Etud)
        {

            //Preparer la requete
            string msg = "nada";

            ArrayList Al = new ArrayList();
            try
            {
                //Etablir la connexion
                con.Open();
                String req = "select O.Nom_Opt,E.NomVacation,E.Promotion,S.NomSession,N.Niveau,E.Nom_Etud,E.Prenom_Etud,E.Id_Etud,O.Id_Opt " +
"from Options O,Cours C,Sessionx S,Niveaux N ,Etudiant E " +
"where  N.codeniv=C.codeniv and S.codesession=C.codesession  " +
"and   C.codeniv='" + codeniv + "' and C.codesession='" + codesession + "' and  C.Id_Opt=O.Id_Opt  " +
" and O.Id_Opt=E.Id_Opt and E.Id_Etud='" + Id_Etud + "' ";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                int i = 0;
                if (rs.Read())
                {
                    PalmaresseDal da = new PalmaresseDal();
                
                    String req1 = "select SUM(N.notenormal) as nombre  from NotesNormal N,Cours C,etudiant E,Palmares P,EvaluationsNormal S  where\n" +
" N.codeEvaluationsNormal=S.codeEvaluationsNormal and  S.codepalmares= P.codepalmares and   C.Id_Cours=P.Id_Cours  and \n" +
" P.NomVacation=E.NomVacation and E.Id_Etud=N.Id_Etud and    C.codeniv='" + codeniv + "' and C.codesession='" + codesession + "' and P.Id_Opt='" + rs.GetString("Id_Opt") + "'  and N.Id_Etud='" + Id_Etud + "'";
                    String Sommenote =da. RechercherSommation(req1);
                    String req2 = "select count(*) as nombre from cours  where Id_Opt='" + rs.GetString("Id_Opt") + "'  and codeniv='" + codeniv + "' and codesession='" + codesession + "' ;";
                    String Nombrecours = da.RechercherSommation(req2);

                    double nombre = Double.Parse(Nombrecours);
                    double total = nombre * 100;
                    String total2 = (total).ToString();
                    double moyenne = 0;
                    double Sommenote2 = Double.Parse(Sommenote);
                    if (Sommenote2 <= 0)
                    {
                        moyenne = 0;
                    }

                    else { moyenne = Sommenote2 * 10 / total; }


                   

                    String moyenne2 = (moyenne).ToString();
                    Al.Add(rs.GetString(0));

                    Al.Add(rs.GetString(1));

                    Al.Add(rs.GetString(2));

                    Al.Add(rs.GetString(3));

                    Al.Add(rs.GetString(4));

                    Al.Add(rs.GetString(5));

                    Al.Add(rs.GetString(6));

                    Al.Add(rs.GetString(7));

                    Al.Add(Sommenote);

                    Al.Add(total2);

                    Al.Add(moyenne2);




                }

                else { Al.Add("code la pa bon"); }
            }
            catch (Exception ex)
            {
                msg = "" + (ex.ToString());
                Al.Add(msg);
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
      //
        public int RechercherBulletin2( String codeniv,  String Id_Etud, String NomVacation, String Promotion)
        {
            //Preparer la requete
            string msg = "nada";
            String req = "select Id_Cours,Id_Opt from cours where codeniv='" + codeniv + "'  and Id_Opt in(select Id_Opt from etudiant where Id_Etud='" + Id_Etud + "')";
            int nombre = 0;
            ArrayList Al = new ArrayList();
            try
            {
                //Etablir la connexion
                con.Open();
           
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                int i = 0;
                
                while (rs.Read())
                {   
                    String Id_Cours = rs.GetString(0);
                    string Id_Opt = rs.GetString(1);
                    PalmaresseDal da = new PalmaresseDal();
                    String note = da.RechercherCodePalmares(Id_Opt, Id_Cours, NomVacation, Promotion, Id_Etud);
                    int note2 = Int32.Parse(note);

                   if(note2<65){
                       nombre++;
                   }
                    i++;
   
                }
          //      Al.Add(i.ToString());

                //else { //Al.Add("code la pa bon");
                //}
            }
            catch (Exception ex)
            {
                msg = "" + (ex.ToString());
                //Al.Add(msg);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return nombre;
        }

       
    }
}

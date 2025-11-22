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
   public class PalmaresseDal
    {
        public static string conStr = "server=127.0.0.1;user=root;password='';database=GestionUniversite";
        public static MySqlConnection con = new MySqlConnection(conStr);
        public static MySqlCommand cmd = null;
        public static MySqlDataAdapter adapter = new MySqlDataAdapter();

       //
        public string EnregistrerPalmares(Palmaresse Pro)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "Insert into  palmares values('" + Pro.getCodepalmares() + "','" + Pro.getId_Opt() + "','" + Pro.getId_Cours() + "','" + Pro.getNomVacation() + "','" + Pro.getCoeficienttotal() + "','" + Pro.getPromotion() + "','" + Pro.getDatepalmares() + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Le Palmares a ete Creer, son Idendifiant unique est :" + Pro.getCodepalmares();
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
        public string RechercherCodePlamares(String Id_Opt, String Id_Cours, String NomVacation, String Promotion)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Close();
                con.Open();
                String req = "select Codepalmares from palmares where Id_Opt='" + Id_Opt + "' and Id_Cours='" + Id_Cours + "' and NomVacation='" + NomVacation + "' and Promotion='" + Promotion + "'";                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("Codepalmares");

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
        public String RechercherPlamares(String Codepalmares, Palmaresse Pal)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "select  *from palmares where Codepalmares='" + Codepalmares + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {


                    Pal.setCodepalmares(rs.GetString(1));
                    Pal.setId_Opt(rs.GetString(2));
                    Pal.setId_Cours(rs.GetString(3));
                    Pal.setNomVacation(rs.GetString(4));
                    Pal.setCoeficienttotal(rs.GetInt32(5));
                    Pal.setPromotion(rs.GetString(6));
                    Pal.setDatepalmares(rs.GetString(7));
                }

                else { }
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

       //
       
       //
        public string RechercherNotes(String reqnote)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Close();
                con.Open();
                cmd = new MySqlCommand(reqnote, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("notenormal");

                }
            }
            catch (Exception ex)
            {
                 msg = "li pa bon " + (ex.ToString());
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
        public int nombredeligne2()
        {

            //Preparer la requete
            string msg = null;
            String req = "select count(*) as nombre from palmares";
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
            return nom;
        }

        public string RechercherNotesEvaluation(String Id_Etud, String codeEvaluationsNormal)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Open();
                // String req = "select Nom_Opt from  options where Id_Opt='" + Id_Opt + "'";
                String req = "Select notenormal from NotesNormal  where Id_Etud='" + Id_Etud + "' and codeEvaluationsNormal='" + codeEvaluationsNormal + "'"; 
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("notenormal");

                }
            }
            catch (Exception ex)
            {
                /// msg = "" + (ex.ToString());
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
       
        public string[,] ListerPalmares2()
        {

            //Preparer la requete
            string msg = null;
            String req = "select *from palmares order by codepalmares";
            int r = nombredeligne2();
             string[,] data = new string[r, 7];
          
          

            try
            {
                //Etablir la connexion
                con.Open();
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                int i = 0;
                while (rs.Read())
                {

                  //  msg = rs.GetString("notenormal");
                    String Codepalmares = rs.GetString(0);
                    String Id_Opt = rs.GetString(1);
                    String Id_Cours = rs.GetString(2);
                    String NomVacation = rs.GetString(3);
                    int Coeficienttotal = rs.GetInt32(4);
                    String Promotion = rs.GetString(5);
                    String Datepalmares = rs.GetString(6);

                    ServicesCours ser = new ServicesCours();
                    String NomOptions = ser.RechercherNomOptions(Id_Opt);
                    String Nomcours = ser.RechercherCours(Id_Cours);
                    EvaluationsNormalDal pad = new EvaluationsNormalDal();
             //  string note=     RechercherNomOptions2();

                    data[i,0] = Codepalmares;
                    data[i,1] = NomOptions;
                    data[i,2] = Nomcours;
                    data[i,3] = NomVacation;
                    data[i, 4] = Coeficienttotal.ToString();
                    data[i,5] = Promotion;
                    data[i,6] = Datepalmares;

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
            return data;
        }

        public int nombredeligne(String codepalmares)
        {

            //Preparer la requete
            string msg = null;
            String req = "select count(*) as nombre  from Etudiant E,Palmares P,Cours C,nivoetudiants N \n" +
"where N.codeniv=C.codeniv and  C.Id_Cours=P.Id_Cours and  N.Id_Etud=E.Id_Etud and E.promotion=P.promotion and  E.NomVacation=P.NomVacation  and E.Id_Opt=P.Id_Opt \n" +
" and codepalmares='" + codepalmares + "'";
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
            return nom;
        }

        public string[,] ListerPalmares(String codepalmares)
        {

            //Preparer la requete
            string msg = null;
            String req = "select E.Id_Etud,E.Nom_Etud,E.Prenom_Etud from Etudiant E,Palmares P,Cours C,nivoetudiants N  \n" +
"where N.codeniv=C.codeniv and  C.Id_Cours=P.Id_Cours and  N.Id_Etud=E.Id_Etud and E.promotion=P.promotion and  E.NomVacation=P.NomVacation  and E.Id_Opt=P.Id_Opt \n" +
" and codepalmares='" + codepalmares + "'";
            int r = nombredeligne(codepalmares);
            string[,] data = new string[r, 9];


            try
            {
                //Etablir la connexion
                con.Open();
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                int i = 0;
                while (rs.Read())
                {

             //       double b = 4,5;



                    String Id_Etud = rs.GetString(0);

                    String Nom_Etud = rs.GetString(1);
                    String Prenom_Etud = rs.GetString(2);

                    EvaluationsNormalDal da = new EvaluationsNormalDal();

                    String reqnote = "select notenormal from NotesNormal natural join EvaluationsNormal  where codepalmares='" + codepalmares + "' and TypesNormal='Intra' \n" +
"and  DescriptionsNormal='Examen'  and Id_Etud='" + Id_Etud + "'";
                    String noteexamenintra = da.RechercherNotes(reqnote);
                    if (noteexamenintra == null)
                    {
                        noteexamenintra = "0";
                    }

                    reqnote = "select notenormal from NotesNormal natural join EvaluationsNormal  where codepalmares='" + codepalmares + "' and TypesNormal='Intra' \n" +
"and  DescriptionsNormal='Devoir'  and Id_Etud='" + Id_Etud + "'";
                    EvaluationsNormalDal da1 = new EvaluationsNormalDal();
                    String notedevoirintra = da1.RechercherNotes(reqnote);
                    if (notedevoirintra == null)
                    {
                        notedevoirintra = "0";
                    }

                    reqnote = "select notenormal from NotesNormal natural join EvaluationsNormal  where codepalmares='" + codepalmares + "' and TypesNormal='Final' \n" +
"and  DescriptionsNormal='Examen'  and Id_Etud='" + Id_Etud + "'";
                    EvaluationsNormalDal da2 = new EvaluationsNormalDal();
                    String noteexamenfinal = da2.RechercherNotes(reqnote);
                    if (noteexamenfinal == null)
                    {
                        noteexamenfinal = "0";
                    }



                    reqnote = "select notenormal from NotesNormal natural join EvaluationsNormal  where codepalmares='" + codepalmares + "' and TypesNormal='Final' \n" +
"and  DescriptionsNormal='Devoir'  and Id_Etud='" + Id_Etud + "'";
                    EvaluationsNormalDal da3 = new EvaluationsNormalDal();
                    String notedevoirfinal = da3.RechercherNotes(reqnote);
                    if (notedevoirfinal == null)
                    {
                        notedevoirfinal = "0";
                    }


                    double noteexamenintra2 = Double.Parse(noteexamenintra);
                    double notedevoirintra2 = Double.Parse(notedevoirintra);
                    double noteexamenfinal2 = Double.Parse(noteexamenfinal);
                    double notedevoirfinal2 = Double.Parse(notedevoirfinal);
                    double notefinal = noteexamenintra2 + notedevoirintra2 + noteexamenfinal2 + notedevoirfinal2;

                    int i_val = (int)Math.Round(notefinal);
                    String note = (i_val).ToString();
                    String CoeficientNormal = "100";
                    //
                    if (noteexamenintra == "0")
                    {
                        noteexamenintra = "-";
                    }
                    if (notedevoirintra == "0")
                    {
                        notedevoirintra = "-";
                    }
                    if (noteexamenfinal == "0")
                    {
                        noteexamenfinal = "-";
                    }
                    if (notedevoirfinal == "0")
                    {
                        notedevoirfinal = "-";
                    }
                    //      
                    data[i,0] = Id_Etud;
                    data[i,1] = Nom_Etud;
                    data[i,2] = Prenom_Etud;
                    data[i, 3] = noteexamenintra;
                    data[i, 4] = notedevoirintra;
                    data[i, 5] = noteexamenfinal;
                    data[i, 6] = notedevoirfinal;
                    data[i, 7] = note;
                    data[i, 8] = CoeficientNormal;

                    i++;

                }
            }
            catch (Exception ex)
            {
                msg = "" + (ex.ToString());
                data = new string[1, 1]{
                {"gwo ere "+msg}
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

        public ArrayList RechercherPalmares2( String codepalmares)
        {

            //Preparer la requete
            string msg = "nada";

            ArrayList Al = new ArrayList();
            try
            {
                //Etablir la connexion
                con.Open();
                String req = "select O.Nom_Opt,C.Nom_Cours,P.NomVacation,P.Promotion,S.NomSession,N.Niveau\n" +
   "from Options O,Cours C,palmares P,Sessionx S,Niveaux N \n" +
   "where O.Id_Opt=P.Id_Opt and N.codeniv=C.codeniv and S.codesession=C.codesession  \n" +
   "and C.Id_Cours=P.Id_Cours and P.codepalmares='" + codepalmares + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                int i = 0;
                if (rs.Read())
                {

                    Al.Add(rs.GetString(0));
                    Al.Add(rs.GetString(1));
                    Al.Add(rs.GetString(2));
                    Al.Add(rs.GetString(3));
                    Al.Add(rs.GetString(4));
                    Al.Add(rs.GetString(5));
                  

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

        public string RechercherCodePalmares(String Id_Opt, String Id_Cours, String NomVacation, String Promotion, String Id_Etud)
        {

            //Preparer la requete
            string msg = "0";


            try
            {
                //Etablir la connexion
                con.Clone();
                con.Open();

                String req = "select Codepalmares from palmares where Id_Opt='" + Id_Opt + "' and Id_Cours='" + Id_Cours + "' and NomVacation='" + NomVacation + "' and Promotion='" + Promotion + "'";
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("Codepalmares");
                    string Codepalmares = msg;
                    String reqnote = "select notenormal from NotesNormal natural join EvaluationsNormal  where codepalmares='" + Codepalmares + "' and TypesNormal='Intra' \n" +
"and  DescriptionsNormal='Examen'  and Id_Etud='" + Id_Etud + "'";
                    String noteexamenintra = RechercherNotes(reqnote);
                    if (noteexamenintra == null)
                    {
                        noteexamenintra = "0";
                    }

                    reqnote = "select notenormal from NotesNormal natural join EvaluationsNormal  where codepalmares='" + Codepalmares + "' and TypesNormal='Intra' \n" +
"and  DescriptionsNormal='Devoir'  and Id_Etud='" + Id_Etud + "'";
                    String notedevoirintra = RechercherNotes(reqnote);
                    if (notedevoirintra == null)
                    {
                        notedevoirintra = "0";
                    }

                    reqnote = "select notenormal from NotesNormal natural join EvaluationsNormal  where codepalmares='" + Codepalmares + "' and TypesNormal='Final' \n" +
"and  DescriptionsNormal='Examen'  and Id_Etud='" + Id_Etud + "'";
                    String noteexamenfinal = RechercherNotes(reqnote);
                    if (noteexamenfinal == null)
                    {
                        noteexamenfinal = "0";
                    }



                    reqnote = "select notenormal from NotesNormal natural join EvaluationsNormal  where codepalmares='" + Codepalmares + "' and TypesNormal='Final' \n" +
"and  DescriptionsNormal='Devoir'  and Id_Etud='" + Id_Etud + "'";
                    String notedevoirfinal = RechercherNotes(reqnote);
                    if (notedevoirfinal == null)
                    {
                        notedevoirfinal = "0";
                    }


                    double noteexamenintra2 = Double.Parse(noteexamenintra);
                    double notedevoirintra2 = Double.Parse(notedevoirintra);
                    double noteexamenfinal2 = Double.Parse(noteexamenfinal);
                    double notedevoirfinal2 = Double.Parse(notedevoirfinal);
                    double notefinal = noteexamenintra2 + notedevoirintra2 + noteexamenfinal2 + notedevoirfinal2;

                    int i_val = (int)Math.Round(notefinal);
                    string note = (i_val).ToString();
                    msg = note;
                    //msg = noteexamenintra;
                }

                else {
                    msg = "0";
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
        //
        public string RechercherSommation(String reqnote)
        {

            //Preparer la requete
            string msg = "0";


            try
            {
                //Etablir la connexion
                con.Open();

                //Creer Statement
                cmd = new MySqlCommand(reqnote, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString(0);

                    if(msg==null){
                        msg = "0";
                    }

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

    }
}

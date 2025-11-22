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
    public class EvaluationsNormalDal : App
    {
    

        public string EnregistrerEvaluation(EvaluationsNormal Eva)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "Insert into  EvaluationsNormal values('" + Eva.getCodeEvaluationsNormal() + "','" + Eva.getCodepalmares() + "','" + Eva.getTypesNormal() + "','" + Eva.getDescriptionsNormal() + "','" + Eva.getCoeficientNormal() + "','" + Eva.getDateEvaluationsNormal() + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "L'evaluation a ete Creer, son Idendifiant unique est :" + Eva.getCodeEvaluationsNormal();
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
        public ArrayList RechercherEvaluation(String codeEvaluationsNormal)
        {

            //Preparer la requete
            string msg = null;

            ArrayList Al = new ArrayList();
            try
            {
                //Etablir la connexion
                con.Open();
                String req = "select O.Nom_Opt,C.Nom_Cours,S.NomSession,N.Niveau,P.promotion,V.NomVacation,\n" +
"E.Codepalmares,E.TypesNormal,E.DescriptionsNormal,E.CoeficientNormal\n" +
"from Options O,Cours C, Sessionx S , Niveaux N ,palmares P , Vacations V,EvaluationsNormal E where\n" +
"O.Id_Opt=C.Id_Opt and  N.codeniv=C.codeniv and  S.codesession=C.codesession\n" +
" and C.Id_Cours=P.Id_Cours and V.NomVacation=P.NomVacation  and P.codepalmares=E.codepalmares \n" +
" and E.codeEvaluationsNormal='" + codeEvaluationsNormal + "'";
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
                    Al.Add(rs.GetString(6));
                    Al.Add(rs.GetString(7));
                    Al.Add(rs.GetString(8));
                    Al.Add(rs.GetString(9));

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
        //
        public string RechercherSommationcoef(String Codepalmares)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "select sum(CoeficientNormal) as nombre from EvaluationsNormal natural join palmares where codepalmares='" + Codepalmares + "'";
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("nombre");

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
        public string RechercherNomcours(String Codepalmares)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "select Nom_Cours from cours natural join palmares where codepalmares='" + Codepalmares + "'";                //Executer la requete
                //Creer un objet de type ResultSet
                cmd = new MySqlCommand(req, con);
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
        //
        public string RechercherNomOption(String Codepalmares)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Open();
               String req = "select Nom_Opt from options natural join palmares where codepalmares='" + Codepalmares + "'";  
                //Creer un objet de type ResultSet
               cmd = new MySqlCommand(req, con);
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
        //
        public string RechercherCodeEvaluation(String Codepalmares, String TypesNormal, String DescriptionsNormal)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "select codeEvaluationsNormal from EvaluationsNormal where Codepalmares='" + Codepalmares + "' and TypesNormal='" + TypesNormal + "' and DescriptionsNormal='" + DescriptionsNormal + "'";
                cmd = new MySqlCommand(req, con);
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("codeEvaluationsNormal");

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
        //
        public int nombredeligneEva()
        {

            //Preparer la requete
            string msg = null;
            String req = "select count(*) as nombre from EvaluationsNormal ";
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

        public string[,] ListerEvaluation()
        {

            //Preparer la requete
            string msg = null;
            String req = "select E.codeEvaluationsNormal , O.Nom_Opt,C.Nom_Cours,S.NomSession,N.Niveau,P.promotion,V.NomVacation,\n" +
 "E.Codepalmares,E.TypesNormal,E.DescriptionsNormal,E.CoeficientNormal\n" +
 "from Options O,Cours C, Sessionx S , Niveaux N ,palmares P , Vacations V,EvaluationsNormal E where\n" +
 "O.Id_Opt=C.Id_Opt and  N.codeniv=C.codeniv and  S.codesession=C.codesession\n" +
 " and C.Id_Cours=P.Id_Cours and V.NomVacation=P.NomVacation  and P.codepalmares=E.codepalmares ";
            int r = nombredeligneEva();
            string[,] data = new string[r, 11];



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

                    String codeEvaluationsNormal = rs.GetString(0);
                    String Nom_Opt = rs.GetString(1);
                  
                    String Nom_Cours = rs.GetString(2);
                    String NomSession = rs.GetString(3);
                    String Niveau = rs.GetString(4);
                    String promotion = rs.GetString(5);
                    String NomVacation = rs.GetString(6);
                    String Codepalmares = rs.GetString(7);
                    String TypesNormal = rs.GetString(8);
                    String DescriptionsNormal = rs.GetString(9);
                    String CoeficientNormal = rs.GetString(10);
                   

                    data[i,0] = codeEvaluationsNormal;
                    data[i,1] = Nom_Opt;
                    data[i,2] = Nom_Cours;
                    data[i,3] = NomSession;
                    data[i,4] = Niveau;
                    data[i,5] = promotion;
                    data[i,6] = NomVacation;
                    data[i,7] = Codepalmares;
                    data[i,8] = TypesNormal;
                    data[i,9] = DescriptionsNormal;
                    data[i,10] = CoeficientNormal;

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
        //

        public string RechercherNotes(String reqnote)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
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
        public int nombredeligne(String codeEvaluationsNormal)
        {

            //Preparer la requete
            string msg = null;
            String req = "select count(*) as nombre\n" +
   " from etudiant E,Palmares P, EvaluationsNormal D,Cours C ,nivoetudiants N \n" +
" where N.codeniv=C.codeniv and  C.Id_Cours=P.Id_Cours and  N.Id_Etud=E.Id_Etud and E.promotion=P.promotion and  E.NomVacation=P.NomVacation  and E.Id_Opt=P.Id_Opt \n" +
" and P.codepalmares=D.codepalmares and D.codeEvaluationsNormal='" + codeEvaluationsNormal + "'";

            string req1 = "select count(*) as nombre from EvaluationsNormal";

            int nom = 0;
            try
            {
                //Etablir la connexion
                con.Close();
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

      

        //
        public string[,] ListedesNotes(String codeEvaluationsNormal)
        {

            //Preparer la requete
            string msg = null;
            String req = "select E.Id_Etud,E.Nom_Etud,E.Prenom_Etud,D.CoeficientNormal,D.codeEvaluationsNormal \n" +
" from etudiant E,Palmares P, EvaluationsNormal D,Cours C ,nivoetudiants N \n" +
" where N.codeniv=C.codeniv and  C.Id_Cours=P.Id_Cours and  N.Id_Etud=E.Id_Etud and E.promotion=P.promotion and  E.NomVacation=P.NomVacation  and E.Id_Opt=P.Id_Opt \n" +
" and P.codepalmares=D.codepalmares and D.codeEvaluationsNormal='"+codeEvaluationsNormal+"'";

          
            int r = nombredeligne(codeEvaluationsNormal);
            string[,] data = new string[r, 6];
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

                    string Id_Etud = rs.GetString(0);
                    String Nom_Etud = rs.GetString(1);
                    String Prenom_Etud = rs.GetString(2);
                    String CoeficientNormal = rs.GetString(3);
                    String codeval = rs.GetString(4);
                    PalmaresseDal pa = new PalmaresseDal(); 
                    String notenormal = pa.RechercherNotesEvaluation(Id_Etud,codeEvaluationsNormal);
                    if (notenormal == null)
                    {
                        notenormal = "0";
                    }
                   
                    //      
                    data[i, 0] = Id_Etud;
                    data[i, 1] = Nom_Etud;
                    data[i, 2] = Prenom_Etud;
                    data[i, 3] = notenormal;
                    data[i, 4] = CoeficientNormal;
                    data[i, 5] = codeval;

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
    }
}

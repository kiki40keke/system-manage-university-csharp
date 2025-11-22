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
  public  class ModalitePaiementDal : App
    {
        

        public string EnregistrerPaiement(ModalitePaiement Pro)
        {
            string msg = "";
            try
            {
                con.Open();
                string req = "Insert into  Paiment values('" + Pro.getCodepc() + "','" + Pro.getId_Opt() + "', '" + Pro.getFraisInscription() + "','" + Pro.getFraisDentres() + "','" + Pro.getFraisSession() + "','" + Pro.getDateenreg() + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {

                    msg = "Cette Modalite de paiement a ete Enregiter pour Cette Option, son Idendifiant unique est :" + Pro.getCodepc();
                   
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
        public ModalitePaiement RechercherPaiement(String codepc, ModalitePaiement Pro)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                string req = "Select *  from Paiment  where codepc='" + codepc + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    Pro.setCodepc(rs.GetString(0));
                    Pro.setId_Opt(rs.GetString(1));
                    Pro.setFraisInscription(rs.GetDouble(2));
                    Pro.setFraisDentres(rs.GetDouble(3));
                    Pro.setFraisSession(rs.GetDouble(4));
                    Pro.setDateenreg(rs.GetString(5));
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
        public ModalitePaiement RechercherPaiement2(String Id_Opt, ModalitePaiement Pro)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                string req = "Select *  from Paiment  where Id_Opt='" + Id_Opt + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    Pro.setCodepc(rs.GetString(0));
                    Pro.setId_Opt(rs.GetString(1));
                    Pro.setFraisInscription(rs.GetDouble(2));
                    Pro.setFraisDentres(rs.GetDouble(3));
                    Pro.setFraisSession(rs.GetDouble(4));
                    Pro.setDateenreg(rs.GetString(5));
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
        public string ModifierPaiement(String codepc, double fraisInscription, double fraisDentres, double fraisSession)
        {
            string msg = null;
            try
            {
                con.Open();
                String req = "update Paiment set fraisInscription='" + fraisInscription + "',fraisDentres='" + fraisDentres + "',fraisSession='" + fraisSession + "' where codepc='" + codepc + "'";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Modification reussi vre";
                }
                else { msg = "Modification non reussi"; }
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
        public int EnregistrerAncien(String codepc, String Id_Opt, String Dateenreg, double fraisInscription, double fraisDentres, double fraisSession)
        {
            string msg = "";
            int va = 0;
     
            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");
            try
            {
                con.Open();
                String req = "Insert into  AncienPaiment values('" + codepc + "','" + Id_Opt + "','" + fraisInscription + "','" + fraisDentres + "','" + fraisSession + "','" + Dateenreg + "','" + datedujour + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {

                    msg = "enreg reussi";

                    va = 1;
                }
                else { va=0;}
            }
            catch (MySqlException ex)
            {
                msg = "" + ex.ToString();
                va = 0;
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
            return va;

        }
      //
        public string EnregistrerComptePaiement(String Id_Etud, String Id_Opt, double fraisInscription, double fraisDentres, double fraisSession)
        {
            string msg = "";
            int va = 0;
            double solde = 0;
            Random rd = new Random();
            int val = rd.Next(111 + 99999);
            String codecompte = "Compte-" + val;
            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");
            try
            {
                con.Open();
                String req = "Insert into  ComptePaiment values('" + codecompte + "','" + Id_Opt + "','" + Id_Etud + "','" + fraisInscription + "','" + fraisDentres + "','" + fraisSession + "','" + solde + "','" + datedujour + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {

                    msg = "enreg reussi";

                    va = 1;
                }
            }
            catch (MySqlException ex)
            {
                msg = "" + ex.ToString();
                va = 0;
            }
            finally
            {
                if (con != null) { con.Close(); }
            }
            return msg;

        }
      //
        public string SuprimmerPaiement(String codepc)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "delete from Paiment  where codepc='" + codepc + "'";

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
      //
        public string ModifierMontant(String CodeCompte, double solde)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "Update ComptePaiment set solde='" + solde + "' where CodeCompte='" + CodeCompte + "'";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Compte Modifier"; 
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
        public string enregTransfert(String CodeCompte, double momtant)
        {
            string msg = "";
            var dt = DateTime.Now;
            string datedujour = dt.ToString("yyyy/MM/dd");

            Random rd = new Random();
            int val = rd.Next(9999);
            String tran = "Tr-" + val;
            try
            {
                con.Open();
                String req = "Insert into  TransacrionsEtudiants values('" + tran + "','" + CodeCompte + "','" + momtant + "','" + datedujour + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    msg = "Transactions Enregistrer";
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
        public string RechercherCodeCompte(String Id_Etud)
        {

            //Preparer la requete
            string msg = null;
        

            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select CodeCompte  from ComptePaiment  where Id_Etud='" + Id_Etud + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("CodeCompte");

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
        public string RechercherSolde(String CodeCompte)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select solde  from ComptePaiment  where CodeCompte='" + CodeCompte + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("solde");

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
        public string RechercherSommation(String Id_Etud)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select sum(FraisInscription+fraisDentres+FraisSession+FraisSession) as solde  from ComptePaiment  where Id_Etud='" + Id_Etud + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("solde");

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
        public string RechercherFrais(String Id_Etud)
        {

            //Preparer la requete
            string msg = null;


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select FraisSession  from ComptePaiment  where Id_Etud='" + Id_Etud + "'";
                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    msg = rs.GetString("FraisSession");

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
        public DataSet ListerPaiement()
        {

            DataSet mesaje = new DataSet();
            string req = "Select P.codepc, O.Nom_Opt, P.FraisInscription,P.fraisDentres,P.FraisSession from Paiment P,Options O where P.Id_Opt=O.Id_Opt";


            con.Open();

            MySqlDataAdapter myAdapter = new MySqlDataAdapter(req, con);
            myAdapter.Fill(mesaje, "Paiment P,Options O");
            con.Close();
            return mesaje;
        }
      //
        public DataSet ListerAncienPaiement()
        {

            DataSet mesaje = new DataSet();

            String req = "Select P.codepc, O.Nom_Opt, P.FraisInscription,P.fraisDentres, P. FraisSession, P.dateenregmodif from AncienPaiment P,Options O where P.Id_Opt=O.Id_Opt";

            con.Open();

            MySqlDataAdapter myAdapter = new MySqlDataAdapter(req, con);
            myAdapter.Fill(mesaje, "AncienPaiment P,Options O");
            con.Close();
            return mesaje;
        }
      //
        public DataSet Listertransactions()
        {

            DataSet mesaje = new DataSet();
            String req = "Select * from TransacrionsEtudiants";


            con.Open();

            MySqlDataAdapter myAdapter = new MySqlDataAdapter(req, con);
            myAdapter.Fill(mesaje, "TransacrionsEtudiants");
            con.Close();
            return mesaje;
        }
    }
}

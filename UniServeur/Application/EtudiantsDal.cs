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
   public class EtudiantsDal
    {
        public static string conStr = "server=localhost;user=root;password='3059';database=gestionuniversite";
        public static MySqlConnection con = new MySqlConnection(conStr);
        public static MySqlCommand cmd = null;
        public static MySqlDataAdapter adapter = new MySqlDataAdapter();

        public string EnregistreEtudiant(Etudiants Etud)
        {
            string msg = "";
            try
            {
                con.Open();
                string req = "Insert into  Etudiant values('" + Etud.getCodeEtud() + "','" + Etud.getNom() + "','" + Etud.getPrenom() + "','" + Etud.getSexe() + "','" + Etud.getDateNaiss() + "','" + Etud.getNif() + "','" + Etud.getAdresse() + "','" + Etud.getEmail() + "','" + Etud.getPhone() + "','" + Etud.getNomResponsable() + "','" + Etud.getPhoneResponsable() + "','" + Etud.getVacation() + "','" + Etud.getNomOption() + "','" + Etud.getDatEnregistr() + "','" + Etud.getPromotion() + "','" + Etud.getNiveau() + "')";

                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    ModalitePaiement paie = new ModalitePaiement();
                    ModalitePaiementDal dal = new ModalitePaiementDal();
                    dal.RechercherPaiement2(Etud.getNomOption(), paie);

                    double fraisInscription2 = paie.getFraisInscription();
                    if (fraisInscription2 != 0.0)
                    {
                        ReinscrireEtud("1", Etud.getCodeEtud());
                        msg = "Enregistrement reussi, Etudiant de code:" + Etud.getCodeEtud();
                        double fraisDentres2 = paie.getFraisDentres();
                        double fraisSession2 = paie.getFraisSession();
                 dal.EnregistrerComptePaiement(Etud.getCodeEtud(), Etud.getNomOption(), fraisInscription2, fraisDentres2, fraisSession2);
                    }

                    else
                    {
                        msg = "Une modalite de paiement n'as pas ete enregistrer pour l'option de cet etudiant";
                        SuprimmerEtudiant(Etud.getCodeEtud());
                    }
                }
            }
            catch (MySqlException ex)
            {
                msg = "" + ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return msg;

        }
       //
        public Etudiants RechercherEudiant(String CodeEtud, Etudiants Etud)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();
                String req = "Select Id_Etud,Nom_Etud,Prenom_Etud,sexe,datNaiss,nif,adresse,email,phone,nomResponsable,numeroRefference,NomVacation,Nom_Opt,promotion,codeniv from Etudiant natural join options where Id_Etud='" + CodeEtud + "'";

                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {


                   

                    Etud.setCodeEtud(rs.GetString(0));
                    Etud.setNom(rs.GetString(1));
                    Etud.setPrenom(rs.GetString(2));
                    Etud.setSexe(rs.GetString(3));
                    Etud.setDateNaiss(rs.GetString(4));
                    Etud.setNif(rs.GetString(5));
                    Etud.setAdresse(rs.GetString(6));
                    Etud.setEmail(rs.GetString(7));
                    Etud.setPhone(rs.GetString(8));
                    Etud.setNomResponsable(rs.GetString(9));
                    Etud.setPhoneResponsable(rs.GetString(10));
                    Etud.setVacation(rs.GetString(11));
                    Etud.setNomOption(rs.GetString(12));
                    Etud.setPromotion(rs.GetString(13));
                    Etud.setNiveau(rs.GetString(14));
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
            return Etud;
        }

       //
        public Etudiants RechercherNifEudiant(String req, Etudiants Etud)
        {

            //Preparer la requete
            string msg = "";


            try
            {
                //Etablir la connexion
                con.Open();

                //Creer Statement
                cmd = new MySqlCommand(req, con);
                //Executer la requete
                //Creer un objet de type ResultSet
                MySqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {




                    Etud.setCodeEtud(rs.GetString(0));
                    Etud.setNom(rs.GetString(1));
                    Etud.setPrenom(rs.GetString(2));
                    Etud.setSexe(rs.GetString(3));
                    Etud.setDateNaiss(rs.GetString(4));
                    Etud.setNif(rs.GetString(5));
                    Etud.setAdresse(rs.GetString(6));
                    Etud.setEmail(rs.GetString(7));
                    Etud.setPhone(rs.GetString(8));
                    Etud.setNomResponsable(rs.GetString(9));
                    Etud.setPhoneResponsable(rs.GetString(10));
                    Etud.setVacation(rs.GetString(11));
                    Etud.setNomOption(rs.GetString(12));
                    Etud.setPromotion(rs.GetString(13));
                    Etud.setNiveau(rs.GetString(14));
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
            return Etud;
        }
       //
        public string ModifierEtudiant(String CodeEtud, String Nom, String Prenom, String adresse, String email, String phone, String nomResponsable, String numeroRefference)
        {
            string msg = "";
            try
            {
                con.Open();
                String req = "update Etudiant set Nom_Etud='" + Nom + "',Prenom_Etud='" + Prenom + "',adresse='" + adresse + "',email='" + email + "',phone='" + phone + "',nomResponsable='" + nomResponsable + "',numeroRefference='" + numeroRefference + "' where Id_Etud='" + CodeEtud + "'";
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
       //
        public string ModifierNiveauEtudiant(String CodeEtud, String codeniv)
        {
            string msg = "";
            try
            {
                con.Close();
                con.Open();
                String req = "update Etudiant set codeniv='" + codeniv + "' where Id_Etud='" + CodeEtud + "'";
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

       //
        public string ReinscrireEtud(String Niv, String CodeEtud)
        {
            string msg = "";
            Random rd = new Random();
            int val = rd.Next(111 + 9999);
            String codeNivEt = "Niv-" + val;
            try
            {
                con.Close();
                con.Open();
                String req = "insert into NivoEtudiants values('" + codeNivEt + "','" + CodeEtud + "','" + Niv + "')";
                cmd = new MySqlCommand(req, con);
                if (cmd.ExecuteNonQuery() != 0)
                {
                    ModifierNiveauEtudiant(CodeEtud, Niv);
                    msg = "L'etudiant a ete Reeinscrit et maintenant au niveau !" + Niv;
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
        public string SuprimmerEtudiant(String Id_Etud)
        {
            string msg = "";
            try
            {
                con.Close();
                con.Open();
                String req = "delete from Etudiant  where Id_Etud='" + Id_Etud + "'";
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
        public DataSet ListerEtudiant()
        {

            DataSet mesaje = new DataSet();
            string req = "Select * from etudiant";


            con.Open();

            MySqlDataAdapter myAdapter = new MySqlDataAdapter(req, con);
            myAdapter.Fill(mesaje, "etudiant");
            con.Close();
            return mesaje;
        }

    }
}

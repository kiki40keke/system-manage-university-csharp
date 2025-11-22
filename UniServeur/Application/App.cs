using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Dal
{
    public class App
    {
        // Protéger les membres pour l'accès en héritage
        protected static string conStr = "server=localhost;user=root;password='3059';database=gestionuniversite";
        protected static MySqlConnection con = new MySqlConnection(conStr);
        protected static MySqlCommand cmd = null;
        protected static MySqlDataAdapter adapter = new MySqlDataAdapter();

        // Méthodes utilitaires protégées
        protected static void OpenConnection()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
        }

        protected static void CloseConnection()
        {
            if (con.State != ConnectionState.Closed)
                con.Close();
        }
    }
}


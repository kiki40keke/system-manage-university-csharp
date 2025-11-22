using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using Controlleur;
using Dal;

namespace UniServeur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            //creation du bchanel
            TcpChannel tp = new TcpChannel(1069);

          //  EvaluationsNormalDal pad = new EvaluationsNormalDal();
          //  PalmaresseDal pas = new PalmaresseDal();
          //  string[,] ListerNotes = pad.ListedesNotes("EvNor-772991");
          ////  string[,] ListerNotes = pas.ListerPalmares2();
          //  int ligne = ListerNotes.Length;
          //  int div = ligne / 5;
          //  MessageBox.Show(ListerNotes[0,0]);

          //  string code = ListerNotes[0, 0].ToString();


            //enregistrer
            ChannelServices.RegisterChannel(tp);
            
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControlleurUtilisateur), "objetUtilisateur", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(EmployerControlleur), "objetEmployer", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ProfesseurControlleur), "objetProfesseur", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ServicesControleur), "objetServicesCours", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControlleurEtudiants), "objetEtudiant", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ControlleurPaiement), "objetPaiement", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PalmaresControlleur), "objetPalmaresse", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(EvaluationsNormalControlleur), "objetEvaluation", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(NoteControlleur), "objetNote", WellKnownObjectMode.Singleton);


        
        }
    }
}

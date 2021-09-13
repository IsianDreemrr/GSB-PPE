using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPE2
{

  //  public static class Globals
    //{
  //      public static string Identifiant = "";
   // }

    public partial class frmlLogin : Form
    {

        //Identifiants de connexion
        public static string Identifiant = "";
        public static string NomParent = "";

        //INDIQUER ICI LA DATASOURCE (Ainsi que sur la fonction jumelle de l'autre classe)
        private string datasource()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\ppe2\login.mdf;Integrated Security=True;Connect Timeout=30";
        }

        //Init
        public frmlLogin()
        {
            InitializeComponent();
        }

        private void GetNomPrenom()
        {
            //Fonction utilisée pour actualiser le contenu de la liste des enfants
            //Connexion à la BDD
            SqlConnection sqlcon = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string query = "Select nom,prenom from login where username = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            SqlCommand command = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            SqlDataReader reader = command.ExecuteReader();


            //Lecture du résultat de la requête
            reader.Read();
            NomParent = "";
            NomParent += (string)reader["prenom"];
            NomParent += " ";
            NomParent += (string)reader["nom"];
            sqlcon.Close();
        }

        //Clic de connexion 
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //Connexion à la bdd et écriture de la requête
            SqlConnection sqlcon = new SqlConnection(datasource());
            string query = "Select * from login where username = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";

            //Execution de la requête
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();

            //Vérification des identifiants (Si il y a 1 ligne, c'est que ça marche)
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {

                sqlcon.Close();

                //Appel de l'autre fenêtre
               

                if (NomParent == "")
                {
                    GetNomPrenom();
                    frmMain objFrmMain = new frmMain();
                    objFrmMain.Show();
                    this.Hide();
                }
                else
                {
                    GetNomPrenom();
                    frmMain objFrmMain = new frmMain();
                    objFrmMain.Show();
                    this.Close();
                }

                





            }
            else MessageBox.Show("Identifiants invalides. Veuillez réessayer.");
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Identifiant = txtUsername.Text.ToString();
        }
    }
}

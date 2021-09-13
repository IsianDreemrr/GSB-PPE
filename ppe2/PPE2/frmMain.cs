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
    public partial class frmMain : Form
    {
        public string Username;

        //Init
        public frmMain()
        {
            InitializeComponent();

            frmlLogin frm = new frmlLogin();

            LabelNom.Text = frmlLogin.NomParent;
            //MessageBox.Show("Bonjour, " + frmlLogin.NomParent + "!");
            full_refresh();


        }

        //INDIQUER ICI LA DATASOURCE (Ainsi que sur la fonction jumelle de l'autre classe)
        private string datasource()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\ppe2\login.mdf;Integrated Security=True;Connect Timeout=30";
        }

        // -------------------------- FONCTIONS ----------------------------------
        // --------------------------   Gets ---------------------------------------

        private string get_TrancheAgeEnfant()
        {
            //Fonction utilisée pour actualiser le contenu de la liste des enfants
            //Connexion à la BDD
            SqlConnection sqlconRefresh = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string queryRefresh = "Select Enfant.age from Enfant where enfant.prenom = '" + ChoixEnfant.SelectedItem + "'";
            SqlCommand commandRefresh = new SqlCommand(queryRefresh, sqlconRefresh);
            sqlconRefresh.Open();
            //SqlDataReader readerRefresh = commandRefresh.ExecuteReader();

            int age = (Int32)commandRefresh.ExecuteScalar();
            string trancheAge = "0";
            if (age < 2) trancheAge = "0-2";
            if (age >= 2 && age <4) trancheAge = "2-4";
            if (age >= 4 && age <8) trancheAge = "4-8";
            if (age >= 8 && age < 12) trancheAge = "8-12";
            if (age >= 12) trancheAge = ">12";

            sqlconRefresh.Close();

            return trancheAge;
        }

        private int getIdLogin()
        {
            //Fonction utilisée pour actualiser le contenu de la liste des enfants
            //Connexion à la BDD
            SqlConnection sqlcon = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string query = "select IdLogin from login where username = '" + frmlLogin.Identifiant + "'";
            SqlCommand command = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            int Retour = (Int32)command.ExecuteScalar();
            sqlcon.Close();
            return Retour;
        }


        private int getIdEnfant()
        {
            //Fonction utilisée pour actualiser le contenu de la liste des enfants
            //Connexion à la BDD
            SqlConnection sqlcon = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string query = "select idEnfant from Enfant where prenom = '" + ChoixEnfant.SelectedItem + "'";
            SqlCommand command = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            int Retour = (Int32)command.ExecuteScalar();
            sqlcon.Close();
            return Retour;
        }


        private int getIdJouet()
        {
            //Fonction utilisée pour actualiser le contenu de la liste des enfants
            //Connexion à la BDD
            SqlConnection sqlcon = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string query = "select idJouet from jouet where nom = '" + Catalogue.SelectedItem + "'";
            SqlCommand command = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            int Retour = (Int32)command.ExecuteScalar();
            sqlcon.Close();
            return Retour;
        }

        // -------------------------- Is? ---------------------------------------

        private bool IsJouetEnStock()
        {

            int IdJouet = getIdJouet();

            //Fonction utilisée pour actualiser le contenu de la liste des enfants
            //Connexion à la BDD
            SqlConnection sqlcon = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string query = "select count(IDReservation) from Reservation where idJouet = " + IdJouet +"";
            SqlCommand command = new SqlCommand(query, sqlcon);
            sqlcon.Open();

            //Retour
            int resultat = (Int32)command.ExecuteScalar();
            sqlcon.Close();

            if (resultat >= 5) return false;
            else return true;


        }

        private bool IsEnfantDispo()
        {

            int IdEnfant = getIdEnfant();
            int IdLogin = getIdLogin();

            //Connexion à la BDD
            SqlConnection sqlcon = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string query = "select count(IDReservation) from Reservation where idEnfant = " + IdEnfant + " and IdLogin = " + IdLogin + "";
            SqlCommand command = new SqlCommand(query, sqlcon);
            sqlcon.Open();

            //Retour
            int resultat = (Int32)command.ExecuteScalar();
            sqlcon.Close();

            if (resultat >= 1) return false;
            else return true;

        }

        // -------------------------- Refresh ---------------------------------------
        private void full_refresh()
        {
            refresh_Catalogue();
            refresh_ChoixEnfant();
            refresh_LabelPanier();
            refresh_LabelRes();
        }

        private void refresh_ChoixEnfant()
        {
            //Fonction utilisée pour actualiser le contenu de la liste des enfants
            //Connexion à la BDD
            SqlConnection sqlconRefresh = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string queryRefresh = "Select Enfant.prenom from Enfant join Parentalite on Enfant.idEnfant = Parentalite.idEnfant join login on login.idLogin = Parentalite.idLogin where login.username = '" + frmlLogin.Identifiant + "'";
            SqlCommand commandRefresh = new SqlCommand(queryRefresh, sqlconRefresh);
            sqlconRefresh.Open();
            SqlDataReader readerRefresh = commandRefresh.ExecuteReader();

            //Suppression du contenu actuellement affiché dans la liste d'enfants
            ChoixEnfant.Items.Clear();

            //Affichage du contenu actualisé (ligne par ligne)
            while (readerRefresh.Read())
            {
                ChoixEnfant.Items.Add(readerRefresh["prenom"]);
            }
            sqlconRefresh.Close();

        }


        private void refresh_Catalogue()
        {
           //Fonction utilisée pour actualiser le contenu de la liste du catalogue
           //Connexion à la BDD
            SqlConnection sqlconRefresh = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string queryRefresh = "Select nom from jouet where categorie = '" + ListCategorie.SelectedItem + "' and trancheAge = '" + ListTrancheAge.SelectedItem + "' and quantite > 0";
            SqlCommand commandRefresh = new SqlCommand(queryRefresh, sqlconRefresh);
            sqlconRefresh.Open();
            SqlDataReader readerRefresh = commandRefresh.ExecuteReader();

            //Suppression du contenu actuellement affiché dans le catalogue
            Catalogue.Items.Clear();

            //Affichage du contenu actualisé (ligne par ligne)
            while (readerRefresh.Read())
            {
                Catalogue.Items.Add(readerRefresh["nom"]);
            }
            sqlconRefresh.Close();
        }



        private void refresh_LabelPanier()
        {
            btnAjoutPanier.Enabled = false;
            //Si un item est sélectionné
            if (Catalogue.SelectedItem != null)
            {
                //Si un enfant est sélectionné
                if (ChoixEnfant.SelectedItem != null)
                {
                    //Si la tranche d'âge correspond avec l'âge de l'enfant
                    if ((String)ListTrancheAge.SelectedItem == get_TrancheAgeEnfant())
                    {
                        //Si la limite de 5 réservations n'est pas atteinte
                        if (IsJouetEnStock() == true)
                        {

                            if (IsEnfantDispo() == true)
                            {
                                LabelErrorRes.Text = "";

                                //Actualisation du bouton
                                btnAjoutPanier.Enabled = true;
                            }
                        }
                        else LabelErrorRes.Text = "Max 5 réservations par jouet.";
                    }
                    else LabelErrorRes.Text = "Tranche d'âge invalide";
                }
                else LabelErrorRes.Text = "Sélectionnez un enfant";
            }
            else LabelErrorRes.Text = "Sélectionnez un jouet";



        }

        private void refresh_LabelRes()
        {
            if (ChoixEnfant.SelectedItem == null)
            {
                LabelRes.Text = "Sélectionnez un enfant pour voir ses réservations.";

                //Actualisation du bouton
                btnRetirerPanier.Enabled = false;
                
            }
            else
            {
                if (IsEnfantDispo() == true)
                {
                    LabelRes.Text = "Aucune réservation de jouet pour cet enfant.";

                    //Actualisation du bouton
                    btnRetirerPanier.Enabled = false;
                }
                else
                {
                    //Fonction utilisée pour actualiser le contenu de la liste du catalogue
                    //Connexion à la BDD
                    SqlConnection sqlconRefresh = new SqlConnection(datasource());

                    //Requête SQL pour obtenir le contenu à afficher
                    string queryRefresh = "Select nom from jouet join Reservation on jouet.idJouet = Reservation.idJouet where jouet.idJouet = (select idJouet from Reservation where idlogin = " + getIdLogin() + " and idEnfant = " + getIdEnfant() + ")";
                    SqlCommand commandRefresh = new SqlCommand(queryRefresh, sqlconRefresh);
                    sqlconRefresh.Open();
                    SqlDataReader readerRefresh = commandRefresh.ExecuteReader();

                    //Affichage du contenu actualisé (ligne par ligne)
                    readerRefresh.Read();
                    LabelRes.Text = "Un(e) " + readerRefresh["nom"] + " est réservé pour cet enfant.";
                    sqlconRefresh.Close();

                    //Actualisation du bouton
                    btnRetirerPanier.Enabled = true;
                }
            }
        }



        // -------------------------- Actions ---------------------------------------

        private void Reservation()
        {
            //Obtention de variables pour la requête
            int IdLogin = getIdLogin();
            int IdEnfant = getIdEnfant();
            int IdJouet = getIdJouet();

            //Fonction utilisée pour actualiser le contenu de la liste des enfants
            //Connexion à la BDD
            SqlConnection sqlconRes = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string queryRes = "insert into Reservation(IdLogin, idEnfant, idJouet) values ("+ IdLogin +","+ IdEnfant +","+ IdJouet +")";
            SqlCommand commandRes = new SqlCommand(queryRes, sqlconRes);
            sqlconRes.Open();
            SqlDataReader readerRes = commandRes.ExecuteReader();

            sqlconRes.Close();


        }


        private void SupprimerReservation()
        {
            //Obtention de variables pour la requête
            int IdLogin = getIdLogin();
            int IdEnfant = getIdEnfant();

            //Fonction utilisée pour actualiser le contenu de la liste des enfants
            //Connexion à la BDD
            SqlConnection sqlconRes = new SqlConnection(datasource());

            //Requête SQL pour obtenir le contenu à afficher
            string queryRes = "delete from Reservation where idEnfant = " + IdEnfant + " and IdLogin =" + IdLogin + "";
            SqlCommand commandRes = new SqlCommand(queryRes, sqlconRes);
            sqlconRes.Open();
            SqlDataReader readerRes = commandRes.ExecuteReader();

            sqlconRes.Close();
        }



        // -------------------------- Events ---------------------------------------

        private void ListTrancheAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            full_refresh();
        }

        private void ListCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            full_refresh();
        }



        private void btnAjoutPanier_Click(object sender, EventArgs e)
        {
            //Si un item est sélectionné
            if (Catalogue.SelectedItem != null)
            {
                //Si un enfant est sélectionné
                if (ChoixEnfant.SelectedItem != null)
                {
                    //Si la tranche d'âge correspond avec l'âge de l'enfant
                     if ((String)ListTrancheAge.SelectedItem == get_TrancheAgeEnfant())
                     {
                        //Si la limite de 5 réservations n'est pas atteinte
                        if (IsJouetEnStock() == true)
                        {

                            if (IsEnfantDispo() == true)
                            {
                                Reservation();
                                MessageBox.Show("Le jouet a été réservé !");
                                full_refresh();
                            }
                        }
                        else MessageBox.Show("Dû à une limite de 5 réservation par jouet, vous ne pouvez plus réserver ce jouet-ci.");
                    }
                    else MessageBox.Show("Le jouet n'appartient pas à la tranche age adaptée à votre enfant.");
                }
                else MessageBox.Show("Vous n'avez pas sélectionné d'enfant pour recevoir le cadeau");
            }
            else MessageBox.Show("Vous n'avez pas sélectionné de jouet à réserver.");
        }

        private void btnRetirerPanier_Click(object sender, EventArgs e)
        {
            //Si un enfant est sélectionné
            if (ChoixEnfant.SelectedItem != null)
            {
                if (IsEnfantDispo() == false)
                {
                   SupprimerReservation();
                   MessageBox.Show("Le jouet a été supprimé !");
                    full_refresh();
                }
                else MessageBox.Show("L'enfant choisi n'a pas de réservation à supprimer.");

            }
            else MessageBox.Show("Vous n'avez pas sélectionné d'enfant pour laquelle la réservation doit être supprimée");
        }

        private void ChoixEnfant_SelectedItemChanged(object sender, EventArgs e)
        {
            get_TrancheAgeEnfant();
            full_refresh();

        }


        private void btnDeco_Click(object sender, EventArgs e)
        {
            frmlLogin objFrmlLogin = new frmlLogin();

            objFrmlLogin.Show();
            this.Close();
        }

        // ------ Non utilisés -------


        private void catalogue_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_LabelPanier();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void LabelRes_Click(object sender, EventArgs e)
        {

        }


        private void LabelNom_Click(object sender, EventArgs e)
        {

        }
    }
}

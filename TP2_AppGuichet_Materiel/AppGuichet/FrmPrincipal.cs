using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;


namespace AppGuichet
{
    /// =====================================================================================================================
    /// <summary>
    /// Représente l’utilisation d’un guichet automatique. Un client peut se connecter avec son numéro et son mot de passe.
    /// Il peut retirer de l’argent si son solde le permet. L’administrateur du guichet peut demander la liste des clients
    /// où la liste des transactions effectuées sur le guichet.
    /// </summary>
    /// ======================================================================================================================
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Démo)";

        #region Constantes
        //--- CHAMPS: constantes ----------------------------------------------------------
        public const string CHEMIN_FICHIER_CLIENTS = "../../../Fichiers/Clients.csv";
        public const string CHEMIN_FICHIER_TRANSACTIONS = "../../../Fichiers/Transactions.csv";
        #endregion

        #region Champs et Propriétés
        private ServiceGuichet m_service;


        #endregion

        #region Constructeur
        //---------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text += APP_INFO;
            m_service = new ServiceGuichet(CHEMIN_FICHIER_CLIENTS, CHEMIN_FICHIER_TRANSACTIONS);
            m_service.ChargerClients();
            m_service.ChargerTransactions();

        }
        #endregion





        #region Menu Administrateur
        //---------------------------------------------------------------------------------
        private void mnuAdminListeClients_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------------------------
        private void mnuAdminListeTransactions_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void FrmPrincipal_FormClosing(object sender, EventArgs e)
        {


        }
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {



        }



        #region Bouton Connexion/Déconnexion 
        //---------------------------------------------------------------------------------
        public void btnConnexion_Click(object sender, EventArgs e)
        {
            if (m_service.ClientCourant == null)
            {
                if (m_service.Connexion(txtNumClient.Text, txtMotDePasse.Text))
                {
                    MessageBox.Show("Connexion réussie");

                    if (m_service.ClientCourant.IsAdmin)
                        mnuAdministrateur.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erreur de connexion");
                }
            }
            else
            {
                m_service.Deconnexion();
                mnuAdministrateur.Enabled = false;
                MessageBox.Show("Déconnecté");
            }


        }
        #endregion

        #region Bouton Retirer et Événement Combo Montant à retirer
        //---------------------------------------------------------------------------------
        //Retire le montant choisi
        public void btnDeposer_Click(object sender, EventArgs e)
        {
            try
            {
                int montant = int.Parse(cboMontant.Text);

                m_service.ClientCourant.Deposer(montant);

                m_service.CreerTransaction(
                    SorteTransactions.Dépôt,
                    m_service.ClientCourant.NumClient,
                    DateTime.Now,
                    montant
                );

                MessageBox.Show("Dépôt effectué");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        //---------------------------------------------------------------------------------
        //Choix du montant à retirer
        private void cboMontant_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        #endregion

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            try
            {
                int montant = int.Parse(cboMontant.Text);

                m_service.ClientCourant.Retirer(montant);

                m_service.CreerTransaction(
                    SorteTransactions.Retrait,
                    m_service.ClientCourant.NumClient,
                    DateTime.Now,
                    montant
                );

                MessageBox.Show("Retrait effectué");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void mnuAdministrateur_Click(object sender, EventArgs e)
        {

        }

        private void grpIdentification_Enter(object sender, EventArgs e)
        {

        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Windows.Forms;
//using System.IO;

//namespace AppGuichet
//{
//    /// =====================================================================================================================
//    /// <summary>
//    /// Représente l’utilisation d’un guichet automatique. Un client peut se connecter avec son numéro et son mot de passe.
//    /// Il peut retirer de l’argent si son solde le permet. L’administrateur du guichet peut demander la liste des clients
//    /// où la liste des transactions effectuées sur le guichet.
//    /// </summary>
//    /// ======================================================================================================================
//    public partial class FrmPrincipal : Form
//    {
//        public const string APP_INFO = "(Démo)";

//        #region Constantes
//        //--- CHAMPS: constantes ----------------------------------------------------------
//        private const string NOM_FICHIER_CLIENTS = "Fichiers\\Clients.txt";
//        public const string NOM_FICHIER_TRANSACTIONS = "Fichiers\\Transactions.txt";
//        private const string NO_ADMIN = "000";
//        public const string ERR_NUMERO_CLIENT = "Numéro de client non valide";
//        private const string ERR_MOT_DE_PASSE = "Mot de passe incorrect";
//        #endregion

//        #region Champs et Propriétés
//        public ServiceGuichet m_serviceGuichet { get; private set; }
       
       
//        #endregion

//        #region Constructeur
//        //---------------------------------------------------------------------------------
//        public FrmPrincipal()
//        {
//            InitializeComponent();
//            this.Text += APP_INFO;
//            //-----------------------------------------------------------------------------------------------------
//           m_serviceGuichet = new ServiceGuichet();
//        }
//        #endregion

     

       

//        #region Menu Administrateur
//        //---------------------------------------------------------------------------------
//        private void mnuAdminListeClients_Click(object sender, EventArgs e)
//        {
//            //FrmListeClients objFrmListeClients = new FrmListeClients(m_colClients);
//            //objFrmListeClients.ShowDialog();
//        }
//        //---------------------------------------------------------------------------------
//        private void mnuAdminListeTransactions_Click(object sender, EventArgs e)
//        {
//            FrmListeTransactions objFrmListeTransactions = new FrmListeTransactions(m_serviceGuichet.Transactions);
//            objFrmListeTransactions.ShowDialog();
//        }


//        #endregion

//        private void FrmPrincipal_FormClosing(object sender, EventArgs e)
//        {
//            //FrmListeClients objFrmListeClients = new FrmListeClients(m_colClients);
//            //objFrmListeClients.ShowDialog();
//        }
//        private void mnuFichierQuitter_Click(object sender, EventArgs e)
//        {
//            //FrmListeClients objFrmListeClients = new FrmListeClients(m_colClients);
//            //objFrmListeClients.ShowDialog();
//        }

//        #region  Méthodes: Enregistrer la transaction, PermettreUneConnexion, MettreAjourSelonContexte, RechercherClient
//        //-----------------------------------------------------------------------------------------------------------
//        /// <summary>
//        /// Écrit dans le fichier de transactions, la nouvelle transaction qui vient de se produire, maintenant.
//        /// Ajoute aussi cette nouvelle transaction dans la collection de transactions.
//        /// </summary>
//        /// <param name="pSorteTransaction">sorte de transaction</param>
//        /// <param name="pMontantRetrait">montant du retrait, 0 si ce n'est pas un retrait</param>
//        /// --------------------------------------------------------------------------------------------------------
//        public void EnregistrerLaTransaction(SorteTransactions pSorteTransaction, int pMontantRetrait)
//        {
           
//        }
        
//        //------------------------------------------------------------------------------------------------
//        /// <summary>
//        /// Modifie l'interface selon qu'un client se connecte ou se déconnecte. 
//        /// </summary>
//        /// <param name="pConnexionEstPermise">un client se connecte ou non</param>
//        /// ---------------------------------------------------------------------------------------------
//        private void PermettreUneConnexion(bool pConnexionEstPermise)
//        {
//            //txtNumClient.ReadOnly = !pConnexionEstPermise;
//            //lblMotDePasse.Enabled = pConnexionEstPermise;
//            //txtMotDePasse.Enabled = pConnexionEstPermise;
//            //btnConnexion.Text = pConnexionEstPermise ? "Se connecter" : "Se déconnecter";

//            //if (pConnexionEstPermise)
//            //{
//            //    txtNumClient.Clear();
//            //    txtMotDePasse.Clear();
//            //    txtSolde.Clear();
//            //    txtNom.Clear();
//            //    txtSorteCompte.Clear();
//            //    txtNumClient.Focus();
//            //}

//        }
//        //--------------------------------------------------------------------------------------------
//        /// <summary>
//        /// Active ou désactive les menus et contrôles selon s'il s'agit de l'administrateur ou non.
//        /// </summary>
//        /// -----------------------------------------------------------------------------------------
//        private void MettreAJourSelonContexte()
//        {
//            //bool modeAdmin = m_objClientCourant != null && m_objClientCourant.NumClient == NO_ADMIN;
//            ////mnuAdminNouveauClient.Enabled = modeAdmin;
//            //mnuAdminListeClients.Enabled = modeAdmin;
//            //mnuAdminListeTransactions.Enabled = modeAdmin;
//            //mnuAdministrateur.Enabled = modeAdmin;
//            //grpInfosClient.Enabled = m_objClientCourant != null && !modeAdmin;
//        }
   
//        #endregion

//        #region Bouton Connexion/Déconnexion 
//        //---------------------------------------------------------------------------------
//        public void btnConnexion_Click(object sender, EventArgs e)
//        {
//            if (m_serviceGuichet.ClientCourant == null)
//            {
//                bool estConnecte = m_serviceGuichet.Connexion(txtNumClient.Text, txtMotDePasse.Text);
//                if (estConnecte)
//                {
//                    if (m_serviceGuichet.ClientCourant.IsAdmin)
//                    {
//                        mnuAdministrateur.Enabled = true;
//                        mnuAdminListeClients.Enabled = true;
//                        mnuAdminListeTransactions.Enabled = true;

//                        grpInfosClient.Enabled = false;
//                        cboComptes.SelectedIndex = -1;
//                        cboMontant.SelectedIndex = -1;
//                        txtNom.Text = m_serviceGuichet.ClientCourant.Nom;
//                        txtSolde.Clear();//.Text = ((Compte)cboComptes.SelectedItem).Solde.ToString("C2");

//                        btnRetirer.Enabled = false;
//                        btnDeposer.Enabled = false;

                       
//                    }
//                    else
//                    {
//                        foreach (Compte compte in m_serviceGuichet.ClientCourant.Comptes)
//                        {
//                            cboComptes.Items.Add(compte);
//                        }
//                        cboComptes.SelectedIndex = 0;
//                        txtNom.Text = m_serviceGuichet.ClientCourant.Nom;
//                        txtSolde.Text = ((Compte)cboComptes.SelectedItem).Solde.ToString("C2");
//                        grpInfosClient.Enabled = true;
//                        mnuAdministrateur.Enabled = false;
//                        btnRetirer.Enabled = false;
//                        btnDeposer.Enabled = false;
                        

//                    }
//                    txtNumClient.Enabled = false;
//                    txtMotDePasse.Enabled = false;
//                    btnConnexion.Text = "Se déconnecter";
//                }

//            }
//            else
//            {
//                bool estConnecte = m_serviceGuichet.Deconnexion();
//                btnConnexion.Text = "Se connecter";
//                cboComptes.SelectedIndex = -1;
//                txtNom.Clear();//.Text = m_serviceGuichet.ClientCourant.Nom;
//                txtSolde.Clear();//.Text = ((Compte)cboComptes.SelectedItem).Solde.ToString("C2");
//                grpInfosClient.Enabled = false;
//                mnuAdministrateur.Enabled = false;
//                btnRetirer.Enabled = false;
//                btnDeposer.Enabled = false;
//                txtNumClient.Clear();
//                txtNumClient.Enabled = true;
//                txtMotDePasse.Clear();
//                txtMotDePasse.Enabled = true;



//            }



//            //errIdentification.SetError(txtNumClient, "");
//            //errIdentification.SetError(txtMotDePasse, "");
//            //if (m_objClientCourant != null) // Le client va se déconnecter
//            //{
//            //    PermettreUneConnexion(true); // un autre client pourra se connecter
//            //    EnregistrerLaTransaction(SorteTransactions.Déconnexion,0);
//            //    m_objClientCourant = null;
//            //}
//            //else // Le client va tenter de se connecter
//            //{
//            //    //on vérifie si le numéro du client existe dans la liste des clients
//            //    m_objClientCourant = RechercherClient(txtNumClient.Text);
//            //    if (m_objClientCourant != null) // le numéro du client est bon !
//            //    {
//            //        //on vérifie alors le mot de passe saisi
//            //        if (m_objClientCourant.MotDePasse == txtMotDePasse.Text) // on peut connecter ce client, les données saisies sont bonnes.
//            //        {
//            //            errIdentification.SetError(txtMotDePasse, "");
//            //            PermettreUneConnexion(false);
//            //            txtNom.Text = m_objClientCourant.Nom;
//            //            txtSorteCompte.Text = m_objClientCourant.SorteCompte.ToString();
//            //            txtSolde.Text = m_objClientCourant.Solde.ToString("C0");
//            //            cboMontant.SelectedIndex = -1;
//            //            EnregistrerLaTransaction(SorteTransactions.Connexion, 0);
//            //        }
//            //        else //Mot de passe non valide
//            //        {
//            //            errIdentification.SetError(txtMotDePasse, ERR_MOT_DE_PASSE);
//            //            txtMotDePasse.Clear();
//            //            txtMotDePasse.Focus();
//            //            m_objClientCourant = null;
//            //        }
//            //    }
//            //    else //le numéro du client est non valide
//            //    {
//            //        errIdentification.SetError(txtNumClient, ERR_NUMERO_CLIENT);
//            //        txtNumClient.Clear();
//            //        txtNumClient.Focus();
//            //    }
//            //}
//            MettreAJourSelonContexte();
//          }
//         #endregion

//        #region Bouton Retirer et Événement Combo Montant à retirer
//        //---------------------------------------------------------------------------------
//        //Retire le montant choisi
//        public void btnDeposer_Click(object sender, EventArgs e)
//        {
//            Compte CompteSelectionne = ((Compte)cboComptes.SelectedItem);        

//            int montant = int.Parse(cboMontant.Text);
//            CompteSelectionne.Deposer(montant);
//            txtSolde.Text = CompteSelectionne.Solde.ToString("C2");
//            btnRetirer.Enabled = CompteSelectionne.PeutRetirer(montant);
           
//            m_serviceGuichet.CreerTransaction(SorteTransactions.Dépôt, CompteSelectionne, DateTime.Now, montant);
           
//        }
//        //---------------------------------------------------------------------------------
//        //Choix du montant à retirer
//        private void cboMontant_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (cboMontant.SelectedIndex == -1)
//            {
//                btnRetirer.Enabled = false;
//                btnDeposer.Enabled = false;
//            }
               
//            else
//            {
//                btnRetirer.Enabled = ((Compte)cboComptes.SelectedItem).PeutRetirer(int.Parse(cboMontant.Text));
//                btnDeposer.Enabled = true;
//            }
               
//        }

//        #endregion

//        private void btnRetirer_Click(object sender, EventArgs e)
//        {
//            Compte CompteSelectionne = ((Compte)cboComptes.SelectedItem);

//            int montant = int.Parse(cboMontant.Text);
//            CompteSelectionne.Retirer(montant);
//            txtSolde.Text = CompteSelectionne.Solde.ToString("C2");
//            btnRetirer.Enabled = CompteSelectionne.PeutRetirer(int.Parse(cboMontant.Text));
//            m_serviceGuichet.CreerTransaction(SorteTransactions.Retrait, CompteSelectionne, DateTime.Now, montant);
//        }

//        private void cboComptes_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (cboMontant.SelectedIndex == -1)
//            {
//                btnRetirer.Enabled = false;
//                btnDeposer.Enabled = false;
//            }

//            else
//            {
//                btnDeposer.Enabled = true;
//                txtSolde.Text = ((Compte)cboComptes.SelectedItem).Solde.ToString("C2");
//            }
                
//        }

//        private void mnuAdministrateur_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
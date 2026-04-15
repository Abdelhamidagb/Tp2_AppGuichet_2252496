//using System;
//using System.Collections.Generic;
//using System.Windows.Forms;

//namespace AppGuichet
//{

//    public partial class FrmListeTransactions : Form
//    {
//        //------------------------------------------------------------------------------
//        private List<Transaction> m_colTransactions;

//        //----------------------------------------------------------------
//        public FrmListeTransactions(List<Transaction> pColTransactions)
//        {
//            InitializeComponent();
//            //--------------------------------------
//            m_colTransactions = pColTransactions;
//            cboOpération.SelectedIndex = 0;
//        }
//        //------------------------------------------------------------------------------
//        private void AfficherListeTransactions(FiltreOperation pFiltreOpération)
//        {
//            lsvTransactions.Items.Clear();

//            for (int index = m_colTransactions.Count - 1; index >= 0; index--)
//            {
//                Transaction objTransaction = m_colTransactions[index];
//                bool accepter = false;
//                switch (pFiltreOpération)
//                {
//                    case FiltreOperation.Toutes:
//                        accepter = true;
//                        break;
//                    case FiltreOperation.Dépôt:
//                        accepter = objTransaction.SorteTransaction == SorteTransactions.Dépôt;
//                        break;
//                    case FiltreOperation.Retrait:
//                        accepter = objTransaction.SorteTransaction == SorteTransactions.Retrait;
//                        break;
//                    default:
//                        accepter = true;
//                        break;
//                }

//                if (accepter)
//                {
//                    ListViewItem unItem = new ListViewItem(objTransaction.SorteTransaction.ToString());
                   
//                    unItem.SubItems.Add(objTransaction.Compte.NumCompte);
//                    unItem.SubItems.Add(objTransaction.Date.ToString("yyyy-MM-dd HH:mm:ss"));
//                    unItem.SubItems.Add(objTransaction.Montant != 0 ? objTransaction.Montant.ToString("c2") : "--");

//                    lsvTransactions.Items.Add(unItem);
//                }
//            }
//        }
//        //------------------------------------------------------------------------------
//        private void cboOpération_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            AfficherListeTransactions((FiltreOperation)cboOpération.SelectedIndex);
//            lblNbrTransactions.Text = lsvTransactions.Items.Count.ToString();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Transactions;
using System.Windows.Forms;


namespace AppGuichet
{

    public partial class FrmListeTransactions : Form
    {
        //------------------------------------------------------------------------------
        private List<Transaction> m_transactions;

        //----------------------------------------------------------------
        public FrmListeTransactions(List<Transaction> pTransactions)
        {
            InitializeComponent();
            //--------------------------------------

            if (pTransactions == null)
                throw new ArgumentNullException();

            m_transactions = pTransactions;

            cboOpération.DataSource = Enum.GetValues(typeof(FiltreOperation));

            AfficherListeTransactions();



        }
        //------------------------------------------------------------------------------
        private void AfficherListeTransactions()
        {
            lsvTransactions.Items.Clear();

            FiltreOperation filtre = (FiltreOperation)cboOpération.SelectedItem;

            foreach (Transaction t in m_transactions)
            {
                if (filtre == FiltreOperation.Dépôt && t.SorteTransaction != SorteTransactions.Dépôt)
                    continue;

                if (filtre == FiltreOperation.Retrait && t.SorteTransaction != SorteTransactions.Retrait)
                    continue;

                ListViewItem item = new ListViewItem(t.SorteTransaction.ToString());
                item.SubItems.Add(t.NumClient);
                item.SubItems.Add(t.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                item.SubItems.Add(t.Montant.ToString());

                lsvTransactions.Items.Add(item);
            }
        }
        //------------------------------------------------------------------------------
        private void cboOpération_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherListeTransactions();
        }
    }
}
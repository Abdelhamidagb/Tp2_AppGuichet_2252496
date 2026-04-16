using System.Collections.Generic;
using System.Windows.Forms;


namespace AppGuichet
{
    public partial class FrmListeClients : Form
    {
        //---------------------------------------------------------------------------------
        private List<Client> m_clients;


        public FrmListeClients(List<Client> pClients)
        {
            InitializeComponent();

            AfficherListeClients();

            if (pClients == null)
                throw new ArgumentNullException();

            m_clients = pClients;
        }
        //---------------------------------------------------------------------------------
        public void AfficherListeClients()
        {
            lsvClients.Items.Clear();

            foreach (Client c in m_clients)
            {
                ListViewItem item = new ListViewItem(c.NumClient);
                item.SubItems.Add(c.Nom);
                item.SubItems.Add(c.Role.ToString());
                item.SubItems.Add(c.Solde.ToString());

                lsvClients.Items.Add(item);
            }

        }

        private void lsvClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
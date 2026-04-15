//using System.Collections.Generic;
//using System.Windows.Forms;

//namespace AppGuichet
//{
//    public partial class FrmListeClients : Form
//    {
//        //---------------------------------------------------------------------------------
//        private List<Client> m_colClients;

      
//        public FrmListeClients(List<Client> pColClients)
//        {
//            InitializeComponent();
//            m_colClients = pColClients;
//            AfficherListeClients();
//        }
//        //---------------------------------------------------------------------------------
//        public void AfficherListeClients()
//        {
//            lsvClients.Items.Clear();
//            foreach (Client objClient in m_colClients)
//            {
//                ListViewItem unItem = new ListViewItem(objClient.NumClient.ToString());

//                unItem.SubItems.Add(objClient.Nom);
//                unItem.SubItems.Add(objClient.SorteCompte.ToString());
//                unItem.SubItems.Add(objClient.Solde.ToString("C2"));
//                unItem.SubItems.Add(objClient.MotDePasse);
//                lsvClients.Items.Add(unItem);
//            }
//        }
//    }
//}
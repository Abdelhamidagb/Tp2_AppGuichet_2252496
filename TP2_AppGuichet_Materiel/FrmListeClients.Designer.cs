//namespace AppGuichet
//{
//    partial class FrmListeClients
//    {
//        /// <summary>
//        /// Variable nécessaire au concepteur.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Nettoyage des ressources utilisées.
//        /// </summary>
//        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Code généré par le Concepteur Windows Form

//        /// <summary>
//        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
//        /// le contenu de cette méthode avec l'éditeur de code.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.lsvClients = new System.Windows.Forms.ListView();
//            this.clhNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.clhNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.clhCompte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.clhSolde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.clhMotPasse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.SuspendLayout();
//            // 
//            // lsvClients
//            // 
//            this.lsvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.lsvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
//            this.clhNo,
//            this.clhNom,
//            this.clhCompte,
//            this.clhSolde,
//            this.clhMotPasse});
//            this.lsvClients.FullRowSelect = true;
//            this.lsvClients.GridLines = true;
//            this.lsvClients.HideSelection = false;
//            this.lsvClients.Location = new System.Drawing.Point(8, 12);
//            this.lsvClients.MultiSelect = false;
//            this.lsvClients.Name = "lsvClients";
//            this.lsvClients.Size = new System.Drawing.Size(431, 305);
//            this.lsvClients.TabIndex = 2;
//            this.lsvClients.UseCompatibleStateImageBehavior = false;
//            this.lsvClients.View = System.Windows.Forms.View.Details;
//            // 
//            // clhNo
//            // 
//            this.clhNo.Text = "No";
//            this.clhNo.Width = 52;
//            // 
//            // clhNom
//            // 
//            this.clhNom.Text = "Nom";
//            this.clhNom.Width = 114;
//            // 
//            // clhCompte
//            // 
//            this.clhCompte.Text = "Compte";
//            this.clhCompte.Width = 70;
//            // 
//            // clhSolde
//            // 
//            this.clhSolde.Text = "Solde";
//            this.clhSolde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
//            this.clhSolde.Width = 95;
//            // 
//            // clhMotPasse
//            // 
//            this.clhMotPasse.Text = "Mot Passe";
//            this.clhMotPasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
//            this.clhMotPasse.Width = 78;
//            // 
//            // FrmListeClients
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(447, 329);
//            this.Controls.Add(this.lsvClients);
//            this.MaximizeBox = false;
//            this.MaximumSize = new System.Drawing.Size(463, 10000);
//            this.MinimumSize = new System.Drawing.Size(463, 150);
//            this.Name = "FrmListeClients";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Liste des clients de la banque";
//            this.ResumeLayout(false);

//        }

//        #endregion

//        public System.Windows.Forms.ListView lsvClients;
//        public System.Windows.Forms.ColumnHeader clhNo;
//        public System.Windows.Forms.ColumnHeader clhNom;
//        public System.Windows.Forms.ColumnHeader clhCompte;
//        public System.Windows.Forms.ColumnHeader clhSolde;
//        public System.Windows.Forms.ColumnHeader clhMotPasse;
//    }
//}
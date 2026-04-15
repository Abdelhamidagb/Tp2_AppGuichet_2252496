//namespace AppGuichet
//{
//    partial class FrmListeTransactions
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
//            this.lsvTransactions = new System.Windows.Forms.ListView();
//            this.clhOperation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.clhNoClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.clhDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.clhMontant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.lblOpération = new System.Windows.Forms.Label();
//            this.cboOpération = new System.Windows.Forms.ComboBox();
//            this.lblNbrTransactions = new System.Windows.Forms.Label();
//            this.label1 = new System.Windows.Forms.Label();
//            this.SuspendLayout();
//            // 
//            // lsvTransactions
//            // 
//            this.lsvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//            | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.lsvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
//            this.clhOperation,
//            this.clhNoClient,
//            this.clhDate,
//            this.clhMontant});
//            this.lsvTransactions.FullRowSelect = true;
//            this.lsvTransactions.GridLines = true;
//            this.lsvTransactions.HideSelection = false;
//            this.lsvTransactions.Location = new System.Drawing.Point(8, 52);
//            this.lsvTransactions.MultiSelect = false;
//            this.lsvTransactions.Name = "lsvTransactions";
//            this.lsvTransactions.Size = new System.Drawing.Size(353, 322);
//            this.lsvTransactions.TabIndex = 1;
//            this.lsvTransactions.UseCompatibleStateImageBehavior = false;
//            this.lsvTransactions.View = System.Windows.Forms.View.Details;
//            // 
//            // clhOperation
//            // 
//            this.clhOperation.Text = "Opération";
//            this.clhOperation.Width = 80;
//            // 
//            // clhNoClient
//            // 
//            this.clhNoClient.Text = "Numéro";
//            this.clhNoClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
//            // 
//            // clhDate
//            // 
//            this.clhDate.Text = "Date";
//            this.clhDate.Width = 130;
//            // 
//            // clhMontant
//            // 
//            this.clhMontant.Text = "Montant";
//            this.clhMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
//            // 
//            // lblOpération
//            // 
//            this.lblOpération.AutoSize = true;
//            this.lblOpération.Location = new System.Drawing.Point(8, 15);
//            this.lblOpération.Name = "lblOpération";
//            this.lblOpération.Size = new System.Drawing.Size(82, 13);
//            this.lblOpération.TabIndex = 2;
//            this.lblOpération.Text = "Filtre opération :";
//            // 
//            // cboOpération
//            // 
//            this.cboOpération.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.cboOpération.FormattingEnabled = true;
//            this.cboOpération.Items.AddRange(new object[] {
//            "Toutes",
//            "Connexion/Déconnexion",
//            "Retrait"});
//            this.cboOpération.Location = new System.Drawing.Point(96, 12);
//            this.cboOpération.Name = "cboOpération";
//            this.cboOpération.Size = new System.Drawing.Size(181, 21);
//            this.cboOpération.TabIndex = 3;
//            this.cboOpération.SelectedIndexChanged += new System.EventHandler(this.cboOpération_SelectedIndexChanged);
//            // 
//            // lblNbrTransactions
//            // 
//            this.lblNbrTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.lblNbrTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblNbrTransactions.Location = new System.Drawing.Point(319, 12);
//            this.lblNbrTransactions.Name = "lblNbrTransactions";
//            this.lblNbrTransactions.Size = new System.Drawing.Size(38, 21);
//            this.lblNbrTransactions.TabIndex = 4;
//            this.lblNbrTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(288, 16);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(30, 13);
//            this.label1.TabIndex = 5;
//            this.label1.Text = "Nbr :";
//            // 
//            // FrmListeTransactions
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(369, 385);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.lblNbrTransactions);
//            this.Controls.Add(this.cboOpération);
//            this.Controls.Add(this.lblOpération);
//            this.Controls.Add(this.lsvTransactions);
//            this.MaximizeBox = false;
//            this.MaximumSize = new System.Drawing.Size(385, 10000);
//            this.MinimumSize = new System.Drawing.Size(385, 150);
//            this.Name = "FrmListeTransactions";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "Liste des transactions à ce guichet";
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        public System.Windows.Forms.ListView lsvTransactions;
//        public System.Windows.Forms.ColumnHeader clhOperation;
//        public System.Windows.Forms.ColumnHeader clhNoClient;
//        public System.Windows.Forms.ColumnHeader clhDate;
//        public System.Windows.Forms.ColumnHeader clhMontant;
//        public System.Windows.Forms.Label lblOpération;
//        public System.Windows.Forms.ComboBox cboOpération;
//        private System.Windows.Forms.Label lblNbrTransactions;
//        public System.Windows.Forms.Label label1;
//    }
//}
namespace Proiect2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricComenziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconectareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAdministrareMagazin = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProdusNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareCantitateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAdministrareUtilizatori = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricComenziToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCumparare = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIDDet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDetalii = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(12, 39);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(470, 341);
            this.dgView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem,
            this.userToolStripMenuItem,
            this.mAdministrareMagazin,
            this.mAdministrareUtilizatori,
            this.informatiiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshProduseToolStripMenuItem});
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.meniuToolStripMenuItem.Text = "Magazin";
            // 
            // refreshProduseToolStripMenuItem
            // 
            this.refreshProduseToolStripMenuItem.Name = "refreshProduseToolStripMenuItem";
            this.refreshProduseToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.refreshProduseToolStripMenuItem.Text = "Refresh produse";
            this.refreshProduseToolStripMenuItem.Click += new System.EventHandler(this.refreshProduseToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istoricComenziToolStripMenuItem,
            this.deconectareToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.userToolStripMenuItem.Text = "Utilizator";
            // 
            // istoricComenziToolStripMenuItem
            // 
            this.istoricComenziToolStripMenuItem.Name = "istoricComenziToolStripMenuItem";
            this.istoricComenziToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.istoricComenziToolStripMenuItem.Text = "Istoric comenzi";
            this.istoricComenziToolStripMenuItem.Click += new System.EventHandler(this.istoricComenziToolStripMenuItem_Click);
            // 
            // deconectareToolStripMenuItem
            // 
            this.deconectareToolStripMenuItem.Name = "deconectareToolStripMenuItem";
            this.deconectareToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deconectareToolStripMenuItem.Text = "Deconectare";
            this.deconectareToolStripMenuItem.Click += new System.EventHandler(this.deconectareToolStripMenuItem_Click);
            // 
            // mAdministrareMagazin
            // 
            this.mAdministrareMagazin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mAdministrareMagazin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mAdministrareMagazin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProdusToolStripMenuItem,
            this.stergereProdusToolStripMenuItem});
            this.mAdministrareMagazin.Name = "mAdministrareMagazin";
            this.mAdministrareMagazin.Size = new System.Drawing.Size(135, 20);
            this.mAdministrareMagazin.Text = "Administrare Magazin";
            // 
            // adaugareProdusToolStripMenuItem
            // 
            this.adaugareProdusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProdusNouToolStripMenuItem,
            this.adaugareCantitateToolStripMenuItem});
            this.adaugareProdusToolStripMenuItem.Name = "adaugareProdusToolStripMenuItem";
            this.adaugareProdusToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.adaugareProdusToolStripMenuItem.Text = "Adaugare produs";
            // 
            // adaugareProdusNouToolStripMenuItem
            // 
            this.adaugareProdusNouToolStripMenuItem.Name = "adaugareProdusNouToolStripMenuItem";
            this.adaugareProdusNouToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.adaugareProdusNouToolStripMenuItem.Text = "Adaugare produs nou";
            this.adaugareProdusNouToolStripMenuItem.Click += new System.EventHandler(this.adaugareProdusNouToolStripMenuItem_Click);
            // 
            // adaugareCantitateToolStripMenuItem
            // 
            this.adaugareCantitateToolStripMenuItem.Name = "adaugareCantitateToolStripMenuItem";
            this.adaugareCantitateToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.adaugareCantitateToolStripMenuItem.Text = "Adaugare cantitate";
            this.adaugareCantitateToolStripMenuItem.Click += new System.EventHandler(this.adaugareCantitateToolStripMenuItem_Click);
            // 
            // stergereProdusToolStripMenuItem
            // 
            this.stergereProdusToolStripMenuItem.Name = "stergereProdusToolStripMenuItem";
            this.stergereProdusToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.stergereProdusToolStripMenuItem.Text = "Stergere produs";
            this.stergereProdusToolStripMenuItem.Click += new System.EventHandler(this.stergereProdusToolStripMenuItem_Click);
            // 
            // mAdministrareUtilizatori
            // 
            this.mAdministrareUtilizatori.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mAdministrareUtilizatori.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mAdministrareUtilizatori.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereContToolStripMenuItem,
            this.istoricComenziToolStripMenuItem1});
            this.mAdministrareUtilizatori.Name = "mAdministrareUtilizatori";
            this.mAdministrareUtilizatori.Size = new System.Drawing.Size(140, 20);
            this.mAdministrareUtilizatori.Text = "Administrare Utilizatori";
            // 
            // stergereContToolStripMenuItem
            // 
            this.stergereContToolStripMenuItem.Name = "stergereContToolStripMenuItem";
            this.stergereContToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.stergereContToolStripMenuItem.Text = "Stergere cont";
            this.stergereContToolStripMenuItem.Click += new System.EventHandler(this.stergereContToolStripMenuItem_Click);
            // 
            // istoricComenziToolStripMenuItem1
            // 
            this.istoricComenziToolStripMenuItem1.Name = "istoricComenziToolStripMenuItem1";
            this.istoricComenziToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.istoricComenziToolStripMenuItem1.Text = "Istoric vanzari";
            this.istoricComenziToolStripMenuItem1.Click += new System.EventHandler(this.istoricComenziToolStripMenuItem1_Click);
            // 
            // informatiiToolStripMenuItem
            // 
            this.informatiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.informatiiToolStripMenuItem.Name = "informatiiToolStripMenuItem";
            this.informatiiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.informatiiToolStripMenuItem.Text = "Informatii";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefresh.Location = new System.Drawing.Point(559, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Reimprospatare";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCumparare
            // 
            this.btnCumparare.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCumparare.Location = new System.Drawing.Point(559, 327);
            this.btnCumparare.Name = "btnCumparare";
            this.btnCumparare.Size = new System.Drawing.Size(95, 23);
            this.btnCumparare.TabIndex = 3;
            this.btnCumparare.Text = "Cumparare";
            this.btnCumparare.UseVisualStyleBackColor = false;
            this.btnCumparare.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(520, 39);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(82, 20);
            this.lblHello.TabIndex = 4;
            this.lblHello.Text = "Welcome";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Enabled = false;
            this.lblWarning.Location = new System.Drawing.Point(519, 366);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(47, 13);
            this.lblWarning.TabIndex = 5;
            this.lblWarning.Text = "Warning";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(599, 39);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(55, 20);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "Nume";
            // 
            // txtCantitate
            // 
            this.txtCantitate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCantitate.Location = new System.Drawing.Point(574, 301);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(100, 20);
            this.txtCantitate.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtID.Location = new System.Drawing.Point(574, 275);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(550, 278);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(519, 304);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(49, 13);
            this.lblCantitate.TabIndex = 10;
            this.lblCantitate.Text = "Cantitate";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSearch.Location = new System.Drawing.Point(13, 406);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(266, 20);
            this.txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(285, 404);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Cautare";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIDDet
            // 
            this.txtIDDet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtIDDet.Location = new System.Drawing.Point(574, 144);
            this.txtIDDet.Name = "txtIDDet";
            this.txtIDDet.Size = new System.Drawing.Size(100, 20);
            this.txtIDDet.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Afisare detalii produs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Achizitionare produs";
            // 
            // btnDetalii
            // 
            this.btnDetalii.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDetalii.Location = new System.Drawing.Point(559, 170);
            this.btnDetalii.Name = "btnDetalii";
            this.btnDetalii.Size = new System.Drawing.Size(95, 23);
            this.btnDetalii.TabIndex = 18;
            this.btnDetalii.Text = "Afisare detalii";
            this.btnDetalii.UseVisualStyleBackColor = false;
            this.btnDetalii.Click += new System.EventHandler(this.btnDetalii_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(730, 446);
            this.Controls.Add(this.btnDetalii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDDet);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnCumparare);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "CNSShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricComenziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconectareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAdministrareMagazin;
        private System.Windows.Forms.ToolStripMenuItem mAdministrareUtilizatori;
        private System.Windows.Forms.ToolStripMenuItem adaugareProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricComenziToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informatiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCumparare;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.ToolStripMenuItem adaugareProdusNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareCantitateToolStripMenuItem;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIDDet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetalii;
    }
}
namespace Proiect2
{
    partial class AdaugareProdusTask
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.nuCantitate = new System.Windows.Forms.NumericUpDown();
            this.dtValabilitate = new System.Windows.Forms.DateTimePicker();
            this.dtIntrare = new System.Windows.Forms.DateTimePicker();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(103, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Adaugare";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nuCantitate
            // 
            this.nuCantitate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nuCantitate.Location = new System.Drawing.Point(103, 371);
            this.nuCantitate.Name = "nuCantitate";
            this.nuCantitate.Size = new System.Drawing.Size(120, 20);
            this.nuCantitate.TabIndex = 20;
            // 
            // dtValabilitate
            // 
            this.dtValabilitate.CalendarMonthBackground = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtValabilitate.Location = new System.Drawing.Point(65, 315);
            this.dtValabilitate.Name = "dtValabilitate";
            this.dtValabilitate.Size = new System.Drawing.Size(200, 20);
            this.dtValabilitate.TabIndex = 19;
            // 
            // dtIntrare
            // 
            this.dtIntrare.CalendarMonthBackground = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtIntrare.Location = new System.Drawing.Point(65, 256);
            this.dtIntrare.Name = "dtIntrare";
            this.dtIntrare.Size = new System.Drawing.Size(200, 20);
            this.dtIntrare.TabIndex = 18;
            // 
            // txtDescriere
            // 
            this.txtDescriere.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDescriere.Location = new System.Drawing.Point(65, 158);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(200, 62);
            this.txtDescriere.TabIndex = 17;
            // 
            // txtDenumire
            // 
            this.txtDenumire.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDenumire.Location = new System.Drawing.Point(65, 94);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(200, 20);
            this.txtDenumire.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantitate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data valabilitate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data intrare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descriere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Denumire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adaugare Produs";
            // 
            // AdaugareProdusTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(326, 524);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nuCantitate);
            this.Controls.Add(this.dtValabilitate);
            this.Controls.Add(this.dtIntrare);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AdaugareProdusTask";
            this.Text = "AdaugareProdus";
            ((System.ComponentModel.ISupportInitialize)(this.nuCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nuCantitate;
        private System.Windows.Forms.DateTimePicker dtValabilitate;
        private System.Windows.Forms.DateTimePicker dtIntrare;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}
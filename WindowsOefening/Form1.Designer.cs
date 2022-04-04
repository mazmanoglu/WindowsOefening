namespace WindowsOefening
{
    partial class Form1
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
            this.lstReaders = new System.Windows.Forms.ListBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblLeeftijd = new System.Windows.Forms.Label();
            this.lblHoofdDeksel = new System.Windows.Forms.Label();
            this.lblTijdScrijft = new System.Windows.Forms.Label();
            this.lblKleur = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHat = new System.Windows.Forms.Label();
            this.lblMagColor = new System.Windows.Forms.Label();
            this.lblCountHoofdDeksel = new System.Windows.Forms.Label();
            this.lblCountsKleurTijdschrift = new System.Windows.Forms.Label();
            this.cmbHats = new System.Windows.Forms.ComboBox();
            this.cmbMagazineColors = new System.Windows.Forms.ComboBox();
            this.lblBeide = new System.Windows.Forms.Label();
            this.lblHatCount = new System.Windows.Forms.Label();
            this.lblMagazineColorCount = new System.Windows.Forms.Label();
            this.lblBothCount = new System.Windows.Forms.Label();
            this.lblLezerToevoegen = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.grbSelectReader = new System.Windows.Forms.GroupBox();
            this.grbCounts = new System.Windows.Forms.GroupBox();
            this.grbAddReader = new System.Windows.Forms.GroupBox();
            this.grbSelectReader.SuspendLayout();
            this.grbCounts.SuspendLayout();
            this.grbAddReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstReaders
            // 
            this.lstReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReaders.FormattingEnabled = true;
            this.lstReaders.ItemHeight = 25;
            this.lstReaders.Location = new System.Drawing.Point(17, 27);
            this.lstReaders.Name = "lstReaders";
            this.lstReaders.Size = new System.Drawing.Size(125, 179);
            this.lstReaders.TabIndex = 1;
            this.lstReaders.SelectedIndexChanged += new System.EventHandler(this.lstReaders_SelectedIndexChanged);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.Location = new System.Drawing.Point(182, 26);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(72, 18);
            this.lblPerson.TabIndex = 2;
            this.lblPerson.Text = "Person :";
            // 
            // lblLeeftijd
            // 
            this.lblLeeftijd.AutoSize = true;
            this.lblLeeftijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeeftijd.Location = new System.Drawing.Point(182, 62);
            this.lblLeeftijd.Name = "lblLeeftijd";
            this.lblLeeftijd.Size = new System.Drawing.Size(62, 18);
            this.lblLeeftijd.TabIndex = 3;
            this.lblLeeftijd.Text = "Leeftijd :";
            // 
            // lblHoofdDeksel
            // 
            this.lblHoofdDeksel.AutoSize = true;
            this.lblHoofdDeksel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoofdDeksel.Location = new System.Drawing.Point(182, 94);
            this.lblHoofdDeksel.Name = "lblHoofdDeksel";
            this.lblHoofdDeksel.Size = new System.Drawing.Size(103, 18);
            this.lblHoofdDeksel.TabIndex = 4;
            this.lblHoofdDeksel.Text = "HoofdDeksel :";
            // 
            // lblTijdScrijft
            // 
            this.lblTijdScrijft.AutoSize = true;
            this.lblTijdScrijft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijdScrijft.Location = new System.Drawing.Point(182, 134);
            this.lblTijdScrijft.Name = "lblTijdScrijft";
            this.lblTijdScrijft.Size = new System.Drawing.Size(94, 18);
            this.lblTijdScrijft.TabIndex = 5;
            this.lblTijdScrijft.Text = "TijdSchrift :";
            // 
            // lblKleur
            // 
            this.lblKleur.AutoSize = true;
            this.lblKleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKleur.Location = new System.Drawing.Point(182, 164);
            this.lblKleur.Name = "lblKleur";
            this.lblKleur.Size = new System.Drawing.Size(50, 18);
            this.lblKleur.TabIndex = 6;
            this.lblKleur.Text = "Kleur :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblAge.Location = new System.Drawing.Point(318, 62);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 18);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age";
            // 
            // lblHat
            // 
            this.lblHat.AutoSize = true;
            this.lblHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblHat.Location = new System.Drawing.Point(318, 94);
            this.lblHat.Name = "lblHat";
            this.lblHat.Size = new System.Drawing.Size(31, 18);
            this.lblHat.TabIndex = 8;
            this.lblHat.Text = "Hat";
            // 
            // lblMagColor
            // 
            this.lblMagColor.AutoSize = true;
            this.lblMagColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagColor.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMagColor.Location = new System.Drawing.Point(318, 164);
            this.lblMagColor.Name = "lblMagColor";
            this.lblMagColor.Size = new System.Drawing.Size(45, 18);
            this.lblMagColor.TabIndex = 9;
            this.lblMagColor.Text = "Color";
            // 
            // lblCountHoofdDeksel
            // 
            this.lblCountHoofdDeksel.AutoSize = true;
            this.lblCountHoofdDeksel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountHoofdDeksel.Location = new System.Drawing.Point(29, 35);
            this.lblCountHoofdDeksel.Name = "lblCountHoofdDeksel";
            this.lblCountHoofdDeksel.Size = new System.Drawing.Size(100, 18);
            this.lblCountHoofdDeksel.TabIndex = 11;
            this.lblCountHoofdDeksel.Text = "Hoofddeksel :";
            // 
            // lblCountsKleurTijdschrift
            // 
            this.lblCountsKleurTijdschrift.AutoSize = true;
            this.lblCountsKleurTijdschrift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountsKleurTijdschrift.Location = new System.Drawing.Point(29, 66);
            this.lblCountsKleurTijdschrift.Name = "lblCountsKleurTijdschrift";
            this.lblCountsKleurTijdschrift.Size = new System.Drawing.Size(117, 18);
            this.lblCountsKleurTijdschrift.TabIndex = 12;
            this.lblCountsKleurTijdschrift.Text = "Kleur Tijdschrift :";
            // 
            // cmbHats
            // 
            this.cmbHats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHats.FormattingEnabled = true;
            this.cmbHats.Location = new System.Drawing.Point(181, 27);
            this.cmbHats.Name = "cmbHats";
            this.cmbHats.Size = new System.Drawing.Size(161, 26);
            this.cmbHats.TabIndex = 13;
            this.cmbHats.SelectedIndexChanged += new System.EventHandler(this.cmbHats_SelectedIndexChanged);
            // 
            // cmbMagazineColors
            // 
            this.cmbMagazineColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMagazineColors.FormattingEnabled = true;
            this.cmbMagazineColors.Location = new System.Drawing.Point(181, 60);
            this.cmbMagazineColors.Name = "cmbMagazineColors";
            this.cmbMagazineColors.Size = new System.Drawing.Size(161, 26);
            this.cmbMagazineColors.TabIndex = 14;
            this.cmbMagazineColors.SelectedIndexChanged += new System.EventHandler(this.cmbMagazineColors_SelectedIndexChanged);
            // 
            // lblBeide
            // 
            this.lblBeide.AutoSize = true;
            this.lblBeide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeide.Location = new System.Drawing.Point(178, 100);
            this.lblBeide.Name = "lblBeide";
            this.lblBeide.Size = new System.Drawing.Size(53, 18);
            this.lblBeide.TabIndex = 15;
            this.lblBeide.Text = "Beide :";
            // 
            // lblHatCount
            // 
            this.lblHatCount.AutoSize = true;
            this.lblHatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHatCount.Location = new System.Drawing.Point(487, 35);
            this.lblHatCount.Name = "lblHatCount";
            this.lblHatCount.Size = new System.Drawing.Size(31, 18);
            this.lblHatCount.TabIndex = 16;
            this.lblHatCount.Text = "Hat";
            // 
            // lblMagazineColorCount
            // 
            this.lblMagazineColorCount.AutoSize = true;
            this.lblMagazineColorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazineColorCount.Location = new System.Drawing.Point(487, 66);
            this.lblMagazineColorCount.Name = "lblMagazineColorCount";
            this.lblMagazineColorCount.Size = new System.Drawing.Size(37, 18);
            this.lblMagazineColorCount.TabIndex = 17;
            this.lblMagazineColorCount.Text = "Mag";
            // 
            // lblBothCount
            // 
            this.lblBothCount.AutoSize = true;
            this.lblBothCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBothCount.Location = new System.Drawing.Point(487, 100);
            this.lblBothCount.Name = "lblBothCount";
            this.lblBothCount.Size = new System.Drawing.Size(39, 18);
            this.lblBothCount.TabIndex = 18;
            this.lblBothCount.Text = "Both";
            // 
            // lblLezerToevoegen
            // 
            this.lblLezerToevoegen.AutoSize = true;
            this.lblLezerToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLezerToevoegen.Location = new System.Drawing.Point(29, 52);
            this.lblLezerToevoegen.Name = "lblLezerToevoegen";
            this.lblLezerToevoegen.Size = new System.Drawing.Size(131, 18);
            this.lblLezerToevoegen.TabIndex = 20;
            this.lblLezerToevoegen.Text = "Lezer Toevoegen :";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(178, 47);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(161, 24);
            this.txtAmount.TabIndex = 21;
            // 
            // btnAddReader
            // 
            this.btnAddReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReader.Location = new System.Drawing.Point(400, 47);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(84, 26);
            this.btnAddReader.TabIndex = 22;
            this.btnAddReader.Text = "Add";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // grbSelectReader
            // 
            this.grbSelectReader.Controls.Add(this.lblMagColor);
            this.grbSelectReader.Controls.Add(this.lblHat);
            this.grbSelectReader.Controls.Add(this.lblAge);
            this.grbSelectReader.Controls.Add(this.lblKleur);
            this.grbSelectReader.Controls.Add(this.lblTijdScrijft);
            this.grbSelectReader.Controls.Add(this.lblHoofdDeksel);
            this.grbSelectReader.Controls.Add(this.lblLeeftijd);
            this.grbSelectReader.Controls.Add(this.lblPerson);
            this.grbSelectReader.Controls.Add(this.lstReaders);
            this.grbSelectReader.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbSelectReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSelectReader.Location = new System.Drawing.Point(27, 27);
            this.grbSelectReader.Name = "grbSelectReader";
            this.grbSelectReader.Size = new System.Drawing.Size(669, 233);
            this.grbSelectReader.TabIndex = 23;
            this.grbSelectReader.TabStop = false;
            this.grbSelectReader.Text = "Select Reader";
            // 
            // grbCounts
            // 
            this.grbCounts.Controls.Add(this.lblBothCount);
            this.grbCounts.Controls.Add(this.lblMagazineColorCount);
            this.grbCounts.Controls.Add(this.lblHatCount);
            this.grbCounts.Controls.Add(this.lblBeide);
            this.grbCounts.Controls.Add(this.cmbMagazineColors);
            this.grbCounts.Controls.Add(this.cmbHats);
            this.grbCounts.Controls.Add(this.lblCountsKleurTijdschrift);
            this.grbCounts.Controls.Add(this.lblCountHoofdDeksel);
            this.grbCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCounts.Location = new System.Drawing.Point(27, 282);
            this.grbCounts.Name = "grbCounts";
            this.grbCounts.Size = new System.Drawing.Size(669, 153);
            this.grbCounts.TabIndex = 24;
            this.grbCounts.TabStop = false;
            this.grbCounts.Text = "Counts";
            // 
            // grbAddReader
            // 
            this.grbAddReader.Controls.Add(this.btnAddReader);
            this.grbAddReader.Controls.Add(this.txtAmount);
            this.grbAddReader.Controls.Add(this.lblLezerToevoegen);
            this.grbAddReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddReader.Location = new System.Drawing.Point(27, 458);
            this.grbAddReader.Name = "grbAddReader";
            this.grbAddReader.Size = new System.Drawing.Size(669, 115);
            this.grbAddReader.TabIndex = 25;
            this.grbAddReader.TabStop = false;
            this.grbAddReader.Text = "Add Reader(s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(734, 591);
            this.Controls.Add(this.grbAddReader);
            this.Controls.Add(this.grbCounts);
            this.Controls.Add(this.grbSelectReader);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSelectReader.ResumeLayout(false);
            this.grbSelectReader.PerformLayout();
            this.grbCounts.ResumeLayout(false);
            this.grbCounts.PerformLayout();
            this.grbAddReader.ResumeLayout(false);
            this.grbAddReader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstReaders;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblLeeftijd;
        private System.Windows.Forms.Label lblHoofdDeksel;
        private System.Windows.Forms.Label lblTijdScrijft;
        private System.Windows.Forms.Label lblKleur;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHat;
        private System.Windows.Forms.Label lblMagColor;
        private System.Windows.Forms.Label lblCountHoofdDeksel;
        private System.Windows.Forms.Label lblCountsKleurTijdschrift;
        private System.Windows.Forms.ComboBox cmbHats;
        private System.Windows.Forms.ComboBox cmbMagazineColors;
        private System.Windows.Forms.Label lblBeide;
        private System.Windows.Forms.Label lblHatCount;
        private System.Windows.Forms.Label lblMagazineColorCount;
        private System.Windows.Forms.Label lblBothCount;
        private System.Windows.Forms.Label lblLezerToevoegen;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.GroupBox grbSelectReader;
        private System.Windows.Forms.GroupBox grbCounts;
        private System.Windows.Forms.GroupBox grbAddReader;
    }
}


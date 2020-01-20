namespace ExercicesWinForms
{
    partial class ex5
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.dataGridViewPersonnes = new System.Windows.Forms.DataGridView();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateRow = new System.Windows.Forms.Button();
            this.textBoxLastnameRead = new System.Windows.Forms.TextBox();
            this.textBoxFirstnameRead = new System.Windows.Forms.TextBox();
            this.textBoxBirthdateRead = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(13, 13);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(127, 50);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Retour au menu";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dataGridViewPersonnes
            // 
            this.dataGridViewPersonnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.prenom,
            this.dateNaissance});
            this.dataGridViewPersonnes.Location = new System.Drawing.Point(39, 108);
            this.dataGridViewPersonnes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPersonnes.Name = "dataGridViewPersonnes";
            this.dataGridViewPersonnes.ReadOnly = true;
            this.dataGridViewPersonnes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonnes.Size = new System.Drawing.Size(373, 199);
            this.dataGridViewPersonnes.TabIndex = 6;
            this.dataGridViewPersonnes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonnes_CellContentClick);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(494, 143);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(271, 20);
            this.textBoxLastname.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // dateNaissance
            // 
            this.dateNaissance.HeaderText = "Date de Daissance";
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.ReadOnly = true;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Location = new System.Drawing.Point(494, 194);
            this.textBoxFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(271, 20);
            this.textBoxFirstname.TabIndex = 8;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(494, 245);
            this.textBoxBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(271, 20);
            this.textBoxBirthday.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date de Naissance :";
            // 
            // btnCreateRow
            // 
            this.btnCreateRow.Location = new System.Drawing.Point(494, 296);
            this.btnCreateRow.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateRow.Name = "btnCreateRow";
            this.btnCreateRow.Size = new System.Drawing.Size(271, 28);
            this.btnCreateRow.TabIndex = 13;
            this.btnCreateRow.Text = "Créer";
            this.btnCreateRow.UseVisualStyleBackColor = true;
            this.btnCreateRow.Click += new System.EventHandler(this.btnCreateRow_Click);
            // 
            // textBoxLastnameRead
            // 
            this.textBoxLastnameRead.Location = new System.Drawing.Point(117, 332);
            this.textBoxLastnameRead.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastnameRead.Name = "textBoxLastnameRead";
            this.textBoxLastnameRead.ReadOnly = true;
            this.textBoxLastnameRead.Size = new System.Drawing.Size(190, 20);
            this.textBoxLastnameRead.TabIndex = 14;
            // 
            // textBoxFirstnameRead
            // 
            this.textBoxFirstnameRead.Location = new System.Drawing.Point(117, 374);
            this.textBoxFirstnameRead.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstnameRead.Name = "textBoxFirstnameRead";
            this.textBoxFirstnameRead.ReadOnly = true;
            this.textBoxFirstnameRead.Size = new System.Drawing.Size(190, 20);
            this.textBoxFirstnameRead.TabIndex = 15;
            // 
            // textBoxBirthdateRead
            // 
            this.textBoxBirthdateRead.Location = new System.Drawing.Point(117, 415);
            this.textBoxBirthdateRead.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBirthdateRead.Name = "textBoxBirthdateRead";
            this.textBoxBirthdateRead.ReadOnly = true;
            this.textBoxBirthdateRead.Size = new System.Drawing.Size(190, 20);
            this.textBoxBirthdateRead.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prénom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date de Naissance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Entrez vos données :";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(377, 66);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 21;
            this.labelCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nombre de Personnes : ";
            // 
            // ex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBirthdateRead);
            this.Controls.Add(this.textBoxFirstnameRead);
            this.Controls.Add(this.textBoxLastnameRead);
            this.Controls.Add(this.btnCreateRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.dataGridViewPersonnes);
            this.Controls.Add(this.exitBtn);
            this.Name = "ex5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView dataGridViewPersonnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissance;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateRow;
        private System.Windows.Forms.TextBox textBoxLastnameRead;
        private System.Windows.Forms.TextBox textBoxFirstnameRead;
        private System.Windows.Forms.TextBox textBoxBirthdateRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label8;
    }
}
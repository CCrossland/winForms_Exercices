namespace ExercicesWinForms
{
    partial class ex4
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
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAdded = new System.Windows.Forms.Label();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
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
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(278, 216);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(13, 13);
            this.labelCount.TabIndex = 17;
            this.labelCount.Text = "0";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(138, 248);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(219, 28);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAdded
            // 
            this.labelAdded.AutoSize = true;
            this.labelAdded.Location = new System.Drawing.Point(134, 216);
            this.labelAdded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdded.Name = "labelAdded";
            this.labelAdded.Size = new System.Drawing.Size(87, 13);
            this.labelAdded.TabIndex = 15;
            this.labelAdded.Text = "Marque ajoutée :";
            // 
            // textBoxCar
            // 
            this.textBoxCar.Location = new System.Drawing.Point(138, 175);
            this.textBoxCar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(217, 20);
            this.textBoxCar.TabIndex = 14;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(430, 248);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(276, 28);
            this.buttonSelect.TabIndex = 19;
            this.buttonSelect.Text = "Sélectionner";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Visible = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.DisplayMember = "Marquevoiture.label";
            this.comboBoxCars.FormattingEnabled = true;
            this.comboBoxCars.Location = new System.Drawing.Point(430, 175);
            this.comboBoxCars.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCars.Name = "comboBoxCars";
            this.comboBoxCars.Size = new System.Drawing.Size(275, 21);
            this.comboBoxCars.TabIndex = 18;
            this.comboBoxCars.ValueMember = "Marquevoiture.id";
            this.comboBoxCars.Visible = false;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(135, 158);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(162, 13);
            this.labelAdd.TabIndex = 20;
            this.labelAdd.Text = "Ajouter cinq marques de voiture :";
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(427, 158);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(181, 13);
            this.labelSelect.TabIndex = 21;
            this.labelSelect.Text = "Sélectionner une marque de voiture :";
            this.labelSelect.Visible = false;
            // 
            // ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.comboBoxCars);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAdded);
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.exitBtn);
            this.Name = "ex4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAdded;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ComboBox comboBoxCars;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelSelect;
    }
}
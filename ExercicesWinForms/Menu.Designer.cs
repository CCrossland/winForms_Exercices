namespace ExercicesWinForms
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lien_ex1 = new System.Windows.Forms.Button();
            this.lien_ex2 = new System.Windows.Forms.Button();
            this.lien_ex3 = new System.Windows.Forms.Button();
            this.lien_ex4 = new System.Windows.Forms.Button();
            this.lien_ex5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lien_ex1
            // 
            this.lien_ex1.Location = new System.Drawing.Point(294, 72);
            this.lien_ex1.Name = "lien_ex1";
            this.lien_ex1.Size = new System.Drawing.Size(229, 43);
            this.lien_ex1.TabIndex = 0;
            this.lien_ex1.Text = "Exercice 1";
            this.lien_ex1.UseVisualStyleBackColor = true;
            this.lien_ex1.Click += new System.EventHandler(this.lien_ex1_Click);
            // 
            // lien_ex2
            // 
            this.lien_ex2.Location = new System.Drawing.Point(294, 142);
            this.lien_ex2.Name = "lien_ex2";
            this.lien_ex2.Size = new System.Drawing.Size(229, 43);
            this.lien_ex2.TabIndex = 1;
            this.lien_ex2.Text = "Exercice 2";
            this.lien_ex2.UseVisualStyleBackColor = true;
            this.lien_ex2.Click += new System.EventHandler(this.lien_ex2_Click);
            // 
            // lien_ex3
            // 
            this.lien_ex3.Location = new System.Drawing.Point(294, 209);
            this.lien_ex3.Name = "lien_ex3";
            this.lien_ex3.Size = new System.Drawing.Size(229, 43);
            this.lien_ex3.TabIndex = 2;
            this.lien_ex3.Text = "Exercice 3";
            this.lien_ex3.UseVisualStyleBackColor = true;
            this.lien_ex3.Click += new System.EventHandler(this.lien_ex3_Click);
            // 
            // lien_ex4
            // 
            this.lien_ex4.Location = new System.Drawing.Point(294, 273);
            this.lien_ex4.Name = "lien_ex4";
            this.lien_ex4.Size = new System.Drawing.Size(229, 43);
            this.lien_ex4.TabIndex = 3;
            this.lien_ex4.Text = "Exercice 4";
            this.lien_ex4.UseVisualStyleBackColor = true;
            this.lien_ex4.Click += new System.EventHandler(this.lien_ex4_Click);
            // 
            // lien_ex5
            // 
            this.lien_ex5.Location = new System.Drawing.Point(294, 337);
            this.lien_ex5.Name = "lien_ex5";
            this.lien_ex5.Size = new System.Drawing.Size(229, 43);
            this.lien_ex5.TabIndex = 4;
            this.lien_ex5.Text = "Exercice 5";
            this.lien_ex5.UseVisualStyleBackColor = true;
            this.lien_ex5.Click += new System.EventHandler(this.lien_ex5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lien_ex5);
            this.Controls.Add(this.lien_ex4);
            this.Controls.Add(this.lien_ex3);
            this.Controls.Add(this.lien_ex2);
            this.Controls.Add(this.lien_ex1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu des Exercices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lien_ex1;
        private System.Windows.Forms.Button lien_ex2;
        private System.Windows.Forms.Button lien_ex3;
        private System.Windows.Forms.Button lien_ex4;
        private System.Windows.Forms.Button lien_ex5;
    }
}


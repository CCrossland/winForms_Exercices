namespace ExercicesWinForms
{
    partial class ex1
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
            this.Valider = new System.Windows.Forms.Button();
            this.Féminin = new System.Windows.Forms.RadioButton();
            this.Masculin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(13, 13);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(127, 50);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Retour au menu";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(267, 244);
            this.Valider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(173, 62);
            this.Valider.TabIndex = 7;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Féminin
            // 
            this.Féminin.AutoSize = true;
            this.Féminin.Location = new System.Drawing.Point(379, 182);
            this.Féminin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Féminin.Name = "Féminin";
            this.Féminin.Size = new System.Drawing.Size(61, 17);
            this.Féminin.TabIndex = 6;
            this.Féminin.Text = "Féminin";
            this.Féminin.UseVisualStyleBackColor = true;
            // 
            // Masculin
            // 
            this.Masculin.AutoSize = true;
            this.Masculin.Location = new System.Drawing.Point(267, 182);
            this.Masculin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Masculin.Name = "Masculin";
            this.Masculin.Size = new System.Drawing.Size(67, 17);
            this.Masculin.TabIndex = 5;
            this.Masculin.Text = "Masculin";
            this.Masculin.UseVisualStyleBackColor = true;
            // 
            // ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Féminin);
            this.Controls.Add(this.Masculin);
            this.Controls.Add(this.exitBtn);
            this.Name = "ex1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.RadioButton Féminin;
        private System.Windows.Forms.RadioButton Masculin;
    }
}
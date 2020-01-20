namespace ExercicesWinForms
{
    partial class ex3
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInverseCheck = new System.Windows.Forms.Button();
            this.buttonUncheckAll = new System.Windows.Forms.Button();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxColor = new System.Windows.Forms.CheckedListBox();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Compteur";
            // 
            // buttonInverseCheck
            // 
            this.buttonInverseCheck.Location = new System.Drawing.Point(293, 382);
            this.buttonInverseCheck.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInverseCheck.Name = "buttonInverseCheck";
            this.buttonInverseCheck.Size = new System.Drawing.Size(129, 30);
            this.buttonInverseCheck.TabIndex = 11;
            this.buttonInverseCheck.Text = "Inverser les choix";
            this.buttonInverseCheck.UseVisualStyleBackColor = true;
            this.buttonInverseCheck.Click += new System.EventHandler(this.buttonInverseCheck_Click);
            // 
            // buttonUncheckAll
            // 
            this.buttonUncheckAll.Location = new System.Drawing.Point(293, 346);
            this.buttonUncheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.buttonUncheckAll.Size = new System.Drawing.Size(129, 28);
            this.buttonUncheckAll.TabIndex = 10;
            this.buttonUncheckAll.Text = "Tout décocher";
            this.buttonUncheckAll.UseVisualStyleBackColor = true;
            this.buttonUncheckAll.Click += new System.EventHandler(this.buttonUncheckAll_Click);
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Location = new System.Drawing.Point(293, 309);
            this.buttonCheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(129, 28);
            this.buttonCheckAll.TabIndex = 9;
            this.buttonCheckAll.Text = "Tout cocher";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // checkedListBoxColor
            // 
            this.checkedListBoxColor.FormattingEnabled = true;
            this.checkedListBoxColor.Items.AddRange(new object[] {
            "Bleu",
            "Rouge",
            "Vert",
            "Noir",
            "Blanc",
            "Jaune",
            "Brun",
            "Mauve",
            "Orange",
            "Rose"});
            this.checkedListBoxColor.Location = new System.Drawing.Point(293, 75);
            this.checkedListBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxColor.Name = "checkedListBoxColor";
            this.checkedListBoxColor.Size = new System.Drawing.Size(128, 169);
            this.checkedListBoxColor.TabIndex = 7;
            this.checkedListBoxColor.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxColor_SelectedIndexChanged);
            // 
            // ex3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonInverseCheck);
            this.Controls.Add(this.buttonUncheckAll);
            this.Controls.Add(this.buttonCheckAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxColor);
            this.Controls.Add(this.exitBtn);
            this.Name = "ex3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInverseCheck;
        private System.Windows.Forms.Button buttonUncheckAll;
        private System.Windows.Forms.Button buttonCheckAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxColor;
    }
}
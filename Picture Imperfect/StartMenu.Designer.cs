namespace Picture_Imperfect
{
    partial class StartMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStartInfo = new System.Windows.Forms.Label();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelInstruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStartInfo
            // 
            this.labelStartInfo.AutoSize = true;
            this.labelStartInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelStartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartInfo.Location = new System.Drawing.Point(16, 574);
            this.labelStartInfo.Name = "labelStartInfo";
            this.labelStartInfo.Size = new System.Drawing.Size(85, 29);
            this.labelStartInfo.TabIndex = 3;
            this.labelStartInfo.Text = "label1";
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer1.Image = global::Picture_Imperfect.Properties.Resources.Readybutton;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(39, 241);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(124, 118);
            this.pictureBoxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer1.TabIndex = 4;
            this.pictureBoxPlayer1.TabStop = false;
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer2.Image = global::Picture_Imperfect.Properties.Resources.Readybutton;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(243, 241);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(124, 118);
            this.pictureBoxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer2.TabIndex = 5;
            this.pictureBoxPlayer2.TabStop = false;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.ForeColor = System.Drawing.Color.Gold;
            this.labelPlayer1.Location = new System.Drawing.Point(34, 213);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(133, 29);
            this.labelPlayer1.TabIndex = 6;
            this.labelPlayer1.Text = "PLAYER 1";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.ForeColor = System.Drawing.Color.Gold;
            this.labelPlayer2.Location = new System.Drawing.Point(238, 213);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(133, 29);
            this.labelPlayer2.TabIndex = 7;
            this.labelPlayer2.Text = "PLAYER 2";
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.BackColor = System.Drawing.Color.Transparent;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstruction.ForeColor = System.Drawing.Color.Gold;
            this.labelInstruction.Location = new System.Drawing.Point(44, 392);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(211, 29);
            this.labelInstruction.TabIndex = 8;
            this.labelInstruction.Text = "PRESS YELLOW";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::Picture_Imperfect.Properties.Resources.StartMenu;
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.labelStartInfo);
            this.Name = "StartMenu";
            this.Size = new System.Drawing.Size(800, 750);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.StartMenu_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStartInfo;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelInstruction;
    }
}

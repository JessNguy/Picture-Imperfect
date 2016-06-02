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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonControls = new System.Windows.Forms.Button();
            this.buttonGameRule = new System.Windows.Forms.Button();
            this.labelStartInfo = new System.Windows.Forms.Label();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(554, 498);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(229, 56);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonControls
            // 
            this.buttonControls.BackColor = System.Drawing.Color.Transparent;
            this.buttonControls.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonControls.FlatAppearance.BorderSize = 0;
            this.buttonControls.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonControls.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonControls.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonControls.Location = new System.Drawing.Point(243, 498);
            this.buttonControls.Name = "buttonControls";
            this.buttonControls.Size = new System.Drawing.Size(231, 56);
            this.buttonControls.TabIndex = 1;
            this.buttonControls.UseVisualStyleBackColor = false;
            // 
            // buttonGameRule
            // 
            this.buttonGameRule.BackColor = System.Drawing.Color.Transparent;
            this.buttonGameRule.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonGameRule.FlatAppearance.BorderSize = 0;
            this.buttonGameRule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.buttonGameRule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonGameRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGameRule.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGameRule.Location = new System.Drawing.Point(3, 498);
            this.buttonGameRule.Name = "buttonGameRule";
            this.buttonGameRule.Size = new System.Drawing.Size(234, 56);
            this.buttonGameRule.TabIndex = 2;
            this.buttonGameRule.UseVisualStyleBackColor = false;
            // 
            // labelStartInfo
            // 
            this.labelStartInfo.AutoSize = true;
            this.labelStartInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelStartInfo.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartInfo.Location = new System.Drawing.Point(16, 574);
            this.labelStartInfo.Name = "labelStartInfo";
            this.labelStartInfo.Size = new System.Drawing.Size(86, 33);
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
            this.labelPlayer1.Font = new System.Drawing.Font("OCR A Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.ForeColor = System.Drawing.Color.Gold;
            this.labelPlayer1.Location = new System.Drawing.Point(34, 213);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(156, 25);
            this.labelPlayer1.TabIndex = 6;
            this.labelPlayer1.Text = "PLAYER 1";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2.Font = new System.Drawing.Font("OCR A Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.ForeColor = System.Drawing.Color.Gold;
            this.labelPlayer2.Location = new System.Drawing.Point(238, 213);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(156, 25);
            this.labelPlayer2.TabIndex = 7;
            this.labelPlayer2.Text = "PLAYER 2";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::Picture_Imperfect.Properties.Resources.StartMenu;
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.labelStartInfo);
            this.Controls.Add(this.buttonGameRule);
            this.Controls.Add(this.buttonControls);
            this.Controls.Add(this.buttonStart);
            this.Name = "StartMenu";
            this.Size = new System.Drawing.Size(800, 750);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartMenu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonControls;
        private System.Windows.Forms.Button buttonGameRule;
        private System.Windows.Forms.Label labelStartInfo;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
    }
}

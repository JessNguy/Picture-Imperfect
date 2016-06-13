namespace Picture_Imperfect
{
    partial class CopyScreen
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
            this.pictureBoxMouth = new System.Windows.Forms.PictureBox();
            this.pictureBoxHead = new System.Windows.Forms.PictureBox();
            this.pictureBoxSymbol = new System.Windows.Forms.PictureBox();
            this.pictureBoxShirt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShirt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMouth
            // 
            this.pictureBoxMouth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMouth.Image = global::Picture_Imperfect.Properties.Resources.Strip_2;
            this.pictureBoxMouth.Location = new System.Drawing.Point(13, 237);
            this.pictureBoxMouth.Name = "pictureBoxMouth";
            this.pictureBoxMouth.Size = new System.Drawing.Size(800, 148);
            this.pictureBoxMouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMouth.TabIndex = 1;
            this.pictureBoxMouth.TabStop = false;
            // 
            // pictureBoxHead
            // 
            this.pictureBoxHead.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHead.Image = global::Picture_Imperfect.Properties.Resources.Strip_1;
            this.pictureBoxHead.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxHead.Name = "pictureBoxHead";
            this.pictureBoxHead.Size = new System.Drawing.Size(800, 228);
            this.pictureBoxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHead.TabIndex = 0;
            this.pictureBoxHead.TabStop = false;
            // 
            // pictureBoxSymbol
            // 
            this.pictureBoxSymbol.Image = global::Picture_Imperfect.Properties.Resources.Strip_4;
            this.pictureBoxSymbol.Location = new System.Drawing.Point(25, 664);
            this.pictureBoxSymbol.Name = "pictureBoxSymbol";
            this.pictureBoxSymbol.Size = new System.Drawing.Size(800, 267);
            this.pictureBoxSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSymbol.TabIndex = 3;
            this.pictureBoxSymbol.TabStop = false;
            // 
            // pictureBoxShirt
            // 
            this.pictureBoxShirt.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShirt.Image = global::Picture_Imperfect.Properties.Resources.Strip_3;
            this.pictureBoxShirt.Location = new System.Drawing.Point(13, 391);
            this.pictureBoxShirt.Name = "pictureBoxShirt";
            this.pictureBoxShirt.Size = new System.Drawing.Size(800, 267);
            this.pictureBoxShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShirt.TabIndex = 2;
            this.pictureBoxShirt.TabStop = false;
            // 
            // CopyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxMouth);
            this.Controls.Add(this.pictureBoxHead);
            this.Controls.Add(this.pictureBoxSymbol);
            this.Controls.Add(this.pictureBoxShirt);
            this.Name = "CopyScreen";
            this.Size = new System.Drawing.Size(800, 750);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShirt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHead;
        private System.Windows.Forms.PictureBox pictureBoxMouth;
        private System.Windows.Forms.PictureBox pictureBoxShirt;
        private System.Windows.Forms.PictureBox pictureBoxSymbol;
    }
}

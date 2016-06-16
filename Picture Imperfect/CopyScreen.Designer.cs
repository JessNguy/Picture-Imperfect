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
            this.pictureBoxSymbol = new System.Windows.Forms.PictureBox();
            this.pictureBoxHead = new System.Windows.Forms.PictureBox();
            this.pictureBoxShirt = new System.Windows.Forms.PictureBox();
            this.pictureBoxMouth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSymbol
            // 
            this.pictureBoxSymbol.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSymbol.Image = global::Picture_Imperfect.Properties.Resources.Symbol_Size;
            this.pictureBoxSymbol.Location = new System.Drawing.Point(-3, 443);
            this.pictureBoxSymbol.Name = "pictureBoxSymbol";
            this.pictureBoxSymbol.Size = new System.Drawing.Size(800, 750);
            this.pictureBoxSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSymbol.TabIndex = 3;
            this.pictureBoxSymbol.TabStop = false;
            this.pictureBoxSymbol.Visible = false;
            this.pictureBoxSymbol.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSymbol_Paint);
            // 
            // pictureBoxHead
            // 
            this.pictureBoxHead.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHead.Image = global::Picture_Imperfect.Properties.Resources.SHead_Size;
            this.pictureBoxHead.Location = new System.Drawing.Point(-3, 3);
            this.pictureBoxHead.Name = "pictureBoxHead";
            this.pictureBoxHead.Size = new System.Drawing.Size(800, 750);
            this.pictureBoxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHead.TabIndex = 0;
            this.pictureBoxHead.TabStop = false;
            this.pictureBoxHead.Visible = false;
            // 
            // pictureBoxShirt
            // 
            this.pictureBoxShirt.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShirt.Image = global::Picture_Imperfect.Properties.Resources.S_Shirt_size;
            this.pictureBoxShirt.Location = new System.Drawing.Point(-3, 408);
            this.pictureBoxShirt.Name = "pictureBoxShirt";
            this.pictureBoxShirt.Size = new System.Drawing.Size(800, 750);
            this.pictureBoxShirt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShirt.TabIndex = 2;
            this.pictureBoxShirt.TabStop = false;
            this.pictureBoxShirt.Visible = false;
            // 
            // pictureBoxMouth
            // 
            this.pictureBoxMouth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMouth.Image = global::Picture_Imperfect.Properties.Resources.SMouth_Size;
            this.pictureBoxMouth.Location = new System.Drawing.Point(3, 408);
            this.pictureBoxMouth.Name = "pictureBoxMouth";
            this.pictureBoxMouth.Size = new System.Drawing.Size(800, 750);
            this.pictureBoxMouth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMouth.TabIndex = 1;
            this.pictureBoxMouth.TabStop = false;
            this.pictureBoxMouth.Visible = false;
            // 
            // CopyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxHead);
            this.Controls.Add(this.pictureBoxShirt);
            this.Controls.Add(this.pictureBoxMouth);
            this.Controls.Add(this.pictureBoxSymbol);
            this.Name = "CopyScreen";
            this.Size = new System.Drawing.Size(800, 750);
            this.Load += new System.EventHandler(this.CopyScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CopyScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouth)).EndInit();
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

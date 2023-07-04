
namespace Eloiswapper
{
    partial class Mochilas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mochilas));
            this.labelmochilas = new System.Windows.Forms.Label();
            this.picominty = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picominty)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmochilas
            // 
            this.labelmochilas.AutoSize = true;
            this.labelmochilas.BackColor = System.Drawing.Color.Transparent;
            this.labelmochilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmochilas.ForeColor = System.Drawing.Color.White;
            this.labelmochilas.Location = new System.Drawing.Point(206, 22);
            this.labelmochilas.Name = "labelmochilas";
            this.labelmochilas.Size = new System.Drawing.Size(129, 31);
            this.labelmochilas.TabIndex = 1;
            this.labelmochilas.Text = "Mochilas";
            // 
            // picominty
            // 
            this.picominty.BackColor = System.Drawing.Color.Transparent;
            this.picominty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picominty.Image = ((System.Drawing.Image)(resources.GetObject("picominty.Image")));
            this.picominty.Location = new System.Drawing.Point(33, 67);
            this.picominty.Name = "picominty";
            this.picominty.Size = new System.Drawing.Size(87, 83);
            this.picominty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picominty.TabIndex = 29;
            this.picominty.TabStop = false;
            this.picominty.Click += new System.EventHandler(this.picominty_Click);
            // 
            // Mochilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.picominty);
            this.Controls.Add(this.labelmochilas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mochilas";
            this.Text = "Mochilas";
            this.Load += new System.EventHandler(this.Mochilas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picominty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmochilas;
        private System.Windows.Forms.PictureBox picominty;
    }
}
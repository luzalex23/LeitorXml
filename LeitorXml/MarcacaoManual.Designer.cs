namespace LeitorXml
{
    partial class MarcacaoManual
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
            this.manualMaker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manualMaker
            // 
            this.manualMaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualMaker.ForeColor = System.Drawing.Color.DarkCyan;
            this.manualMaker.Location = new System.Drawing.Point(12, 12);
            this.manualMaker.Name = "manualMaker";
            this.manualMaker.Size = new System.Drawing.Size(157, 23);
            this.manualMaker.TabIndex = 0;
            this.manualMaker.Text = "MarcacaoManual";
            this.manualMaker.UseVisualStyleBackColor = true;
            this.manualMaker.Click += new System.EventHandler(this.manualMaker_Click);
            // 
            // MarcacaoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(186, 68);
            this.Controls.Add(this.manualMaker);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MarcacaoManual";
            this.Text = "MarcacaoManual";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manualMaker;
    }
}
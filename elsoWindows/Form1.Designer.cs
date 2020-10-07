namespace elsoWindows
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_udvozles = new System.Windows.Forms.Label();
            this.tb_szoveg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kiir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kilépés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_udvozles
            // 
            this.lbl_udvozles.AutoSize = true;
            this.lbl_udvozles.Location = new System.Drawing.Point(164, 9);
            this.lbl_udvozles.Name = "lbl_udvozles";
            this.lbl_udvozles.Size = new System.Drawing.Size(55, 20);
            this.lbl_udvozles.TabIndex = 1;
            this.lbl_udvozles.Text = "label1";
            this.lbl_udvozles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_szoveg
            // 
            this.tb_szoveg.Location = new System.Drawing.Point(100, 46);
            this.tb_szoveg.Name = "tb_szoveg";
            this.tb_szoveg.Size = new System.Drawing.Size(180, 29);
            this.tb_szoveg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ide írj:";
            // 
            // btn_kiir
            // 
            this.btn_kiir.Location = new System.Drawing.Point(144, 108);
            this.btn_kiir.Name = "btn_kiir";
            this.btn_kiir.Size = new System.Drawing.Size(75, 32);
            this.btn_kiir.TabIndex = 4;
            this.btn_kiir.Text = "Kiír";
            this.btn_kiir.UseVisualStyleBackColor = true;
            this.btn_kiir.Click += new System.EventHandler(this.btn_kiir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 257);
            this.Controls.Add(this.btn_kiir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_szoveg);
            this.Controls.Add(this.lbl_udvozles);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elso formos alkalmazas";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_udvozles;
        private System.Windows.Forms.TextBox tb_szoveg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kiir;
    }
}


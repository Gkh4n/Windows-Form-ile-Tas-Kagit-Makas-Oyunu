namespace TKM
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
            this.components = new System.ComponentModel.Container();
            this.btnTas = new System.Windows.Forms.Button();
            this.btnKagit = new System.Windows.Forms.Button();
            this.btnMakas = new System.Windows.Forms.Button();
            this.btnMakasPc = new System.Windows.Forms.Button();
            this.btnKagitPc = new System.Windows.Forms.Button();
            this.btnTasPc = new System.Windows.Forms.Button();
            this.skorLbl = new System.Windows.Forms.Label();
            this.durumLbl = new System.Windows.Forms.Label();
            this.rakipLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnYeniden = new System.Windows.Forms.Button();
            this.sonucLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTas
            // 
            this.btnTas.BackColor = System.Drawing.Color.White;
            this.btnTas.Location = new System.Drawing.Point(311, 293);
            this.btnTas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTas.Name = "btnTas";
            this.btnTas.Size = new System.Drawing.Size(105, 32);
            this.btnTas.TabIndex = 0;
            this.btnTas.Text = "TAŞ";
            this.btnTas.UseVisualStyleBackColor = false;
            this.btnTas.Click += new System.EventHandler(this.btnTas_Click);
            // 
            // btnKagit
            // 
            this.btnKagit.BackColor = System.Drawing.Color.White;
            this.btnKagit.Location = new System.Drawing.Point(311, 338);
            this.btnKagit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKagit.Name = "btnKagit";
            this.btnKagit.Size = new System.Drawing.Size(105, 32);
            this.btnKagit.TabIndex = 0;
            this.btnKagit.Text = "KAĞIT";
            this.btnKagit.UseVisualStyleBackColor = false;
            this.btnKagit.Click += new System.EventHandler(this.btnKagit_Click);
            // 
            // btnMakas
            // 
            this.btnMakas.BackColor = System.Drawing.Color.White;
            this.btnMakas.Location = new System.Drawing.Point(311, 385);
            this.btnMakas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakas.Name = "btnMakas";
            this.btnMakas.Size = new System.Drawing.Size(105, 32);
            this.btnMakas.TabIndex = 0;
            this.btnMakas.Text = "MAKAS";
            this.btnMakas.UseVisualStyleBackColor = false;
            this.btnMakas.Click += new System.EventHandler(this.btnMakas_Click);
            // 
            // btnMakasPc
            // 
            this.btnMakasPc.BackColor = System.Drawing.Color.Gray;
            this.btnMakasPc.Enabled = false;
            this.btnMakasPc.Location = new System.Drawing.Point(311, 120);
            this.btnMakasPc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakasPc.Name = "btnMakasPc";
            this.btnMakasPc.Size = new System.Drawing.Size(105, 31);
            this.btnMakasPc.TabIndex = 1;
            this.btnMakasPc.Text = "MAKAS";
            this.btnMakasPc.UseVisualStyleBackColor = false;
            // 
            // btnKagitPc
            // 
            this.btnKagitPc.BackColor = System.Drawing.Color.Gray;
            this.btnKagitPc.Enabled = false;
            this.btnKagitPc.Location = new System.Drawing.Point(311, 73);
            this.btnKagitPc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKagitPc.Name = "btnKagitPc";
            this.btnKagitPc.Size = new System.Drawing.Size(105, 31);
            this.btnKagitPc.TabIndex = 2;
            this.btnKagitPc.Text = "KAĞIT";
            this.btnKagitPc.UseVisualStyleBackColor = false;
            // 
            // btnTasPc
            // 
            this.btnTasPc.BackColor = System.Drawing.Color.Gray;
            this.btnTasPc.Enabled = false;
            this.btnTasPc.Location = new System.Drawing.Point(311, 27);
            this.btnTasPc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTasPc.Name = "btnTasPc";
            this.btnTasPc.Size = new System.Drawing.Size(105, 31);
            this.btnTasPc.TabIndex = 3;
            this.btnTasPc.Text = "TAŞ";
            this.btnTasPc.UseVisualStyleBackColor = false;
            // 
            // skorLbl
            // 
            this.skorLbl.AutoSize = true;
            this.skorLbl.BackColor = System.Drawing.Color.Transparent;
            this.skorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.skorLbl.Location = new System.Drawing.Point(679, 23);
            this.skorLbl.Name = "skorLbl";
            this.skorLbl.Size = new System.Drawing.Size(77, 31);
            this.skorLbl.TabIndex = 4;
            this.skorLbl.Text = "Sen: ";
            // 
            // durumLbl
            // 
            this.durumLbl.AutoSize = true;
            this.durumLbl.BackColor = System.Drawing.Color.Transparent;
            this.durumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.durumLbl.Location = new System.Drawing.Point(293, 205);
            this.durumLbl.Name = "durumLbl";
            this.durumLbl.Size = new System.Drawing.Size(0, 31);
            this.durumLbl.TabIndex = 5;
            // 
            // rakipLbl
            // 
            this.rakipLbl.AutoSize = true;
            this.rakipLbl.BackColor = System.Drawing.Color.Transparent;
            this.rakipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakipLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rakipLbl.Location = new System.Drawing.Point(12, 23);
            this.rakipLbl.Name = "rakipLbl";
            this.rakipLbl.Size = new System.Drawing.Size(99, 31);
            this.rakipLbl.TabIndex = 6;
            this.rakipLbl.Text = "Rakip: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnYeniden
            // 
            this.btnYeniden.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnYeniden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYeniden.Location = new System.Drawing.Point(638, 383);
            this.btnYeniden.Name = "btnYeniden";
            this.btnYeniden.Size = new System.Drawing.Size(118, 36);
            this.btnYeniden.TabIndex = 7;
            this.btnYeniden.Text = "Yeniden Oyna";
            this.btnYeniden.UseVisualStyleBackColor = false;
            this.btnYeniden.Click += new System.EventHandler(this.btnYeniden_Click);
            // 
            // sonucLbl
            // 
            this.sonucLbl.AutoSize = true;
            this.sonucLbl.BackColor = System.Drawing.Color.Transparent;
            this.sonucLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.sonucLbl.Location = new System.Drawing.Point(175, 205);
            this.sonucLbl.Name = "sonucLbl";
            this.sonucLbl.Size = new System.Drawing.Size(0, 31);
            this.sonucLbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::TKM.Properties.Resources.gfdgf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.sonucLbl);
            this.Controls.Add(this.btnYeniden);
            this.Controls.Add(this.durumLbl);
            this.Controls.Add(this.btnMakas);
            this.Controls.Add(this.btnKagit);
            this.Controls.Add(this.btnTas);
            this.Controls.Add(this.rakipLbl);
            this.Controls.Add(this.skorLbl);
            this.Controls.Add(this.btnMakasPc);
            this.Controls.Add(this.btnKagitPc);
            this.Controls.Add(this.btnTasPc);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taş Kağıt Makas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTas;
        private System.Windows.Forms.Button btnKagit;
        private System.Windows.Forms.Button btnMakas;
        private System.Windows.Forms.Button btnMakasPc;
        private System.Windows.Forms.Button btnKagitPc;
        private System.Windows.Forms.Button btnTasPc;
        private System.Windows.Forms.Label skorLbl;
        private System.Windows.Forms.Label durumLbl;
        private System.Windows.Forms.Label rakipLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnYeniden;
        private System.Windows.Forms.Label sonucLbl;
    }
}


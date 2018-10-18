namespace SmarterThing
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
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Tablobasi = new System.Windows.Forms.Label();
            this.lblhaber = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.graphic = new System.Windows.Forms.Timer(this.components);
            this.lblMailDetay = new System.Windows.Forms.Label();
            this.Saat = new System.Windows.Forms.Timer(this.components);
            this.mailcek = new System.Windows.Forms.Timer(this.components);
            this.ScreenSaver = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaat.Font = new System.Drawing.Font("Segoe Script", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaat.Location = new System.Drawing.Point(0, 0);
            this.lblSaat.Margin = new System.Windows.Forms.Padding(0);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(1145, 122);
            this.lblSaat.TabIndex = 2;
            this.lblSaat.Text = "Saat";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTarih.Font = new System.Drawing.Font("Segoe Script", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Location = new System.Drawing.Point(0, 122);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(1145, 71);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(295, 273);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "label1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(295, 399);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "label1";
            // 
            // Tablobasi
            // 
            this.Tablobasi.AutoSize = true;
            this.Tablobasi.Location = new System.Drawing.Point(295, 229);
            this.Tablobasi.Name = "Tablobasi";
            this.Tablobasi.Size = new System.Drawing.Size(35, 13);
            this.Tablobasi.TabIndex = 7;
            this.Tablobasi.Text = "label1";
            // 
            // lblhaber
            // 
            this.lblhaber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblhaber.AutoSize = true;
            this.lblhaber.Location = new System.Drawing.Point(295, 560);
            this.lblhaber.Name = "lblhaber";
            this.lblhaber.Size = new System.Drawing.Size(35, 13);
            this.lblhaber.TabIndex = 9;
            this.lblhaber.Text = "label1";
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMail.BackColor = System.Drawing.Color.Maroon;
            this.lblMail.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(945, 71);
            this.lblMail.Margin = new System.Windows.Forms.Padding(10);
            this.lblMail.MaximumSize = new System.Drawing.Size(200, 50);
            this.lblMail.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(200, 50);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail Sayısı : ";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graphic
            // 
            this.graphic.Interval = 10;
            this.graphic.Tick += new System.EventHandler(this.graphic_Tick);
            // 
            // lblMailDetay
            // 
            this.lblMailDetay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMailDetay.BackColor = System.Drawing.Color.Maroon;
            this.lblMailDetay.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailDetay.Location = new System.Drawing.Point(945, 126);
            this.lblMailDetay.Margin = new System.Windows.Forms.Padding(10);
            this.lblMailDetay.MaximumSize = new System.Drawing.Size(200, 700);
            this.lblMailDetay.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblMailDetay.Name = "lblMailDetay";
            this.lblMailDetay.Padding = new System.Windows.Forms.Padding(10);
            this.lblMailDetay.Size = new System.Drawing.Size(200, 536);
            this.lblMailDetay.TabIndex = 11;
            this.lblMailDetay.Text = "Mail Detayları :";
            this.lblMailDetay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Saat
            // 
            this.Saat.Tick += new System.EventHandler(this.Saat_Tick);
            // 
            // mailcek
            // 
            this.mailcek.Enabled = true;
            this.mailcek.Interval = 10000000;
            this.mailcek.Tick += new System.EventHandler(this.mailcek_Tick);
            // 
            // ScreenSaver
            // 
            this.ScreenSaver.Tick += new System.EventHandler(this.ScreenSaver_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1145, 760);
            this.Controls.Add(this.lblMailDetay);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblhaber);
            this.Controls.Add(this.Tablobasi);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblSaat);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LightSalmon;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label Tablobasi;
        private System.Windows.Forms.Label lblhaber;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Timer graphic;
        private System.Windows.Forms.Label lblMailDetay;
        private System.Windows.Forms.Timer Saat;
        private System.Windows.Forms.Timer mailcek;
        private System.Windows.Forms.Timer ScreenSaver;
    }
}


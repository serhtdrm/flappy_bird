namespace flappy_bird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Zamin = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.Kus = new System.Windows.Forms.PictureBox();
            this.skorText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Zamin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kus)).BeginInit();
            this.SuspendLayout();
            // 
            // Zamin
            // 
            this.Zamin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Zamin.Image = global::flappy_bird.Properties.Resources.ground;
            this.Zamin.Location = new System.Drawing.Point(3, 434);
            this.Zamin.Name = "Zamin";
            this.Zamin.Size = new System.Drawing.Size(981, 55);
            this.Zamin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zamin.TabIndex = 3;
            this.Zamin.TabStop = false;
            // 
            // BoruAlt
            // 
            this.BoruAlt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BoruAlt.Image = global::flappy_bird.Properties.Resources.pipe;
            this.BoruAlt.Location = new System.Drawing.Point(689, 311);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(100, 128);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 2;
            this.BoruAlt.TabStop = false;
            // 
            // BoruUst
            // 
            this.BoruUst.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BoruUst.Image = global::flappy_bird.Properties.Resources.pipedown;
            this.BoruUst.Location = new System.Drawing.Point(689, 0);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(100, 109);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 1;
            this.BoruUst.TabStop = false;
            // 
            // Kus
            // 
            this.Kus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Kus.Image = global::flappy_bird.Properties.Resources.bird;
            this.Kus.Location = new System.Drawing.Point(87, 82);
            this.Kus.Name = "Kus";
            this.Kus.Size = new System.Drawing.Size(55, 50);
            this.Kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kus.TabIndex = 0;
            this.Kus.TabStop = false;
            // 
            // skorText
            // 
            this.skorText.AutoSize = true;
            this.skorText.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skorText.Location = new System.Drawing.Point(42, 504);
            this.skorText.Name = "skorText";
            this.skorText.Size = new System.Drawing.Size(100, 30);
            this.skorText.TabIndex = 4;
            this.skorText.Text = "Score:0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 30;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(979, 544);
            this.Controls.Add(this.skorText);
            this.Controls.Add(this.Zamin);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.BoruUst);
            this.Controls.Add(this.Kus);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Zamin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kus;
        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox Zamin;
        private System.Windows.Forms.Label skorText;
        private System.Windows.Forms.Timer GameTimer;
    }
}


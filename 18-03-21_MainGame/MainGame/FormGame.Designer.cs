﻿namespace MainGame
{
    partial class FormGame
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.picTank = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrSparo = new System.Windows.Forms.Timer(this.components);
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.canvas1 = new SpriteCanvas.Canvas();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picTank
            // 
            this.picTank.BackColor = System.Drawing.Color.Transparent;
            this.picTank.Location = new System.Drawing.Point(121, 130);
            this.picTank.Name = "picTank";
            this.picTank.Size = new System.Drawing.Size(50, 50);
            this.picTank.TabIndex = 1;
            this.picTank.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // tmrSparo
            // 
            this.tmrSparo.Enabled = true;
            this.tmrSparo.Interval = 1;
            this.tmrSparo.Tick += new System.EventHandler(this.tmrSparo_Tick);
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picEnemy.Location = new System.Drawing.Point(598, 147);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(50, 50);
            this.picEnemy.TabIndex = 3;
            this.picEnemy.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(232, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 192);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // canvas1
            // 
            this.canvas1.ImageLayout = new System.Drawing.Point(10, 6);
            this.canvas1.Location = new System.Drawing.Point(611, 244);
            this.canvas1.Name = "canvas1";
            this.canvas1.PictureFile = ((System.Drawing.Image)(resources.GetObject("canvas1.PictureFile")));
            this.canvas1.Size = new System.Drawing.Size(150, 150);
            this.canvas1.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 33;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 507);
            this.Controls.Add(this.canvas1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picEnemy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picTank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picTank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrSparo;
        private System.Windows.Forms.PictureBox picEnemy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SpriteCanvas.Canvas canvas1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer AnimationTimer;
    }
}


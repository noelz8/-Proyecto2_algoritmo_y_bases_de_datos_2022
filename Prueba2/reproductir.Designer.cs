﻿namespace Prueba2
{
    partial class reproductir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reproductir));
            this.lblCancion = new System.Windows.Forms.Label();
            this.mtrackEstatus = new System.Windows.Forms.TrackBar();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mtrackVolumen = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mtrackEstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtrackVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.BackColor = System.Drawing.Color.White;
            this.lblCancion.Location = new System.Drawing.Point(12, 9);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(15, 16);
            this.lblCancion.TabIndex = 9;
            this.lblCancion.Text = "--";
            // 
            // mtrackEstatus
            // 
            this.mtrackEstatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtrackEstatus.Location = new System.Drawing.Point(12, 54);
            this.mtrackEstatus.Name = "mtrackEstatus";
            this.mtrackEstatus.Size = new System.Drawing.Size(214, 56);
            this.mtrackEstatus.TabIndex = 1;
            this.mtrackEstatus.Scroll += new System.EventHandler(this.mtrackEstatus_Scroll);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(537, 12);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(403, 224);
            this.Reproductor.TabIndex = 2;
            this.Reproductor.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Image = global::Prueba2.Properties.Resources.add;
            this.btnAdjuntar.Location = new System.Drawing.Point(15, 136);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(56, 50);
            this.btnAdjuntar.TabIndex = 3;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::Prueba2.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(94, 136);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(54, 50);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::Prueba2.Properties.Resources.stop;
            this.btnStop.Location = new System.Drawing.Point(169, 136);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(59, 50);
            this.btnStop.TabIndex = 5;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Prueba2.Properties.Resources.volume_up_4_xxl;
            this.pictureBox4.Location = new System.Drawing.Point(15, 214);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 50);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // mtrackVolumen
            // 
            this.mtrackVolumen.LargeChange = 2;
            this.mtrackVolumen.Location = new System.Drawing.Point(94, 214);
            this.mtrackVolumen.Maximum = 150;
            this.mtrackVolumen.Name = "mtrackVolumen";
            this.mtrackVolumen.Size = new System.Drawing.Size(214, 56);
            this.mtrackVolumen.TabIndex = 4;
            this.mtrackVolumen.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(537, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 100);
            this.panel1.TabIndex = 8;
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 16;
            this.lstCanciones.Location = new System.Drawing.Point(-5, 293);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(725, 164);
            this.lstCanciones.TabIndex = 9;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Prueba2.Properties.Resources.encendido__1_;
            this.pictureBox5.Location = new System.Drawing.Point(792, 331);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 50);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // reproductir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 577);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtrackVolumen);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.mtrackEstatus);
            this.Controls.Add(this.lblCancion);
            this.Name = "reproductir";
            this.Text = "reproductir";
            ((System.ComponentModel.ISupportInitialize)(this.mtrackEstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtrackVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.TrackBar mtrackEstatus;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.PictureBox btnAdjuntar;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar mtrackVolumen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
    }
}
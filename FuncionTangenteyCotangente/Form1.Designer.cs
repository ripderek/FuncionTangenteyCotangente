﻿namespace FuncionTangenteyCotangente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.btnTangente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtancho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtescala = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picFondo);
            this.panel1.Location = new System.Drawing.Point(5, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 511);
            this.panel1.TabIndex = 1;
            // 
            // picFondo
            // 
            this.picFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFondo.BackgroundImage")));
            this.picFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFondo.Location = new System.Drawing.Point(0, 0);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(496, 511);
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            this.picFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.picFondo_Paint);
            // 
            // btnTangente
            // 
            this.btnTangente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTangente.Location = new System.Drawing.Point(420, 15);
            this.btnTangente.Name = "btnTangente";
            this.btnTangente.Size = new System.Drawing.Size(83, 33);
            this.btnTangente.TabIndex = 0;
            this.btnTangente.Text = "Aceptar";
            this.btnTangente.UseVisualStyleBackColor = true;
            this.btnTangente.Click += new System.EventHandler(this.btnTangente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtescala);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtancho);
            this.groupBox1.Controls.Add(this.btnTangente);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // txtancho
            // 
            this.txtancho.Location = new System.Drawing.Point(60, 22);
            this.txtancho.Name = "txtancho";
            this.txtancho.Size = new System.Drawing.Size(69, 20);
            this.txtancho.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ancho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escala:";
            // 
            // txtescala
            // 
            this.txtescala.Location = new System.Drawing.Point(187, 22);
            this.txtescala.Name = "txtescala";
            this.txtescala.Size = new System.Drawing.Size(69, 20);
            this.txtescala.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tipo",
            "Tangente",
            "Cotangente"});
            this.comboBox1.Location = new System.Drawing.Point(281, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Button btnTangente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtescala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtancho;
    }
}


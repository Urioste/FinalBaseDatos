﻿namespace FinalBaseDatos
{
    partial class InsertarPer
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
            this.NombreEncargado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ci = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Parentesco = new System.Windows.Forms.TextBox();
            this.EtTelefono = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.TextBox();
            this.CuentaBco = new System.Windows.Forms.TextBox();
            this.EtiquetaBco = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Banco = new System.Windows.Forms.TextBox();
            this.Registrado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreEncargado
            // 
            this.NombreEncargado.Location = new System.Drawing.Point(133, 46);
            this.NombreEncargado.Name = "NombreEncargado";
            this.NombreEncargado.Size = new System.Drawing.Size(209, 22);
            this.NombreEncargado.TabIndex = 0;
            this.NombreEncargado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dirección";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(133, 207);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(209, 22);
            this.Direccion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carnet de Identidad";
            // 
            // Ci
            // 
            this.Ci.Location = new System.Drawing.Point(133, 130);
            this.Ci.Name = "Ci";
            this.Ci.Size = new System.Drawing.Size(210, 22);
            this.Ci.TabIndex = 5;
            this.Ci.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(680, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Completar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parentesco";
            // 
            // Parentesco
            // 
            this.Parentesco.Location = new System.Drawing.Point(302, 272);
            this.Parentesco.Name = "Parentesco";
            this.Parentesco.Size = new System.Drawing.Size(210, 22);
            this.Parentesco.TabIndex = 8;
            this.Parentesco.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // EtTelefono
            // 
            this.EtTelefono.AutoSize = true;
            this.EtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtTelefono.Location = new System.Drawing.Point(456, 188);
            this.EtTelefono.Name = "EtTelefono";
            this.EtTelefono.Size = new System.Drawing.Size(69, 16);
            this.EtTelefono.TabIndex = 9;
            this.EtTelefono.Text = "Teléfono";
            // 
            // Celular
            // 
            this.Celular.Location = new System.Drawing.Point(459, 207);
            this.Celular.Name = "Celular";
            this.Celular.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Celular.Size = new System.Drawing.Size(210, 22);
            this.Celular.TabIndex = 10;
            this.Celular.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // CuentaBco
            // 
            this.CuentaBco.Location = new System.Drawing.Point(459, 46);
            this.CuentaBco.Name = "CuentaBco";
            this.CuentaBco.Size = new System.Drawing.Size(211, 22);
            this.CuentaBco.TabIndex = 11;
            // 
            // EtiquetaBco
            // 
            this.EtiquetaBco.AutoSize = true;
            this.EtiquetaBco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaBco.Location = new System.Drawing.Point(456, 24);
            this.EtiquetaBco.Name = "EtiquetaBco";
            this.EtiquetaBco.Size = new System.Drawing.Size(169, 16);
            this.EtiquetaBco.TabIndex = 12;
            this.EtiquetaBco.Text = "Cuenta Bancaria [6 dig]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Banco";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Banco
            // 
            this.Banco.Location = new System.Drawing.Point(459, 130);
            this.Banco.Name = "Banco";
            this.Banco.Size = new System.Drawing.Size(211, 22);
            this.Banco.TabIndex = 14;
            // 
            // Registrado
            // 
            this.Registrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Registrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrado.Location = new System.Drawing.Point(12, 253);
            this.Registrado.Name = "Registrado";
            this.Registrado.Size = new System.Drawing.Size(150, 82);
            this.Registrado.TabIndex = 15;
            this.Registrado.Text = "Ya esta Registrado?";
            this.Registrado.UseVisualStyleBackColor = false;
            this.Registrado.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FinalBaseDatos.Properties.Resources.family;
            this.pictureBox1.Location = new System.Drawing.Point(191, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // InsertarPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registrado);
            this.Controls.Add(this.Banco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EtiquetaBco);
            this.Controls.Add(this.CuentaBco);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.EtTelefono);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Parentesco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreEncargado);
            this.Name = "InsertarPer";
            this.Text = "Responsable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreEncargado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Ci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Parentesco;

        private System.Windows.Forms.Label EtTelefono;
        private System.Windows.Forms.TextBox Celular;
        private System.Windows.Forms.TextBox CuentaBco;
        private System.Windows.Forms.Label EtiquetaBco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Banco;
        private System.Windows.Forms.Button Registrado;

        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
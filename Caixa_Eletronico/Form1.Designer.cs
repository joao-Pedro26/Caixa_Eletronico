﻿namespace Caixa_Eletronico
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
            this.lblValor = new System.Windows.Forms.Label();
            this.btDepositar = new System.Windows.Forms.Button();
            this.btSacar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOper_valor = new System.Windows.Forms.NumericUpDown();
            this.numOper_limite = new System.Windows.Forms.NumericUpDown();
            this.tmrJuros = new System.Windows.Forms.Timer(this.components);
            this.lblTaxa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOper_valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper_limite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(37, 51);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(74, 25);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            // 
            // btDepositar
            // 
            this.btDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDepositar.Location = new System.Drawing.Point(42, 116);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(138, 46);
            this.btDepositar.TabIndex = 2;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // btSacar
            // 
            this.btSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSacar.Location = new System.Drawing.Point(201, 116);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(138, 46);
            this.btSacar.TabIndex = 3;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(131, 198);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(94, 29);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "R$ 0.00";
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Limite:";
            // 
            // numOper_valor
            // 
            this.numOper_valor.Location = new System.Drawing.Point(117, 56);
            this.numOper_valor.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.numOper_valor.Name = "numOper_valor";
            this.numOper_valor.Size = new System.Drawing.Size(191, 20);
            this.numOper_valor.TabIndex = 8;
            this.numOper_valor.Tag = "";
            // 
            // numOper_limite
            // 
            this.numOper_limite.Location = new System.Drawing.Point(125, 266);
            this.numOper_limite.Name = "numOper_limite";
            this.numOper_limite.Size = new System.Drawing.Size(191, 20);
            this.numOper_limite.TabIndex = 9;
            // 
            // tmrJuros
            // 
            this.tmrJuros.Enabled = true;
            this.tmrJuros.Interval = 5000;
            this.tmrJuros.Tick += new System.EventHandler(this.tmrJuros_Tick);
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(30, 330);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(38, 13);
            this.lblTaxa.TabIndex = 10;
            this.lblTaxa.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 369);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.numOper_limite);
            this.Controls.Add(this.numOper_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOper_valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOper_limite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOper_valor;
        private System.Windows.Forms.NumericUpDown numOper_limite;
        private System.Windows.Forms.Timer tmrJuros;
        private System.Windows.Forms.Label lblTaxa;
    }
}


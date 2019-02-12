namespace ex_bank
{
    partial class FrmConta
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
            this.btnDeposito = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.grpBoxFunc = new System.Windows.Forms.GroupBox();
            this.cboBoxFavorecido = new System.Windows.Forms.ComboBox();
            this.lblFavorecido = new System.Windows.Forms.Label();
            this.cboBoxTitular = new System.Windows.Forms.ComboBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.lblInfoTitular = new System.Windows.Forms.Label();
            this.txtBoxInfoTitular = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtBoxSaldo = new System.Windows.Forms.TextBox();
            this.grpBoxFunc.SuspendLayout();
            this.grpBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeposito
            // 
            this.btnDeposito.Enabled = false;
            this.btnDeposito.Location = new System.Drawing.Point(14, 153);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(84, 23);
            this.btnDeposito.TabIndex = 1;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.BtnDeposito_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.Navy;
            this.lblValor.Location = new System.Drawing.Point(29, 108);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(57, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor (R$):";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(91, 104);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSaque
            // 
            this.btnSaque.Enabled = false;
            this.btnSaque.Location = new System.Drawing.Point(116, 153);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(84, 23);
            this.btnSaque.TabIndex = 4;
            this.btnSaque.Text = "Sacar";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.BtnSaque_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Enabled = false;
            this.btnTransferir.Location = new System.Drawing.Point(218, 153);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(84, 23);
            this.btnTransferir.TabIndex = 5;
            this.btnTransferir.Text = "Transferência";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.BtnTransferir_Click);
            // 
            // grpBoxFunc
            // 
            this.grpBoxFunc.Controls.Add(this.cboBoxFavorecido);
            this.grpBoxFunc.Controls.Add(this.lblFavorecido);
            this.grpBoxFunc.Controls.Add(this.cboBoxTitular);
            this.grpBoxFunc.Controls.Add(this.lblTitular);
            this.grpBoxFunc.Controls.Add(this.btnDeposito);
            this.grpBoxFunc.Controls.Add(this.txtValor);
            this.grpBoxFunc.Controls.Add(this.lblValor);
            this.grpBoxFunc.Controls.Add(this.btnTransferir);
            this.grpBoxFunc.Controls.Add(this.btnSaque);
            this.grpBoxFunc.ForeColor = System.Drawing.Color.Navy;
            this.grpBoxFunc.Location = new System.Drawing.Point(12, 12);
            this.grpBoxFunc.Name = "grpBoxFunc";
            this.grpBoxFunc.Size = new System.Drawing.Size(317, 190);
            this.grpBoxFunc.TabIndex = 6;
            this.grpBoxFunc.TabStop = false;
            this.grpBoxFunc.Text = "Movimentação da Conta";
            // 
            // cboBoxFavorecido
            // 
            this.cboBoxFavorecido.FormattingEnabled = true;
            this.cboBoxFavorecido.Location = new System.Drawing.Point(91, 65);
            this.cboBoxFavorecido.Name = "cboBoxFavorecido";
            this.cboBoxFavorecido.Size = new System.Drawing.Size(214, 21);
            this.cboBoxFavorecido.TabIndex = 9;
            this.cboBoxFavorecido.SelectedIndexChanged += new System.EventHandler(this.cboBoxFavorecido_SelectedIndexChanged);
            // 
            // lblFavorecido
            // 
            this.lblFavorecido.AutoSize = true;
            this.lblFavorecido.ForeColor = System.Drawing.Color.Navy;
            this.lblFavorecido.Location = new System.Drawing.Point(23, 69);
            this.lblFavorecido.Name = "lblFavorecido";
            this.lblFavorecido.Size = new System.Drawing.Size(63, 13);
            this.lblFavorecido.TabIndex = 8;
            this.lblFavorecido.Text = "Favorecido:";
            // 
            // cboBoxTitular
            // 
            this.cboBoxTitular.FormattingEnabled = true;
            this.cboBoxTitular.Location = new System.Drawing.Point(91, 26);
            this.cboBoxTitular.Name = "cboBoxTitular";
            this.cboBoxTitular.Size = new System.Drawing.Size(214, 21);
            this.cboBoxTitular.TabIndex = 7;
            this.cboBoxTitular.SelectedIndexChanged += new System.EventHandler(this.CboBoxTitular_SelectedIndexChanged);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.ForeColor = System.Drawing.Color.Navy;
            this.lblTitular.Location = new System.Drawing.Point(47, 30);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(39, 13);
            this.lblTitular.TabIndex = 6;
            this.lblTitular.Text = "Titular:";
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.lblInfoTitular);
            this.grpBoxInfo.Controls.Add(this.txtBoxInfoTitular);
            this.grpBoxInfo.Controls.Add(this.lblSaldo);
            this.grpBoxInfo.Controls.Add(this.txtBoxSaldo);
            this.grpBoxInfo.ForeColor = System.Drawing.Color.Navy;
            this.grpBoxInfo.Location = new System.Drawing.Point(335, 12);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(211, 190);
            this.grpBoxInfo.TabIndex = 7;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Informação";
            // 
            // lblInfoTitular
            // 
            this.lblInfoTitular.AutoSize = true;
            this.lblInfoTitular.ForeColor = System.Drawing.Color.Navy;
            this.lblInfoTitular.Location = new System.Drawing.Point(59, 26);
            this.lblInfoTitular.Name = "lblInfoTitular";
            this.lblInfoTitular.Size = new System.Drawing.Size(39, 13);
            this.lblInfoTitular.TabIndex = 3;
            this.lblInfoTitular.Text = "Titular:";
            // 
            // txtBoxInfoTitular
            // 
            this.txtBoxInfoTitular.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxInfoTitular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxInfoTitular.Location = new System.Drawing.Point(104, 26);
            this.txtBoxInfoTitular.Name = "txtBoxInfoTitular";
            this.txtBoxInfoTitular.Size = new System.Drawing.Size(100, 13);
            this.txtBoxInfoTitular.TabIndex = 2;
            this.txtBoxInfoTitular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.ForeColor = System.Drawing.Color.Navy;
            this.lblSaldo.Location = new System.Drawing.Point(11, 163);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(87, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo Atual (R$):";
            // 
            // txtBoxSaldo
            // 
            this.txtBoxSaldo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSaldo.Location = new System.Drawing.Point(101, 163);
            this.txtBoxSaldo.Name = "txtBoxSaldo";
            this.txtBoxSaldo.Size = new System.Drawing.Size(100, 13);
            this.txtBoxSaldo.TabIndex = 0;
            this.txtBoxSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 209);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.grpBoxFunc);
            this.Name = "FrmConta";
            this.Text = "frmConta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxFunc.ResumeLayout(false);
            this.grpBoxFunc.PerformLayout();
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.GroupBox grpBoxFunc;
        private System.Windows.Forms.ComboBox cboBoxTitular;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.GroupBox grpBoxInfo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtBoxSaldo;
        private System.Windows.Forms.ComboBox cboBoxFavorecido;
        private System.Windows.Forms.Label lblFavorecido;
        private System.Windows.Forms.Label lblInfoTitular;
        private System.Windows.Forms.TextBox txtBoxInfoTitular;
    }
}


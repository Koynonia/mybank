namespace mybank
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
            this.grpFunc = new System.Windows.Forms.GroupBox();
            this.cboFavorecido = new System.Windows.Forms.ComboBox();
            this.lblFavorecido = new System.Windows.Forms.Label();
            this.cboTitular = new System.Windows.Forms.ComboBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.lblInfoTitular = new System.Windows.Forms.Label();
            this.txtInfoTitular = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.grpFunc.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeposito
            // 
            this.btnDeposito.Enabled = false;
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Navy;
            this.lblValor.Location = new System.Drawing.Point(29, 108);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(57, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor (R$):";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(91, 104);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSaque
            // 
            this.btnSaque.Enabled = false;
            this.btnSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(218, 153);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(84, 23);
            this.btnTransferir.TabIndex = 5;
            this.btnTransferir.Text = "Transferência";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.BtnTransferir_Click);
            // 
            // grpFunc
            // 
            this.grpFunc.Controls.Add(this.cboFavorecido);
            this.grpFunc.Controls.Add(this.lblFavorecido);
            this.grpFunc.Controls.Add(this.cboTitular);
            this.grpFunc.Controls.Add(this.lblTitular);
            this.grpFunc.Controls.Add(this.btnDeposito);
            this.grpFunc.Controls.Add(this.txtValor);
            this.grpFunc.Controls.Add(this.lblValor);
            this.grpFunc.Controls.Add(this.btnTransferir);
            this.grpFunc.Controls.Add(this.btnSaque);
            this.grpFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFunc.ForeColor = System.Drawing.Color.Navy;
            this.grpFunc.Location = new System.Drawing.Point(12, 12);
            this.grpFunc.Name = "grpFunc";
            this.grpFunc.Size = new System.Drawing.Size(317, 190);
            this.grpFunc.TabIndex = 6;
            this.grpFunc.TabStop = false;
            this.grpFunc.Text = "Movimentação da Conta";
            // 
            // cboFavorecido
            // 
            this.cboFavorecido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFavorecido.FormattingEnabled = true;
            this.cboFavorecido.Location = new System.Drawing.Point(91, 65);
            this.cboFavorecido.Name = "cboFavorecido";
            this.cboFavorecido.Size = new System.Drawing.Size(214, 21);
            this.cboFavorecido.TabIndex = 9;
            this.cboFavorecido.SelectedIndexChanged += new System.EventHandler(this.CboFavorecido_SelectedIndexChanged);
            // 
            // lblFavorecido
            // 
            this.lblFavorecido.AutoSize = true;
            this.lblFavorecido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorecido.ForeColor = System.Drawing.Color.Navy;
            this.lblFavorecido.Location = new System.Drawing.Point(23, 69);
            this.lblFavorecido.Name = "lblFavorecido";
            this.lblFavorecido.Size = new System.Drawing.Size(63, 13);
            this.lblFavorecido.TabIndex = 8;
            this.lblFavorecido.Text = "Favorecido:";
            // 
            // cboTitular
            // 
            this.cboTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitular.FormattingEnabled = true;
            this.cboTitular.Location = new System.Drawing.Point(91, 26);
            this.cboTitular.Name = "cboTitular";
            this.cboTitular.Size = new System.Drawing.Size(214, 21);
            this.cboTitular.TabIndex = 7;
            this.cboTitular.SelectedIndexChanged += new System.EventHandler(this.CboTitular_SelectedIndexChanged);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.ForeColor = System.Drawing.Color.Navy;
            this.lblTitular.Location = new System.Drawing.Point(47, 30);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(39, 13);
            this.lblTitular.TabIndex = 6;
            this.lblTitular.Text = "Titular:";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblConta);
            this.grpInfo.Controls.Add(this.txtConta);
            this.grpInfo.Controls.Add(this.lblInfoTitular);
            this.grpInfo.Controls.Add(this.txtInfoTitular);
            this.grpInfo.Controls.Add(this.lblSaldo);
            this.grpInfo.Controls.Add(this.txtSaldo);
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.ForeColor = System.Drawing.Color.Navy;
            this.grpInfo.Location = new System.Drawing.Point(335, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(211, 190);
            this.grpInfo.TabIndex = 7;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Informação";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.ForeColor = System.Drawing.Color.Navy;
            this.lblConta.Location = new System.Drawing.Point(60, 45);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(38, 13);
            this.lblConta.TabIndex = 5;
            this.lblConta.Text = "Conta:";
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConta.Location = new System.Drawing.Point(105, 45);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 13);
            this.txtConta.TabIndex = 4;
            // 
            // lblInfoTitular
            // 
            this.lblInfoTitular.AutoSize = true;
            this.lblInfoTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTitular.ForeColor = System.Drawing.Color.Navy;
            this.lblInfoTitular.Location = new System.Drawing.Point(59, 26);
            this.lblInfoTitular.Name = "lblInfoTitular";
            this.lblInfoTitular.Size = new System.Drawing.Size(39, 13);
            this.lblInfoTitular.TabIndex = 3;
            this.lblInfoTitular.Text = "Titular:";
            // 
            // txtInfoTitular
            // 
            this.txtInfoTitular.BackColor = System.Drawing.SystemColors.Menu;
            this.txtInfoTitular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfoTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoTitular.Location = new System.Drawing.Point(104, 26);
            this.txtInfoTitular.Name = "txtInfoTitular";
            this.txtInfoTitular.Size = new System.Drawing.Size(100, 13);
            this.txtInfoTitular.TabIndex = 2;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Navy;
            this.lblSaldo.Location = new System.Drawing.Point(11, 163);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(87, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo Atual (R$):";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(101, 163);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 13);
            this.txtSaldo.TabIndex = 0;
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 209);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpFunc);
            this.Name = "FrmConta";
            this.Text = "frmConta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFunc.ResumeLayout(false);
            this.grpFunc.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.GroupBox grpFunc;
        private System.Windows.Forms.ComboBox cboTitular;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.ComboBox cboFavorecido;
        private System.Windows.Forms.Label lblFavorecido;
        private System.Windows.Forms.Label lblInfoTitular;
        private System.Windows.Forms.TextBox txtInfoTitular;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtConta;
    }
}


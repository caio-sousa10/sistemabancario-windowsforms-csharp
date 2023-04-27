namespace SistemaBancario01
{
    partial class Form_ATM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbox_areaAcesso = new GroupBox();
            label7 = new Label();
            txtb_InserirSaldo = new TextBox();
            lbl_ID = new Label();
            txtb_Inserir_ID = new TextBox();
            btnCriarCP = new Button();
            btn_CriarCCorrente = new Button();
            btn_Transferir = new Button();
            label6 = new Label();
            txtBox_InserirValor_transferencia = new TextBox();
            label5 = new Label();
            label4 = new Label();
            cmbox_contaChegada = new ComboBox();
            cmbox_contaSaida = new ComboBox();
            lbl_mostrar_saldo = new Label();
            label3 = new Label();
            txtbox_inserir_valor = new TextBox();
            label2 = new Label();
            btn_depositar = new Button();
            btn_sacar = new Button();
            cmbox_Contas = new ComboBox();
            label1 = new Label();
            txtbox_inserirNome = new TextBox();
            lbl_nome = new Label();
            gbox_areaAcesso.SuspendLayout();
            SuspendLayout();
            // 
            // gbox_areaAcesso
            // 
            gbox_areaAcesso.Controls.Add(label7);
            gbox_areaAcesso.Controls.Add(txtb_InserirSaldo);
            gbox_areaAcesso.Controls.Add(lbl_ID);
            gbox_areaAcesso.Controls.Add(txtb_Inserir_ID);
            gbox_areaAcesso.Controls.Add(btnCriarCP);
            gbox_areaAcesso.Controls.Add(btn_CriarCCorrente);
            gbox_areaAcesso.Controls.Add(btn_Transferir);
            gbox_areaAcesso.Controls.Add(label6);
            gbox_areaAcesso.Controls.Add(txtBox_InserirValor_transferencia);
            gbox_areaAcesso.Controls.Add(label5);
            gbox_areaAcesso.Controls.Add(label4);
            gbox_areaAcesso.Controls.Add(cmbox_contaChegada);
            gbox_areaAcesso.Controls.Add(cmbox_contaSaida);
            gbox_areaAcesso.Controls.Add(lbl_mostrar_saldo);
            gbox_areaAcesso.Controls.Add(label3);
            gbox_areaAcesso.Controls.Add(txtbox_inserir_valor);
            gbox_areaAcesso.Controls.Add(label2);
            gbox_areaAcesso.Controls.Add(btn_depositar);
            gbox_areaAcesso.Controls.Add(btn_sacar);
            gbox_areaAcesso.Controls.Add(cmbox_Contas);
            gbox_areaAcesso.Controls.Add(label1);
            gbox_areaAcesso.Controls.Add(txtbox_inserirNome);
            gbox_areaAcesso.Controls.Add(lbl_nome);
            gbox_areaAcesso.Location = new Point(12, 12);
            gbox_areaAcesso.Name = "gbox_areaAcesso";
            gbox_areaAcesso.Size = new Size(374, 385);
            gbox_areaAcesso.TabIndex = 0;
            gbox_areaAcesso.TabStop = false;
            gbox_areaAcesso.Text = "Área de acesso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 115);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 25;
            label7.Text = "Saldo:";
            // 
            // txtb_InserirSaldo
            // 
            txtb_InserirSaldo.Location = new Point(65, 112);
            txtb_InserirSaldo.Name = "txtb_InserirSaldo";
            txtb_InserirSaldo.Size = new Size(100, 23);
            txtb_InserirSaldo.TabIndex = 24;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(6, 75);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(54, 15);
            lbl_ID.TabIndex = 23;
            lbl_ID.Text = "Número:";
            // 
            // txtb_Inserir_ID
            // 
            txtb_Inserir_ID.Location = new Point(65, 72);
            txtb_Inserir_ID.Name = "txtb_Inserir_ID";
            txtb_Inserir_ID.Size = new Size(100, 23);
            txtb_Inserir_ID.TabIndex = 22;
            // 
            // btnCriarCP
            // 
            btnCriarCP.Location = new Point(228, 22);
            btnCriarCP.Name = "btnCriarCP";
            btnCriarCP.Size = new Size(78, 50);
            btnCriarCP.TabIndex = 21;
            btnCriarCP.Text = "Criar Conta Poupança";
            btnCriarCP.UseVisualStyleBackColor = true;
            btnCriarCP.Click += btnCriarCP_Click_1;
            // 
            // btn_CriarCCorrente
            // 
            btn_CriarCCorrente.Location = new Point(228, 83);
            btn_CriarCCorrente.Name = "btn_CriarCCorrente";
            btn_CriarCCorrente.Size = new Size(78, 52);
            btn_CriarCCorrente.TabIndex = 20;
            btn_CriarCCorrente.Text = "Criar Conta Corrente";
            btn_CriarCCorrente.UseVisualStyleBackColor = true;
            btn_CriarCCorrente.Click += btn_CriarCCorrente_Click;
            // 
            // btn_Transferir
            // 
            btn_Transferir.Location = new Point(228, 346);
            btn_Transferir.Name = "btn_Transferir";
            btn_Transferir.Size = new Size(100, 31);
            btn_Transferir.TabIndex = 19;
            btn_Transferir.Text = "Transferir";
            btn_Transferir.UseVisualStyleBackColor = true;
            btn_Transferir.Click += btn_Transferir_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 254);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 18;
            label6.Text = "Valor da Transferência";
            // 
            // txtBox_InserirValor_transferencia
            // 
            txtBox_InserirValor_transferencia.Location = new Point(228, 272);
            txtBox_InserirValor_transferencia.Name = "txtBox_InserirValor_transferencia";
            txtBox_InserirValor_transferencia.Size = new Size(100, 23);
            txtBox_InserirValor_transferencia.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 336);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 16;
            label5.Text = "Conta Destinatária";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 254);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 15;
            label4.Text = "Conta Remetente";
            // 
            // cmbox_contaChegada
            // 
            cmbox_contaChegada.FormattingEnabled = true;
            cmbox_contaChegada.Location = new Point(11, 354);
            cmbox_contaChegada.Name = "cmbox_contaChegada";
            cmbox_contaChegada.Size = new Size(121, 23);
            cmbox_contaChegada.TabIndex = 14;
            cmbox_contaChegada.SelectedIndexChanged += cmbox_contaChegada_SelectedIndexChanged_1;
            // 
            // cmbox_contaSaida
            // 
            cmbox_contaSaida.FormattingEnabled = true;
            cmbox_contaSaida.Location = new Point(11, 272);
            cmbox_contaSaida.Name = "cmbox_contaSaida";
            cmbox_contaSaida.Size = new Size(121, 23);
            cmbox_contaSaida.TabIndex = 13;
            cmbox_contaSaida.SelectedIndexChanged += cmbox_contaSaida_SelectedIndexChanged_1;
            // 
            // lbl_mostrar_saldo
            // 
            lbl_mostrar_saldo.AutoSize = true;
            lbl_mostrar_saldo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_mostrar_saldo.Location = new Point(87, 214);
            lbl_mostrar_saldo.Name = "lbl_mostrar_saldo";
            lbl_mostrar_saldo.Size = new Size(34, 17);
            lbl_mostrar_saldo.TabIndex = 12;
            lbl_mostrar_saldo.Text = "R$ 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 216);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 11;
            label3.Text = "Saldo Atual:";
            // 
            // txtbox_inserir_valor
            // 
            txtbox_inserir_valor.Location = new Point(228, 183);
            txtbox_inserir_valor.Name = "txtbox_inserir_valor";
            txtbox_inserir_valor.Size = new Size(100, 23);
            txtbox_inserir_valor.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 165);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Valor";
            // 
            // btn_depositar
            // 
            btn_depositar.Location = new Point(293, 212);
            btn_depositar.Name = "btn_depositar";
            btn_depositar.Size = new Size(75, 23);
            btn_depositar.TabIndex = 8;
            btn_depositar.Text = "Depositar";
            btn_depositar.UseVisualStyleBackColor = true;
            btn_depositar.Click += btn_depositar_Click_1;
            // 
            // btn_sacar
            // 
            btn_sacar.Location = new Point(193, 212);
            btn_sacar.Name = "btn_sacar";
            btn_sacar.Size = new Size(75, 23);
            btn_sacar.TabIndex = 7;
            btn_sacar.Text = "Sacar";
            btn_sacar.UseVisualStyleBackColor = true;
            btn_sacar.Click += btn_sacar_Click_1;
            // 
            // cmbox_Contas
            // 
            cmbox_Contas.FormattingEnabled = true;
            cmbox_Contas.Location = new Point(11, 183);
            cmbox_Contas.Name = "cmbox_Contas";
            cmbox_Contas.Size = new Size(121, 23);
            cmbox_Contas.TabIndex = 6;
            cmbox_Contas.SelectedIndexChanged += cmbox_Contas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 165);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 5;
            label1.Text = "Contas";
            // 
            // txtbox_inserirNome
            // 
            txtbox_inserirNome.Location = new Point(65, 27);
            txtbox_inserirNome.Name = "txtbox_inserirNome";
            txtbox_inserirNome.Size = new Size(100, 23);
            txtbox_inserirNome.TabIndex = 3;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(6, 30);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(43, 15);
            lbl_nome.TabIndex = 2;
            lbl_nome.Text = "Nome:";
            // 
            // Form_ATM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 412);
            Controls.Add(gbox_areaAcesso);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form_ATM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATM";
            gbox_areaAcesso.ResumeLayout(false);
            gbox_areaAcesso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbox_areaAcesso;
        private TextBox txtbox_inserirNome;
        private Label lbl_nome;
        private TextBox txtbox_inserir_valor;
        private Label label2;
        private Button btn_depositar;
        private Button btn_sacar;
        private ComboBox cmbox_Contas;
        private Label label1;
        private Label label5;
        private Label label4;
        private ComboBox cmbox_contaChegada;
        private ComboBox cmbox_contaSaida;
        private Label lbl_mostrar_saldo;
        private Label label3;
        private Button btn_Transferir;
        private Label label6;
        private TextBox txtBox_InserirValor_transferencia;
        private Button btnCriarCP;
        private Button btn_CriarCCorrente;
        private Label lbl_ID;
        private TextBox txtb_Inserir_ID;
        private Label label7;
        private TextBox txtb_InserirSaldo;
    }
}
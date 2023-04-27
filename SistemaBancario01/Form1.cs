namespace SistemaBancario01
{
    public partial class Form_ATM : Form
    {
        public List<Conta> listContas { get; set; }
        public Conta contaAtual1 { get; set; }

        public Conta contaAtual2 { get; set; }

        public Form_ATM()
        {
            InitializeComponent();
            listContas = new List<Conta>();
        }
        private void btnCriarCP_Click_1(object sender, EventArgs e)
        {
            // Exemplo de objeto/instancia

            Cliente cliente = new Cliente();

            // exemplo de encapsulamento

            cliente.SetNome(txtbox_inserirNome.Text);


            // Exemplo de Polimorfismo

            Conta conta = new ContaPoupanca(cliente);
            conta.SetNumero(Convert.ToInt32(txtb_Inserir_ID.Text));
            conta.SetSaldo(Convert.ToDouble(txtb_InserirSaldo.Text));

            listContas.Add(conta);
            AtualizarComboboxesTransf();
            AtualizarComboBox();

            txtbox_inserirNome.Text = "";
            txtb_Inserir_ID.Text = "";
            txtb_InserirSaldo.Text = "";
        }

        private void btn_CriarCCorrente_Click(object sender, EventArgs e)
        {
            // Exemplo de objeto/instancia

            Cliente cliente = new Cliente();
            cliente.SetNome(txtbox_inserirNome.Text);


            // Exemplo de Polimorfismo

            Conta conta = new ContaCorrente(cliente);
            conta.SetNumero(Convert.ToInt32(txtb_Inserir_ID.Text));
            conta.SetSaldo(Convert.ToDouble(txtb_InserirSaldo.Text));

            listContas.Add(conta);
            AtualizarComboboxesTransf();
            AtualizarComboBox();

            txtbox_inserirNome.Text = "";
            txtb_Inserir_ID.Text = "";
            txtb_InserirSaldo.Text = "";
        }

        private void AtualizarComboBox()
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listContas;
            cmbox_Contas.DataSource = null;
            cmbox_Contas.Items.Clear();
            cmbox_Contas.DisplayMember = "Numero";
            cmbox_Contas.ValueMember = "Numero";
            cmbox_Contas.DataSource = bindingSource1.DataSource;
            cmbox_Contas.SelectedIndex = 0;
        }

        private void AtualizarComboboxesTransf()
        {
            // mostrando as propriedades que serão mostradas
            cmbox_contaSaida.DisplayMember = "Numero";
            cmbox_contaSaida.ValueMember = "Numero";
            cmbox_contaChegada.DisplayMember = "Numero";
            cmbox_contaChegada.ValueMember = "Numero";

            // instanciando novo objeto para a escolha nao interferir o outro combobox
            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = listContas;

            // instanciando novo objeto para a escolha nao interferir o outro combobox
            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = listContas;

            //linkando combobox com sua fonte de dados que contem a lista de contas
            cmbox_contaSaida.DataSource = bindingSource2;
            cmbox_contaChegada.DataSource = bindingSource3;
        }

        private void cmbox_Contas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // variavel local com safe cast
            Conta selectedConta = cmbox_Contas.SelectedItem as Conta;
            if (selectedConta != null)
            {
                contaAtual1 = selectedConta;
                lbl_mostrar_saldo.Text = "R$ " + Math.Round(contaAtual1.GetSaldo(), 2).ToString();
            }
        }

        private void btn_sacar_Click_1(object sender, EventArgs e)
        {
            // variavel local
            double valor = Convert.ToDouble(txtbox_inserir_valor.Text);
            if (contaAtual1 != null)
            {
                if (contaAtual1.Sacar(valor))
                {
                    lbl_mostrar_saldo.Text = "R$ " + Math.Round(contaAtual1.GetSaldo(), 2).ToString();
                    MessageBox.Show("Saque realizado com sucesso!");
                    txtbox_inserir_valor.Text = "";
                }

                else
                {
                    MessageBox.Show("Não foi possível realizar o saque");
                    txtbox_inserir_valor.Text = "";
                }
            }
        }

        private void btn_depositar_Click_1(object sender, EventArgs e)
        {
            // variavel local
            double valor = Convert.ToDouble(txtbox_inserir_valor.Text);
            if (contaAtual1 != null)
            {
                contaAtual1.Depositar(contaAtual1, valor);
                lbl_mostrar_saldo.Text = "R$ " + Math.Round(contaAtual1.GetSaldo(), 2).ToString();
                MessageBox.Show("Depósito realizado com sucesso!");
                txtbox_inserir_valor.Text = "";
            }
        }

        private void btn_Transferir_Click_1(object sender, EventArgs e)
        {
            // variaveis locais com safe cast
            Conta selectedConta = cmbox_contaSaida.SelectedItem as Conta;
            Conta selectedConta2 = cmbox_contaChegada.SelectedItem as Conta;
            double valor = Convert.ToDouble(txtBox_InserirValor_transferencia.Text);
            if (selectedConta != null && selectedConta2 != null)
            {
                if (selectedConta.Transferir(selectedConta, selectedConta2, valor))
                {
                    lbl_mostrar_saldo.Text = "R$ " + Math.Round(selectedConta.GetSaldo(), 2).ToString();
                    MessageBox.Show("Transferência realizada com sucesso!");
                    txtBox_InserirValor_transferencia.Text = "";
                    cmbox_contaChegada.Text = "";
                    cmbox_contaSaida.Text = "";
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente!");
                    txtBox_InserirValor_transferencia.Text = "";
                }
            }
        }

        private void cmbox_contaChegada_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // variavel local com safe cast
            Conta selectedConta = cmbox_contaChegada.SelectedItem as Conta;
            if (selectedConta != null)
            {
                contaAtual2 = selectedConta;
            }
        }

        private void cmbox_contaSaida_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // variavel local com safe cast
            Conta selectedConta = cmbox_contaSaida.SelectedItem as Conta;
            if (selectedConta != null)
            {
                contaAtual1 = selectedConta;
            }
        }
    }
}
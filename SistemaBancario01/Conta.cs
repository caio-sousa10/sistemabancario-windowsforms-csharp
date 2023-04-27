namespace SistemaBancario01
{
    // abstração (passando para o código a ideia e o que o sistema precisa)

    public class Conta
    {
        // colocando propriedades e encapsulamento (restringindo acesso com modificadores)

        // propriedades = tem o get; set; para conseguir modificar valor

        private double Saldo { get; set; }

        // conseguimos ter visualizacao e proteger o set (encapsulamento)

        public int Numero { get; protected set; }
        private Cliente Cliente { get; set; }

        // construtor sobrecarregado (obrigando que haja um cliente)

        public Conta(Cliente cliente)
        {
            Cliente = cliente;
            Saldo = 0;
        }

        // métodos com parâmetro obrigatório de algum valor para operação 
        // modificador protected para acesso somente por herança e com
        // a palavra virtual para permitir implementação no método em classes filhas

        //  palavra virtual para realizar o Polimorfismo

        public virtual void Depositar(Conta contaRementente, double valor)
        {
            Saldo += valor; // depósito realiza o valor do saldo + o novo valor
        }

        public virtual bool Sacar(double valor)
        {
            // verifica se é possível sacar esse valor
            if (valor > Saldo)
            {
                MessageBox.Show("Não há saldo com esse valor para ser sacado");
                return false;

            }
            else
            {
                Saldo -= valor; // saque é ao contrário do depósito
                return true;
            }
        }

        // método com paramêtros obrigatórios (informar conta que receberá o valor também)

        public bool Transferir(Conta contaAtual1, Conta contaAtual2, double valor)
        {
            // verifica se é possível transferir esse valor

            if (valor > Saldo)
            {
                MessageBox.Show("Valor não disponível para transferência");
                return false;
            }
            else
            {
                contaAtual1.Sacar(valor);
                contaAtual2.Depositar(contaAtual2, valor);
                return true;
            }
        }

        // métodos para acesso as propriedades pelo encapsulamento
        public double GetSaldo()
        {
            return Saldo;
        }

        public void SetSaldo(double valor)
        {
            Saldo = valor;
        }

        public int GetNumero()
        {
            return Numero;
        }

        public void SetNumero(int numero)
        {
            Numero = numero;
        }

        public Cliente GetCliente()
        {
            return Cliente;
        }

        public void SetCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
    }
}

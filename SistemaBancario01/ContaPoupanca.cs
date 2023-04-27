namespace SistemaBancario01
{
    // exemplo de herança (herdando métodos e propriedades) da classe pai Conta

    public class ContaPoupanca : Conta
    {
        // construtor com sobrecarga, referenciando construtor da classe que foi herdada
        // utilizando a palavra base e passando um objeto

        public ContaPoupanca(Cliente cliente) : base(cliente)
        {

        }

        // método modificado para saque conta corrente
        // fornecendo uma implementação específica do método com a palavra override

        // exemplo Polimorfismo
        public override bool Sacar(double valor)
        {
            if (valor <= 1000 && valor < GetSaldo())
            {
                // chamando método da classe pai(método base) com a palavra base
                base.Sacar(valor + 0.1);
                return true;
            }
            else if (valor == GetSaldo())
            {
                MessageBox.Show("Valor não cobre a taxa de saque (10 centavos)");
                return false;
            }
            else if (valor > 1000)
            {
                MessageBox.Show("O valor excede o limite de saque");
                return false;
            }
            else
            {
                MessageBox.Show("Digite um valor válido");
                return false;
            }
        }
    }
}

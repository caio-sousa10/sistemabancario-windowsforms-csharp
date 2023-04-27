namespace SistemaBancario01
{
    // abstração (passando para o código a ideia e o que o sistema precisa)


    // exemplo de herança (herdando métodos e propriedades) da classe pai Conta

    public class ContaCorrente : Conta
    {
        // construtor com sobrecarga, referenciando construtor da classe que foi herdada
        // utilizando a palavra base e passando um objeto

        public ContaCorrente(Cliente cliente) : base(cliente)
        {

        }

        // método modificado para saque conta corrente
        // fornecendo uma implementação específica do método com a palavra override


        //exemplo Polimorfismo
        public override bool Sacar(double valor)
        {
            // chamando método da classe pai(método base) com a palavra base
            if (valor > 0 && valor < GetSaldo())
            {
                base.Sacar(valor + 0.2);
                return true;
            }
            else if (valor == GetSaldo())
            {
                MessageBox.Show("Valor não cobre a taxa de saque (20 centavos)");
                return false;
            }
            else
            {
                MessageBox.Show("O valor excede o saldo da conta");
                return false;
            }
        }
    }
}

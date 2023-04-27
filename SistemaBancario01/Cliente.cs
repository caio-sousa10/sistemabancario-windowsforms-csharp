namespace SistemaBancario01
{
    // abstração (passando para o código a ideia e o que o sistema precisa)

    public class Cliente
    {
        // propriedades privadas da classe publica (encapsulamento para evitar acesso não autorizado)

        private string Nome { get; set; }
        private Endereco Endereço { get; set; }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public Endereco GetEndereco() 
        {
            return Endereço;
        }
    }
}

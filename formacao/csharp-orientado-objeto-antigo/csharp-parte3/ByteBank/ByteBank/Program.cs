using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor diana = new Diretor(5000, "987.654.321-32");
            diana.Nome = "Diana";
            diana.Senha = "123";

            GerenteDeConta francisco = new GerenteDeConta(3000, "654.285.841-63");
            francisco.Nome = "Francisco";
            francisco.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(diana, "123");
            sistemaInterno.Logar(francisco, "abc");
            sistemaInterno.Logar(parceiro, "123456");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario anna = new Designer(2000, "883.654.222-98");
            anna.Nome = "Anna";

            Funcionario diana = new Diretor(5000, "987.654.321-32");
            diana.Nome = "Diana";

            Funcionario luis = new Auxiliar(1500, "123.456.789-54");
            luis.Nome = "Anna";

            Funcionario francisco = new GerenteDeConta(3000, "654.285.841-63");
            francisco.Nome = "Francisco";

            Funcionario caio = new Desenvolvedor(3000, "147.258.369-24");
            francisco.Nome = "Caio";

            gerenciadorBonificacao.Registrar(anna);
            gerenciadorBonificacao.Registrar(diana);
            gerenciadorBonificacao.Registrar(luis);
            gerenciadorBonificacao.Registrar(francisco);
            gerenciadorBonificacao.Registrar(caio);

            Console.WriteLine("Total de bonificação do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}

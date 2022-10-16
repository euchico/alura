
namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}

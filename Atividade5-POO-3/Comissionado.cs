namespace Atividade5_POO_3
{
    public class Comissionado : Empregado
    {
        public double TotalVenda { get; set; }
        public double TaxaComissao { get; set; }
        public override double Vencimento()
        {

            double taxaDecimal = TaxaComissao / 100.00;

            double lucro = TotalVenda * taxaDecimal;

            return lucro;

        }
        public void Cadastro()
        {
            Console.Write("Digite o seu nome: ");

            Nome = Console.ReadLine();

            Console.Write("Digite o seu sobrenome: ");

            Sobrenome = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");

            Cpf = Console.ReadLine();

            Console.Write("Digite o valor do total de vendas: ");

            TotalVenda = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da comissão(em %): ");

            TaxaComissao = Convert.ToDouble(Console.ReadLine());
        }
        public void GetInfos()
        {
            Console.WriteLine($"----------------------");
            Console.WriteLine($"Seu nome é: {Nome}");
            Console.WriteLine($"Seu sobrenome é: {Sobrenome}");
            Console.WriteLine($"Seu CPF é: {Cpf}");
            Console.WriteLine("Seu salário é: " + Vencimento());
            Console.WriteLine($"----------------------");
        }
    }
}

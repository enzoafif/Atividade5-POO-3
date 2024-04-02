namespace Atividade5_POO_3
{
    public class Horista : Empregado
    {
        public double PrecoHora { get; set; }
        public double HorasTrabalhadas { get; set; }
        public override double Vencimento()
        {
            return PrecoHora * HorasTrabalhadas;
        }
        public void Cadastro()
        {
            Console.Write("Digite o seu nome: ");

            Nome = Console.ReadLine();

            Console.Write("Digite o seu sobrenome: ");

            Sobrenome = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");

            Cpf = Console.ReadLine();

            Console.Write("Digite o preço da sua hora: ");

            PrecoHora = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de horas trabalhadas: ");

            HorasTrabalhadas = Convert.ToDouble(Console.ReadLine());
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

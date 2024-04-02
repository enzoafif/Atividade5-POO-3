namespace Atividade5_POO_3
{
    public class Assalariado : Empregado
    {
        public double Salario { get; set; }

        public override double Vencimento()
        {
            return Salario;
        }

        public void Cadastro()
        {
            Console.Write("Digite o seu nome: ");

            Nome = Console.ReadLine();

            Console.Write("Digite o seu sobrenome: ");

            Sobrenome = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");

            Cpf = Console.ReadLine();

            Console.Write("Digite o seu salário: ");

            Salario = Convert.ToDouble(Console.ReadLine());

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

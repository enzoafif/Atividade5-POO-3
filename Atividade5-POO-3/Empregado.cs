namespace Atividade5_POO_3
{
    abstract public class Empregado
    {
        protected string? Nome { get; set; }
        protected string? Sobrenome { get; set; }
        protected string? Cpf { get; set; }

        abstract public double Vencimento();
    }
}

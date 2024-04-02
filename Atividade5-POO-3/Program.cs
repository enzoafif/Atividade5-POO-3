using Atividade5_POO_3;

bool loop = true;

while (loop)
{
    Console.WriteLine("Escolha um tipo de empregado\n");

    Console.WriteLine("1-Assalariado");
    Console.WriteLine("2-Comissionado");
    Console.WriteLine("3-Horista");
    Console.WriteLine("4-Sair do programa");

    int escolha = Convert.ToInt32(Console.ReadLine());
    Assalariado assalariado = new();
    Comissionado comissionado = new();
    Horista horista = new();

    switch (escolha)
    {
        case 1:

            assalariado.Cadastro();
            assalariado.GetInfos();
            break;

        case 2:
            comissionado.Cadastro();
            comissionado.GetInfos();
            break;

        case 3:
            horista.Cadastro();
            horista.GetInfos();
            break;

        case 4:
            loop = false;
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente");
            break;
    }
}

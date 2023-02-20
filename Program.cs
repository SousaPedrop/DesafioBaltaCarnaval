using DesafioBaltaCarnaval;

bool exibirMenu = true;

while (exibirMenu)
{
    Menu();
}

void Menu()
{
    Console.Clear();

    Console.WriteLine("Escolha o que deseja fazer: \n");

    Console.WriteLine("1 - Contar a quantidade de caracteres e palavras de uma entrada.");
    Console.WriteLine("2 - Calcular IMC.");
    Console.WriteLine("3 - Escolher entre gasolina ou álcool.");
    Console.WriteLine("4 - Calcular troco.");
    // Console.WriteLine("5 - Aguardando...");
    // Console.WriteLine("6 - Aguardando...");
    // Console.WriteLine("7 - Aguardando...");
    Console.WriteLine("0 - Encerrar programa \n");

    int escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 0:
            Console.WriteLine("Encerrando o programa...");
            exibirMenu = false;
            break;
        case 1:
            PrimeiroDia.ContarLetrasEPalavras();
            break;
        case 2:
            SegundoDia.CalcularIMC();
            break;
        case 3:
            TerceiroDia.EscolherGasolinaOuAlcool();
            break;
        case 4:
            QuartoDia.PassarTroco();
            break;
        // case 5: System.Console.WriteLine("Aguardando...");
        //         break;
        // case 6: System.Console.WriteLine("Aguardando...");
        //         break;
        // case 7: System.Console.WriteLine("Aguardando...");
        //         break;
        default:
            Console.WriteLine("Por favor, escolher uma das opções válidas");
            Console.ReadKey();
            break;
    }
}
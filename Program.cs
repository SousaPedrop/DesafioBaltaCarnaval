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
    Console.WriteLine("5 - Descobrir valor por extenso.");
    Console.WriteLine("6 - Encriptar texto.");
    // Console.WriteLine("7 - Aguardando...");
    Console.WriteLine("0 - Encerrar programa \n");

    if (int.TryParse(Console.ReadLine(), out int escolha))
    {
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
            case 5:
                QuintoDia.ValorPorExtenso();
                break;
            case 6:
                SextoDia.EncriptarTexto();
                break;
            // case 7: System.Console.WriteLine("Aguardando...");
            //         break;
            default:
                Console.WriteLine("Por favor, escolher uma das opções válidas");
                Console.ReadKey();
                break;
        }
    }
}


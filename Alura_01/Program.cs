//PROJETO SCREEN SOUD - ALURA 01

string mensssagemBoasVindas = "Boas vindas ao Screen Sound! ";
//CRIA UMA LISTA DE STRING
List<string> listaBandas = new List<string> { };

//FUNÇÃO VOID SEM RETORNO
void ExibirTitulo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensssagemBoasVindas);
}

void ExibirMenu()
{
    Console.WriteLine("\n 1 para registrar banda");
    Console.WriteLine(" 2 para mostar todas as bandas");
    Console.WriteLine(" 3 para avaliar banda");
    Console.WriteLine(" 4 para exibir a média de uma banda");
    Console.WriteLine("-1 para sair");

    Console.WriteLine("\n Digite a sua opção: ");
    string inputResposta = Console.ReadLine()!;
    int resposta = int.Parse(inputResposta);

    switch (resposta)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ListaBandas();
            break;
        case 3: Console.WriteLine("avalie uma banda: ");
            break;
        case 4: Console.WriteLine("a média da banda: ");
            break;
        case -1: Console.WriteLine("sair");
            break;
        default: Console.WriteLine("erro");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas: ");
    Console.WriteLine("Qual o nome da Banda? ");
    string inputBanda = Console.ReadLine()!;
    listaBandas.Add(inputBanda);
    Console.WriteLine($"A Banda {inputBanda} foi registrada com sucesso!");
    
    
    ExibirMenu();
}

void ListaBandas()
{
   //for(int i = 0; i < listaBandas.Count; i++)
    //{
      //  Console.WriteLine(listaBandas[i]);
    //}

    foreach (string banda in listaBandas)
    {
        Console.WriteLine(banda);
    }
}

void ExibirTituloOpcoes(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
}

ExibirTitulo();
ExibirMenu();
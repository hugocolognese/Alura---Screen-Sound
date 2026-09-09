//PROJETO SCREEN SOUD - ALURA 01

string mensssagemBoasVindas = "Boas vindas ao Screen Sound! ";
//CRIA UMA LISTA DE STRING
//List<string> listaBandas = new List<string> { };

//DICIONARIO DAS BANDAS COM NOTAS
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>> { };

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
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMediaBandas();
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
    ExibirTituloOpcoes("Registrar Bandas: ");
    Console.WriteLine("Qual o nome da Banda? ");
    string inputBanda = Console.ReadLine()!;
    bandasRegistradas.Add(inputBanda, new List<int>());
    Console.WriteLine($"A Banda {inputBanda} foi registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirMenu();
}

void ListaBandas()
{
    ExibirTituloOpcoes("Lista de Bandas: ");
   //for(int i = 0; i < listaBandas.Count; i++)
    //{
      //  Console.WriteLine(listaBandas[i]);
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine(banda);
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenu();
    }
}

void ExibirTituloOpcoes(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos +"\n");
}

void AvaliarBanda()
{
    ExibirTituloOpcoes("Avaliar Banda: ");
    Console.WriteLine("qual banda deseja avaliar? ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.WriteLine($"qual a nota da banda {nomeBanda}");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"a nota da {nomeBanda} é {nota}");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenu();
    }else
    {
        Console.WriteLine("nome da banda nao fi encontrada");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenu(); 
    }
}

void ExibirMediaBandas()
{
    ExibirTituloOpcoes("qual banda deseja avaliar?");
    string bandaAvaliada = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(bandaAvaliada))
    {

    }

}

ExibirTitulo();
ExibirMenu();
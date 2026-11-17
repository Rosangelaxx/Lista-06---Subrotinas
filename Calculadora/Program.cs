int opcao;

do
{
    ExibirMenu();
    opcao = LerInteiro();

    switch (opcao)
    {
        case 1:
            ExecutarOperacao("Adição", Adicao);
            break;
        case 2:
            ExecutarOperacao("Subtração", Subtracao);
            break;
        case 3:
            ExecutarOperacao("Multiplicação", Multiplicacao);
            break;
        case 4:
            Divisao();
            break;
        case 0:
            Console.WriteLine("Programa encerrado.");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }

    Console.WriteLine();
} while (opcao != 0);

// ---------- Sub-rotinas ----------

void ExibirMenu()
{
    Console.WriteLine("Calculadora");
    Console.WriteLine();
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("0 - Sair");
    Console.WriteLine();
    Console.Write("Opção: ");
}

int LerInteiro()
{
    int valor;
    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Valor inválido. Digite um número inteiro: ");
    }
    return valor;
}

double LerNumero(string mensagem)
{
    double valor;
    Console.Write(mensagem);
    while (!double.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Valor inválido. Digite um número: ");
    }
    return valor;
}

double Adicao(double a, double b)
{
    return a + b;
}

double Subtracao(double a, double b)
{
    return a - b;
}

double Multiplicacao(double a, double b)
{
    return a * b;
}

void Divisao()
{
    double a = LerNumero("Digite o primeiro número: ");
    double b = LerNumero("Digite o segundo número: ");

    if (b == 0)
    {
        Console.WriteLine("Erro: não é possível dividir por zero.");
        return;
    }

    Console.WriteLine($"Resultado da Divisão: {a} / {b} = {a / b}");
}

void ExecutarOperacao(string nome, Func<double, double, double> operacao)
{
    double a = LerNumero("Digite o primeiro número: ");
    double b = LerNumero("Digite o segundo número: ");

    double resultado = operacao(a, b);
    Console.WriteLine($"Resultado da {nome}: {resultado}");
}

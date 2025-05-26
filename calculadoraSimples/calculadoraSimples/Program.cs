using System;

   class Program
{
    static void Main(string[] args)
    { 
Console.WriteLine("=== CALCULADORA SIMPLES ===");
Console.WriteLine("Escolha uma operação");
Console.WriteLine("1 - Soma (+)");
Console.WriteLine("2 - Subtração (-)");
Console.WriteLine("3 - Multiplicação (*)");
Console.WriteLine("4 - Divisão (/)");

Console.Write("Digite o número da operação desejada; ");
int operacao = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o primeiro número; ");
int num1 = (int)Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número; ");
int num2 = (int)Convert.ToDouble(Console.ReadLine());

double resultado = 0;
bool operacaoValida = true;

switch (operacao)
{
    case 1:
        resultado = num1 + num2;
        break;
            case 2:
        resultado = num1 - num2;
        break;
    case 3:
        resultado = num1 * num2;
        break;
    case 4:
        resultado = num1 / num2;
            break;
        if (num2 != 0)
            resultado = num1 / num2;
        else
        {
            Console.WriteLine("erro: divisão por zero não é permitido.");
            operacaoValida = false;
        }
        break;
    default:
        Console.WriteLine("Operação inválido.");
        operacaoValida = false; 
        break;
        }
        if (operacaoValida)
        {
            {
                Console.WriteLine("resultado: " + resultado);
            }
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
using System;

namespace calculadorainutil {

    class Program {

        static void Main(string[] args) {
            retorno1();
            Console.ReadKey();

        }

        static bool retorno1() {

                // Opções de Cálculo:

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Multiplicação");
                Console.WriteLine("3 - Subtração");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("");
                Console.WriteLine("5 - Sair");

                // Fim das Opções.

                // Declaração das Variaveis:

                string resposta = Console.ReadLine();
                int valor1, valor2, resposta1;

                // Fim das Declarações.
                
                switch(resposta) {

                    case "1":
                        Console.Clear();
                        Console.WriteLine("(ADIÇÃO):");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o primeiro valor:");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());

                        resposta1 = (valor1 + valor2);
                        Console.WriteLine("");
                        Console.WriteLine("A resposta é: {0}", resposta1);
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao inicio");
                        Console.ReadKey();
                        Console.Clear();
                        return retorno1();

                    case "2":
                        Console.Clear();
                        Console.WriteLine("(MULTIPLICAÇÃO):");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o primeiro valor:");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());

                        resposta1 = (valor1 * valor2);
                        Console.WriteLine("");
                        Console.WriteLine("A resposta é: {0}", resposta1);
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao inicio");
                        Console.ReadKey();
                        Console.Clear();
                        return retorno1();

                    case "3":
                        Console.Clear();
                        Console.WriteLine("(SUBTRAÇÃO):");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o primeiro valor:");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());

                        resposta1 = (valor1 - valor2);
                        Console.WriteLine("");
                        Console.WriteLine("A resposta é: {0}", resposta1);
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao inicio");
                        Console.ReadKey();
                        Console.Clear();
                        return retorno1();

                    case "4":
                        Console.Clear();
                        Console.WriteLine("(DIVISÃO):");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o primeiro valor:");
                        valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("");
                        Console.WriteLine("A resposta é: {0}", (double)valor1 / valor2);
                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao inicio");
                        Console.ReadKey();
                        Console.Clear();
                        return retorno1();

                    case "5":
                        Environment.Exit(0);
                        break;
                }
                    Console.Clear();
                    return resposta == "1" || resposta == "2" || resposta == "3" || resposta == "4" || resposta == "5" ? true : retorno1();
        }
    }
}
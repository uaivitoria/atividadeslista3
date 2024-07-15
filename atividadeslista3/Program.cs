using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeslista3
{
    internal class Program
    {
           
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                opcao = Menu();
                OpcaoMenu(opcao);

            } while (opcao != 0);
        }

        static void OpcaoMenu(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Questao1();
                    break;
                case 2:
                    Questao2();
                    break;
                case 3:
                    Console.Clear();
                    Questao3();
                    break;
                case 4:
                    Console.Clear();
                    Questao4();
                    break;
                case 5:
                    Console.Clear();
                    Questao5();
                    break;
                case 6:
                    Console.Clear();
                    Questao6();
                    break;
                case 7:
                    Console.Clear();
                    Questao7();
                    break;
                case 8:
                    Console.Clear();
                    Questao8();
                    break;
                case 9:
                    Console.Clear();
                    Questao9();
                    break;
                case 10:
                    Console.Clear();
                    Questao10();
                    break;
            }
        }

        static int Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Questão 1;");
            Console.WriteLine("2 - Questão 2;");
            Console.WriteLine("3 - Questão 3;");
            Console.WriteLine("4 - Questão 4;");
            Console.WriteLine("5 - Questão 5;");
            Console.WriteLine("6 - Questão 6;");
            Console.WriteLine("7 - Questão 7;");
            Console.WriteLine("8 - Questão 8;");
            Console.WriteLine("9 - Questão 9;");
            Console.WriteLine("10 - Questão 10;");
            Console.WriteLine("--------------------");
            Console.Write("Escolha aqui sua opção: ");
            int questao = Convert.ToInt32(Console.ReadLine());
            return questao;
        }

        static void Questao1()
        {
            Console.Clear();
            int[] numeros1 = new int[10];
            int[] multiplica = new int[10];

            for (int i = 0; i < numeros1.Length; i++)
            {
                Console.WriteLine($"Escreva aqui um número inteiro para a sequencia {i + 1}: ");
                numeros1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numeros1.Length - 1; i++)
            {
                multiplica[i] = numeros1[i] * numeros1[i + 1];
            }

            multiplica[multiplica.Length - 1] = numeros1[numeros1.Length - 1];

            Console.WriteLine($"Números escolhidos: ");
            foreach (int num in numeros1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


            Console.Write("Números multiplicados: ");
            foreach (int num in multiplica)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            Console.Write("Aperte qualquer tecla para voltar ao menu");

            Console.ReadKey();

        }


        static void Questao2()
        {
            Console.Clear();

            int[] numeros1 = new int[5];
            int[] numeros2 = new int[5];

            for (int i = 0; i < numeros1.Length; i++)
            {
                Console.WriteLine($"Escreva aqui um numero para a sequencia {i + 1}: ");
                numeros1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numeros1.Length; i++)
            {
                numeros2[i] = numeros1[numeros1.Length - 1 - i];
            }

            Console.WriteLine("Os numeros em sequencia inversa são: ");
            foreach (int num in numeros2)
            {
                Console.Write(num + " ");
            }


            Console.ReadKey();
        }

        static void Questao3()
        {
            Console.Clear();

            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int[,] matrizC = new int[4, 4];

            Console.Clear();
            Console.Write("informe os números da primeira matriz: ");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.WriteLine($"Informe os valores da primeira matriz [{i},{j}]: ");
                    matrizA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Preencha a segunda matriz:");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.WriteLine($"Informa os valores da segunda matriz [{i},{j}]: ");
                    matrizB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];

                }

                Console.WriteLine("A soma das matrizes é: ");
                for (int k = 0; k < matrizC.GetLength(0); k++)
                {
                    for (int j = 0; j < matrizC.GetLength(1); j++)
                    {
                        Console.Write(matrizC[k, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadKey();



        }

        static void Questao4()
        {
            Console.Clear();

            string[] meses = { "Janeiro", "Fevereiro", "Marco", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };



            int[,] vendas = new int[12, 4]
            {
                {100,20,60,80}, //janeiro
                {10,200,25,40}, //feveiro
                {100,20,60,50}, //marco
                {100,20,60,60}, //abril
                {100,20,60,70}, //maio
                {100,20,60,80}, //junho
                {100,20,60,90}, //julho
                {100,20,60,55}, //agosto
                {20,80,100,80}, //setembro
                {100,10,60,80}, //outubro
                {100,30,80,80}, //novembro
                {100,80,60,80}  //dezembro
            };


            for (int l = 0; l < 12; l++)
            {
                int soma = 0;
                string valoresSemanais = null;
                for (int c = 0; c < 4; c++)
                {
                    soma = soma + vendas[l, c];
                    valoresSemanais += $"{vendas[l, c]}, ";
                }
                Console.WriteLine(meses[l] + ": " + soma);
                Console.WriteLine(valoresSemanais);
            }

            int somaanual = 0;

            for (int i = 0; i < vendas.GetLength(0); i++)
            {
                for (int j = 0; j < vendas.GetLength(1); j++)
                {
                    somaanual += vendas[i, j];
                }

            }
            Console.WriteLine($"A soma das vendas do ano é: {somaanual}");


            Console.ReadKey();




        }

        static void Questao5()
        {
            List<string> cores = new List<string> { "Branco", "Vermelho", "Amarelo", "Azul", "Rosa" };

            Console.WriteLine("A lista inicial de cores: ");
            for (int i = 0; i < cores.Count; i++)
            {
                Console.WriteLine(cores[i]);
            }

            cores.RemoveRange(0, 3);

            cores.AddRange(new List<string> { "branco", "Vermelho", "Amarelo" });

            Console.WriteLine("A lista final de cores: ");
            for (int i = 0; i < cores.Count; i++)
            {
                Console.WriteLine(cores[i]);
            }
            Console.ReadKey();
        }
        static void Questao6() //nao precisa exibir a lista?? 
        {
            int opcaoMenu;
            List<string> Usuarios = new List<string>();

            do
            {
                opcaoMenu = Menu6();


                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine("Escreva aqui o nome do usuario: ");
                        string novousuario = Console.ReadLine();
                        Usuarios.Add(novousuario);
                        Console.WriteLine($"Usuario  {novousuario} adicionado");
                        break;

                    case 2:
                        Console.WriteLine("Escreva o usuario que deseja remover: ");
                        string usuarioremover = Console.ReadLine();
                        Usuarios.Remove(usuarioremover);
                        Console.WriteLine("Usuario removido!");
                        break;

                    case 3:
                        Console.WriteLine("Escreva aqui o usuario que deseja remover: ");
                        string usuariosubstituir = Console.ReadLine();

                        Console.WriteLine("Escreva aqui o novo usuario: ");
                        string usuariosubstituido = Console.ReadLine();

                        int substituir = Usuarios.IndexOf(usuariosubstituir);

                        if (substituir != -1)
                        {
                            Usuarios[substituir] = usuariosubstituido;
                            Console.WriteLine($"Usuário '{usuariosubstituir}' substituído por '{usuariosubstituido}'.");
                        }
                        else
                        {
                            Console.WriteLine($"Usuário '{usuariosubstituir}' não encontrado na lista.");
                        }
                        break;

                    case 4:
                        Usuarios.Clear();
                        Console.WriteLine("Lista de usuarios limpa com sucesso");
                        break;

                }

            } while (opcaoMenu != 0);




            Console.ReadKey();
        }

        static int Menu6()
        {

            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Adicionar usuário");
            Console.WriteLine("2 - Remover usuário");
            Console.WriteLine("3 - Substituir usuário");
            Console.WriteLine("4 - Limpar lista");
            Console.Write("Escolha sua opção: ");
            int opcao = int.Parse(Console.ReadLine());

            return opcao;
        }

        static void Questao7()
        {
            string[] pilha = { "prato1", "prato2", "prato3", "prato4", "prato5" };

            Console.WriteLine("A lista de pratos completa: ");
            for (int i = 0; i < pilha.Length; i++)
            {
                Console.Write(pilha[i] + ", ");
            }

            Array.Resize(ref pilha, pilha.Length - 2);


            Array.Resize(ref pilha, pilha.Length + 1);
            pilha[pilha.Length - 1] = "Prato6";

            Console.WriteLine(" ");
            Console.WriteLine("A nova lista de pratos: ");
            foreach (var i in pilha)
            {
                Console.WriteLine($" {i}");
            }

            Console.ReadKey();
        }

        static void Questao8() //ajuda da barbara do 4° período.
        {
            Stack<string> A = new Stack<string>();
            Stack<string> B = new Stack<string>();
            Stack<string> C = new Stack<string>();

            // Inserindo itens na pilha A
            A.Push("B3");
            A.Push("B2");
            A.Push("B1");

            // Reordenando
            C.Push(A.Pop()); // pega o 1, desempilha do A e empilha no C
            C.Push(A.Pop()); // pega o 2, desempilha do A e empilha no C

            B.Push(A.Pop()); // pega o 3, desempilha do A e empilha no B
            B.Push(C.Pop()); // pega o 2, desempilha do c e empilha no B
            B.Push(C.Pop()); // pega o 1, desempilha do c e empilha no B

            // OBS: string.Join() => concatena os itens de um vetor separando pelo primeiro parametro
            // primeiro parametro: elemento que ficará entre os itens
            // segundo parametro: vetor de origem dos itens
            Console.WriteLine("Elementos da pilha A:");
            Console.WriteLine(string.Join(",", A) + "\r\n");

            Console.WriteLine("Elementos da pilha B:");
            Console.WriteLine(string.Join(",", B) + "\r\n");

            Console.WriteLine("Elementos da pilha C:");
            Console.WriteLine(string.Join(",", C) + "\r\n");

            Console.ReadKey();

        }

        static void Questao9()
        {
            Queue<string> filapessoas = new Queue<string>();
            filapessoas.Enqueue("Pessoa1");
            filapessoas.Enqueue("Pessoa2");
            filapessoas.Enqueue("Pessoa3");
            filapessoas.Enqueue("Pessoa4");
            filapessoas.Enqueue("Pessoa5");

            filapessoas.Dequeue();
            filapessoas.Dequeue();

            filapessoas.Enqueue("pessoa6");

            Console.WriteLine($"A fila de pessoas é: ");
            for (int i = 0; i < filapessoas.Count; i++)
            {
                Console.WriteLine(filapessoas.ElementAt(i));
            }

            Console.ReadKey();
        }

        static void Questao10()
        {
            //criar 2 filas
            Queue<int> fila1 = new Queue<int>();
            fila1.Enqueue(5);
            fila1.Enqueue(10);
            fila1.Enqueue(15);
            fila1.Enqueue(20);

            Queue<int> fila2 = new Queue<int>();
            fila2.Enqueue(2);
            fila2.Enqueue(4);
            fila2.Enqueue(6);
            fila2.Enqueue(8);


            Queue<int> armazenamento = fila1;
            fila1 = fila2;
            fila2 = armazenamento;


            Console.WriteLine("Elementos da fila 1: ");
            foreach (int elementos in fila1)
            {
                Console.WriteLine(elementos);
            }

            Console.WriteLine("Elementos da fila 2:");
            foreach (int elementos in fila2)
            {
                Console.WriteLine(elementos);
            }
            Console.ReadLine();
        }
    }
}



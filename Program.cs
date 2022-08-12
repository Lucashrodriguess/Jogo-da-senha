using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace jogodasenha
{
    internal class Program
    {

        static void Main(string[] args)
        {

            

            int[] vet1 = new int[5]; //armazena os numoros do random
            int[] vet2 = new int[5];  //armazena os numeros digitados pelo jogador
            char[] vet3 = new char[5];  // vet3:  armazena os acertos simbolos
            int tentativa = 4, acertos = 0;


            Console.WriteLine("Neste jogo, voce tera chances de descobrir a senha, caso fracasse ");
            Console.WriteLine("na primeira, tera mais 3 tentativas");
            Console.WriteLine(")>>>>>>>>>>>>>>>>> BOA SORTE <<<<<<<<<<<<<<<<<<<");

            Random teste = new Random();

            for (int i = 0; i < 5; i++)
            {
                vet1[i] = teste.Next(9);
            }
             while (acertos  <= 5)
            {


                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Digite o " + i + " Digito da senha");
                    vet2[i] = int.Parse(Console.ReadLine());

                }

                for (int i = 0; i < 5; i++)
                {
                    if (vet1[i] == vet2[i])
                    {
                        vet3[i] = '!';

                        acertos = acertos + 1;

                        if (acertos == 5)
                        {
                            Console.WriteLine("Parabens Voce Descobriu a senha !!!");
                        }
                        Console.WriteLine();
                    }
                    else

                    if (vet1[i] != vet2[i])
                    {
                        vet3[i] = '#';
                    }
                     if (vet1[i] != vet2[i])
                    {
                        for (int j = 0; j < 5; j++) // verificado se ha o numero digitado porem em posicao diferente
                        {
                            if (vet1[i] == vet2[j])
                            {
                                vet3[i] = '?';
                            }
                        }
                   
                    }
                    Console.Clear();
                }
                 

                if ((tentativa >= 0 && tentativa <= 4) && (acertos > 0 && acertos <=5))
                {
                    Console.WriteLine("VOCE AINDA NAO ACERTO A SENHA");
                    Console.WriteLine();
                    Console.WriteLine("O SIMBOLO ! SIGNIFICA QUE VOCE ACERTO O NUMERO E SUA POSICAO  ");
                    Console.WriteLine("O SIMBOLO ? SIGNIFICA QUE VOCE ACERTO O NUMERO MAIS EM OUTRA POSICAO ");
                    Console.WriteLine("O SIMBOLO # SIGNIFIKA QUE VOCE ERROU O NUMERO  ");

                    Console.WriteLine();

                    Console.WriteLine(" SENHA:  ");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(' ');
                        Console.Write(" " + vet3[i]); // valores da senha na frente
                    }
                    Console.WriteLine();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(' ');
                        Console.Write(" " + vet2[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    tentativa = tentativa - 1;


                    Console.WriteLine("VOCE AINDA TEM " + tentativa + " TENATIVAS RESTANTES");

                    if (tentativa == 0)
                    {
                        Console.WriteLine("Voce Perdeu !!");
                        Console.WriteLine();
                        break;
                    }
                }

            }


            Console.WriteLine("Parabens Voce Descobriu a senha !!!");

            Console.WriteLine("A senha era ");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(vet1[i]);
                }

            Console.ReadLine();
        }
           
        }
    }



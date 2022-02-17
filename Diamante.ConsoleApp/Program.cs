using System;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensaodiamante, spaces, quantidadedeX;


            //Console.WriteLine("digite a letra");

            //int oi = Convert.ToInt32(Console.ReadLine());

            //dimensaodiamante = oi + 6;
            //int f = dimensaodiamante;
            //int g = (dimensaodiamante + 1) / 2;

            //int p = (dimensaodiamante - 1) / 2;



            //Convert.ToInt32(Console.ReadLine());



                string[] alfabeto = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

                Console.Write("Digite uma letra do alfabeto (A - Z): ");
                string letraUsuario = Console.ReadLine();

                string letras = "";
                for (int Z = 0; Z < 26; Z++)
                {
                    if (letraUsuario == alfabeto[Z])
                    {
                        letras += alfabeto[Z];
                        break;
                    }
                    else
                    {
                        letras += alfabeto[Z];
                    }
                }

                Console.WriteLine(letras);
                       

                //cima
                quantidadedeX = 1;
                spaces = (letras.Length - 1) / 2;
            for (int i = 1; spaces > 0; i++)
            {

                //s
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }

                //X
                for (int j = 1; j <= quantidadedeX; j++)
                {
                    if (j > 1 && j < quantidadedeX)
                    {
                        Console.Write(" ");
                        continue;
                    }

                    Console.Write(letras[i - 1]);
                }

                spaces--;
                quantidadedeX += 2;


                Console.WriteLine();
            } 

                //baixo
                for (int W = 1; quantidadedeX > 0; W++)
                {

                    //spaces
                    for (int j = 1; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }

                    //X
                    for (int j = 1; j <= quantidadedeX; j++)
                    {
                        if (j > 1 && j < quantidadedeX)
                        {
                            Console.Write(" ");
                            continue;
                        }
                        Console.Write(letras[W - 1]);
                    }
                    
                    spaces++;
                    quantidadedeX -= 2;
                    Console.WriteLine();
                            
                }
                
                }
            }
                }
            
        
        



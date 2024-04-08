using System;
class HelloWorld
{
    static void Main()
    {

        int escolhaF, contador = 1;
        
        bool FilmeMais = true;
        string desejo, mais;

        Console.WriteLine("Bem vindo a locadora");

        Console.WriteLine("A lista de filmes C) :");
        Console.WriteLine("1)Gente grande ");
        Console.WriteLine("2)Gente grande 2");
        Console.WriteLine("3)Vingadores");
        Console.WriteLine("4)Vingadores 2");
        Console.WriteLine("5)Vingadores Guerra Infinita");
        Console.WriteLine("6)Vingadores Ultimato");
        Console.WriteLine("7)Homem Aranha");
        Console.WriteLine("8)Homem Aranha 2");
        Console.WriteLine("9)Homem Aranha 3");
        Console.WriteLine("10)O bicho vai pegar ");
        Console.WriteLine("11)O bicho vai pegar 2");
        Console.WriteLine("O senhor(a) deseja um filme?");
        desejo = Console.ReadLine();

        switch (desejo)
        {
            case "sim":
                Console.WriteLine("Qual filme?");
                escolhaF = int.Parse(Console.ReadLine());

                if (escolhaF < 0 || escolhaF > 11)
                {
                    Console.WriteLine("O número não é correspondente com um filme!");
                }
                else
                {
                    Console.WriteLine("O filme escolhido foi: " + primeiroF(escolhaF));
                    while(FilmeMais == true)
                      
                    { 
                    Console.WriteLine("O senhor deseja mais alguma coisa?");
                    mais = Console.ReadLine();
                        switch (mais)
                        {

                            case "sim":
                                Console.WriteLine("Digite o filme que o senhor quer:");
                                escolhaF = int.Parse(Console.ReadLine());
                                Console.WriteLine("O filme escolhido foi: " + primeiroF(escolhaF));
                                contador++;
                                
                                break;
                            case "não":
                            double preco = contador*6.50;
                                Console.Write("Ok senhor, o valor do(s) filme(s) foi de ");
                                FilmeMais = false;
                                   DateTime thisDay = DateTime.Today;
                                   Console.WriteLine(preco);
                                   Console.WriteLine("dia alugado:");
                                   Console.WriteLine(thisDay.ToString());
                                    DateTime dataFinal = thisDay.AddDays(2);
                                   Console.WriteLine("dia de devolução:");
                                 Console. WriteLine(""+dataFinal);
                                 break;
                        }   
                      
                    }
                }
                break;
                default:
                Console.WriteLine("Ok senhor(a), tenha um ótimo dia!");
                break;
               
        }

    }
 

        static string primeiroF(int escolha)
        {
            string[] filme =
              { "Não existe este filme, tente novamente com outro digito",
                "Gente grande",
                "Gente grande 2",
                "Vingadores",
                "Vingadores 2",
                "Vingadores Guerra Infinita",
                "Vingadores Ultimato",
                "Homem Aranha",
                "Homem Aranha 2",
                "Homem Aranha 3",
                "O bicho vai pegar",
                "O bicho vai pegar 2"
            };

            return filme[escolha];
        }
}

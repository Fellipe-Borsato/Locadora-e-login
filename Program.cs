using System;
class HelloWorld
{
    static void Main()
    {
        int contador = 0;
        int escolhaF;
        string continuar;
       

        Console.WriteLine("deseja alugar um filme?");
        continuar = Console.ReadLine();
        while (continuar == "sim")
        {

            Console.WriteLine("digite um numero do filme:");
            escolhaF = int.Parse(Console.ReadLine());

            if (escolhaF < 0 || escolhaF > 8)
            {
                Console.WriteLine("O número não é correspondente com um filme!");
            }
            else
            {
                Console.WriteLine("O filme escolhido foi: " + primeiroF(escolhaF));
            }


            static string primeiroF(int escolha)
            {
                string[] filme = {  "Gente grande",
                            "Gente grande 2",
                            "Vingadores",
                            "Vingadores 2",
                            "Vingadores GI",
                            "Vingadores Ultimato",
                            "Homem Aranha",
                            "Homem Aranha 2",
                            "Homem Aranha 3",

            };

                return filme[escolha];
            }
            contador = contador+1;
            Console.WriteLine("deseja outro filme?");
            continuar = Console.ReadLine();
        }

        int valor = contador * 6;

        Console.WriteLine($"Você alugou {contador} filmes e deverá pagar {valor}$");
        Console.WriteLine("Agradecemos a preferência");
    }
}
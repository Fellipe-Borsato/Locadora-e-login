using System;
class HelloWorld {
  static void Main() {
      string cadastro, nome, senha, senha2, email;
    Console.WriteLine("Bem vindo(a)!");
    Console.WriteLine("Você já possui cadastro? ");
    cadastro = Console.ReadLine();
    switch (cadastro){
        case "sim":
        //login
            Console.WriteLine("Digite seu nome de usuário: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();
        break;
        case "não":
        //sign in
            Console.WriteLine("Digite seu nome de usuário: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu e-mail: ");
            email = Console.ReadLine();
          do{
            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();
            Console.WriteLine("Digite novamente para confirmar sua senha: ");
            senha2 = Console.ReadLine();
            if (senha2 != senha)
            {
                Console.WriteLine("senhas incoerentes. ");
            }
            
        } while(senha2 != senha);
        break;
    }
  }
}
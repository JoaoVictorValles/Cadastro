using System;

class login
{
    public static void Main(string[] args)
    {
        string user, password;
        

        Console.WriteLine("Usuário");
        user = Console.ReadLine();
        Console.WriteLine("Senha");
        password = Console.ReadLine();

        if (user == "Joao" && password == "281100")
        {
            Console.WriteLine("Acesso Permitido");
        }
        else
        {
            Console.WriteLine("Usuário ou senha inválidos");
            
        }
    }
}

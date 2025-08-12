using System;
using Cadastro;

class login
{
    public static void Main(string[] args)
    {
        string user, password;
        

        Console.WriteLine("Usuário");
        user = Console.ReadLine();
        Console.WriteLine("Senha");
        password = Console.ReadLine();

        if (user == "Joao" && password == "1234")
        {
            Console.WriteLine("Acesso Permitido\n");

            Console.WriteLine("Bem-vindo, " + user + "!\n");
            Console.WriteLine("Digite a opção que deseja:\n");
            Console.WriteLine("1 - Cadastrar Produto");
            Console.WriteLine("2 - Listar Produtos");   
            Console.WriteLine("3 - Excluir Produto");
            Console.WriteLine("4 - Sair");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Opção 1 selecionada: Cadastrar Produto\n");
                    Add.AddEntry("");
                    break;
                case "2":
                    Console.WriteLine("Opção 2 selecionada: Listar Produtos");
                    // Implementar lógica de listagem de produtos
                    break;
                case "3":
                    Console.WriteLine("Opção 3 selecionada: Excluir Produto");
                    // Implementar lógica de exclusão de produto
                    break;
                case "4":
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Usuário ou senha inválidos");
            
        }
    }
}

// PascalCase → Usado para nomes de Classes, Métodos e Propriedades
// camelCase → Usado para variáveis e parâmetros
// snake_case → Não é comum em C#, mas pode aparecer como texto, banco de dados ou APIs

using System;

class Program
{
    static void Main(string[] args)
    {
        // camelCase (padrão para variáveis em C#)
        string usuarioComDadosAnonimos = "João123";

        // snake_case (apenas exemplo em string)
        string usuario_com_dados_anonimos = "usuario_com_dados_anonimos";

        Console.WriteLine("Exemplo usando camelCase:");
        Console.WriteLine(usuarioComDadosAnonimos);

        Console.WriteLine("--------------------------------");

        Console.WriteLine("Exemplo usando snake_case:");
        Console.WriteLine(usuario_com_dados_anonimos);

        Console.WriteLine("--------------------------------");

        Console.WriteLine("Classe criada com PascalCase: UsuarioComDadosAnonimos");



        Console.WriteLine("--------------------------------");
        Console.WriteLine("Qual a sua idade :");
        string idade = Console.ReadLine();
        Console.WriteLine("A sua idade é: " + idade);
        Console.WriteLine("Qual o seu e-mail :");
        string email = Console.ReadLine();
        Console.WriteLine("A seu e-mail é: " + email);

    }



}
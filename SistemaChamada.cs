/*Programa em C# onde o professor deverá informar a data, nº RA e se a presença do aluno é online ou não */

using System;
class Aluno 
{
    /* Arrays na string que armazenam os alunos e seus respectivos números de identificação */
    string[] user_aut = {"ALUNO1","ALUNO2","ALUNO3","ALUNO4","ALUNO5","ALUNO6","ALUNO7","ALUNO8","ALUNO9","ALUNO10"};
    string[] user_senha = {"12345678","23456789","34567891","45678912","56789123","67891234","78912345","89123456","91234567","01234567"};
    string nome, presença;
    int ra;
    
  static void Main() 
  {
    Console.WriteLine("Bem vindo(a) ao sistema de presença escolar!!!");
    Console.WriteLine(" ");
    Console.Write("Informe a data em formato DDMMAAAA: ");
    int data = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    Console.WriteLine ("Pressione qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    
    int i;
    string op = " ";
    
    for (i=0; op!="XX"; i++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("LISTA DE PRESENÇA");
        Console.WriteLine("");
        Console.Write("Informe o nºRA do aluno correspondente de acordo com o número do RA: ");
        int ra = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine ("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    
        Console.WriteLine("De acordo com as letras correspondentes, informe se o aluno está presente ou ausente:");
        Console.WriteLine("Presente = P");
        Console.WriteLine("Ausente = A");
        Console.WriteLine("Presença Online = PO");
    
        op = Console.ReadLine().ToUpper();
        
        if (op == "P")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ALUNO PRESENTE!!!");
        }
        else if (op == "A")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ALUNO AUSENTE!!!");
        }
        else if (op == "PO")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ALUNO COM PRESENÇA ONLINE!!!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PROGRAMA ENCERRADO COM SUCESSO!!!");
        }
        Console.WriteLine(" ");
        Console.WriteLine ("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }    
  }
}
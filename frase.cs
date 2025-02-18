using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Por favor, escreva uma frase:");
        string frase = Console.ReadLine();

       
        if (!string.IsNullOrWhiteSpace(frase))
        {
            
            string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int numeroDePalavras = palavras.Length;

            
            Console.WriteLine($"A frase contém {numeroDePalavras} palavra(s).");
        }
        else
        {
            Console.WriteLine("Você não digitou nenhuma frase.");
        }

        
        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadKey();
    }
}


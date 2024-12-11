using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite as quatro notas do aluno, separadas por Enter (uma casa decimal):");

        
        double n1 = LerNota("Nota 1: ");
        double n2 = LerNota("Nota 2: ");
        double n3 = LerNota("Nota 3: ");
        double n4 = LerNota("Nota 4: ");


        int peso1 = 2, peso2 = 3, peso3 = 4, peso4 = 1;

        
        double media = (n1 * peso1 + n2 * peso2 + n3 * peso3 + n4 * peso4) / (peso1 + peso2 + peso3 + peso4);

        // Exibição do resultado
        Console.WriteLine($"\nA média ponderada é: {media:F1}");
    }

    static double LerNota(string mensagem)
    {
        double nota;
        Console.Write(mensagem);
        while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida. Por favor, insira um valor entre 0.0 e 10.0.");
        }
        return nota;
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a data e hora de início do evento (formato: dd/MM/yyyy HH:mm:ss):");
        DateTime inicio;
        while (!DateTime.TryParse(Console.ReadLine(), out inicio))
        {
            Console.WriteLine("Formato inválido. Por favor, digite novamente (formato: dd/MM/yyyy HH:mm:ss):");
        }

        Console.WriteLine("Digite a data e hora de término do evento (formato: dd/MM/yyyy HH:mm:ss):");
        DateTime termino;
        while (!DateTime.TryParse(Console.ReadLine(), out termino) || termino < inicio)
        {
            Console.WriteLine("Formato inválido ou término anterior ao início. Por favor, digite novamente:");
        }

        TimeSpan duracao = termino - inicio;

        Console.WriteLine("\nDuração do evento:");
        Console.WriteLine($"{duracao.Days} dia(s), {duracao.Hours} hora(s), {duracao.Minutes} minuto(s), {duracao.Seconds} segundo(s).");
    }
}

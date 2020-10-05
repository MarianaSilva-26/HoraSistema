using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("obtendo a horaSistema!"); 
            DateTime horaSistema = DateTime.Now; 
            Console.WriteLine($"Hora do Sistema: {horaSistema}");
        }
    }
}

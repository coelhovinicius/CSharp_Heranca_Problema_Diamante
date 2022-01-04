using System;

namespace Aula201_Heranca_Diamante.Devices
{
    class Printer : Device, IPrinter // Herda de "Device" e implementa o Contrato com "IPrinter"
    {
        public override void ProcessDoc(string document) // Sobrescrita da Heranca
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document) // Implementacao da Interface
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}

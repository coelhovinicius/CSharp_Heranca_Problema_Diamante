using System;

namespace Aula201_Heranca_Diamante.Devices
{
    class Scanner : Device, IScanner // Herda de "Device" e implementa o Contrato com "IScanner"
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}

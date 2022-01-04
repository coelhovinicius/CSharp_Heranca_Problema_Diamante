using System;

namespace Aula201_Heranca_Diamante.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            System.Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            System.Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}

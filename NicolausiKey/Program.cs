using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NicolausiKey
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int AllocConsole();

        static void Main(string[] args)
        {
            // Start command line version.
            if (args.Length > 0) { InitConsole(); }
            // Start form version.
            else { InitForm(); }
        }

        static void InitConsole()
        {
            // Start console output window.
            AllocConsole();

            // Game selection
            Console.WriteLine("Key Generator for Nicolausi and PC-Bakterien");
            Console.WriteLine("by Hipnosis/Renzo Pigliacampo, 2021\n");
            Console.WriteLine("[1] Nicolausi");
            Console.WriteLine("[2] PC-Bakterien\n");
            Console.Write("Select one game: ");
            uint gameConsole = uint.Parse(Console.ReadLine());

            // Name input
            Console.Write("\nEnter registration name: ");
            string nameConsole = Console.ReadLine();

            // Key generation
            uint keygenResult = Keygen.KeyGenerate(nameConsole, gameConsole);
            Console.WriteLine("\nYour key is: " + keygenResult);
            Console.Write("\nMerry Christmas!");
            Console.ReadKey();
        }

        static void InitForm()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProgramForm());
        }
    }
}

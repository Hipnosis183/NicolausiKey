using System;
using System.Text;

namespace NicolausiKey
{
    class Keygen
    {
        // Just to initialize, it'll be overwritten anyways.
        static uint globalSalt = 0x00000000;

        static string nameInput = "";
        static string nameParsed = "";

        public static uint KeyGenerate(string name, uint game)
        {
            // Set input name string.
            nameInput = name;
            // Final key value to return.
            int keyCode = 0;
            // Stores the result of the character being processed.
            uint charSalt;

            // Despite being calculated, their values are consistent.
            uint mainSalt = game == 1 ? (uint)0x03533335 : (uint)0x00784326;
            uint localSalt = mainSalt >> 0x10 ^ mainSalt & 0xFFFF; // 0x3066

            // Set global salt.
            SetGlobalSalt(localSalt);

            // Parse the input string.
            while (nameInput.Length != 0)
            {
                // Uppercase chars and remove spaces.
                NameFormat();

                // Reset global salt.
                SetGlobalSalt(localSalt);

                // Set the first 4 bytes of the working string, needed for the hashing.
                byte[] nameGlobal = Encoding.ASCII.GetBytes(nameParsed.PadRight(4, (char)0x00));
                uint nameGlobal32 = BitConverter.ToUInt32(nameGlobal, 0);
                nameGlobal32 = nameGlobal32 & 0xFFFF0000;

                while (nameParsed.Length != 0)
                {
                    // Set the lower 2 bytes of the working string, starting with the current character.
                    byte[] nameLocal = Encoding.ASCII.GetBytes(nameParsed.PadRight(2, (char)0x00));
                    uint nameLocal16 = BitConverter.ToUInt16(nameLocal, 0);

                    // Actual hashing.
                    charSalt = ReturnGlobalSalt();
                    charSalt = charSalt ^ (nameGlobal32 ^ nameLocal16);

                    // Sum the result to the key.
                    keyCode += (int)charSalt;

                    // Remove char from parsed string.
                    nameParsed = nameParsed.Remove(0, 1);
                }
            }

            // Return lower bytes of the final key code result.
            return (uint)keyCode & 0xFFFF | 0x2000;
        }

        private static void SetGlobalSalt(uint localSalt)
        {
            // Set a 16-bit mask of the local salt.
            globalSalt = localSalt & 0xFFFF;
        }

        private static uint ReturnGlobalSalt()
        {
            // Hard-coded salt value.
            globalSalt = globalSalt * 0x15A4E35 + 1;
            // Return the higher 16-bits of the salt.
            return globalSalt >> 0x10 & 0x7FFF;
        }

        private static void NameFormat()
        {
            foreach (char letter in nameInput)
            {
                // Remove char from input string.
                nameInput = nameInput.Remove(0, 1);

                // Check if char is a space or number.
                if (letter != 0x20 && !Char.IsNumber(letter))
                {
                    // Add to the parsed string.
                    nameParsed += (Char.ToUpper(letter));
                }
                else { break; }
            }
        }
    }
}

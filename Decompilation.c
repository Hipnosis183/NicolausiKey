// 0x4133C0
uint keyGenerate(byte *nameAddress, uint mainSalt) {
    // Declare variables.
    byte nameChar;
    uint nameChar32;
    uint charSalt;
    ushort nameChar16;
    uint *pArray20uInt;
    uint array20uInt[20];
    uint localSalt;
    int keyCode;

    // Set local and global salt values.
    localSalt = mainSalt >> 0x10 ^ mainSalt & 0xffff;
    setGlobalSalt(localSalt);
    // Initialize the key value to return.
    keyCode = 0;
    // Set first character of the name into the variable.
    nameChar = *nameAddress;
    // Continue if the fist character exists.
    while (nameChar != 0) {
        // Set first character of the name into the variable.
        nameChar = *nameAddress;
        // Don't process if it's an invalid ASCII character (<= 0x20).
        // Checks whether to process or not the first char.
        if (0x20 < nameChar) {
            // Allocate the parsed name array in the pointer address.
            pArray20uInt = array20uInt;
            // Parses all the name chars into an array, uppercassing letters and deleting spaces and numbers.
            while (nameChar != 0) {
                // Load character in a 32-bit value.
                nameChar32 = (uint)nameChar;
                // Don't process if it's an invalid ASCII character (>= 0x80).
                if (nameChar < 0x80) {
                    nameChar32 = charFormat(nameChar32);
                    // Load address 0x442A46 (0x20) to EAX if space.
                    // Load address 0x442AAC (0x84) to EAX if number.
                    // If the char is a space or number, set variable to 0.
                    charSalt = (uint) * (ushort *)(PTR_DAT_00442A3C + nameChar32 * 2) & 0x103;
                    if (charSalt == 0) {
                        break; // Break at space or end of string.
                    }
                    // Set the character in the array.
                    *(char *)pArray20uInt = (char)nameChar32;
                }
                // Increment the pointer of the parsed name array.
                pArray20uInt = (uint *)((int)pArray20uInt + 1);
                // Increment the pointer to the name.
                nameAddress = nameAddress + 1;
                // Set the next char in the name.
                nameChar = *nameAddress;
            }
            // Reset the global salt.
            setGlobalSalt(localSalt);
            // Set beginning of the pointer.
            *(undefined2 *)pArray20uInt = 0;
            pArray20uInt = array20uInt;
            // Load character in a 16-bit value.
            nameChar16 = (ushort)array20uInt[0];
            // Load character in a 32-bit value.
            nameChar32 = array20uInt[0];
            // If the array has any value.
            while (nameChar16 != 0) {
                // Actual hashing.
                charSalt = returnGlobalSalt();
                charSalt = charSalt ^ nameChar32;
                // Load the next character as a 16-bit value.
                nameChar16 = *(ushort *)((int)pArray20uInt + 1);
                // Load the next character as a 32-bit value.
                nameChar32 = nameChar32 & 0xffff0000 | (uint)nameChar16;
                // Sum the result to the key.
                keyCode = keyCode + charSalt;
                // Increment the pointer of the parsed name array.
                pArray20uInt = (uint *)((int)pArray20uInt + 1);
            }
            if (*nameAddress == 0) {
                break; // Break at end of string.
            }
        }
        // Skip the invalid character.
        nameChar = nameAddress[1];
        // Increase the name address pointer.
        nameAddress = nameAddress + 1;
    }
    // Return final key.
    return (uint)(ushort)((ushort)keyCode | 0x2000);
}

// 0x410AB0
uint returnGlobalSalt(void) {
    globalSalt = globalSalt * 0x15a4e35 + 1;
    return globalSalt >> 0x10 & 0x7fff;
}

// 0x410A90
void setGlobalSalt(uint localSalt) {
    globalSalt = localSalt & 0xffff;
    return;
}

// 0x42E5D9
uint charFormat(uint nameParam) {
    // Declare and initialize variables.
    uint nameChar32;
    nameChar32 = nameParam;

    // If it's a lowecase letter.
    if ((0x60 < (int)nameParam) && ((int)nameParam < 0x7b)) {
        // Convert to uppercase.
        nameChar32 = nameParam - 0x20;
    }
    // Return the character.
    return nameChar32;
}
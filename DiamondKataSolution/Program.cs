using System;

class Diamond
{
    static void Main()
    {
        Console.WriteLine("Enter a character (A-Z):");
        char inputChar = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (IsValidInput(inputChar))
        {
            PrintDiamondPattern(inputChar);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a letter from A to Z.");
        }
    }

    static bool IsValidInput(char input)
    {
        return input >= 'A' && input <= 'Z';
    }

    static void PrintDiamondPattern(char midpoint)
    {
        int midpointPosition = midpoint - 'A';
        int counter = 0;
        do
        {
            PrintDiamondRow(counter, midpointPosition);
            counter++;
        } while (counter <= midpointPosition);


        for (int counterDown = midpointPosition - 1; counterDown >= 0; counterDown--)
        {
            PrintDiamondRow(counterDown , midpointPosition);
        }
    }

    static void PrintDiamondRow(int currentRow, int midpointPosition)
    {
        int totalWidth = midpointPosition * 2 + 1;
        char currentChar = (char)('A' + currentRow);

        for (int counter = 0; counter < totalWidth; counter++)
        {
            if (counter == midpointPosition - currentRow || counter == midpointPosition + currentRow)
            {
                Console.Write(currentChar);
            }
            else
            {
                Console.Write(' ');
            }
        }

        Console.WriteLine();
    }
}

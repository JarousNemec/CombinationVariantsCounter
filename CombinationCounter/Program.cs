// See https://aka.ms/new-console-template for more information

using System.Numerics;
using System.Threading.Channels;


Console.WriteLine("Výtejte v mém počítadle počtu kombinací");
Console.WriteLine("Pro pokračování stiskněte ENTER...");
Console.ReadKey();


int itemsCount = 0;
int combinationItemsCount = 0;


string? textInput = "-";
do
{
    Console.WriteLine("Zadejte celé číslo jakožto počet prvků: ");
    textInput = Console.ReadLine();
} while (!int.TryParse(textInput, out itemsCount));
do
{
    Console.WriteLine("Zadejte celé číslo jakožto počet prvků v kombinaci: ");
    textInput = Console.ReadLine();
} while (!int.TryParse(textInput, out combinationItemsCount));
if (itemsCount < combinationItemsCount)
    return;


Console.Write("Komplexní číslo je: ");
Console.WriteLine(CalculateCombinationNumber(itemsCount, combinationItemsCount));


BigInteger CalculateCombinationNumber(int iCount, int combItemsCount)
{
    BigInteger numerator = CalculateIntervalMultiple(iCount, iCount - (iCount - combItemsCount)+1);
    BigInteger denominator = CalculateFactorial(combItemsCount);
    BigInteger result = numerator / denominator;
    return result;
}

BigInteger CalculateFactorial(int number)
{
    BigInteger result = number;
    for (int i = number - 1; i > 1; i--)
    {
        result *= i;
    }

    return result;
}

BigInteger CalculateIntervalMultiple(int startNumber, int endNumber)
{
    BigInteger result = startNumber;
    for (int i = startNumber - 1; i > endNumber; i--)
    {
        result *= i;
    }

    return result;
}
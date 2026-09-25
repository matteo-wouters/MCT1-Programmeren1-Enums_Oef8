using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace _8___Ask_and_write_even;

class Program
{
    static void Main(string[] args)
    {
        List<int> inputNums = new List<int>();
        string stop ="";
        int count=0;
        do
        {
            count++;
            int input=AskNumCheck(count,ref stop);
            inputNums.Add(input);
        }
        while(stop!="stop");
        inputNums.Sort();
        inputNums.Reverse();
        foreach(int num in inputNums)
        {
            if (num % 2 == 0)
            {
                Console.Write("\n"+num);
            }
        }
        EndProgram("\n\nDruk op <ENTER> om af te sluiten...");
    }
    static void EndProgram(string question)
    {
        Console.Write(question);
        Console.ReadLine();
    }
    static int AskNumCheck(int amnt, ref string stop)
    {
        int result;
        bool isValid;
        Console.Write("Geef het {0}e getal in, of typ \"stop\" als je geen getal meer wil ingeven: ",amnt);
        stop = Console.ReadLine().ToLower();
        isValid=int.TryParse(stop,out result);
        while (!isValid&&stop!="stop")
        {
            Console.Write("Ongelidge invoer, probeer opnieuw: ");
            isValid=int.TryParse(Console.ReadLine(),out result);
        }
        return result;
    }
}

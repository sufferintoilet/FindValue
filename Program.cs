internal class Program
{
    private static void Main(string[] args)
    {
        
        string[] nameList={"Nam", "Steve", "Doyle", "Bac", "Sikorsky", "Lam", "Loc", "Akira", "Timmy"};
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();
        bool isTrue = false;
        int i = 0;
        while (i <= nameList.Length-1)
        {
            if (nameList[i].Equals(name))
            {
                Console.WriteLine($"Co ten trong mang va vi tri {i+1}");
                isTrue=true;
                break;
            }
            i++;
        }
        if (!isTrue)
        {
            Console.WriteLine("no name");
        }
    }
}

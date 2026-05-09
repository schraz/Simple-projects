public class Program
{
    private static bool active = true;
    private static List<string> lista = [];
    public static void Main()
    {
        while (active)
        {
            Console.WriteLine("Sua lista:\n");
            foreach(string item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Gostaria de adicionar algo? ");
            string choice = Console.ReadLine()?.ToUpper() ?? "";
            if(choice == "S" || choice == "SIM")
            {
                Adicionar();
            }
            else
            {
                return;
            }
        }
    }
    public static void Adicionar()
    {
        Console.WriteLine("Introduza um elemento à lista");
        string element = Console.ReadLine() ?? "";
        lista.Add(element);
    }
}

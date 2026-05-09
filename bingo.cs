public class Program {
    private static int tentativas = 0;
    private static List<char> bingo = ['B', 'I', 'N', 'G', 'O'];
    private static Random random = new();
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao bingo.");
        while(bingo.Count != 0 && tentativas < 11)
        {
            tentativas++;
            int num = random.Next('A', 'Z' + 1);
            Console.WriteLine($"A letra sorteada foi: {(char)num}\nVocê a tem? (S/N)");
            string resposta = Console.ReadLine()?.ToUpper() ?? "";
            if(string.IsNullOrEmpty(resposta)) continue;
            if(resposta[0] == 'S' && bingo.Contains((char)num))
            {
                bingo.Remove((char)num);
            }
            else if (resposta[0] == 'N')
            {
                Console.WriteLine("Uma pena.");
            }
            else
            {
                Console.WriteLine("Não tente manipular o jogo.");
            }
        }
        if(bingo.Count == 0)
        {
            Console.WriteLine("Parabéns! Você ganhou.");
        }
        else
        {
            Console.WriteLine("Tente de novo na próxima.");
        }
    }
}

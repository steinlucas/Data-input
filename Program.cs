namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Digite uma palavra:");
            string word2 = Console.ReadLine();

            Console.WriteLine("Digite uma palavra:");
            string word3 = Console.ReadLine();

            Console.WriteLine("Digite três palavras que serão separadas:");
            string[] vetor = Console.ReadLine().Split(" ");
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(word1);
            Console.WriteLine(word2);
            Console.WriteLine(word3);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Koodi tähän
                List<string> autolista = new List<string>();
            string syote = "";

            Console.WriteLine("Lisää listalle viisi   automerkkiä");

            while (true)
            {
                syote = Console.ReadLine();
                if (syote == "X" || syote == "x")
                {
                    break;
                }
                autolista.Add(syote);
            }
            Console.WriteLine("Kiitos listan täyttämisestä!");
        }
    }
}

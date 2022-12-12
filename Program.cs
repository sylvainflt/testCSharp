namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "jean";
            string? saisie = "";

            Console.WriteLine("Hello World!");
            Console.WriteLine("Bonjour le monde!");

            while(saisie != nom){
                try
                {
                    saisie = Console.ReadLine();
                    
                }
                catch (IOException e)
                {
                    TextWriter errorWriter = Console.Error;
                    errorWriter.WriteLine(e.Message);
                }
            }     
            Console.WriteLine("Bonjour "+saisie);       

        }
    }
}
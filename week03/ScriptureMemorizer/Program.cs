using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Juan", 3, 16);
        Scripture scripture = new Scripture
        (
            reference,
            "Porque de tal manera amo Dios al mundo que ha dado a Su Hijo Unigenito para que todo aquel que en El cree no se pierda mas tenga vida eterna."
        );

        while (scripture.IsCompletelyHidden() == false)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.ReadLine();
            Console.Clear();
            scripture.HideRandomWords(3);
        }
    }
}
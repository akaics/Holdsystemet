namespace Holdsystemet
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Studerende studerende1 = new Studerende(1, "Gülsüm", "Maglehøjen 10", "1902991234");
                Studerende studerende2 = new Studerende(2, "Nuriye", "Maglehøjen 5", "1902994321");
                Studerende studerende3 = new Studerende(3, "Abdullah", "Valbylanggade 10", "0504002323");

                Console.WriteLine("Tester klassen 'Studerende' objekter:");
                Console.WriteLine(studerende1);
                Console.WriteLine(studerende2);
                Console.WriteLine(studerende3);
                Console.WriteLine();


                Hold hold1 = new Hold("Datamatiker", "Roskilde", "a", 2022, true);
                Hold hold2 = new Hold("It-teknolog", "Køge", "b", 2021, false);

                Console.WriteLine("Tester klassen 'Hold' objekter:");
                Console.WriteLine(hold1);
                Console.WriteLine(hold2);
                Console.WriteLine();


                Console.WriteLine("Tester min AlleStuderende Dictionary + crud metoder:");

                hold1.AdderStuderende(studerende1);
                hold1.AdderStuderende(studerende2);
                hold2.AdderStuderende(studerende3);

                Console.WriteLine("Printer dictionary");
                Console.Write(hold1);
                Console.Write(hold2);
                Console.WriteLine();
                

                hold1.SletStuderende(1);
                hold1.SletStuderende(2);
                hold2.SletStuderende(3);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Programmet fejler :(");
                Console.WriteLine(e.Message);

            }

            //Try catch ændringerne er testet - ændres navn i studerende1 til 'G' smider metoden en argumentexception osv. 
        }
    }
}
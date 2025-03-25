namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("All those numbers make my head hurt!");
                    break;
                
                case "Science":
                    Console.WriteLine("Mitochondria is powerhouse of cell.");
                    break;

                case "History":
                    Console.WriteLine("May you live in interesting times!");
                    break;

                case "English":
                    Console.WriteLine("To be or not to be....what was the question?");
                    break;

                case "Band":
                    Console.WriteLine("🎺 Choreography and Merriment!");
                    break;

                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}
namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("All those numbers make my head hurt!");
                    break;
                
                case "science":
                    Console.WriteLine("Mitochondria is powerhouse of cell.");
                    break;

                case "history":
                    Console.WriteLine("May you live in interesting times!");
                    break;

                case "english":
                    Console.WriteLine("To be or not to be....what was the question?");
                    break;

                case "band":
                    Console.WriteLine("🎺 Choreography and Merriment!");
                    break;

                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}
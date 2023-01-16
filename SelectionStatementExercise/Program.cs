namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //var r = new Random();
            //var favNumber = r.Next(1, 100);


            //Console.WriteLine("Please type in a number between 1-100");
            //var userInput = int.Parse(Console.ReadLine());

            //if(userInput < favNumber)
            //{
            //Console.WriteLine($"{userInput} is too low");
            //}

            //else if(userInput > favNumber)
            //{
            // Console.WriteLine($"{userInput} is too high");
            //}

            //else
            //{
            // Console.WriteLine($"{userInput} is correct! Nice work");
            //}

            Console.WriteLine("What was your favorite subject?");
            string subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "english":
                    Console.WriteLine("That's a crowd favorite, too");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "theatre":
                    Console.WriteLine("Hopefully, we get to see you on broadway or the Big Screen one day!");
                    break;
                case "math":
                    Console.WriteLine("Math is cool!");
                    break;
                case "history":
                    Console.WriteLine("Nice!");
                    break;
                default:
                    Console.WriteLine("That's an interesting subject!");
                    break;
            }
          
        } 



            
    } 
}
namespace CSI120_Lecture5Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hoang Khoi Gia Nguyen
            // CSI 120 - Programming 1

            /* In programming, conditions like if / else if/ and else blocks are known as a D_______ S________?
               Decision Structure.

             * If you have an if / else if / else structure, how many code blocks can run in a single structure?
                if (condition) { // if statement }
                else if ( another condition ) { // else if statement }
                else  { // else statement }
               Only one code block will run .

             * Which code block will run?
                The one that meet the condition.

             * If you have two if separate statements, can these both run?
                if (condition) { // first if }
                if (second condition { // second if }
               Yes, in this case, both if conditions will be checked.

             * How many if else if statements can you have?
                You can only have one if else, but you can have any number of else if inbetween.

             * Can you have an else if / else without an if?
                else if (condition)  { // else if statement }
                else { // else statement }
               No, because there are no condition to run the codes.

             * Can you have an if without an else?
                if (condition) { // if statement }
               Yes, if you only need to check the condition for the code to run and nothing else is needed.

             * Which logical operator do you choose if you have 2 Conditions and both need to be true?
                Use additional condition with logical AND (&&), or connect two if statement (like above question) to check for both conditions.

             * Which logical operator do you choose if you have 2 Conditions, but only one needs to be true?
                Use logical OR (||) to check either of the conditions.
             */


        }
        public static void Part1() // Altitude check app
        {
            Console.Write("Enter plane's altitude (feet):");

            double userAltitude = 0;
            bool isValid1 = false;

            while (!isValid1) // Checking the input
            {
                string userInput = Console.ReadLine(); // Giving the value

                isValid1 = double.TryParse(userInput, out userAltitude);
                if (double.TryParse(userInput, out userAltitude))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }
            }
            double altitudeMeter = userAltitude * 0.3048; // Convert into meter

            if (altitudeMeter >= 7621) // Condition for High
            {
                Console.WriteLine($"Your current altitude:{altitudeMeter} meter(s) ");
                Console.WriteLine("High Altitude\r\nThis altitude is for long-range, high-speed flights");
            }
            else if (altitudeMeter >= 1524) // Condition for Medium
            {
                Console.WriteLine($"Your current altitude:{altitudeMeter} meter(s) ");
                Console.WriteLine("Medium Altitude\r\nThis is considered a Good Altitude for a plane to fly at.");
            }
            else if (altitudeMeter >= 305) // Condition for Low
            {
                Console.WriteLine($"Your current altitude:{altitudeMeter} meter(s) ");
                Console.WriteLine("Low Altitude\r\nThis altitude is used for takeoff and landing");
            }
            else // Outside of condition ranges
            {
                Console.WriteLine("WARNING. The chosen altitude is below handling perimeter. Please increase altitude or perform landing at once!");
            }
        } // End of Altitude app

        public static void Part2() //Letter Grade printing app
        {
            Console.Write("Enter numerical grade:"); // Giving value
            decimal userGrade = 0;

            string userInput = Console.ReadLine();
            decimal.TryParse(userInput, out userGrade);
            

            if (userGrade >= 90 && userGrade <= 100) // Conditions
            {
                Console.WriteLine($"Your numerical grade is : {userGrade}");
                Console.WriteLine($"Your letter grade is : A");
            }
            else if (userGrade >= 80)
            {
                Console.WriteLine($"Your numerical grade is : {userGrade}");
                Console.WriteLine($"Your letter grade is : B");

            }
            else if (userGrade >= 70)
            {
                Console.WriteLine($"Your numerical grade is : {userGrade}");
                Console.WriteLine($"Your letter grade is : C");

            }
            else if (userGrade >= 60)
            {
                Console.WriteLine($"Your numerical grade is : {userGrade}");
                Console.WriteLine($"Your letter grade is : D");

            }
            else if (userGrade >= 0)
            {
                Console.WriteLine($"Your numerical grade is : {userGrade}");
                Console.WriteLine($"Your letter grade is : F");

            }
            else
            {
                Console.WriteLine($"Invalid Grade");
               
            }
             
        } // Letter Printing app end
        
        public static void Part3() // Menu
        {
            Console.WriteLine("Choose your calculator: "); // List drop down
            Console.WriteLine("1 - Altitude");
            Console.WriteLine("2 - Letter Grade");
            Console.WriteLine("3 - Exit");

            Console.Write("Your selection: "); // Input value
            string userInput = Console.ReadLine();

            if (userInput == "1") // Run Altitude calculator
            {
                Part1();
            }
            else if (userInput == "2") // Run letter grade printer
            {
                Part2();
            }
            else if (userInput == "3") // Exit the app
            {
                Console.WriteLine("Press any key to end the app");
                Console.ReadKey();
            }
            
            else
            {
                Console.WriteLine("Unknown Input"); // Out of range
            }
        }
    }
    
}

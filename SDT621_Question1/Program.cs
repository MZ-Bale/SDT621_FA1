using System;

class Program
{
    static void Main()
    {
        // Ask for the student's name
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        // Variables for the three marks
        double mark1, mark2, mark3;

        // Get Subject 1 mark
        while (true)
        {
            Console.Write("Enter mark for Subject 1: ");

            if (double.TryParse(Console.ReadLine(), out mark1))
            {
                break;
            }

            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }

        // Get Subject 2 mark
        while (true)
        {
            Console.Write("Enter mark for Subject 2: ");

            if (double.TryParse(Console.ReadLine(), out mark2))
            {
                break;
            }

            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }

        // Get Subject 3 mark
        while (true)
        {
            Console.Write("Enter mark for Subject 3: ");

            if (double.TryParse(Console.ReadLine(), out mark3))
            {
                break;
            }

            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }

        // Calculate total marks
        double totalMarks = mark1 + mark2 + mark3;

        // Calculate average
        double averageMarks = totalMarks / 3;

        // PASS or FAIL
        string result;

        if (averageMarks >= 50)
        {
            result = "PASS";
        }
        else
        {
            result = "FAIL";
        }

        // Show results
        Console.WriteLine();
        Console.WriteLine("++++++ STUDENT RESULTS ++++++");
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Average Marks: " + averageMarks.ToString("0.0"));
        Console.WriteLine("Result: " + result);
        Console.WriteLine("Result Issued At: " + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss"));

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
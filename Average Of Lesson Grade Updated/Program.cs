using System;

namespace Average_of_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Grade for each lessons \n Use Comma Instead dot");
            Console.WriteLine(" ");
            Console.Write("Math: ");
            float math = float.Parse(Console.ReadLine());
            Console.Write("Howe many hours take this lesson: ");
            float Rmath = float.Parse(Console.ReadLine());
            Console.Write("Turkish: ");
            float turkish = float.Parse(Console.ReadLine());
            Console.Write("Howe many hours take this lesson: ");
            float Rturkish = float.Parse(Console.ReadLine());
            Console.Write("Literature: ");
            float literature = float.Parse(Console.ReadLine());
            Console.Write("Howe many hours take this lesson: ");
            float Rliterature = float.Parse(Console.ReadLine());
            Console.Write("Language And Expression: ");
            float languageExpression = float.Parse(Console.ReadLine());
            Console.Write("Howe many hours take this lesson: ");
            float RlanguageExpression = float.Parse(Console.ReadLine());
            Console.Write("Physics: ");
            float physics = float.Parse(Console.ReadLine());
            Console.Write("Howe many hours take this lesson: ");
            float Rphysics = float.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            float chemistry = float.Parse(Console.ReadLine());
            Console.Write("Howe many hours take this lesson: ");
            float Rchemistry = float.Parse(Console.ReadLine());
            Console.Write("Biology: ");
            float biology = float.Parse(Console.ReadLine());
            Console.Write("Howe many hours take this lesson: ");
            float Rbiology = float.Parse(Console.ReadLine());

            Console.WriteLine("Do you have any other class ? \n yes or no ");
            string input = Console.ReadLine();


            if (input.ToLower() == "yes")
            {
                Console.Write("Write your lesson name: ");
                string extraLessons = Console.ReadLine();
                Console.Write("Write grades for this lesson: ");
                float newLessons2 = float.Parse(Console.ReadLine());
                Console.Write("Howe many hours take this lesson: ");
                float RnewLessons2 = float.Parse(Console.ReadLine());

                float calculate = math * Rmath + turkish * Rturkish + literature * Rliterature + biology * Rbiology + chemistry * Rchemistry + physics * Rphysics + languageExpression * RlanguageExpression + newLessons2 * RnewLessons2;
                double total = calculate / (Rmath + Rturkish + Rliterature + Rbiology + Rchemistry + Rphysics + RlanguageExpression + RnewLessons2);
                if (languageExpression < 50)
                {
                    Console.WriteLine("You will fail (Language and Expression under 50)");
                }
                if (total >= 85)
                {
                    Console.WriteLine($"{total} Congrats! You get certificate of high achievment");
                }
                else if (total >= 70 && total <= 84)
                {
                    Console.WriteLine($"{total} You get certificate of participation");
                }
                else if (total < 50)
                {
                    Console.WriteLine($"{total} You Failed");
                }
                else if (total > 50 && total < 70)
                {
                    Console.WriteLine($"{total} Satisfactory ):");
                }
            }
            else if (input.ToLower() == "no")
            {
                float calculate = math * Rmath + turkish * Rturkish + literature * Rliterature + biology * Rbiology + chemistry * Rchemistry + physics * Rphysics + languageExpression * RlanguageExpression;
                float total = calculate / (Rmath + Rturkish + Rliterature + Rbiology + Rchemistry + Rphysics + RlanguageExpression);
                if (languageExpression < 50)
                {
                    Console.WriteLine("You will fail (Language and Expression under 50)");
                }
                if (total >= 85)
                {
                    Console.WriteLine($"{total} Congrats! You get certificate of high achievment");
                }
                else if (total >= 70 && total <= 84)
                {
                    Console.WriteLine($"{total} You get certificate of participation");
                }
                else if (total < 50)
                {
                    Console.WriteLine($"{total} You Failed");
                }
                else if (total > 50 && total < 70)
                {
                    Console.WriteLine($"{total} Satisfactory");
                }
            }
        }
    }
}

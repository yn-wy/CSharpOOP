namespace Exercise1._0;

class Program
{
    static string GetPaddedString(string content, int leftPadLength, int rightPadLength, char paddingChar = ' ')
    {
        content = content.PadLeft(content.Length + leftPadLength, paddingChar);
        content = content.PadRight(content.Length + rightPadLength, paddingChar);

        return content;
    }

    static void Main(string[] args)
    {
        double lowestMark = 100.0f;
        double highestMark = 0.0f;

        double totalMark = 0.0f;

        const int studentCount = 5;

        Console.WriteLine(GetPaddedString("EXAMINATION REPORT", 30, 0));
        Console.WriteLine(GetPaddedString("No.    Student Name    Mark    Grade", 30, 0));

        for (int i = 1; i <= studentCount; ++i)
        {
            Console.Write("Enter Student Name: ");
            var studentName = Console.ReadLine();

            Console.Write("Enter Student Mark: ");
            var studentMarkString = Console.ReadLine();
            var studentMark = Convert.ToDouble(studentMarkString);

            totalMark += studentMark;

            if (studentMark > highestMark)
            {
                highestMark = studentMark;
            }

            if (studentMark < lowestMark)
            {
                lowestMark = studentMark;
            }

            char studentGrade = '?';
            if (studentMark >= 0 && studentMark < 50)
            {
                studentGrade = 'F';
            }
            else if (studentMark >= 50 && studentMark < 65)
            {
                studentGrade = 'C';
            }
            else if (studentMark >= 65 && studentMark < 80)
            {
                studentGrade = 'B';
            }
            else if (studentMark >= 80 && studentMark <= 100)
            {
                studentGrade = 'A';
            }

            Console.Write(GetPaddedString($"{i}", 30, 6));
            Console.Write(GetPaddedString(
                studentName, 0, studentName.Length >= 16 ? 0 : 16 - studentName.Length));
            Console.Write(GetPaddedString(
                studentMarkString, 0, studentMarkString.Length >= 8 ? 0 : 8 - studentMarkString.Length));
            Console.WriteLine(studentGrade);
        }

        Console.WriteLine(GetPaddedString($"The Average Mark is {totalMark / studentCount}", 30, 0));
        Console.WriteLine(GetPaddedString($"The Minimum Mark is {lowestMark}", 30, 0));
        Console.WriteLine(GetPaddedString($"The Maximum Mark is {highestMark}", 30, 0));
    }
}

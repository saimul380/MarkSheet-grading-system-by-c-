namespace _2nd_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks(0 to 100): ");
            int marksNumber = Convert.ToInt32(Console.ReadLine());
            string markingGrade = "Letter Grade : ";
            string gradePoint = "Point : ";
            string markingRemarks = "Reamrks/Status : ";
            string result="";
            if (marksNumber >= 80)
            {
                result = markingGrade + "A+" + "\n" + gradePoint + "4.00" + "\n" + markingRemarks + "Excellent" +"\n";
            }
            else if (marksNumber <= 79 && marksNumber>=75)
            {
                result = markingGrade + "A" + "\n" + gradePoint + "3.75" + "\n" + markingRemarks + "Excellent" + "\n";
            }
            else if (marksNumber <= 74 && marksNumber >= 70)
            {
                result = markingGrade + "A-" + "\n" + gradePoint + "3.50" + "\n" + markingRemarks + "Very Good" + "\n";
            }
            else if (marksNumber <= 69 && marksNumber >= 65)
            {
                result = markingGrade + "B+" + "\n" + gradePoint + "3.25" + "\n" + markingRemarks + "Good" + "\n";
            }
            else if (marksNumber <= 64 && marksNumber >= 60)
            {
                result = markingGrade + "B" + "\n" + gradePoint + "3.00" + "\n" + markingRemarks + "Good" + "\n";
            }
            else if (marksNumber <= 59 && marksNumber >= 55)
            {
                result = markingGrade + "B-" + "\n" + gradePoint + "2.75" + "\n" + markingRemarks + "Satisfactory" + "\n";
            }
            else if (marksNumber <= 54 && marksNumber >= 50)
            {
                result = markingGrade + "C+" + "\n" + gradePoint + "2.50" + "\n" + markingRemarks + "Satisfactory" + "\n";
            }
            else if (marksNumber <= 49 && marksNumber >= 45)
            {
                result = markingGrade + "C" + "\n" + gradePoint + "2.25" + "\n" + markingRemarks + "Pass" + "\n";
            }
            else if (marksNumber <= 44 && marksNumber >= 40)
            {
                result = markingGrade + "D" + "\n" + gradePoint + "2.00" + "\n" + markingRemarks + "Pass" + "\n";
            }
            else if (marksNumber < 40)
            {
                result = markingGrade + "F" + "\n" + gradePoint + "0.00" + "\n" + markingRemarks + "Fail" + "\n";
            }
            Console.WriteLine(result);
        }
    }
}
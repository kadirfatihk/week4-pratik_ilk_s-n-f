namespace week4_pratik_ilk_sınıf
{
    public class Program
    {
        public static void Main (string[] args)
        {
            // öğretmen tanımlandı.
            Person teacher = new Person();
            teacher.Name = "Jose";
            teacher.Surname = "Mourinho";
            teacher.Birthday = 1963;

            teacher.TeacherDisplay();

            // öğrenci-1 tanımlandı.
            Person student_1 = new Person();
            student_1.Name = "İrfan Can";
            student_1.Surname = "Kahveci";
            student_1.Birthday = 1995;

            // öğrenci-2 tanımlandı.
            Person student_2 = new Person();
            student_2.Name = "Dusan";
            student_2.Surname = "Tadic";
            student_2.Birthday = 1988;

            // öğrenci-3 tanımlandı.
            Person student_3 = new Person();
            student_3.Name = "Ferdi";
            student_3.Surname = "Kadıoğlu";
            student_3.Birthday = 1999;

            student_1.StudentDisplay();
            student_2.StudentDisplay();
            student_3.StudentDisplay();
        }
    }
}
using System;
using System.Collections;
using System.Linq;
using System.IO;

namespace LD
{
    public class Menu
    {
        private Student[] students;
        public void nuskaitymas()
        {

            ArrayList hw = new ArrayList();
            int studentCount = 0;
                studentCount = Convert.ToInt32(Console.ReadLine());
                students = new Student[studentCount];
                for (int i = 0; i < studentCount; i++)
                {
                    string name = Console.ReadLine();
                    string surname = Console.ReadLine();
                    int n = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < n; j++)
                    {
                        float homework = Convert.ToSingle(Console.ReadLine());
                        hw.Add(homework);
                    }

                    float exam = Convert.ToSingle(Console.ReadLine());

                    students[i] = new Student(name, surname, exam, hw);
                }
            Console.WriteLine("{0, 10}{1, 10}{2, 30}{3,25}", "Surname", "Name", "Final Points (Avg.)", "/ Final points (Med.)");
            Console.WriteLine("---------------------------------------------------------------------------");
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("{0, 10}{1, 10}{2, 30}{3,25}", students[i].Surname, students[i].Name, students[i].Final_points.ToString("n2"), students[i].calculateMed().ToString("n2"));
            }

        }
    }
}
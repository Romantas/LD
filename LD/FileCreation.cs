using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace LD
{
    class FileCreation
    {
        private Random rnd = new Random();
        private Stopwatch stopWatch = new Stopwatch();
        List<Student> students = new List<Student>();
        Student[] studentsArray;
        private string path, name;
        private ArrayList hw = new ArrayList();

        private void timeSpend(TimeSpan ts, string name)
        {
            Console.WriteLine(name + " RunTime " + ts);
        }
        public FileCreation(string name)
        {
            this.name = name;
            this.path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @name + ".txt");
        }

        public void fileGeneration(int copies)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter sw = File.AppendText(path);
            Console.WriteLine(name);
            stopWatch.Start();
            for (int i = 0; i < copies; i++)
            {
                string text = string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", "Name" + (i + 1), "Surname" + (i + 1), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11));
                sw.WriteLine(text);
            }
            sw.Close();
        }

        public void nuskaitymas()
        {
            string[] lines = System.IO.File.ReadAllLines(this.path);
            using (var progress = new ProgressBar())
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] line = lines[i].Split(' ');
                    hw.Add(line[2]);
                    hw.Add(line[3]);
                    hw.Add(line[4]);
                    hw.Add(line[5]);
                    hw.Add(line[6]);
                    Student student = new Student();
                    student.name = line[0];
                    student.surname = line[1];
                    student.hw = hw;
                    student.exam = Convert.ToSingle(line[7]);
                    student.final_points = (float)(0.3 * student.averageHw() + 0.7 * student.exam);

                    students.Add(student);
                    progress.Report((double)i / lines.Length);
                }
            }
            studentsArray = students.ToArray();
        }

        public void separation()
        {
            stopWatch.Restart();
            Console.WriteLine("List TEST");
            List<Student> studentsList = new List<Student>(studentsArray);
            List<Student> studentsFailed = new List<Student>();
            List<Student> studentsPassed = new List<Student>();

            foreach (Student student in studentsList)
            {
                if (student.final_points < 5)
                {
                    studentsFailed.Add(student);
                }
                else
                {
                    studentsPassed.Add(student);
                }
            }

            TimeSpan ts = stopWatch.Elapsed;
            timeSpend(ts, "iskaidymas LIST");

            stopWatch.Restart();
            Console.WriteLine("List TEST");
            LinkedList<Student> studentsLinked = new LinkedList<Student>(studentsArray);
            LinkedList<Student> studentsFailedLinked = new LinkedList<Student>();
            LinkedList<Student> studentsPassedLinked = new LinkedList<Student>();

            foreach (Student student in studentsLinked)
            {
                if (student.final_points < 5)
                {
                    studentsFailedLinked.AddLast(student);
                }
                else
                {
                    studentsPassedLinked.AddLast(student);
                }
            }

            ts = stopWatch.Elapsed;
            timeSpend(ts, "iskaidymas LIST");

            stopWatch.Restart();
            Console.WriteLine("List TEST");
            Queue<Student> studentsQue = new Queue<Student>(studentsArray);
            Queue<Student> studentsFailedQue = new Queue<Student>();
            Queue<Student> studentsPassedQue = new Queue<Student>();

            foreach (Student student in studentsQue)
            {
                if (student.final_points < 5)
                {
                    studentsFailedQue.Enqueue(student);
                }
                else
                {
                    studentsPassedQue.Enqueue(student);
                }
            }

            ts = stopWatch.Elapsed;
            timeSpend(ts, "iskaidymas Que");
        }
        public void writeToFile(List<Student> students, string fileName)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), name + fileName + ".txt");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter sw = File.AppendText(path);
            for (int i = 0; i < students.Count; i++)
            {
                string text = string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", students[i].name, students[i].surname, students[i].hw[0], students[i].hw[1], students[i].hw[2], students[i].hw[3], students[i].hw[4], students[i].exam);
                sw.WriteLine(text);
            }
            sw.Close();
        }
    }
}
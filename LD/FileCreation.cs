 using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace LD
{
    class FileCreation
    {
        private Random rnd = new Random();
        private Stopwatch stopWatch = new Stopwatch();
        List<Student> students = new List<Student>();
        private string path, name;
        private ArrayList hw = new ArrayList();

        private void timeSpend (TimeSpan ts, string name) {
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine(name + " RunTime " + elapsedTime);
        }
        public FileCreation(string name, int copies)
        {
            this.name = name;
            this.path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @name + ".txt");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter sw = File.AppendText(path);
            Console.WriteLine(name);
            stopWatch.Start();
            for (int i = 0; i < copies; i++)
            {
                string text = string.Format("{0} {1} {2} {3} {4} {5} {6} {7}","Name" + (i + 1), "Surname" + (i + 1), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11));
                sw.WriteLine(text);
            }
            sw.Close();
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            timeSpend(ts, "irasymas");

            nuskaitymas();
        }

        public void nuskaitymas ()
        {
            string[] lines = System.IO.File.ReadAllLines(this.path);

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
            }

            separation();
        }

        public void separation ()
        {
            List<Student> studentsFailed = new List<Student>();
            List<Student> studentsPassed = new List<Student>();
            stopWatch.Start();
            for (int i = 0; i < students.Count; i++)
            {
                if(students[i].final_points < 5)
                {
                    studentsFailed.Add(students[i]);
                } else
                {
                    studentsPassed.Add(students[i]);
                }
            }
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            timeSpend(ts, "iskaidymas");

            stopWatch.Start();
            writeToFile(studentsFailed, "failed");
            writeToFile(students, "passed");

            ts = stopWatch.Elapsed;
            timeSpend(ts, "irasymas i failus");
        }
        public void writeToFile (List<Student> students, string fileName)
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

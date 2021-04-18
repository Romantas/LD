using System;
using System.Collections;
using System.Text;

namespace LD
{
    public class Student
    {
        private string name, surname;
        private float exam, final_points;
        private ArrayList hw;

        public Student(string surname, string name, float exam, ArrayList hw)
        {
            this.name = name;
            this.surname = surname;
            this.exam = exam;
            this.hw = hw;
            this.final_points = (float)(0.3 * averageHw() + 0.7 * exam);

        }

        public float calculateMed()
        {
            if (hw.Count % 2 == 0)
            {
                return (Convert.ToInt32(hw[(hw.Count / 2) - 1].ToString()) + Convert.ToInt32(hw[(hw.Count / 2)].ToString())) / 2.0F;
            }
            else
            {
                return Convert.ToSingle(hw[(hw.Count / 2)].ToString());
            }
        }

        public float averageHw()
        {
            float suma = 0;
            foreach (Object obj in hw)
            {
                suma += Convert.ToSingle(obj.ToString());
            }
            return suma / hw.Count;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public float Exam
        {
            get { return exam; }
            set { exam = value; }
        }

        public float Final_points
        {
            get { return final_points; }
            set { final_points = value; }
        }

    }
}
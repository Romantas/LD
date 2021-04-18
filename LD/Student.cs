using System;
using System.Collections;
using System.Text;

namespace LD
{
    public struct Student
    {
        public string name, surname;
        public float exam, final_points, med;
        public ArrayList hw;

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
    }
}
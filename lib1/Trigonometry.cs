using System;

namespace lib1
{
    public class Trigonometry
    {
        private string a;

        public Trigonometry(string a)
        {
            this.a = a;
        }

        public string nsin()
        {
            if (Convert.ToDouble(a) == 180 | Convert.ToDouble(a) == 360)
            {
                return Convert.ToString(0);
            }
            double ang;
            ang = Math.PI * Convert.ToDouble(a) / 180.0;
            return Convert.ToString(Math.Sin(ang));
        }

        public string ncos()
        {
            if (Convert.ToDouble(a) == 90 | Convert.ToDouble(a) == 270)
            {
                return Convert.ToString(0);
            }
            double ang;
            ang = Math.PI * Convert.ToDouble(a) / 180.0;
            return Convert.ToString(Math.Cos(ang));
        }

        public string ntg()
        {
            if (Convert.ToDouble(a) == 90 | Convert.ToDouble(a) == 270)
            {
                return "Не существует";
            }
            if (Convert.ToDouble(a) == 180 | Convert.ToDouble(a) == 360)
            {
                return Convert.ToString(0);
            }
            double ang;
            ang = Math.PI * Convert.ToDouble(a) / 180.0;
            return Convert.ToString(Math.Tan(ang));
        }

        public string nctg()
        {
            if (Convert.ToDouble(a) == 0 | Convert.ToDouble(a) == 180 | Convert.ToDouble(a) == 360)
            {
                return "Не существует";
            }
            if (Convert.ToDouble(a) == 90 | Convert.ToDouble(a) == 270)
            {
                return Convert.ToString(0);
            }
            double ang;
            ang = Math.PI * Convert.ToDouble(a) / 180.0;
            return Convert.ToString(1/Math.Tan(ang));
        }

        
    }
}

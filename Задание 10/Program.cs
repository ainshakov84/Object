using System;

namespace Задание_10
{
    class Angle
    {
        double grade;
        double minutes;
        double sec;

        public Angle(double grade, double minutes, double sec)
        {
            this.grade = grade;
            this.minutes = minutes;
            this.sec = sec;
        }

        public double Grade
        {

            get
            {
                return grade;
            }
            set
            {
                if (value >= 0 || value < 360)
                    grade = value;
                else
                    grade = 0;
            }
        }
        public double Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 || value < 60)
                    minutes = value;
                else
                    minutes = 0;
            }
        }
        public double Sec
        {
            get { return sec; }
            set
            {
                if (value >= 0 || value < 60)
                    sec = value;
                else
                    sec = 0;
            }
        }
        public double ToRadians()
        {
            var radians = ((grade + minutes) / 60 + sec / 3600) * (Math.PI) / 180;
            return radians;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Задайте градусы:");
                double grade = double.Parse(Console.ReadLine());
                Console.WriteLine("Задайте минуты");
                double minutes = double.Parse(Console.ReadLine());
                Console.WriteLine("задайте секунды");
                double sec = double.Parse(Console.ReadLine());

                Angle angle = new Angle(grade, minutes, sec);
                Console.WriteLine("Значение угла в радианах" + angle.ToRadians());
                Console.ReadLine();

            }
        }
    }
}





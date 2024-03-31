using System;


namespace TimeProject
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

       
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.Second = second;
        }

        public Time(Time other)
        {
            hour = other.hour;
            minute = other.minute;
            Second = other.Second;
        }
        public Time()
        {
            Hour = 0;
            this.minute = 0;
            this.Second = 0;
        }

        //xay dung property
        public int Hour
        {
            set
            {
                if (value >= 0 && value < 24)
                    hour = value;
            }
            get { return hour; }
        }

        public int Second { get => second; set => second = value; }

        public string ToString()
        {
            string s =  $"{Hour:00}:{minute:00}:{Second:00}";
            return s;
        }

        public Time NextSecond()
        {
            //hour:minute:second (vd: 23:59: 59) + 1s
            int newSecond = Second + 1;
            int newHour = hour;
            int newMinute = minute;

            if (newSecond == 60)
            {
                newSecond = 0;
                newMinute = minute + 1;
                if (newMinute == 60)
                {
                    newMinute = 0;
                    newHour = hour + 1;
                    if (newHour == 24)
                        newHour = 0;
                }
            }

            Time newTime = new Time(newHour, newMinute, newSecond);
            return newTime;
        }

        ~Time()
        {
            Console.WriteLine("doi tuong bi huy");
        }
    }
}

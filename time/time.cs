using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    internal class time
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour { get => hour ; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
        public int Second { get => second; set => second = value; }

        public time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;           
        }

        public string ToString()
        {
            return $"{hour:00}:{minute:00}:{second:00}";
        }
        public time nextSecond()
        {
            DateTime date = new DateTime(1,1,1,hour,minute,second).AddSeconds(1);
            hour = date.Hour;
            minute = date.Minute;
            second = date.Second;
            return this;
           
        }
        public time nextprevious()
        {
            DateTime date = new DateTime(1, 1, 1, hour, minute, second).AddSeconds(-2);
            hour = date.Hour;
            minute = date.Minute;
            second = date.Second;
            return this;
        }
    }
}

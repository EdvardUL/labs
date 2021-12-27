using System;

namespace TimeLib_1
{
    public class Time
    {
        int hours, minutes, seconds;
        public int Hours
        {
            set
            {
                if (value > 24 || value <= 0) throw new Exception("invalid value");
                hours = value;
            }
            get { return hours; }
        }
        public int Minutes
        {
            set
            {
                if (value > 60 || value <= 0) throw new Exception("invalid value");
                minutes = value;
            }
            get { return minutes; }
        }
        public int Seconds
        {
            set
            {
                if (value > 60 || value <= 0) throw new Exception("invalid value");
                seconds = value;
            }
            get { return seconds; }
        }
        public Time()
        {
            hours = 7;
            minutes = 30;
            seconds = 0;
        }
        public Time(int _hours, int _minutes, int _seconds)
        {
            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
        }
        public int TranslationInSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }
        public (int, int, int) PastTime(int _hours, int _minutes, int _seconds)
        {
            if (_hours > 24 || _hours <= 0) throw new Exception("invalid value");
            if (_minutes > 60 || _minutes <= 0) throw new Exception("invalid value");
            if (_seconds > 60 || _seconds <= 0) throw new Exception("invalid value");
            return (_hours - hours, _minutes - minutes, _seconds - seconds);
        }
    }
}

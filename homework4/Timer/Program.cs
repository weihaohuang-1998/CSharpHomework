using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace test2
{
    public delegate void TickHandler();
    public delegate void AlarmHandler();

    public class Clock
    {
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;
        private List<Alarm> AlarmlList = new List<Alarm>();
        private int hour;
        private int minute;
        private int second;

        public Clock()
        {
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
            OnTick += new TickHandler(timeReporter);
            OnAlarm += Ring;
        }

        public Clock(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            OnTick += new TickHandler(timeReporter);
            OnAlarm += Ring;
        }

        public void start()
        {
            while (true)
            {
                Thread.Sleep(1000);
                this.second++;
                OnTick();
                for (int i = 0; i < AlarmlList.Count; i++)
                {
                    if (AlarmlList[i].isTimeToAlarm(this.hour, this.minute, this.second))
                        OnAlarm();
                }
            }
        }

        public void setAlarm(int h, int m, int s)
        {
            Alarm a = new Alarm(h, m, s);
            AlarmlList.Add(a);
        }

        public void Ring()
        {
            Console.WriteLine("This is a alarm!");
        }

        public void timeReporter()
        {
            Console.WriteLine(this.hour + ":" + this.minute + ":" + this.second);
            if (this.second == 60)
            {
                this.second = 0;
                this.minute++;
            }
            if (this.minute == 60)
            {
                this.minute = 0;
                this.hour++;
            }
            if (this.hour == 24)
                this.hour = 0;
        }

    }


    class Alarm
    {
        public int hour;
        public int minute;
        public int second;
        public Alarm(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public bool isTimeToAlarm(int h, int m, int s)
        {
            if (hour == h && minute == m && second == s)
                return true;
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock(23, 25, 20);
            myClock.setAlarm(23, 25, 30);
            myClock.setAlarm(23, 25, 40);
            myClock.setAlarm(23, 25, 50);
            myClock.start();
        }
    }
}
using System;

namespace TimeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.Write(timeConversion(s));
        }
        public static string timeConversion(string s)
        {
            string AM_PM = s.Substring(8, 2);
            string hr = s.Substring(0, 2);
            string time = s.Substring(2, 6);
            string time1 = s.Substring(3, 2);
            int num_hr = Convert.ToInt32(hr);
            int num_time1 = Convert.ToInt32(time1);

            if (AM_PM == "AM" && num_hr > 12)
            {
                int new_hr = num_hr - 12;
                string str_hr = new_hr.ToString();
                return (string.Concat(str_hr, time));
            }
            else if(AM_PM=="AM" && num_hr == 12 && num_time1>0)
            {
                string zero = "00";
                return (string.Concat(zero, time));
            }
            else if (AM_PM=="AM" && num_hr==12 )
            {
                string zero = "00";
                return (string.Concat(zero, time));
            }
            else if (AM_PM == "AM" && num_hr == 0)
            {
                string zero = "00";
                return (string.Concat(zero, time));
            }
            else if (AM_PM == "PM" && num_hr < 12)
            {
                int new_hr = num_hr + 12;
                string str_hr = new_hr.ToString();
                return (string.Concat(str_hr, time));
            }
            else
            {
                string ans = s.Substring(0, 8);
                return ans;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_6
{
    public class NewCall
    {
        public string Number { get; }
        public int Duration { get; }
        public int StartTime { get; }
        public string CurrentRate {get; set;}
        public NewCall(string number,  int duration, int startTime)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentException("Не может быть пустым или содержать только пробел.", nameof(number));
            }
            if (number.Length != 10 || !long.TryParse(number, out long num))
            {
                throw new ArgumentException("Не верно указан номер", nameof(number));
            }
            if (duration <= 0)
            {
                throw new ArgumentException("Время звонка не может быть меньше нуля.", nameof(duration));
            }
            if (startTime < 0 || startTime > 24)
            {
                throw new ArgumentException("Не соблюденные временные рамки", nameof(startTime));
            }
            Number = number;
            Duration = duration;
            StartTime = startTime;
            CurrentRate = CheckRate();
        }

        private string CheckRate()
        {
            if (Number[0] == '9')
                if (Number[1] == '9' && Number[2] == '9')
                {
                    return "999";
                }
                else
                {
                    return "9xx";
                }
            else
            {
                return "other";
            }

        }
    }
    
}

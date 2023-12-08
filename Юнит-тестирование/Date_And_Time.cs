namespace Date_And_Time_n
{
    public class Date_And_Time
    {

        public DateTime GetDateTimeFromUser()
        {
            int year = GetIntFromUser("Введите год:");
            int month = GetIntFromUser("Введите месяц:");
            int day = GetIntFromUser("Введите день:");
            int hour = GetIntFromUser("Введите час:");
            int minute = GetIntFromUser("Введите минуту:");
            int second = GetIntFromUser("Введите секунду:");

            while (!IsValidDateTime(year, month, day, hour, minute, second))
            {
                Console.WriteLine("Введена некорректная дата или время. Попробуйте снова.");
                year = GetIntFromUser("Введите год:");
                month = GetIntFromUser("Введите месяц:");
                day = GetIntFromUser("Введите день:");
                hour = GetIntFromUser("Введите час:");
                minute = GetIntFromUser("Введите минуту:");
                second = GetIntFromUser("Введите секунду:");
            }

            return new DateTime(year, month, day, hour, minute, second);
        }
        static int GetIntFromUser(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int value;

            while (!int.TryParse(input, out value))
            {
                Console.WriteLine("Введено некорректное значение. Попробуйте снова.");
                Console.WriteLine(message);
                input = Console.ReadLine();
            }

            return value;
        }

        public bool IsValidDateTime(int year, int month, int day, int hour, int minute, int second)
        {
            if (year < 1 || year > 9999)
                return false;

            if (month < 1 || month > 12)
                return false;

            if (day < 1 || day > DateTime.DaysInMonth(year, month))
                return false;

            if (hour < 0 || hour > 23)
                return false;

            if (minute < 0 || minute > 59)
                return false;

            if (second < 0 || second > 59)
                return false;

            return true;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Date_And_Time date_And_Time = new Date_And_Time();
                DateTime dateTime = date_And_Time.GetDateTimeFromUser();
                Console.WriteLine("Введенная дата и время: " + dateTime);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}

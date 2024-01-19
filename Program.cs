using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        //Citeste ora automat
        DateTime currentTime = DateTime.Now;

        
        int hours = currentTime.Hour;
        int minutes = currentTime.Minute;
        int seconds = currentTime.Second;

        //Converteste in binar ora primita
        string binaryHours = Convert.ToString(hours, 2).PadLeft(5, '0');
        string binaryMinutes = Convert.ToString(minutes, 2).PadLeft(6, '0');
        string binarySeconds = Convert.ToString(seconds, 2).PadLeft(6, '0');

        // Afisam ceasul binar
        Console.WriteLine($"Ceasul binar este: {binaryHours}:{binaryMinutes}:{binarySeconds}");
    }
}

using System;

class Program
{
    static string ConvertToMilitaryTime(string time12hr)
    {
        string[] timeComponents = time12hr.Split(':', ' ');

        int hours = int.Parse(timeComponents[0]);
        int minutes = int.Parse(timeComponents[1]);
        int seconds = int.Parse(timeComponents[2]);
        string ampm = timeComponents[3].ToLower(){ 

        if (ampm == "pm" && hours < 12)
        {
            hours += 12;
        }

        if (ampm == "am" && hours == 12)
        {
            hours = 0;
        }

        string time24hr = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

        return time24hr;
    }

    static void Main()
    {

        Console.Write("Enter the time in 12-hour format (hh:mm:ssAM/PM): ");
        string time12hr = Console.ReadLine();


        string time24hr = ConvertToMilitaryTime(time12hr);

        Console.WriteLine("The time in 24-hour format is: " + time24hr);
    }
}
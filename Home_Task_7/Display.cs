using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task_7
{//Цей клас є як один з можливих класів, що реалізують відображення. Тут краще імплементувати інтефейс, який буде декларувати вимоги до відображення. І в класі клієнта використовувати візуалізацію чере інтерфейс
    public static class Display
    {

        public static int GetColorLightTime(string trafficlightLocation, string colorName)
        {
            Console.WriteLine($"Enter {colorName} color light time for {trafficlightLocation} traffic light:");
            return int.Parse(Console.ReadLine());
        }

        public static int GetWorkSeconds()
        {
            Console.WriteLine("Enter crossroad work seconds for demo:");
            return int.Parse(Console.ReadLine());
        }


        public static void DisplayInfo(CrossroadEventArgs args)
        {
            Console.Clear();

            string[] headers = new string[args.TrafficLights.Count + 1];
            headers[0] = "Traffic Light";
            for (int i = 0; i < args.TrafficLights.Count; i++)
            {
                headers[i + 1] = args.TrafficLights[i].location.ToString();
            }

            string[] colors = new string[args.TrafficLights.Count + 1];
            colors[0] = "Colors";
            for (int i = 0; i < args.TrafficLights.Count; i++)
            {
                colors[i + 1] = args.TrafficLights[i].CurrentColor.ToString();
            }

            int maxLength = headers.Max(h => h.Length);
            maxLength = Math.Max(maxLength, colors.Max(c => c.Length + 1));

            for (int i = 0; i < headers.Length; i++)
            {
                Console.Write(headers[i].PadRight(maxLength));
                if (i < headers.Length - 1)
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i].PadRight(maxLength));
                if (i < colors.Length - 1)
                {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();

        }
    }
}

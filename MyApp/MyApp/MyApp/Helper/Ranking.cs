using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Helper
{
    public class Ranking
    {
        public static float getRanking()
        {
            try
            {
                int increment = 0, sumar = 0;
                Random rm = new Random();
                for (int i = 0; i < 10; i++)
                {
                    increment = rm.Next(0, 10);
                    sumar += increment;
                }
                var result = (float)sumar / 10;
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

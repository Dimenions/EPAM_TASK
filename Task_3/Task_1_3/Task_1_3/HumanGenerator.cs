using System;
using System.Collections.Generic;


namespace Task_1_3
{
    public static class HumanGenerator
    {
        public static IEnumerable<Human> GenerateHumans(int count)
        {
            Human[] humans = new Human[count];
            for (int i = 0; i < count; i++)
            {
                var tmp = Guid.NewGuid().ToString();
                humans[i] = new Human() { Name = tmp.Substring(0, 5) };
            }

            return humans;
        }
    }
}

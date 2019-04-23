using System;
using System.Collections.Generic;

namespace pong
{
    public class Pong
    {
        
        public string IsPong(int countNum)
        {
            if ((countNum % 3 == 0 && countNum % 5 == 0) && countNum != 0)
            {
                return "Ping-Pong";
            }
            else if (countNum % 3 == 0 && countNum != 0)
            {
                return "Ping";
            }
            else if(countNum % 5 == 0 && countNum != 0)
            {
                return "Pong";
            }
            else return countNum.ToString();
        }

        public string AddPong(int userNumber)
        {
            List<string> counting = new List<string> {};

            for (int i = 0; i <= userNumber; i++){
                counting.Add(IsPong(i));
            }
            string listOutput = string.Join(", ", counting);
            return listOutput;
        }
    }
}

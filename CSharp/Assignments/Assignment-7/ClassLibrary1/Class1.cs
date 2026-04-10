using System;

namespace ClassLibrary1
{
    public class Concession
    {
        public string CalculateConcession(int age)
        {
            const int TotalFare = 500;

            if (age <= 5)
            {
                return "Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                double fare = TotalFare - (TotalFare * 0.30);
                return "Senior Citizen - " + fare;
            }
            else
            {
                return "Ticket Booked - " + TotalFare;
            }
        }
    }
}
using System;
using Domain.Models;
using Service.Interfaces;

namespace Service
{
    public class GetCustomers : IGetCustomers
    {
        public int FilterByAge(Customer[] customers)
        {
            int count = 0;

            foreach (Customer customer in customers)
            {
                if (customer.Age >= 25 && customer.Age <= 30)
                {
                    count++;
                }
            }

            return count;
        }

        public double AverageAge(Customer[] customers)
        {
            double count = 0;
            double sum = 0;

            foreach (Customer customer in customers)
            {
                count++;
                sum += customer.Age;
            }

            return sum / count;
        }
    }
}


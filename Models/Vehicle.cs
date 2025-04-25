using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview.Models
{
    //abstraction practice
    abstract public class Vehicle
    {
        private string Make { get; }
        private string Model { get; }
        private int Year { get; }

        public abstract decimal CalculateRentalCost(int RentalDays);

        public string make
        {
            get
            {
                return Make;
            }
        }
        public string model
        {
            get
            {
                return Model;
            }
        }
        public int year
        {
            get
            {


                return Year;
            }
        }
    }

    public class Car : Vehicle
    {
        public override decimal CalculateRentalCost(int RentalDays)
        {
            return RentalDays * 50;
        }
    }

    public class Truck : Vehicle
    {
        public override decimal CalculateRentalCost(int RentalDays)
        {
            if (RentalDays <= 3)
            {
                return RentalDays * 100;
            }
            else
            {
                int newrentaldays = RentalDays - 3;
                decimal Basecost = 300;

                return newrentaldays * 120 + Basecost;
            }
        }
    }

    public class Motorcycle : Vehicle
    {
        public override decimal CalculateRentalCost(int RentalDays)
        {
            return RentalDays * 15;
        }
    }


    }

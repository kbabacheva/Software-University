using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_And_Worker
{
    public class Worker:Human
    {
        private const int workDaysInWeek = 5;
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay):base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double WeekSalary 
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Week salary cannot be 0 or negative");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Work hours per day cannot be 0 or negative");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * workDaysInWeek);
        }

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}, Week salary: {2}, Work hours per day: {3}", base.FirstName, base.LastName, this.WeekSalary,this.WorkHoursPerDay);
        }
    }
}

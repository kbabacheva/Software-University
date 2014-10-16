using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Project
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private ProjectState state;

        public Project(string projectName, DateTime startDate, string details)
        {
            this.Name = projectName;
            this.StartDate = startDate;
            this.Details = details;
        }
        public string Name 
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project name cannot be empty");
                }
                this.projectName = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; } 
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Start date cannot be empty"); 
                }
                this.startDate = value;
            } 
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Details cannot be empty");
                }
                this.details = value;
            }
        }

        public ProjectState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void CloseProject()
        {
            if (this.state == ProjectState.Opened)
            {
                this.state = ProjectState.Closed;
                Console.WriteLine("The project is now closed!");
            }
            else
            {
                Console.WriteLine("Thte project is already closed!");
            }
        }
        public override string ToString()
        {
            return string.Format("Prject name: {0}, Start date: {1}, Details: {2}",
                this.Name,this.StartDate,this.Details);
        }
    }
}

namespace DataAPI.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }

        public DateTime JoiningDate { get; set; }

        public string Experience => CalculateYearOfExperience(JoiningDate);

        private string CalculateYearOfExperience(DateTime startDate)
        {
            TimeSpan timeDifference = DateTime.Now - startDate;

            int years = timeDifference.Days / 365;
            int months = (timeDifference.Days % 365) / 30;
            int days = (timeDifference.Days % 365) % 30;
            int hours = timeDifference.Hours;
            int minutes = timeDifference.Minutes;
            int seconds = timeDifference.Seconds;

            return $"{years} years, {months} months, {days} days, {hours} hours, {minutes} minutes, {seconds} seconds";
        }

    }
}

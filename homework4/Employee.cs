namespace homework4
{
    public class Employee
    {
        /// <summary>
        /// Any way, salary have to start from some value
        /// </summary>
        private const double InitialSalary = 50.0;

        /// <summary>
        /// Allowance to employee salary by his/her experience (value in percents)
        /// </summary>
        private const double AllowanceByExperience = 5.0;

        /// <summary>
        /// Taxes applied to employees salary (value in percents)
        /// </summary>
        private const double Taxes = 13.0;

        /// <summary>
        /// (value in percents)
        /// </summary>
        private const double PensionFund = 1.0;

        public enum Positions
        {
            // 😁
            Junior1 = 1,
            Junior2 = 2,
            Junior3 = 3,
            Middle1 = 4,
            Middle2 = 5,
            Middle3 = 6,
            Senior1 = 7,
            Senior2 = 8,
            Senior3 = 9
        }

        public string Name { get; }
        public string Surname { get; }
        public Positions Position { get; set; }

        /// <summary>
        /// Experience od Employee in years
        /// </summary>
        public int Experience { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        private double GetFullSalary()
        {
            return InitialSalary + (50.0 * (double) Position) +
                   InitialSalary * (Experience * AllowanceByExperience) / 100;
        }

        public double GetSalary()
        {
            return GetFullSalary() - GetTaxes();
        }

        public double GetTaxes()
        {
            return GetFullSalary() * (Taxes + PensionFund) / 100.0;
        }
    }
}
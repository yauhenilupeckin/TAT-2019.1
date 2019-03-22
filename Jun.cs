namespace DEV_3
{
    class Junior : Employee
    {
        public Junior()
        {
            Cost = 10;
            Productivity = 5;
        }
        public override string GetName()
        {
            return "Junior";
        }
    }
}
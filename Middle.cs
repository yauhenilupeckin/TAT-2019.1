namespace DEV_3
{
    class Middle : Junior
    {
        public Middle()
        {
            Cost += 5;
            Productivity *= 3;
        }
        public override string GetName()
        {
            return "Middle";
        }
    }
}
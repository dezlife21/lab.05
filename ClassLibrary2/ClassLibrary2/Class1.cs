namespace ClassLibrary2
{
    public class TabletOwner
    {
        public string Name;
        public string PhoneNumber;
        public string Price;
        public string Email;
        public DateTime SubscriptionStartDate;
        public bool IsActive;
        public int Age;
        public double GetYearsWithTablet()
        {
            return (DateTime.Now - SubscriptionStartDate).TotalDays / 365;
        }
    }
}
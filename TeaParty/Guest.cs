namespace TeaParty
{
    public class Guest
    {
        public string Surname { get; set; }
        public bool IsMale { get; set; }
        public bool IsKnighted { get; set; }

        public Guest(string surname, bool isMale, bool isNKnighted)
        {
            Surname = surname;
            IsMale = isMale;
            IsKnighted = isNKnighted;
        }
    }
}

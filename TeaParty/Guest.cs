namespace TeaParty
{
    public class Guest
    {
        public string Surname { get; set; }
        private bool isMale;
        private bool isKnighted;

        public Guest(string surname, bool isMale, bool isKnighted)
        {
            Surname = surname;
            this.isMale = isMale;
            this.isKnighted = isKnighted;
        }

        public string Salutation
        {
            get
            {
                if (isKnighted)
                {
                    return "Sir.";
                }

                return isMale ? "Mr." : "Ms.";
            }
        }
    }
}

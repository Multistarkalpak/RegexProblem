namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            //UC1
            RegexClass regex = new RegexClass();
            regex.ValidateFirstNameRegex("Kalpak");

            //UC2
            RegexClass regex2 = new RegexClass();
            regex2.ValidatelastNameRegex("Chincholkar");

        }
    }
}
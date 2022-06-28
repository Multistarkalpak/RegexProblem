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

            //UC3
            string[] EmailList = { "abc@yohoo.com","abc-100@yohoo.com",
                                    "abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net",
                                     "abc.100@abc.com.au", "abc@1.com","abc","abc@.com.my",
                                    "abc123@gmail.a",
                                     "abc1232.com"
                                     ,".abc@abc.com","abc123.com.my", "abc123@.com.com"};

            regex.ValidateEmailIdRegex("kalpakc28@gmail.com");
            foreach (string SampleEmailAddress in EmailList)
            {
                regex.ValidateEmailIdRegex(SampleEmailAddress);
            }

            //UC4
            
            RegexClass regex4 = new RegexClass();
            regex4.ValidateMobileRegex("91 7898156858");

            //UC5

            RegexClass regex5 = new RegexClass();
            regex5.ValidatePasswordRegex("chchvngfnvm");



        }
    }
}
namespace UberPoo
{
    public class Account
    {
        public int id;
        public string name;
        public string document;
        public string? email;
        public string? password;

        public Account(string name, string document)
        {
            this.name = name;
            this.document = document;
        }
    }
}
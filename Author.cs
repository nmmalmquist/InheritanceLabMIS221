namespace mis221_lab_inheritance
{
    public class Author
    {
        private string name;
        private string email;
        private char gender;

        public Author(string tempName, string tempEmail, char tempGender)
        {
            this.name = tempName;
            this.email = tempEmail;
            this.gender = tempGender;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetGender(char gender)
        {
            this.gender = gender;
        }

        public string GetName()
        {
            return this.name;
        }
        public string GetEmail()
        {
            return this.email;
        }
        public char GetGender()
        {
            return this.gender;
        }

        public override string ToString()
        {
            return $"name={this.name} email={this.email} gender={this.gender}";

        }
    }
}
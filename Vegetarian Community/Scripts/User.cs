namespace Vegetarian_Community.Scripts
{
    public sealed class User
    {
        private int _id;
        private string _name;
        private string _sex;
        private int _age;        

        public User(int currentId, string name, string sex, int age)
        {
            _id = currentId;
            _name = name;
            _sex = sex;
            _age = age;
        }

        public int Id => _id;

        public string Name => _name;

        public string Sex => _sex;

        public int Age => _age;
    }
}

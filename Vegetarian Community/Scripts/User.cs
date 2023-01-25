using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetarian_Community.Scripts
{
    public sealed class User
    {
        private int _id;
        private string _name;
        private string _sex;
        private int _age;

        private static int _currentId = 0;

        public User(string name, string sex, int age)
        {
            _id = _currentId;
            _name = name;
            _sex = sex;
            _age = age;

            _currentId++;
        }

        public int Id => _id;

        public string Name => _name;

        public string Sex => _sex;

        public int Age => _age;
    }
}

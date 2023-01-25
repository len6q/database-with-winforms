using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetarian_Community.Scripts
{
    public sealed class Post
    {
        private int _id;
        private string _text;
        private int _userId;

        private static int _currentId = 0;

        public Post(string text, int userId)
        {
            _id = _currentId;
            _text = text;
            _userId = userId;

            _currentId++;
        }

        public int Id => _id;

        public string Text => _text;

        public int UserId => _userId;
    }
}

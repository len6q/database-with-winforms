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

        public Post(int currentId, string text, int userId)
        {
            _id = currentId;
            _text = text;
            _userId = userId;            
        }

        public int Id => _id;

        public string Text => _text;

        public int UserId => _userId;
    }
}

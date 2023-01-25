using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetarian_Community.Scripts
{
    public sealed class Comment
    {
        private int _id;
        private string _text;
        private int _userId;
        private int _postId;

        private static int _currentId = 0;

        public Comment(string text, int userId, int postId)
        {
            _id = _currentId;
            _text = text;
            _userId = userId;
            _postId = postId;

            _currentId++;
        }

        public int Id => _id;

        public string Text => _text;

        public DateTime Time => DateTime.Now;

        public int UserId => _userId;

        public int PostId => _postId;
    }
}

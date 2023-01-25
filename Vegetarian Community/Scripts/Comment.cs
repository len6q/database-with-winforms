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

        public Comment(int currentId, string text, int userId, int postId)
        {
            _id = currentId;
            _text = text;
            _userId = userId;
            _postId = postId;
        }

        public int Id => _id;

        public string Text => _text;

        public DateTime Time => DateTime.Now;

        public int UserId => _userId;

        public int PostId => _postId;
    }
}

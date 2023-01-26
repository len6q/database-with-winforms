using System;

namespace Vegetarian_Community.Scripts
{
    public sealed class Comment
    {
        private int _id;
        private string _text;
        private DateTime _time;
        private int _userId;
        private int _postId;

        public Comment(int currentId, string text, DateTime time, int userId, int postId)
        {
            _id = currentId;
            _text = text;
            _time = time;
            _userId = userId;
            _postId = postId;
        }

        public int Id => _id;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public DateTime Time => _time;

        public int UserId => _userId;

        public int PostId => _postId;

        public override string ToString()
        {
            return $"({ _userId}) : { _text} | { _time}";
        }

    }
}

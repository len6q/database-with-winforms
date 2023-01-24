using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetarian_Community
{
    public sealed class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime Time = DateTime.Now;

        public int UserId { get; set; }

        public int PostId { get; set; }
    }
}

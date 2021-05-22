using System;
using System.Collections.Generic;

namespace MemeDuniya.Model
{
    public class Feed
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string ContentType { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

    }

    public class Comment
    {
        public string Text { get; set; }

        public Guid User { get; set; }
    }
}

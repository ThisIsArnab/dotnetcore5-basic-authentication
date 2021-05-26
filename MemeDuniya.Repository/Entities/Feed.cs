using System;
using System.Collections.Generic;

namespace MemeDuniya.Repository.Entities
{
    public class Feed
    {
        public int Id { get; set; } 

        public int UserId { get; set; }

        public string ContentType { get; set; }    

        public byte[] ContentData { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }

    public class Comment 
    {
        public string Text { get; set; }

        public int UserId { get; set; }
    }
}

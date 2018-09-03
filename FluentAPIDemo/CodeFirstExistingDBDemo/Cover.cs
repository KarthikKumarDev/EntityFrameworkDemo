
using System.Collections.Generic;

namespace CodeFirstExistingDBDemo
{
    public class Cover
    {
        public HashSet<Tag> Tags { get; }

        public Cover()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public Course Course { get; set; }
    }
}

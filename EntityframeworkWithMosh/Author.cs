using System.Collections.Generic;

namespace EntityframeworkWithMosh
{
    public class Author
    {


        public int AuthorID { get; set; }
        public string Name { get; set; }

        public IList<Course> Courses { get; set; }
    }
}
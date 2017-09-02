using System.Collections.Generic;

namespace EntityframeworkWithMosh
{
    public class Tag
    {




        public int ID { get; set; }
        public string Name { get; set; }

        public IList<Course> Courses { get; set; }
    }
}
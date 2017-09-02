using System;
using System.Collections.Generic;

namespace EntityframeworkWithMosh
{
    public class Course
    {



        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public CourseLevel Level { get; set; }

       
        public float FullPrice { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public IList<Tag> Tags { get; set; }

       


    }
}

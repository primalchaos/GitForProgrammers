using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class Book
    {
        public string Title { get; set; }
        public List<string> Author { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}

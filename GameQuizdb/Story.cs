using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz
{
    public class Story
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }
        public string StartText { get; set; }
        public string EndText { get; set; }
        public virtual ICollection<Chapters> Chapters { get; set; }
    }
}

      

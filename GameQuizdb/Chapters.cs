using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameQuiz
{
    public class Chapters
    {
        public int Id { get; set; }
        public int StoryID { get; set; }
        public string Chapter { get; set; }
        public string Success { get; set; }
        public string Fail { get; set; }
        public virtual Story? Story { get; set; }
        public virtual ICollection<DataBaseQuestions> Questions { get; set; }

        public Chapters()
        {

        }
    }
}

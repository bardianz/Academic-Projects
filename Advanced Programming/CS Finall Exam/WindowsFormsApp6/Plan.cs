using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Plan
    {
        string lesson;
        string id;
        string teacher;

        public string lessonProperty { get { return lesson; } set { lesson = value; } }
        public string idProperty { get { return id; } set { id = value; } }
        public string teacherProperty { get { return teacher; } set { teacher = value; } }

        public Plan(string lesson, string id, string teacher)
        {
            this.lesson = lesson;
            this.id = id;
            this.teacher = teacher;
        }

    }
}

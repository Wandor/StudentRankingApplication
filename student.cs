using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRankingApplication
{
    class student
    {

        public string name { get; set; }
        public int maths { get; set; }
        public int english { get; set; }
        public int science { get; set; }
        public int total { get; set; }
        public int position { get; set; }

        public student(string name, int maths, int english, int science)
        {

            this.name = name;
            this.maths = maths;
            this.english = english;
            this.science = science;
            total = maths + english + science;
        }
    }
}

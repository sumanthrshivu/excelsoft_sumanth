using System;

namespace encapsulation_demo
{
    class studentInfo
    {

        private string id;
        private string name;
        private int marks;

        public string std_id
        {
            get { return id; }
            set { id = value; }
        }
        public string std_name
        {
            get { return name; }
            set { name = value; }
        }
        public int std_marks
        {
            get { return marks; }
            set { marks = value; }
        }

    }

    class stdinfo
    {
        static void Main()
        {
            studentInfo s1 = new studentInfo();
            s1.std_id = "12";
            s1.std_name = "sumanth";
            s1.std_marks = 80;

            Console.WriteLine(s1.std_id);
            Console.WriteLine(s1.std_name);
            Console.WriteLine(s1.std_marks);

        }
    }

}

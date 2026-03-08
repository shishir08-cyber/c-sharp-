using System;


    class Experiement2
    {
        private string name;

        public void SetName(string n)
        {
            name = n;
        }

        public void GetName()
        {
            Console.WriteLine("Student Name: " + name);
        }
    }

    class Experiment2
    {
        static void Main()
        {
            Experiement2 s = new Experiement2();
            s.SetName("Varad Bhagwan Sonad");
            s.GetName();
            Console.ReadLine();
        }
    }


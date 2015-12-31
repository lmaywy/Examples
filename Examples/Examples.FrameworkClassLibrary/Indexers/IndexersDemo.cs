using System;

namespace Examples.FrameworkClassLibrary.Indexers
{
    public class IndexersDemo
    {
        public static void Demo()
        {
            SampleCollection<string> names = new SampleCollection<string>();
            names[0] = "zhang san";
            names[1] = "li si";
            Console.WriteLine("using indexers to access the first element: {0}", names[0]);

            Sample sample=new Sample();
            sample[1] = 1;
            Console.WriteLine("using indexers to access the second element: {0}", sample[1]);
        }
    }
}

using System;
using System.Linq;

namespace Examples.FrameworkClassLibrary.Reflection
{
    public class TypeDemo
    {
        /// <summary>
        /// demo sutiation:
        ///     given get a System.Type instance using typeof/instance.GetType()
        ///     when retrieve infomation related to this type
        ///     then should get info like interfaces,methods,fields,properties,constructors,events,attributes
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("Reflection : Type Demo");
            var instance = new Sample { Name = "May" };
            //var type = typeof(Sample);
            var type = instance.GetType();
            Console.WriteLine("FullName:{0}", type.FullName);

            //gets all the interfaces implemented or inherited
            var interfaces = type.GetInterfaces();
            interfaces.ToList().ForEach(t =>
            {
                Console.WriteLine("Interfaces:{0}", t.FullName);
            });

            //gets all the public methods of the current
            var methods = type.GetMethods();
            methods.ToList().ForEach(m =>
            {
                Console.WriteLine("methods:{0} is method public:{1}", m.Name, m.IsPublic);
                var parameters = m.GetParameters();
                Console.WriteLine("methods:{0} parameters:{1}", m.Name, string.Join(",", parameters.Select(c => c.Name).ToArray()));
                if (!parameters.Any())
                {
                    m.Invoke(instance, null);
                }
            });

            //gets all the public fields of the current
            var fields = type.GetFields();
            fields.ToList().ForEach(f =>
            {
                Console.WriteLine("fields:{0} is public:{1}", f.Name, f.IsPublic);
            });

            //gets all the public properties of the current
            var properties = type.GetProperties();
            properties.ToList().ForEach(p =>
            {
                Console.WriteLine("Properties:{0}", p.Name);
            });
        }
    }
}

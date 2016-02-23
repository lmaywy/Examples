using System;

namespace Examples.FrameworkClassLibrary.Convertions
{
    /// <summary>
    /// The demo of C# conversion
    /// </summary>
    public class ConversionDemo
    {
        public static void Demo()
        {
            #region implicitly/explicitly conversion between value type
            //implicitly conversion
            int i = 10;
            double j = i; // i to j using implict int => double
            //int k = j; //Cannot implicitly convert type 'double' to 'int' 

            //explicitly conversion using (int) before 'j'
            int k = (int)j;
            float f = 21474836470;
            int l = (int)f; //when the value is exceed the max value of int ,it will be the min value:-2147483648 rather than throw exception
            Console.WriteLine("i:{0},j:{1},k:{2},l:{3}", i, j, k, l);
            #endregion

            #region implicitly/explicitly conversion between reference type,also include 'as' /'is'
            Animal animal = new Animal { Name = "Animal" };
            animal.Walk(); //Animal walks
            Dog dog = new Dog { Name = "Dog" };
            dog.Walk(); //Dog walks
            animal = dog; //implicitly convertion subClass to baseClass
            animal.Walk(); //Dog walks

            Animal animal2 = new Animal { Name = "Animal2" };
            //dog = (Dog)animal2; //throw InvalidCastException: Unable to cast object of type  
            //dog.Run();
            if (animal2 is Dog) // using is to check if animal is an instance of Dog
            {
                dog = (Dog)animal2;
            }
            var dog2 = animal2 as Dog; // not throw exception when it can't be converted
            Console.WriteLine(dog2 == null);
            #endregion

            #region using method(.net self method/your customize method) to do conversion like DTO framework automapper
            int val = Int32.Parse("123");
            //int val2=Int32.Parse("1ds23"); //'System.FormatException'  Input string was not in a correct format.
            int val3 = Convert.ToInt32("1234");
            int a;
            bool intFromString = Int32.TryParse("123", out a);
            #endregion

            #region boxing/unboxing & nullable type & operator '??'
            object obj = 1; // boxing =new object(1)
            int intFromObject = (int)obj;
            int? intNullable = 10;
            Console.WriteLine(intNullable.Value);
            var dog3 = new Dog();
            Console.WriteLine("{0}", (dog ?? new Dog { Age = 20 }).Age);
            #endregion

        }
    }

    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Walk()
        {
            Console.WriteLine("{0} walks", Name);
        }
    }

    class Dog : Animal
    {
        public void Run()
        {
            Console.WriteLine("Dog run");
        }
    }
}

using System;
using System.Configuration;

namespace Examples.DesignPatterns.Builder
{
    /// <summary>
    /// demo sutiation:
    /// Given a client want to order the KFC set meal
    /// KFC provider 2 different sets meal:golden meal and normal meal( both it provide humbuger,cola, chips but can be different kinds)
    /// Then using builder pattern to create the meal
    /// The process of creating the meal is the same, but the part of the meal can be different.
    /// </summary>
    public class BuilderDemo
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Demo()
        {
            var builderName = ConfigurationManager.AppSettings["builderName"];
            var director = new FoodManager();
            var builder = (FoodBuilder)Activator.CreateInstance(Type.GetType(builderName));
            director.Construct(builder);

            Food food = builder.GetFood();

            food.Show();
        }
    }
}

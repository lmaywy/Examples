
namespace Examples.DesignPatterns.Adapter
{
      /*
        1．Adapter模式主要应用于“希望复用一些现存的类，但是接口又与复用环境要求不一致的情况”，在遗留代码复用、类库迁移等方面非常有用。

        2．Adapter模式有对象适配器和类适配器两种形式的实现结构，但是类适配器采用“多继承”的实现方式，带来了不良的高耦合，所以一般不推荐使用。
                
           对象适配器采用“对象组合”的方式，更符合松耦合精神。

        3．Adapter模式的实现可以非常的灵活，不必拘泥于GOF23中定义的两种结构。例如，完全可以将Adapter模式中的“现存对象”作为新的接口方法参数，来达到适配的目的。

        4．Adapter模式本身要求我们尽可能地使用“面向接口的编程”风格，这样才能在后期很方便的适配。[以上几点引用自MSDN WebCast]
        
        */
    public class AdpaterDemo
    {
        /// <summary>
        /// Demo situation:
        /// Given a project which using a third log api to do logging, but for some reason it needs to switch to other log api instead of the exsiting one
        /// the previous log api provider:Write(),but currently it provider WriteLog(), so we need to add a adapter bettween these 2 api
        /// Then we can using adaper patter to resolve this solution
        /// Adding a adapter which inherted the previous log api interface and also using constructor to pass the new api abstract class to call the new api method 
        /// </summary>
        public static void Demo()
        {
            var logAdaptee=new DBLog();
            var log=new LogAdpater(logAdaptee); // when it swtich to the new log api,only need to change implementation for the log instance
            log.Write("test log message");
        }
    }
}

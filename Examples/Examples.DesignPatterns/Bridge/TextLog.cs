namespace Examples.DesignPatterns.Bridge
{
    class TextLog : Log
    {
        public override void Write()
        {
            Implementor.Excute("test for text");
        }
    }
}

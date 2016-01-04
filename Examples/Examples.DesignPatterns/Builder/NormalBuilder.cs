namespace Examples.DesignPatterns.Builder
{
    public class NormalBuilder : FoodBuilder
    {
        private Food NormalFood = new Food();

        public override void BuildHamb()
        {
            NormalFood.Add("NormalHamb", "��10.50");
        }

        public override void BuildCoke()
        {
            NormalFood.Add("CokeCole", "��4.50");
        }

        public override void BuildChip()
        {
            NormalFood.Add("FireChips", "��2.00");
        }

        public override Food GetFood()
        {
            return NormalFood;
        }
    }
}
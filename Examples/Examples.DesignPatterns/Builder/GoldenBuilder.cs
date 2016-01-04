namespace Examples.DesignPatterns.Builder
{
    public class GoldenBuilder:FoodBuilder
    {
        private Food GoldFood = new Food();

        public override void BuildHamb()
        {
            GoldFood.Add("GoldHamb", "￥13.50");
        }

        public override void BuildCoke()
        {
            GoldFood.Add("CokeCole", "￥4.50");
        }

        public override void BuildChip()
        {
            GoldFood.Add("FireChips", "￥3.50");
        }

        public override Food GetFood()
        {
            return GoldFood;
        }

    }
}

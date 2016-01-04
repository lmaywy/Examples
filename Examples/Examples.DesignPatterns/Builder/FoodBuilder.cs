namespace Examples.DesignPatterns.Builder
{
    public abstract class FoodBuilder
    {
        public abstract void BuildHamb();
        public abstract void BuildCoke();
        public abstract void BuildChip();
        public abstract Food GetFood();
    }
}

namespace Examples.DesignPatterns.Builder
{
    public class FoodManager
    {
        public void Construct(FoodBuilder builder)
        {
            builder.BuildHamb();

            builder.BuildCoke();

            builder.BuildChip();
        }
    }
}

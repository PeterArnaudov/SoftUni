namespace DependencyInversion
{
    public class PrimitiveCalculator
    {
        private ICalculationStrategy calculationStrategy;

        public PrimitiveCalculator()
        {
            this.calculationStrategy = new AdditionStrategy();
        }

        public void ChangeStrategy(char strategyType)
        {
            ICalculationStrategy strategy = null;

            if (strategyType == '+')
            {
                strategy = new AdditionStrategy();
            }
            else if (strategyType == '-')
            {
                strategy = new SubtractionStrategy();
            }
            else if (strategyType == '*')
            {
                strategy = new MultiplicationStrategy();
            }
            else if (strategyType == '/')
            {
                strategy = new DivisionStrategy();
            }

            this.calculationStrategy = strategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.calculationStrategy.Calculate(firstOperand, secondOperand);
        }
    }
}

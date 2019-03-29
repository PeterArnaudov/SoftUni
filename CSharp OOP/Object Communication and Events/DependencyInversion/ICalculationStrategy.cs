namespace DependencyInversion
{
    using System;

    public interface ICalculationStrategy
    {
        int Calculate(int leftOperand, int rightOperand);
    }
}

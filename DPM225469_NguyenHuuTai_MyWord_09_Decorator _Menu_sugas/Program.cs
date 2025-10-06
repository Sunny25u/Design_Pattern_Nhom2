using System;
using static System.Console;

// Component
public abstract class Beverage
{
    public abstract string Description { get; }
    public abstract double Cost();
}

// ConcreteComponent
public class Espresso : Beverage
{
    public override string Description => "Espresso";
    public override double Cost() => 2.0;
}

public class Latte : Beverage
{
    public override string Description => "Latte";
    public override double Cost() => 3.5;
}

// Decorator
public abstract class BeverageDecorator : Beverage
{
    protected Beverage beverage;

    public BeverageDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }
}

// ConcreteDecorator
public class Milk : BeverageDecorator
{
    public Milk(Beverage beverage) : base(beverage) { }

    public override string Description => beverage.Description + ", Milk";
    public override double Cost() => beverage.Cost() + 0.5;
}

public class Sugar : BeverageDecorator
{
    public Sugar(Beverage beverage) : base(beverage) { }

    public override string Description => beverage.Description + ", Sugar";
    public override double Cost() => beverage.Cost() + 0.2;
}

public class WhippedCream : BeverageDecorator
{
    public WhippedCream(Beverage beverage) : base(beverage) { }

    public override string Description => beverage.Description + ", Whipped Cream";
    public override double Cost() => beverage.Cost() + 0.7;
}

// Program
public class Program
{
    public static void Main()
    {
        // Order 1: Espresso with Milk and Sugar
        Beverage order1 = new Espresso();
        order1 = new Milk(order1);
        order1 = new Sugar(order1);

        WriteLine($"{order1.Description} : ${order1.Cost()}");

        // Order 2: Latte with Whipped Cream
        Beverage order2 = new Latte();
        order2 = new WhippedCream(order2);

        WriteLine($"{order2.Description} : ${order2.Cost()}");

        // Order 3: Latte with Milk, Sugar, Whipped Cream
        Beverage order3 = new Latte();
        order3 = new Milk(order3);
        order3 = new Sugar(order3);
        order3 = new WhippedCream(order3);

        WriteLine($"{order3.Description} : ${order3.Cost()}");

        ReadKey();
    }
}

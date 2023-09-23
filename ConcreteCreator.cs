namespace CSharp23._09
{
    public class ConcreteCreator1 : Creator
    {
        public override Product FactoryMethod(string info) =>  new ConcreteProduct1(info);
    }

    public class ConcreteCreator2 : Creator
    {
        public override Product FactoryMethod(string info) => new ConcreteProduct2(info);
    }
}
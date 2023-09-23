namespace CSharp23._09
{
    public class ConcreteCreator1
    {
        public string AnOperation(string info)
        {
            ConcreteProduct1 newProduct = FactoryMethod(info);
            newProduct.Transform();
            newProduct.Transform();
            return newProduct.GetInfo();
        }
        public virtual ConcreteProduct1 FactoryMethod(string info) =>  new ConcreteProduct1(info);
    }

    public class ConcreteCreator2 : ConcreteCreator1
    {
        public override ConcreteProduct1 FactoryMethod(string info) => new ConcreteProduct2(info);
    }
}
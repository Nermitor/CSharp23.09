namespace CSharp23._09
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod(string info);

        public string AnOperation(string info)
        {
            Product newProduct = FactoryMethod(info);
            newProduct.Transform();
            newProduct.Transform();
            return newProduct.GetInfo();
        }
    }

    public abstract class Product
    {
        public abstract void Transform();
        public abstract string GetInfo();
    }
}
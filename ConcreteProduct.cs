using System.Linq;

namespace CSharp23._09
{
    public class ConcreteProduct1
    {
        protected string info;

        public ConcreteProduct1(string info)
        {
            this.info = info.ToLower();
        }
        public virtual void Transform()
        {
            string newInfo = "";
            for (int i = 0; i < info.Length - 1; i++)
            {
                newInfo += info[i];
                if (i < info.Length - 1 && info[i] != '*')
                {
                    newInfo += "*";
                }
            }
            newInfo += info[info.Length - 1];
            info = newInfo;
        }

        public string GetInfo() => info;
    }
    
    public class ConcreteProduct2 : ConcreteProduct1
    {

        public ConcreteProduct2(string info) : base(info)
        {
            this.info = char.ToUpper(info[0]) + info.Substring(1);
        }
        public override void Transform()
        {
            base.Transform();
            info = "==" + info + "==";
        }
    }
}
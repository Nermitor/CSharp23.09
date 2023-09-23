using System.Linq;

namespace CSharp23._09
{
    public class ConcreteProduct1 : Product
    {
        private string info;

        public ConcreteProduct1(string info)
        {
            this.info = info.ToLower();
        }
        public override void Transform()
        {
            string newInfo = "";
            for (int i = 0; i < info.Length - 1; i++)
            {
                newInfo += info[i];
                if (i < info.Length - 1 && info[i] != ' ')
                {
                    newInfo += ' ';
                }
            }
            newInfo += info[info.Length - 1];
            info = newInfo;
        }

        public override string GetInfo() => info;
    }
    
    public class ConcreteProduct2 : Product
    {
        private string info;

        public ConcreteProduct2(string info)
        {
            this.info = info.ToUpper();
        }
        public override void Transform()
        {
            string newInfo = "";
            for (int i = 0; i < info.Length - 1; i++)
            {
                newInfo += info[i];
                if (i < info.Length - 1 && info[i] != '*')
                {
                    newInfo += "**";
                }
            }
            newInfo += info[info.Length - 1];
            info = newInfo;
        }

        public override string GetInfo() => info;
    }
}
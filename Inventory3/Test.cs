using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory3
{
    class Test
    {
        private List<string> list;
        public Test()
        {
            list = new List<string>();

            list.Add("홍길동");
            list.Add("임꺽정");
            list.Add("장길산");

            foreach(string name in list)
            {
                Console.WriteLine(name);
            }
        }
        ~Test() 
        {
            if (list != null)
                list.Clear();
        }
    }
}

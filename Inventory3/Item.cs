using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory3
{
    class Item
    {
        private string name;
        private int cnt = 1;
        private int damage;
        

        public Item() { }

        ~Item() { }
        public string Name
        {
            get { return this.name; }
            set { this.name = value;}

        }
        public int Cnt
        {
            get { return this.cnt; }
            set { this.cnt = value; }
        }

        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }
       
        public Item(string name)
        {
            this.name = name;
        }
        public Item(string name,int cnt)
        {
            this.name = name;
            this.cnt = cnt;
        }

        public Item(string name,int damage,int cnt=1)
        {
            this.name = name;
            this.cnt = cnt;
            this.damage = damage;
        }


    }
}

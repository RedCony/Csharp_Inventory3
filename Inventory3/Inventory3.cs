using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory3
{
    class Inventory3
    {
        private List<Item> items;
        

        public Inventory3() 
        {
            this.items = new List<Item>();
        }
        ~Inventory3()
        {
            if (items != null)
                items.Clear();
        }

        public Inventory3(int narrycnt)
        {
            if (items != null)
            {
                this.items = new List<Item>(narrycnt);
            }
           
        }
        public void AddItem(Item item)
        {
            Item fitem = this.FndItem(item.Name);
            if(fitem != null)
            {
                fitem.Cnt++;
            }
            else
            {
                this.items.Add(item);
            }
        }

        private Item FndItem(string name)
        {
            Item fnditem = null;
            foreach(Item item in this.items)
            {
                if (item.Name == name)
                {
                    fnditem = item;
                    break;
                }
            }
            return fnditem;
        }
        public int GetCont()
        {
            int ttl = 0;
            foreach(Item item in this.items)
            {
                ttl += item.Cnt;
            }
            return ttl;
        }
        public Item FindItemByName(string name)
        {
            Item foundItem = this.FndItem(name);
            Item rtnitem = null;
            
            if (foundItem != null)
            {
                rtnitem = new Item(foundItem.Name);
                foundItem.Cnt -= 1;
                if (foundItem.Cnt <= 0)
                {
                    this.items.Remove(foundItem);
                }
            }
            return foundItem;
        }
        public void PrintItems()
        {
            if (this.items.Count <= 0)
            {
                Console.WriteLine("인벤토리가 비었습니다.");
            }
            else
            {
                foreach (Item item in this.items)
                {
                    Console.WriteLine("{0}*{1}",item.Name,item.Cnt);
                }
            }
           
        }


    }
}

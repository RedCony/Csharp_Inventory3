using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("홍길동",2 ,50, 2);
            Item item = new Item("장검", 3);
            hero.GetItem(item);
            hero.EquipItem("장검");

            var damage = hero.GetDamage();  //5 
            Console.WriteLine(damage);

            Wolf wolf = new Wolf("울프1", 20, 3);
            hero.Attack(wolf);

            hero.UnEquipItem();
            hero.Attack(wolf);

            hero.EquipItem("장검");
            hero.Attack(wolf);

            hero.Attack(wolf);
            hero.Attack(wolf);
            hero.Attack(wolf);
            hero.Attack(wolf);
            hero.Attack(wolf);
            hero.Attack(wolf);
            hero.Attack(wolf);
            hero.Attack(wolf);





            /*
            Hero hero = new Hero("홍길동");
            Item item = new Item("장검");
            hero.GetItem(item); 
            Console.WriteLine(hero.GetInventoryCount());    
            hero.EquipItem("장검");
            Console.WriteLine(hero.GetInventoryCount());   
            Console.WriteLine(hero.EquipedWeaponName());   
            hero.UnEquipItem();
            Console.WriteLine(hero.GetInventoryCount());    
            string weaponName = hero.EquipedWeaponName();
            if (weaponName == null)
            {
                Console.WriteLine("{0}은 착용중인 아이템이 없습니다",hero.Name);
            }
            else
            {
                Console.WriteLine(weaponName);
            }
            */



            /*
            Inventory3 inventory = new Inventory3();
            inventory.AddItem(new Item("장검"));
            inventory.AddItem(new Item("장검"));
            inventory.AddItem(new Item("장검"));

            int count = inventory.GetCont();
            Console.WriteLine(count);   

            inventory.PrintItems(); 

            Item item = inventory.FindItemByName("장검");
            if (item != null)
            {
                Console.WriteLine("{0} x{1}", item.Name, item.Cnt);    
            }

            count = inventory.GetCont();
            Console.WriteLine(count);   

            inventory.PrintItems(); 

            inventory.FindItemByName("장검");
            inventory.FindItemByName("장검");

            count = inventory.GetCont();
            Console.WriteLine(count);   

            inventory.PrintItems(); 
            */






            /*
            Inventory3 inventory = new Inventory3();
            Item item0 = new Item("장검");
            Item item1 = new Item("단검");
            inventory.AddItem(item0);
            inventory.AddItem(item1);
            int count = inventory.GetCont();
            Console.WriteLine(count);   //2
            inventory.PrintItems();
           
           
            Item foundItem = inventory.FindItemByName("장검");
            Console.WriteLine(foundItem.Name);  //장검 
            count = inventory.GetCont();
            Console.WriteLine(count);   //1

            foundItem = inventory.FindItemByName("활");
            if (foundItem != null)
            {
                Console.WriteLine(foundItem.Name);
            }
            else
            {
                Console.WriteLine("활을 찾지 못했습니다.");
            }
            */

        }
    }
}

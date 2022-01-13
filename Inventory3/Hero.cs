using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory3
{
    class Hero
    {
        private string name;
        private Inventory3 inventory;
        private int hp;
        private int damage;
        public Item weapon;

        public Hero() 
        {
            inventory = new Inventory3();
        }
        ~Hero() { }

        public string Name
        {
            get { return this.name; }
            set { this.name = value;}
        }
        public int HP
        {
            get { return this.hp; }
            set { this.hp = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }

        public Hero(string name)
        {
            this.name = name;
            inventory = new Inventory3();
        }

        public Hero(string name,int narrycnt)
        {
            this.name = name;
            if(inventory != null)
            {
                inventory = new Inventory3(narrycnt);
            }
        }

        public Hero(string name, int narrycnt,int hp,int damage)
        {
            this.name = name;
            this.hp = hp;
            this.damage = damage;
            if (inventory != null)
            {
                inventory = new Inventory3(narrycnt);
            }
        }

        public void GetItem(Item item)
        {
            this.inventory.AddItem(item);
        }

        public void EquipItem(string name) 
        {
            Item item = this.inventory.FindItemByName(name);
            this.weapon = item;
            Console.WriteLine("{0}이 {1}을(를) 장착 하였습니다.",this.Name,this.weapon.Name);
        }

        public int GetInventoryCount()
        {
            return this.inventory.GetCont();
        }

        public string EquipedWeaponName()
        {
            if(this.weapon != null)
            {
                return this.weapon.Name;
            }
            return null;
        }

        public void UnEquipItem()
        { 
            if(this.weapon != null)
            {
                Console.WriteLine("{0}이 {1}을(를) 해제 하였습니다.", this.Name,this.weapon.Name);
                this.inventory.AddItem(this.weapon);
                this.weapon = null;
            }
            else
            {
                Console.WriteLine("{0}은 착용중인 아이템이 없습니다.",this.Name);
            }
        }

        public int GetDamage()
        {
            if(this.weapon != null)
            {
                return this.damage + this.weapon.Damage;
            }
            else
            {
                return this.damage;
            }
        }

        public void Attack(Wolf tg)
        { 
            if(tg.HP <= 0)
            {
                Console.WriteLine("{0}은 이미 명계로 떠났습니다.",tg.Name);
                return;
            }
            tg.Hit(this.GetDamage());
        }
    }
}

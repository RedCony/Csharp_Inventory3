using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory3
{
    class Wolf
    {
        private string name;
        private int hp;
        private int damage;
        private int maxHp;


        public Wolf() { }
        ~Wolf() { }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int HP
        {
            get { return this.hp; }
            set { this.hp = value; }
        }
        public int MaxHP
        {
            get { return this.maxHp; }
            set { this.maxHp = value; }
        }
        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }

        public Wolf(string name,int maxHp,int damage)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = this.maxHp;
            this.damage = damage;
        }

        public void Hit(int damage)
        {
            this.hp -= damage;
            if (this.hp <= 0)
            {
                this.hp = 0;
            }
            Console.WriteLine("{0}이 피해(-{1})을 받았습니다.{2}/{3}",this.name,this.damage,this.hp,this.maxHp);

            if(this.hp <= 0)
            {
                this.Die();

            }
        }

        public void Die()
        {
            this.hp = 0;
            Console.WriteLine("{0}이 명계로 떠났습니다.",this.name);
        }
    }
}

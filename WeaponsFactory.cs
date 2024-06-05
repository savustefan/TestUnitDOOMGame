using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Design_Patterns___DOOM_Game
{
    public abstract class Weapon
    {
        public abstract void Use();
    }

    public class Chainsaw : Weapon
    {
        public override void Use()
        {
            Console.WriteLine("Chainsaw found!");
        }
    }

 
    abstract class WeaponFactory
    {
        public abstract Weapon CreateWeapon();
    }

    class ChainsawFactory : WeaponFactory
    {
        public override Weapon CreateWeapon()
        {
            return new Chainsaw();
        }
    }


}
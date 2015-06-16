using UnityEngine;
using System.Collections;


namespace BurgZergArcade.ItemSystem
{
    public interface IISDestructable 
    {
        int Durability { get; }
        int MaxDurability { get; }

        void TakeDamage(int dmg);
        void Break();
        void RepairItem();

        //durability
        //takedamage
    }
}
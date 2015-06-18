using UnityEngine;
using System.Collections;
using System;

namespace BurgZergArcade.ItemSystem
{
    [System.Serializable]
    public class ISWeapon : ISObject, IISWeapon, IISDestructable, IISEquipable, IISGameObject
    {
        [SerializeField] int _minDamage;

        [SerializeField] int _durability;
        [SerializeField] int _maxDurability;
        [SerializeField] ISEquipmentSlot _equipmentSlot;
        [SerializeField] GameObject _prefab;

        public ISWeapon()
        {
            _equipmentSlot = new ISEquipmentSlot();
            _prefab = new GameObject();

        }
        public ISWeapon(int dur, int maxDur, ISEquipmentSlot equipSlot, GameObject prefab)
        {
            _durability = dur;
            _maxDurability = maxDur;
            _equipmentSlot = equipSlot;
            _prefab = prefab;
        }

        public int Attack
        {
            
            get { return 0; }
            set { return; }
           
        }

        public void TakeDamage(int dmg)
        {
            _durability -= dmg;
            if (_durability < 0)
            {
                _durability = 0;
            }

        }

        public void Break()
        {
            _durability = 0;
        }

        public void RepairItem()
        {
            _maxDurability--;

            if (_maxDurability > 0)
            _durability = _maxDurability;
             
        }

        public bool Equip()
        {
            throw new NotImplementedException();
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        public int Durability
        {
            get
            {
                return _durability;
            }
        }

        public int MaxDurability
        {
            get
            {
                return _maxDurability;
            }
        }

        public ISEquipmentSlot EquipmentSlot
        {
            get {return _equipmentSlot;}
        }

        public GameObject Prefab
        {
            get { return _prefab; }
            
        }
    }
}
using UnityEngine;
using System.Collections;
using System;
using UnityEditor;

namespace BurgZergArcade.ItemSystem
{
    [System.Serializable]
    public class ISWeapon : ISObject, IISWeapon, IISDestructable, IISGameObject
    {
        [SerializeField] int _minDamage;

        [SerializeField] int _durability;
        [SerializeField] int _maxDurability;
        [SerializeField] ISEquipmentSlot _equipmentSlot;
        [SerializeField] GameObject _prefab;
        public EquipmentSlot equipmentSlot;

        public ISWeapon()
        {
            _equipmentSlot = new ISEquipmentSlot();
         

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


        //This code will go in a new scriot later on. 
        public override void OnGUI()
        {
            base.OnGUI();
            //  Name = EditorGUILayout.TextField("Name: ", Name);

            _minDamage = System.Convert.ToInt32(EditorGUILayout.TextField("Min Dmg", _minDamage.ToString()));
            _durability = System.Convert.ToInt32(EditorGUILayout.TextField("Durability", _durability.ToString()));
            _maxDurability = System.Convert.ToInt32(EditorGUILayout.TextField("Max Dmg", _maxDurability.ToString()));

            DisplayEquipmentSlot();
            DisplayPrefab();
            
        
        }

        public void DisplayEquipmentSlot()
        {
            equipmentSlot = (EquipmentSlot)EditorGUILayout.EnumPopup("Equipment Slot",equipmentSlot);
      
            GUILayout.Label("Equipment slot");
        }

        public void DisplayPrefab()
        {
          _prefab = EditorGUILayout.ObjectField("Prefab", _prefab, typeof(GameObject), false) as GameObject;
 
          
        }


    }
}
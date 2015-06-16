using UnityEngine;
using System.Collections;
using System;

namespace BurgZergArcade.ItemSystem
{
    [System.Serializable]
    public class ISObject : IISObject
    {
        [SerializeField] Sprite _icon;
        [SerializeField] string _name;
        [SerializeField] int _value;
        [SerializeField] int _burdon;
        [SerializeField] ISQuality _quality;



        public int Burdon
        {
            get { return _burdon; }

            set { _burdon = value; }
        }



        public Sprite Icon
        {
            get { return _icon; }

            set { _icon = value; }
        }



        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }



        public ISQuality Quality
        {
            get { return _quality; }

            set { _quality = value; }
        }



        public int Value
        {
            get { return _value; }

            set { _value = value; }
        }
    }
}
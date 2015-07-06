using UnityEngine;
using System.Collections;
using System;
using UnityEditor;

namespace BurgZergArcade.ItemSystem
{
    [System.Serializable]
    public class ISObject : IISObject
    {
        [SerializeField]  string _name;
        [SerializeField]  Sprite _icon;
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


        //This code is going to be placed in a new class later on.
 
        ISQualityDatabase qdb;
        int qualitySelectedIndex = 0;
        string[] option = new string[] { "com", "unc", "rar" };

        public virtual void OnGUI()
        {
            GUILayout.BeginVertical();
            _name = EditorGUILayout.TextField("Name", _name);
            _value = System.Convert.ToInt32(EditorGUILayout.TextField("Value", _value.ToString()));
            _burdon = System.Convert.ToInt32(EditorGUILayout.TextField("Burdon", _burdon.ToString()));
            DisplayIcon();
            DisplayQuality();
            GUILayout.EndVertical();
        }

        public void DisplayIcon()
        {
            GUILayout.Label("Icon");
        }



        public int SelectedQualityID
        {
          get { return qualitySelectedIndex; }
        }

        public ISObject()
        {
             string DATABASE_NAME = @"bzaDatabase.asset";
             string DATABASE_PATH = @"Database";
             qdb = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
            option = new string[qdb.Count];
            for (int cnt = 0; cnt < qdb.Count; cnt++)
            {
                option[cnt] = qdb.Get(cnt).Name;
            }
        }




        public void DisplayQuality()
        {
            GUILayout.Label("Quality");
           qualitySelectedIndex = EditorGUILayout.Popup("Quality", qualitySelectedIndex, option);
            _quality = qdb.Get(SelectedQualityID);
        }
    }
}
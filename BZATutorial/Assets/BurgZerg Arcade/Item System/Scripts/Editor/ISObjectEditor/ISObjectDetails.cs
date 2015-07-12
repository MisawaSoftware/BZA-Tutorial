using UnityEngine;
using UnityEditor;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor   
    {
        enum DisplayState
        {
            NONE, 
            DETAILS
        };
        ISWeapon tempWeapon = new ISWeapon();
        bool showNewWeaponDetails = false;
        DisplayState state = DisplayState.NONE;


        void ItemDetails()
        {

            GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.BeginVertical( GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));

            EditorGUILayout.LabelField("State: " + state);
            switch (state)
            {
                case DisplayState.DETAILS:
                        DisplayNewWeapon();
                    break;
                default:
                    break;
            }


            
            GUILayout.EndVertical();
         

            //GUILayout.Space(50);
            GUILayout.BeginHorizontal();
            
            DisplayButtons();
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();
        }



        void DisplayNewWeapon()
        {
   
            tempWeapon.OnGUI();
            
  
        }

        void DisplayButtons()
        {

            if (state == DisplayState.NONE)
            {
                if (GUILayout.Button("Create Weapon"))
                {
                    tempWeapon = new ISWeapon();
                    state = DisplayState.DETAILS;
                    Debug.Log("Create new weapon");
                }
            }
            else
            {
                if (GUILayout.Button("Save"))
                {
                    if (_selectedIndex == -1)
                        database.Add(tempWeapon);
                    else
                        database.Replace(_selectedIndex,tempWeapon);

                    state = DisplayState.NONE;
                    database.Add(tempWeapon);
                        tempWeapon = null;
                    _selectedIndex = -1;
                }

                if (GUILayout.Button("Cancel"))
                {
                    tempWeapon = null;
                    showNewWeaponDetails = false;
                    state = DisplayState.NONE;
                    _selectedIndex = -1;
                }
            }
        }
    }
}
﻿using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor   
    {
        ISWeapon tempWeapon = new ISWeapon();
        bool showNewWeaponDetails = false;

        void ItemDetails()
        {

            GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.BeginVertical( GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
           

            if (showNewWeaponDetails)
                DisplayNewWeapon();
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

            if (!showNewWeaponDetails)
            {
                if (GUILayout.Button("Create Weapon"))
                {
                    tempWeapon = new ISWeapon();
                    showNewWeaponDetails = true;
                    Debug.Log("Create new weapon");
                }
            }
            else
            {
                if (GUILayout.Button("Save"))
                {
                    showNewWeaponDetails = false;
                }

                if (GUILayout.Button("Cancel"))
                {
                    tempWeapon = null;
                    showNewWeaponDetails = false;
                }
            }
        }
    }
}
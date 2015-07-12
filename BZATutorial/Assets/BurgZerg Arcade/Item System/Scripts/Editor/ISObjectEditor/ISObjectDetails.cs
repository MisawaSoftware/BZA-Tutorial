using UnityEngine;
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
           
            switch (state)
            {
                case DisplayState.DETAILS:
                    if (showNewWeaponDetails)
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

                    //string DATABASE_NAME = @"bzaDatabase.asset";
                    //string DATABASE_PATH = @"Database";
                    //ISQualityDatabase qdb;
                    //qdb = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
                    //tempWeapon.Quality = qdb.Get(tempWeapon.SelectedQualityID);
          
                    database.Add(tempWeapon);
                    tempWeapon = null;
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
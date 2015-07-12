using UnityEngine;
using System.Collections;
using UnityEditor; 

namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {


        ISWeaponDatabase database;
       
        //int selectedIndex = -1;

        const int SPRITE_BUTTON_SIZE = 46;
        const string DATABASE_NAME = @"bzaWeaponDatabase.asset";
        const string DATABASE_PATH = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;

        [MenuItem("BZA/Database/Item System Editor %#o")]
        public static void Init()
        {
            ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
            window.minSize = new Vector2(800, 600);
            window.titleContent.text = "Item System";
            window.Show();

        }



        void OnEnable()
        {
            if (database == null)
            database = ISWeaponDatabase.GetDatabase<ISWeaponDatabase>(DATABASE_PATH, DATABASE_NAME);
        }



        void OnGUI()
        {
            TopTabBar();
            GUILayout.BeginHorizontal();
            ListView();
            ItemDetails();
            GUILayout.EndHorizontal();

 
        } 


    }
}
using UnityEngine;
using System.Collections;
using UnityEditor; 

namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor : EditorWindow
    {
        [MenuItem("BZA/Database/Item System Editor %#o")]
        public static void Init()
        {
            ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor>();
            window.minSize = new Vector2(800, 600);
            window.title = "Item System";
            window.Show();

        }



        void OnEnable()
        {
           

        }



        void OnGUI()
        {
            TopTabBar();
            ListView();
        }


    }
}
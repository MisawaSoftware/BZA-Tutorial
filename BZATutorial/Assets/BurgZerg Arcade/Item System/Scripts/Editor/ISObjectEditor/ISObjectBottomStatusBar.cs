using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        void BottomStatusBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            GUILayout.Label("Bottom status bar view");
            GUILayout.EndHorizontal();
        }
    }
}
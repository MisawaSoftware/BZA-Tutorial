using UnityEngine;
using System.Collections;


namespace BurgZergArcade.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        Vector2 _scrollPos = Vector2.zero;
        void ListView()
        {

            _scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(200));
            GUILayout.Label("Hi");
            GUILayout.EndScrollView();

        }

    }
}

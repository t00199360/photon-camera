using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.NFEditor
{
    public class NoteCompleteWindow : EditorWindow
    {
        private const string MESSAGE =
            "\n\nNice try! However, these features are only available in Pro-version of NaturalFront Unity Plugin, including:\n\n • Automatic animation between key-frames\n\n • Synchronization of animation and audio, including lip-sync \n\n • Realistic and wide-range of facial movements. \n\n";


        public void OnGUI()
        {
            Color defaultTextColor = EditorGUIUtility.isProSkin ? Color.white : Color.black;

            GUI.skin.button.normal.textColor = defaultTextColor;
            GUI.skin.button.onHover.textColor = defaultTextColor;
            GUI.skin.label.normal.textColor = defaultTextColor;
            GUI.skin.label.onNormal.textColor = defaultTextColor;
            GUI.skin.label.onHover.textColor = defaultTextColor;
            EditorStyles.radioButton.onFocused.textColor = defaultTextColor;
            EditorStyles.radioButton.onHover.textColor = defaultTextColor;
            EditorStyles.radioButton.onActive.textColor = defaultTextColor;
            EditorStyles.radioButton.onNormal.textColor = defaultTextColor;
            EditorStyles.radioButton.normal.textColor = defaultTextColor;

            DrawInstructions();

        }

        private void DrawInstructions()
        {
            GUI.TextArea(new Rect(5, 30, 400, 230), MESSAGE);

            GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
            Color linkColor = EditorGUIUtility.isProSkin ? new Color(0.5f, 0.5f, 1) : Color.blue;
            linkStyle.normal.textColor = linkColor;
            linkStyle.hover.textColor = linkColor;

            if (GUI.Button(new Rect(5, 278, 250, 20), "Get the Pro-version", linkStyle))
            {
                Application.OpenURL("http://u3d.as/JRW");
            }

        }

    }
}

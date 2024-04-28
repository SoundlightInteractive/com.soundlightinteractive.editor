#if UNITY_EDITOR
using SoundlightInteractive.Utils;
using UnityEditor;
using UnityEngine;

namespace SoundlightInteractive.Editor
{
    public class ShowAllHiddenItemsToolWindow : MonoBehaviour
    {
        [MenuItem("Puffer Software/Show All Hidden Items", false, 1)]
        public static void ShowAllHiddenItems()
        {
            foreach (GameObject obj in FindObjectsOfType<GameObject>())
            {
                if (obj.hideFlags == HideFlags.HideInHierarchy)
                {
                    obj.hideFlags = HideFlags.None;
                }
            }

            EditorApplication.RepaintHierarchyWindow();
            SIDebug.Log("<color=orange> <color=green>Success : </color>All Hidden Items Showing!</color>");
        }
    }
}

#endif
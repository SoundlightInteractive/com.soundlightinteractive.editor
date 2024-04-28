#if UNITY_EDITOR
using SoundlightInteractive.Utils;
using UnityEditor;
using UnityEngine;

namespace SoundlightInteractive.Editor
{
    public class ClearAllPlayerPrefsToolWindow : MonoBehaviour
    {
        [MenuItem("Soundlight Interactive/Clear All Player Prefs", false, 1)]
        public static void ClearAllPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
            SIDebug.Log("<color=orange> <color=green>Success : </color>All Player Prefs Cleared!</color>");
        }
    }
}
#endif
using PlanetaGameLabo.UNetCustom;
using UnityEditor;
using UnityEngine;

namespace PlanetaGameLabo.Editor {
    internal static class UnityInternal {
        internal static GUIContent EditorGUILayoutInternalTrTextContent(string param1, string param2 = null) {
            if (param2 != null) {
                return (GUIContent)typeof(EditorGUIUtility).GetMethod("TrTextContent").Invoke(null, new object[] { param1, param2 });
            }
            else {
                return (GUIContent)typeof(EditorGUIUtility).GetMethod("TrTextContent").Invoke(null, new object[] { param1 });
            }
        }
    }
}

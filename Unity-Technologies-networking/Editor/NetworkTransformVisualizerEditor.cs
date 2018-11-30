using PlanetaGameLabo.UNetCustom;
using UnityEditor;

namespace PlanetaGameLabo.Editor {
    [CustomEditor(typeof(NetworkTransformVisualizer), true)]
    [CanEditMultipleObjects]
    public class NetworkTransformVisualizerEditor : NetworkBehaviourInspector
    {
        internal override bool hideScriptField
        {
            get
            {
                return true;
            }
        }
    }
}

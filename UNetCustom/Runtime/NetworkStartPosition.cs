#if ENABLE_UNET
using System;
using UnityEngine;

namespace PlanetaGameLabo.UNetCustom
{
    [DisallowMultipleComponent]
    [AddComponentMenu("PlanetaGameLabo/UNetCustom/NetworkStartPosition")]
    public class NetworkStartPosition : MonoBehaviour
    {
        public void Awake()
        {
            NetworkManager.RegisterStartPosition(transform);
        }

        public void OnDestroy()
        {
            NetworkManager.UnRegisterStartPosition(transform);
        }
    }
}
#endif

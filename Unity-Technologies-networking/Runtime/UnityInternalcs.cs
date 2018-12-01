using System.Net;
using UnityEngine.Networking;

namespace PlanetaGameLabo.UNetCustom {
    internal static class UnityInternal {
        internal static bool NetworkTransportInternalDoesEndPointUsePlatformProtocols(EndPoint end_point) {
            return (bool)typeof(NetworkTransport).GetMethod("DoesEndPointUsePlatformProtocols").Invoke(null, new object[] { end_point });
        }
    }
}

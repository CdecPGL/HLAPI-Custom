# HLAPI Custom

[![Build status](https://ci.appveyor.com/api/projects/status/g22xd40dlg6opj9n/branch/master?svg=true)](https://ci.appveyor.com/project/CdecPGL/hlapi-custom/branch/master)

Customized UNET HLAPI based on fixes branch of [HLAPI Community Edition](https://github.com/vis2k/HLAPI-Community-Edition).

## Additional Features

- Customize scene loading process in NetworkManager
- Enable/Disable client scene change when OnStartClient is called in NetworkManager
- Change Client Scene from Server in NetworkManager

### Customize scene loading process in NetworkManager

```csharp
protected virtual AsyncOperationWrapper NetworkManager.LoadSceneAsync(string newSceneName);
```

This method can be oveerrided to implement fade in/out in scene loading.

The behavior of default implementation is same as that of original HLAPI.

### Enable/Disable client scene change when OnStartClient is called in NetworkManager

```csharp
protected bool NetworkManager.enableServerAutoClientSceneChangeOnStartClient { get; set; }
```

This proterty enables us to controll automatic client scene changing when OnStartClient is called.

This proterty is used in only server and it is better to set the value in OnStartServer.

Default value is true which is same behavior as that of original HLAPI.

### Change Client Scene from Server in NetworkManager

```csharp
protected void NetworkManager.ServerChangeClientSceneToNetworkScene(NetworkConnection conn = null);
```

By calling this method, we can change specific/all clients scene to scene of server.
This is usefull when NetworkManager.enableAutoClientSceneChangeOnStart is false and you want to change client scene manually.

If you pass a instance of NetworkConnection, a client of the connection will change its scene.
Otherwise, all clients will change their scenes.

## Version Numbering Rule

```text
<Major Version>.<Minor Version>.<Sub Version>

```

- Breaking Change: Increment major version number
- Feature Addition but Not Breaking Change: Increment minor version number
- Bug Fix: Increment sub version number

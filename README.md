# UNet Custom

[![Build status](https://ci.appveyor.com/api/projects/status/g22xd40dlg6opj9n/branch/master?svg=true)](https://ci.appveyor.com/project/CdecPGL/hlapi-custom/branch/master)

Customized UNet HLAPI based on fixes branch of [Mirror](https://github.com/vis2k/Mirror).

## Additional Features

- Customize scene loading process in NetworkManager

### Customize scene loading process in NetworkManager

```csharp
protected virtual AsyncOperationWrapper NetworkManager.LoadSceneAsync(string newSceneName);
```

This method can be oveerrided to implement fade in/out in scene loading.

The behavior of default implementation is same as that of original HLAPI.

## Version Numbering Rule

```text
<Major Version>.<Minor Version>.<Sub Version>

```

- Breaking Change: Increment major version number
- Feature Addition but Not Breaking Change: Increment minor version number
- Bug Fix: Increment sub version number

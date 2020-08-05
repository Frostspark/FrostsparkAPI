## Frostspark :: API

This is the repository for Frostspark's Plugin API.

To use Frostspark you'll need to use one of the bundled releases, or manually compile the server binary yourself.

**This is just a plugin API** - aka a framework for creating plugins for Frostspark's ecosystem. The API is portable and version agnostic - a plugin for a specific version of Frostspark's API should run regardless of game version running underneath. This means you **do not** get access to game code as a result.  

If you need access to game code, you'll also need to reference the FrostsparkServer binary. This means your plugin will no longer be portable between server binaries and will only work on a specific implementation of it.

This project is under construction, and isn't in a usable state.

If you'd like to contribute to the development of this project, you should talk to us on our Discord server at https://terraria.gg/discord. Head for the "Frostspark Zone ❄️" section to find out more. 

**Important notes:**
- Events marked using the `ICancellable` interface are not guaranteed to always be rolled back properly - cancellation of events in Terraria's ecosystem is provided on a 'best-effort' basis. For details on which events won't be rolled back properly, and conditions under which such failures happen, consult the engine that implements this API.
# Gatekept
See [Project website](https://blorptopia.dev/projects/gatekept) for more details

## Running it locally
```
# Setup libraries
mkdir Libs
ln -s $GAME_DATA_PATH/Managed/ Libs/Game
ln -s $GAME_PATH/MelonLoader/net6/MelonLoader.dll Libs/MelonLoader.dll

# Install the mod
ln -s $(pwd)/bin/Debug/net10.0/gatekept.dll $GAME_PATH/Mods/gatekept.dll

# Build the mod
dotnet build
```

## Technical decisions
### Why not use `string.Format`
Standard libraries seems to be a bit broken; and as this is meant as a small joke project I don't want to spend too much time on it

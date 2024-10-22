English - [中文](./README.md)
# Please follow open-source license.

# Functionalities 

### Passive
- Remove camera angle restrictions
- Fix display of Chinese player names as `□` when you use Chinese as game language
- Remove player name length restrictions (HUD and chat)
- Remove lowercase-only sending restriction
- Remove sensitive word restrictions (required by owner of the room)

### You can 
- Press `I` to turn head like crazy
- Hold `O` to open mouth
- Use arrow keys `↑ ↓ ← →` to control head movement
- Use `W A S D` to control body movement
- Hold `right mouse button` to rotate and control body rotation
- Press `delete` key to reset position and rotation
- Hold `mouse scroll wheel button` and drag the mouse to move the head forward or backward
- Press `Left Shift` and `Left Ctrl` for up and down movements

### You cannot 
- Look at other people's cards
- Modify the hand of cards
- Be Immortal

# Installation
 1. Installation [BepInEx5](https://github.com/BepInEx/BepInEx/tree/v5-lts)（[instruction](https://docs.bepinex.dev/articles/user_guide/installation/index.html)）
 2. Download dll file from [Release](https://github.com/dogdie233/LiarsBarEnhance/releases)
 3. Put the dll file in `<game root>\BepInEx\plugins`
# Custom Build
 1.  Make sure you have [.NET SDK](https://dotnet.microsoft.com/zh-cn/download)
 2.  Clone this repo
 3.  Make a directory `lib` in repo
 4.  copy all dll into this `lib` directory  (`<game root>/Liar's Bar_Data/Managed/`)
 5.  do `dotnet build -c Release` 
 6.  Your dll is in `<directory root>/bin/Release/netstandard2.1/publish/whatever_your_name.dll`

# Misc.
We are trilled to have contributions to the functionality (excluding those that affect game balance, i.e cheating), you can raise feature requests in **issues** and wait for interested developers to implement them.

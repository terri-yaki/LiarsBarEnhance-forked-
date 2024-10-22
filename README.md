---

## 中文 - [English](./README_en.md)

# 請遵守開源協議

# 功能

### 被動技

- 移除視角轉動限制
- 修復中文玩家名顯示`□`
- 移除玩家名字長度限制（HUD與聊天）
- 移除只能發送小寫限制
- 移除敏感詞限制（房主需要）

### 主動技

- 按 `I` 瘋狂轉頭
- 按住 `O` 張嘴
- `↑↓←→` 控制頭的移動
- `WASD` 控制身體移動
- 按住鼠標右鍵轉動控制身體轉動
- 按 `delete` 鍵重置位置與旋轉
- 按住 `鼠標滾輪鍵` 拖動鼠標可以讓頭前後移動
- 按 `左Shift` 與 `左Ctrl` 分別為上下移動

### 做不到

- 看別人的牌
- 修改手中的牌型
- 不死

# 安裝

1. 安裝插件加載器 [BepInEx5](https://github.com/BepInEx/BepInEx/releases)（[官方教程](https://docs.bepinex.dev/articles/user_guide/installation/index.html)）
2. 從 [Release](https://github.com/dogdie233/LiarsBarEnhance/releases) 下載插件本體（dll 後綴）
3. 將下載的 dll 放置在插件文件夾（即 `<遊戲根目錄>/BepInEx/plugins`）

# 自己構建插件

1. 確保已經安裝了 [.NET SDK](https://dotnet.microsoft.com/zh-cn/download)（6.0 或以上）
2. clone 本倉庫
3. 在項目根目錄創建 `lib` 文件夾
4. 複製遊戲的所有 dll（位於 `<遊戲根目錄>/Liar's Bar_Data/Managed/`）進 `lib` 文件夾
5. 在項目根目錄執行 `dotnet build -c Release`
6. 生成的插件文件在 `<項目根目錄>/bin/Release/netstandard2.1/publish/com.github.dogdie233.LiarsBarEnhance.dll`

# 其他

歡迎歡愉的功能貢獻（影響遊戲平衡除外），可以提起功能請求等待有興趣的開發者實現  
[BepinEx5 安裝教程【Unity 遊戲 Mod/插件製作教程 02 - BepInEx 的安裝和使用 - 哔哩哔哩】](https://www.bilibili.com/read/cv8997496/)

---

## English - [中文](./README.md)

# Please Follow the Open Source License

# Features

### Passive Abilities

- Remove camera rotation restrictions
- Fix display issue for Chinese player names showing `□`
- Remove player name length limit (HUD and chat)
- Remove restriction to send only lowercase
- Remove sensitive word restrictions (host required)

### Active Abilities

- Press `I` to rotate head wildly
- Hold `O` to open mouth
- `↑↓←→` to control head movement
- `WASD` to control body movement
- Hold right mouse button to control body rotation
- Press `delete` to reset position and rotation
- Hold `mouse wheel button` and drag to move the head forward/backward
- `Left Shift` and `Left Ctrl` to move up and down respectively

### Limitations

- Cannot see other players' cards
- Cannot modify cards in hand
- Cannot become invincible

# Installation

1. Install the plugin loader [BepInEx5](https://github.com/BepInEx/BepInEx/releases) ([Official Guide](https://docs.bepinex.dev/articles/user_guide/installation/index.html))
2. Download the plugin from [Release](https://github.com/dogdie233/LiarsBarEnhance/releases) (with `.dll` extension)
3. Place the downloaded `.dll` file in the plugins folder (`<Game Root Directory>/BepInEx/plugins`)

# Building the Plugin Yourself

1. Ensure you have installed the [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or above)
2. Clone this repository
3. Create a `lib` folder in the project root directory
4. Copy all game `.dll` files (located in `<Game Root>/Liar's Bar_Data/Managed/`) into the `lib` folder
5. Run `dotnet build -c Release` in the project root directory
6. The generated plugin file will be in `<Project Root>/bin/Release/netstandard2.1/publish/com.github.dogdie233.LiarsBarEnhance.dll`

# Others

Contributions for fun features are welcome (excluding those affecting game balance). You can submit feature requests for interested developers to implement.  
[BepinEx5 Installation Guide【Unity Game Mod/Plugin Tutorial 02 - Installing and Using BepInEx - Bilibili】](https://www.bilibili.com/read/cv8997496/)

---

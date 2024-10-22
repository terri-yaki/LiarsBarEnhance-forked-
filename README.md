中文 - [English](./README_en.md)
# 请遵守开源协议
# 请遵守开源协议
# 请遵守开源协议

# 功能

### 被动技

 - 移除视角转动限制
 - 修复中文玩家名显示`□`
 - 移除玩家名字长度限制（HUD与聊天）
 - 移除只能发送小写限制
 - 移除敏感词限制（房主需要）

### 主动技

 - 按I疯狂转头
 - 按住O张嘴
 - ↑↓←→控制头的移动
 - WASD控制身体移动
 - 按住鼠标右键转动控制身体转动
 - 按`delete`键重置位置与旋转
 - 按住`鼠标滚轮键`拖动鼠标可以让头前后移动
 - 按`左Shift`与`左Ctrl`分别为上下移动

### 做不到

 - 看别人的牌
 - 修改手中的牌型
 - 不死

# 安装

 1. 安装插件加载器[BepInEx5](https://github.com/BepInEx/BepInEx/releases)（[官方教程](https://docs.bepinex.dev/articles/user_guide/installation/index.html)）
 2. 从[Release](https://github.com/dogdie233/LiarsBarEnhance/releases)下载插件本体（dll后缀）
 3. 将下载的dll放置在插件文件夹 （即`<游戏根目录>/BepInEx/plugins`）

# 自己构建插件

 1. 确保已经安装了[.NET SDK](https://dotnet.microsoft.com/zh-cn/download)（6.0或以上）
 2. clone本仓库
 3. 在项目根目录创建`lib`文件夹
 4. 复制游戏的所有dll（位于`<游戏根目录>/Liar's Bar_Data/Managed/`）进`lib`文件夹
 5. 在项目根目录执行`dotnet build -c Release`  
 6. 生成的插件文件在`<项目根目录>/bin/Release/netstandard2.1/publish/com.github.dogdie233.LiarsBarEnhance.dll`

# 其他

欢迎欢愉的功能贡献（影响游戏平衡除外），可以提起功能请求等待有兴趣的开发者实现  
[BepinEx5安装教程【Unity游戏Mod/插件制作教程02 - BepInEx的安装和使用-哔哩哔哩】](https://www.bilibili.com/read/cv8997496/)

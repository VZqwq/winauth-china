# Windows 验证器 (WinAuth)

*WinAuth 是一款便携式、开源的 Windows 平台验证器，提供基于计数器或时间的 RFC 6238 验证器以及常见实现方案（如 Google 验证器）。WinAuth 可用于许多比特币交易网站以及游戏平台，支持 Battle.net（魔兽世界、炉石传说、风暴英雄、暗黑破坏神）、激战 2、Glyph（Rift 和上古世纪）、WildStar、RuneScape、SWTOR 以及 Steam。*

---

## 下载最新测试版

最新测试版本为 WinAuth 3.6，可在 [发布页面](https://github.com/winauth/winauth/releases)获取。除非您在测试新功能，否则请勿使用此版本。

这可能是 WinAuth 发布为 3.7 版本前的最后一个版本。它已达到使用寿命的终点，需要进行大规模 UI 改造。感谢所有使用 WinAuth、提供修复和宝贵建议的用户。

---

## 下载最新稳定版 (WinAuth 3.5)

WinAuth 提供了一种将多种两步验证服务整合在一处的便捷解决方案。

这是最新的稳定版本，可从 [发布页面](https://github.com/winauth/winauth/downloads)下载，或直接从以下链接下载：

[最新版本 (WinAuth-3.5.1)](https://github.com/winauth/winauth/releases/download/3.5.1/WinAuth-3.5.1.zip)

还有适用于 [.Net 3.5 的 WinAuth 版本](https://github.com/winauth/winauth/releases/download/3.5.1/WinAuth-3.5.1-NET35.zip)，可在 Windows 7 系统"开箱即用"地运行。

<img src="https://winauth.github.io/winauth/images/winauth3-preview.png alt="WinAuth3 Preview" />

功能包括：

  * 支持基于时间的 RFC 6238 验证器（如 Google 验证器）和基于 HOTP 计数器的验证器
  * 支持 Battle.net（魔兽世界、炉石传说、风暴英雄、暗黑破坏神 III）、激战 2、Trion / Glyph（Rift、上古世纪）、RuneScape、WildStar、SWTOR 和 Steam
  * 支持 Steam 的 SteamGuard 保护以及交易确认功能
  * 支持许多比特币交易网站，如 Coinbase、Gemini、Circle、Bitstamp、BTC-e、Cryptsy
  * 同时显示多个验证器
  * 验证码自动显示和刷新，也可手动刷新
  * 数据使用您的密码保护，锁定到 Windows 计算机或账户，或使用 YubiKey 加密保护
  * 每个验证器可有额外的密码保护
  * 支持恢复功能（针对支持的验证器，如 Battle.net 和 Rift）
  * 可选择标准图标或自定义图标
  * 热键绑定，支持标准或自定义操作（如验证码通知、键盘输入、复制到剪贴板）
  * 便携模式，防止修改其他文件或注册表设置
  * 支持 UriKeyFormat 格式的导入导出，以及从 Android 版 Authenticator Plus 导入

#### 更新

  * 3.5.1 - 问题#366：修复 Steam 故障时大量发送通知的问题。登录时隐藏确认/全部取消按钮。

### 使用方法

使用以下链接下载最新版本的 WinAuth，或前往 [发布页面](https://github.com/winauth/winauth/releases)。

需要 [Microsoft .NET 4.5](http://www.microsoft.com/en-us/download/details.aspx?id=30653) 运行环境

使用步骤：
  * 下载 WinAuth 最新稳定版
  * 无需安装，只需打开 zip 文件并将 WinAuth.exe 解压缩到计算机上的任意位置
  * 双击或运行 WinAuth.exe
  * 点击"添加"按钮来添加或导入验证器
  * 右键单击任意验证器以打开上下文菜单
  * 如果未启用自动刷新，单击右侧图标显示当前验证码
  * 点击齿轮/选项图标进入程序选项设置

从源代码编译构建：
  * 下载源代码文件或克隆项目
  * 需要 Microsoft Visual Studio 2015
  * 其他依赖项已包含在源代码树的 Third Party 文件夹中
  * 使用 [ILMerge](http://research.microsoft.com/en-us/people/mbarnett/ilmerge.aspx ) 将程序集合并为单个 exe 文件

### 新功能

3.5 版本包含 Steam 交易确认功能。

<img src="https://winauth.github.io/winauth/images/2013/07/steamconf1.png" alt="steamconf" class="aligncenter" />

如果您使用 WinAuth 3.3.7 或更早版本注册了 SteamGuard，则需要从您的 Steam 账户中移除并重新添加。这是因为 WinAuth 3.3 只保留了生成 SteamGuard 验证码所需的信息，而交易确认功能需要更多信息。

您可以进入常规 Steam 客户端，选择账户详情，然后点击"管理 Steam Guard"。点击"移除验证器"按钮并输入恢复代码（又称撤销代码——可通过在 WinAuth 中右键单击找到）。

添加新验证器后，右键单击时会有一个额外选项称为"交易确认..."。这将使用您的用户名/密码登录并显示当前待处理的交易确认。您可以点击查看更多详情，并使用按钮接受或拒绝交易。

如果您选择"记住我"，WinAuth 将保持您已登录状态（不保存用户名/密码），以便您快速再次进入交易确认界面。

---

## 常见问题

#### 它安全吗？可靠吗？

所有验证器都只是提供另一层安全保障。没有任何方案是 100% 有效的。

物理设备/钥匙扣设备目前是最好的保护方式。虽然仍然容易受到中间人攻击，但无法获取存储在其内部的密钥。如果您有任何顾虑，建议使用此类设备。

iPhone 应用程序或在未获取 Root 权限的 Android 设备上的应用程序也是安全的。无法获取存储在设备上的密钥，但某些应用提供了导出密钥的方式，如果您没有妥善保管手机，这可能会危及您的验证器的安全性。此外，如果这些应用在其他地方备份数据，这些数据也可能存在风险。

已获取 Root 权限的 Android 手机可能会被有访问权限的应用读取密钥。有些应用不对密钥进行加密，因此应视为具有风险。

WinAuth 将您的密钥存储在计算机上的加密文件中。虽然因此无法提供与独立物理设备相同的安全性，但已尽最大努力保护您机器上的密钥。如上所述，对机器的物理访问将是唯一可能危及任何验证器安全性的途径。

#### 我担心这可能是病毒 / 恶意软件 / 键盘记录器

WinAuth 自 2010 年中期以来一直被广泛使用，已有数千名用户下载使用。

它始终是开源的，允许所有人检查和审查代码。虽然提供了预编译的二进制文件，但源代码始终同时发布，以便您审查代码并自行编译。

不会向任何第三方服务器发送个人信息。它甚至看不到您的账户信息，只能看到您的验证器详情。

不会在您的机器上安装其他可执行文件。没有安装程序在您无法监控的情况下执行操作。WinAuth 是便携式的，您可以在任何位置直接运行。

#### 我在另一个网站上找到了 WinAuth，是一样的东西吗？

WinAuth 源代码上传至 GitHub：http://github.com/winauth/winauth ，预编译二进制文件在 [发布页面](https://github.com/winauth/winauth/releases)。它不在其他任何地方发布，请勿下载其他声称是 WinAuth 的程序。

#### WinAuth 将我的验证器信息保存在哪里？

与其他一些验证器应用程序不同，WinAuth 不会将您的信息存储/发送到任何第三方服务器。您的验证器信息默认保存在您的账户漫游配置文件中，即 c:\Users\<用户名>\AppData\Roaming\WinAuth。但是，此文件可以移动到任意位置，并在运行时传递给 WinAuth。

---

## 更多信息

所有商标均已被认可，包括但不限于：

  * 暴雪娱乐、Battle.net、魔兽世界、星际争霸、暗黑破坏神
  * ArenaNet、激战 2
  * Trion、Rift
  * Google
  * Microsoft
  * Steam

---

## 作者

WinAuth 由 Colin Mackie 编写。版权所有 (C) 2010-2017。

比特币捐赠地址：`1C4bMkMATViiWYsmJSDUx2MruWM785C36Y`

---

## 许可证

本程序为自由软件：您可以根据自由软件基金会发布的 GNU 通用公共许可证（许可证的第 3 版）或（如您选择的）任何后续版本重新分发和/或修改它。

本程序发布的目的是希望它有用，但不做任何保证；甚至没有关于适销性或特定用途适用性的暗示保证。有关详细信息，请参阅 GNU 通用公共许可证。

您应该随本程序收到一份 GNU 通用公共许可证副本。如果没有收到，请参阅 http://www.gnu.org/licenses/。

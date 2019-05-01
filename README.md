# C_Sharp_Basis
# C#入门
## 见识C#编写的各类应用程序

- Console
- WPF (Windows Presentation Foundation)
- Windows Form (Old)
- ASP.NET WebForms (Old)
- ASP.NET MVC (Model-View-Controller)
- WCF (Windows Communication Foundation)
- Windows Store Application
- Windows Phone Application
- Cloud (Windows Azure)
- WF (Workflow Foundation)

## 剖析 Hello World 程序
### 类 class
类是构成程序的主体
### 名称空间 namespace
名称空间以树形结构组织类（和其他类型）

  - 例如，Button类和Path类

### 类库的引用

- 类库引用是使用名称空间的基础
  - 不同类型的项目默认引用不同的类库
- DLL（动态链接库）引用（黑盒引用，没有源代码）
  - NuGet简介
  > NuGet（读作New Get）是用于微软.NET开发平台的软件包管理器，是一个Visual Studio的扩展。在使用Visual Studio开发基于.NET Framework的应用时，NuGet能够令你在项目中添加、移除和更新引用的工作变得更加快捷方便。
  >
  > 通过NuGet你可以很容易的访问到其他开发者发布的软件包，你也可以创建、分享或者发布自己的包到NuGet。微软的EntityFramework、ASP.NET MVC等或者一些常用到的第三方软件包：Json.NET、NUnit等都托管到NuGet上。
  > 
  > **为什么要用NuGet？**
  >
  > 一个大的项目不可能所有的功能都要自己去实现，有句话说的好：“不要轻易造轮子”，最简单直接的办法就是使用别人造好的“轮子”。
  > 
  > 通常引用一个类库到我们的项目中要先下载或找到类库，然后复制到项目目录，最后添加引用。
  >
  > 如果我们引用的类库有更新的版本并且我们想使用的话又要重新添加引用，一两个倒还好，如果引用数量较多的话重复添加引用是比较麻烦和枯燥的，并且要卸载引用的时候还是要经过几个步骤。
  >
  > 这也就是为什么推荐使用NuGet的原因，NuGet能够让我们轻松的实现对软件包的引用、更新和卸载。 
- 项目引用（白盒引用，有源代码）

### 依赖关系
类（或对象）之间的耦合关系

优秀的程序追求高内聚，低耦合

### 排除错误

- 仔细阅读编译器的报错
- MSDN文档和搜索引擎结合
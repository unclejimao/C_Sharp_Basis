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

----------------------------------------------

## 类、对象、类成员简介
- 类（class）是现实世界事物的模型
  - 类是对现实世界事物进行抽象的结果
  - 事物包括“物质”（实体）和“运动”（逻辑）
  - 建模是一个去伪存真、由表及里的过程
     
### 类与对象的关系

对象也叫实例，是经过“实例化”后得到的内存中的实体

- 什么时候叫“对象”，什么时候叫“实例” 

  - 对象和实例是一回事 
  - 现实世界中叫“对象”，程序世界中叫“实例”
  - 二者并无太大区别，常常混用，初学者不必迷惑

- 依照类，我们可以创建对象，这就叫“实例化”
  - 使用new操作符创建类的实例
  - 有些类是无法实例化的，比如“数学”，我们无法创建“一个数学”

- 引用变量与实例的关系
  - 孩子与气球
  - 气球不一定有孩子牵着
  - 多个孩子可以使用各自的绳子牵着同一个气球，也可以通过一根绳子牵着气球
    
### 类的三大成员
1. **属性（Property）**
- 存储数据，组合起来表示当前类或者对象的状态
2. **方法（Method）**
- 由C中的函数（function）进化而来，表示类或者对象可以做什么
- 工作中90%的时间都是在与方法打交道，因为它是“真正做事”、“构成逻辑”的成员
3. **事件（Event）**
- 类或者对象通知其他类或者对象的机制，为C#特有（Java通过其他方法实现这个机制）
- 善于用事件机制很重要


**某些特殊类或者对象在成员方面侧重点不同**

- 模型类或者对象重在属性，如Entity Framework
- 工具类或者对象重在方法，如Math，Console
- 通知类或者对象重在事件，如各种Timer
### 类的静态成员与实例成员
- 静态（static）成员在语义上表示它是“类的成员”，是类固有的属性，不能作为实例化对象的成员。

比如：类Human，可以拥有“增长率”，“总量”等属性，但是实例化后的对象“Jack”就没有“增长率”，“总量”这些属性，这些属性对于Human来说是static静态的成员。
- 实例（非静态）成员在语义上表示他是“对象的成员”

比如：对象Jack的“身高”，“体重”等属性
- 关于“绑定”（Binding）

Binding指的是编译器如何把成员与类或者对象关联起来

## C#语言基本元素概览
### C#语言基本元素
- 标记（Token）
  - **关键字（KeyWord）**
  
    关键字是预定义的保留标识符，对编译器有特殊意义。 除非前面有 @ 前缀，否则不能在程序中用作标识符。 例如，@if 是有效标识符，而 if 则不是，因为 if 是关键字。

    第一个表列出了是 C# 程序任意部分中的保留标识符的关键字。

    |请|记|住|我|
    |-|-|-|-|
    |abstract|as|base|bool|
    |break|byte|case|catch|
    |char|checked|class|const|
    |continue|decimal|default|delegate|
    |do|double|else|enum|
    |event|explicit|extern|false|
    |finally|fixed|float|for|
    |foreach|goto|if|implicit|
    |in|int|interface|internal|
    |is|lock|long|namespace|
    |new|null|object|operator|
    |out|override|params|private|
    |protected|public|readonly|ref|
    |return|sbyte|sealed|short|
    |sizeof|stackalloc|static|string|
    |struct|switch|this|throw|
    |true|try|typeof|uint|
    |ulong|unchecked|unsafe|ushort|
    |using|using static|virtual|void|
    |volatile|while|
    
    **上下文关键字**
    
     上下文关键字仅在一部分程序上下文中有特殊含义，可以在相应上下文范围之外用作标识符。 一般来说，C# 语言中新增的关键字会作为上下文关键字添加，以免破坏用旧版语言编写的程序。


    |上|下|文|
    |-|-|-|
    |add|alias|ascending|
    |async|await|by|
    |descending|dynamic|equals|
    |from|get|global|
    |group|into|join|
    |let|nameof|on|
    |orderby|partial（类型）|partial（方法）|
    |remove|select|set|
    |值|var|when（筛选条件）|
    |where（泛型类型约束）|where（查询子句）|yield|

  - 操作符（Operator）
  - 标识符（Identifier）

    标识符是程序员给变量、类等起的名字。无论任何标识符，在命名时应赋予其意义，方便别人读懂

    - 什么是合法的标识符？
      - 不与关键字冲突。如果想用关键字作为标识符，需要在关键字前面加@符号
      - 可以使用字母、下划线、数字，但是不能用数字开头
    - 大小写规范
      - 驼峰法：第一个单词首字母小写，后续单词首字母大写，如myVariable。驼峰法在对变量命名时使用
      - Pascal法：每个单词的首字母都大写，如MyFirstClass。Pascal法在对类、方法、名称空间等命名时使用
    - 命名规范
      - 对类命名时，类名应该是名词或名词复数
      - 对类的成员命名时，属性名应该是名词或名词复数；方法名应该是动词或动词短语
  - 标点符号

    是符号但不参与运算。比如“{”、“}”和“;”。每个语句后面都应该有一个分号“;”。
  - 文本（字面值）
    - 整数

            int x=3;
            long y=30L;     //后缀L或者l表示它是一个长整型变量 

    - 实数

            float m=0.2F;       //后缀F或者f表示单精度浮点数类型，声明float类型后面必须加后缀
            double n=0.1D;      //后缀D或d表示它是一个双精度浮点数变量

    - 字符

            char c='c';         //使用单引号引起来，只能是一个字符
    - 字符串

            string s="c";       //双引号，可以是0个、1个、多个字符
    - 布尔

            bool b1=true;
            bool b2=false;
    - 空（null）

            string s=null;
- 注释与空白
  - 单行

            //双斜杠后面是注释内容
  - 多行（块注释）

            /*此处是块注释内容*/
            
            /*/*块注释无法嵌套,这种做法是错误的*/*/

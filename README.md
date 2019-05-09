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

## 类型（Type）

- 又名数据类型（Data Type）
    - A data type is a homogeneous collection of values, effectively presented, equipped with a set of operations which manipulate these values.
    - 是数据在内存中存储的“型号”
    - 小内存容纳大尺寸数据会丢失精度、发生错误
    - 大内存容纳小尺寸数据会导致浪费
    - 编程语言的数据类型与数学的数据类型不完全相同
- 强类型语言与弱类型语言的比较
  - C语言示例：if条件

       C语言中没有bool类型，下面的语句可以在C语言中编译过去。

       事实上只要if()判断条件不为0，都会判定为真，去执行if{}语句块。
        
       ```C
        if(x=100)
        {
            printf("It's OK\n");
        }
       ```
       但是C#中有bool类型，if()判断条件如果不是bool类型的值，编译不过去：

       ```C#
        if(x=100)
        {
            Console.WriteLine("It's OK\n");
        }
        //这句在C#中会报错
       ```
  - JavaScript示例：动态类型

       下面这句在JavaScript中不会报错，即使给原来是整数的变量赋值一个字符串：

    ```JavaScript
    function ButtonClicked(){
        var myVar=100;
        myVar="Mr. Okay!";
        alert(myVar);
    }  
    ```
  - C#语言对弱类型/动态类型的模仿

    C#是强类型语言，但是它对弱类型语言的动态类型进行了模仿

    在C#中，与JavaScript的var类似的关键字是dynamic

    **C#中的var和JavaScript中的var完全不同，不要搞混了**

    ```C#
    dynamic myVar=100;
    Console.WriteLine(myVar);
    myVar="Mr. Okay!";
    Console.WriteLine(myVar);
    //上述语句在C#中可以顺利通过编译并执行
    //JavaScript中用var声明的变量可以对其进行任意赋各种类型值
    //而C#中的var声明并赋值的变量，编译器会自动检测你赋的值的类型，之后就固定认为该变量类型就是其初值的类型，无法再对其赋其他类型的值。
    ```
### 类型再C#中的作用
**一个C#类型中所包含的信息**
  - 存储此类型变量所需的空间大小
  - 此类型值的最大、最小范围
  - 此类型所包含的成员，如方法、属性、事件等
  - 此类型是由什么基类派生而来
  - 程序运行时，此类型变量分配到内存什么位置
    - Stack简介
    - Stack overflow
    - Heap简介
    - 使用Performance Monitor查看进程的堆内存使用量
    - 关于内存泄漏
  - 此类型所允许的操作或者运算

# C#语言的类型系统
## C#五大数据类型
- 类（classes）：如Windows、Form、Console、String
- 结构体（Structures）：如Int32、Int64、Single、Double
- 枚举（Enumerations）：如HorizontalAlignment、Visibility
- 接口（Interfaces）
- 委托（Delegates）

## C#类型的派生谱系
> **面试问题：C#语言有几种数据类型？**</br>
> **回答：**</br>
> &emsp;&emsp;C#中的数据类型包括引用类型和值类型两大类，其中引用类型包括**类**、**接口**、**委托**，值类型包括**结构体**和**枚举**。五种数据类型都是以Object为自己的基类型的。</br>

**Object**</br>
|</br>
|---**引用类型（Reference Type）**</br>
|&emsp;&emsp;|</br>
|&emsp;&emsp;|---类</br>
|&emsp;&emsp;|</br>
|&emsp;&emsp;|---接口</br>
|&emsp;&emsp;|</br>
|&emsp;&emsp;|---委托</br>
|&emsp;&emsp;</br>
|&emsp;&emsp;</br>
|&emsp;&emsp;</br>
|---**值类型（Value Type）**</br>
|&emsp;&emsp;|</br>
|&emsp;&emsp;|---结构体</br>
|&emsp;&emsp;|</br>
|&emsp;&emsp;|---枚举</br>

## 变量、对象与内存
**什么是变量**</br>
&emsp;&emsp;**变量 = 以变量名所对应的内存地址为起点、以其数据所要求的存储空间为长度的一块内存区域。**

  - 表面上看，变量的用途是存储数据
  - 实际上，变量表示了 **存储位置，并且每一个变量都有一个类型，以决定什么样的值能存入变量中**
  - 变量一共有7种
    - 静态变量
    - 实例变量（成员变量，字段）
    - 数组元素
    - 值参数
    - 引用参数
    - 输出形参
    - 局部变量
  - 狭义的变量指的是局部变量，因为其他种类的变量都有自己的约定名称
    - 简单的讲，狭义变量就是方法体里面声明的变量
  - 变量的声明
    - 有效修饰符组合（可选）&emsp;类型&emsp;变量名&emsp;初始化器（可选）

- **值类型的变量**
  - 以byte、sbyte、short、ushort为例
  - 值类型没有实例，所谓的实例与变量合而为一
- **引用类型的变量**
  - 引用类型变量与实例的关系：引用类型变量存储的数据是对象的内存地址
- 局部变量是在Stack上分配内存
- 变量的默认值
- 常量（值不可改变的变量）
- 装箱与拆箱（Boxing & Unboxing）
  - Boxing ：把Stack上的值类型封装成基类Object实例存放至Heap
  - Unboxing：把Heap上存的Object实例取出，转换成Boxing前的子类存到Stack
  - 装箱和拆箱涉及到堆栈数据的转移，会损失一些性能

## 方法的定义与调用
### 方法的由来
方法前身是C/C++语言的函数，方法是面向对象的范畴，在非面向对象语言中仍称为函数
- 方法永远都是 **类（或结构体）** 的成员
  - C#中的方法不可能独立于类或结构体之外
  - 只有作为类或结构体的成员时才称作方法
  - C++中是可以独立于类或者结构体的，称为“全局函数”
- 方法是类（或结构体）最基本的成员
  - 最基本的成员只有两个——字段和方法（成员变量和成员方法），本质仍是数据+算法
  - 方法便是类（或结构体）能做什么事情
- 为什么需要方法和函数
  1. 隐藏复杂逻辑
  2. 复用
### 方法的声明与调用
- 声明方法的语法详解
  - 参见C#语言文档，在C#中，生命与定义不分家，这一点与C++有区别
  - Parameter全称为formal parameter，意为“形式上的参数”，简称“形参”
  - Parameter本质是一种变量
- 为方法命名的规范
  - 大小写规范：Pascal方式，即第一个单词首字母要大写
  - 注意需要以动词或者动词短语作为名字
- 重温静态（static）方法和实例方法
  - static方法是隶属于类的，实例化后的对象看不见
  - 实例方法是隶属于实例的，实例可以调用它
- 调用方法
  - 圆括号（）在方法调用时称为方法调用操作符，是不可以省略的
  - Argument在中文C#语言文档的官方译法为“实际参数”，简称“实参”，可以理解为调用方法是的真实条件
  - 调用方法时的argument列表要与定义方法时的parameter列表相匹配，这是因为C#是一种强类型语言，argument是值，parameter是变量，值与变量一定要匹配，否则编译器会报错
### 构造器（constructor）
- 构造器是类（class）的成员之一，又叫构造函数，是一种特殊的函数
- 狭义的构造器指的是“实例构造器”（instance constructor），用来构造实例在内存中的内部结构
- 如何调用构造器
  - 当声明类时没有为它准备构造器的话，编译器会为这个类准备一个默认的构造器
- 声明构造器
  - 声明构造器使用public修饰符，构造器没有返回值，不写返回类型，连void都不用
  - 构造器命名必须和声明的类名相同，后跟圆括号包裹的参数列表（para A，para B……）
  - 构造器内部使用this关键字代表当前类
  - 在类的内部输入ctor，然后两下tab键，可以自动生成构造器框架
  - 可以通过声明相同名称的方式进行方法重载，以给一个类多种构造器选择
- 构造器的内存原理

    ```C#
    Student stu = new Student();
    
    //对于该语句的解释
    //首先使用Student创建一个Student类的引用变量stu；
    //使用new Student创建Student类的一个实例；
    //圆括号()是方法调用操作符，表示调用Student类的构造器来构造实例的内部结构；
    //等号=将构造好的实例赋值给stu；
    //通过以上操作我们就得到了一个Student类的实例stu
    ```
    - 对于使用默认构造器（不带参数）的类来说，创建一个类实例的过程如下：
      - 由于类是引用变量，因此栈内存放的是实例在内存空间的地址，因此首先在栈内给引用变量分配一个4字节空间用于存放实例地址
      - 实例存放在内存的堆中，根据类的成员分配足够的连续空间，并将地址写入栈中保存对应引用变量的内存
      - 然后构造器对内存中的实例部分进行初始化，根据类的各字段类型进行内存划分，比如int划分4个字节、short划分2个字节，并将所有位初始化为0
      - 如下图所示
        ![](https://raw.githubusercontent.com/unclejimao/picBed/master/MemoryOfConstructorWithoutPara.png?token=ALNAEY7GASGETEUZHLH3NDS42P2HW)
    - 对于使用自定义构造器（带参数）的类来说，以
        ```C#
        Student student = new Student(1 , "Mr. Okay");
        class Student
        {
            public Student(int initId,string initName)
            {
                this.ID = initId;
                this.Name = initName;
            }
       
            public int ID;
            public string Name;
        }
        ``` 
        为例，创建一个类实例的过程如下：

        -  在栈中为引用变量student分配4个字节，用来存储实例在堆中的地址
        -  在堆中为实例分配足够的连续空间，并将地址交给堆中的引用变量。在此例中，构造器有两个类型的参数，其中int是值类型，直接分配4个字节，并根据构造器进行初始化；string是引用类型，所有要分配4个字节用来存放地址，并且在堆中另外寻找可以存放string初始化内容的内存空间，进行初始化，并将地址交给string引用变量保存
        -  如下图所示
            ![](https://raw.githubusercontent.com/unclejimao/picBed/master/MemoryOfConstructorWithPara.png?token=ALNAEYYGBHMLKLGSWTMB7DS42P2SC)


### 方法的重载（Overlord）
- 声明带有重载的方法
  - 方法签名（method signature）由方法的名称、类型形参的个数和他每一个形参（从左到右的顺序）的类型和种类（值、引用或输出）组成。
    - 方法签名不包含返回类型
  - 实例构造函数签名由它的每一个形参（从左到右的顺序）的类型和种类（值、引用或输出）组成。
  - 重载决策（到底调用哪一个重载）：用于在给定了参数列表及一组候选函数成员的情况下，选择一个最佳函数成员来实施调用
### 对方法进行debug
### 方法的调用与栈
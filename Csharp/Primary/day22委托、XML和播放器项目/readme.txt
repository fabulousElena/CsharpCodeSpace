..

1.为什么使用委托
将一个方法作为参数传递给另一个方法。
2.委托概念
委托所指向的函数必须跟委托具有相同的签名（参数和返回值）
3.匿名函数
当方法只执行一次的时候，可以使用
//lamda表达式  => goes to  去哪儿
DelSayHi del = (string name) => { Console.WriteLine("你好" + name); };
4.泛型委托
code

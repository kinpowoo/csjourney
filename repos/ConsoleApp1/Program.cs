using System;

namespace ConsoleApp1
{
    internal class Pet
    {
        public string name = "pet";
        public Pet(string name)
        {
            this.name = "我是:"+ name;
        }
    }

   internal class Dog : Pet
    {
        public string alias = "xiaoHuang";

        public Dog(string name) : base(name)
        {
            Console.WriteLine(this.name);
        }

        public int myAge(int a,int c)
        {
            Console.WriteLine("Dog age exec!");
            if(a+c > 10)
            {
                //如果狗的年龄大于10岁，通知狗死亡
                if(WhenDogDie != null)
                {
                    WhenDogDie();
                }
            }
            return a-c;
        }

        public delegate void Act();
        public event Act WhenDogDie; //声明一个狗死亡的事件
    }

    delegate int SumUp(int a, int b);
    

    class Program
    {
        static void Main(string[] args)
        {

            /*     Dog d = new Dog("小黄");
                 Console.WriteLine(d.alias);
                 SumUp del;
                 del = (a, b) =>
                 {
                     Console.WriteLine("lambda exec!");
                     return a + b;
                 };
                 del += d.myAge;
                 int result = del(5, 6);
                 Console.WriteLine("the result is :"+result);
                 Console.WriteLine("我是谁{0},你又是谁{1:d}", "哈哈", 2);

                 //为狗添加死亡通知方法
                 d.WhenDogDie += () =>
                 {
                     Console.WriteLine("我的狗死了");
                 };
                 */

            /*    //事件执行
                d.myAge(4, 7);*/

            //FileOperator.ReadFromFile();
            //FileOperator.WriteToFile("我是一段测试文字");
            ThreadPool.Play();

        }
    }
}

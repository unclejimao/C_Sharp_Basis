using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            //(new Form()).Text="My Form";
            //(new Form()).ShowDialog();

            //Form myForm = new Form();
            //Form myForm1;
            //myForm1 = myForm;
            //myForm.Text = "MyForm";
            //myForm.ShowDialog();
            //myForm1.Text = "I changed it";
            //myForm.ShowDialog();
            //上面几行代码说明赋值操作符“=”使得两个实例引用了同一个对象，类似于C中的指针

            Type myType = typeof(Form);
            PropertyInfo[] info = myType.GetProperties();
            Console.WriteLine(myType.BaseType .FullName);
            foreach (var item in info)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

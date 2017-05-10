using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    public class GlobalData
   {
      public static  List<Product> list=new List<Product>();
   }

    public class Class1
    {

       
    }
     public class Product
    {
        public int sl_no;
        public string name;
        public int quantity;
        public float price;

         public Product()
         {

         }
       public  Product(int s,string n,int q,float p)
        {
           sl_no=s;
           name=n;
           quantity=q;
           price=p;
        }

       
    }
}

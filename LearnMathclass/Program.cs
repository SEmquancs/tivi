using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMathclass
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = Math.Max(10, 25);
            Console.WriteLine($"Max({10},{25})={max}");
            Console.WriteLine("Max(10,25)="+max);

            Console.WriteLine("Nhap do tuoi cua Quan");
            int quan = System.Int32.Parse(Console.ReadLine());
            if (quan >= 18) 
            {
                Console.WriteLine("Quan phai di hoc dai hoc");
            }else
            {
                Console.WriteLine("Quan phai tiep tuc di hoc");
            }

            
            Console.WriteLine("*Bai tap 2");
            Console.WriteLine("Tim so lon nhat trong 3 so x,y,z");
            Console.WriteLine("Nhap so x= ");
            int x = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so y= ");
            int y = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so z= ");
            int z = System.Int32.Parse(Console.ReadLine());
            if(x>y)
            {
                if(y>z)
                {
                    Console.WriteLine("x la gia tri lon nhat");
                }
                else
                {
                    if(y<z)
                    {
                        if(x>z)
                        {
                            Console.WriteLine("x la gia tri lon nhat");
                        }
                        else
                        {
                            Console.WriteLine("z la gia tri lon nhat");
                        }
                    }
                    else
                    {
                        Console.WriteLine("x la gia tri lon nhat");
                    }
                }
            }
            else
            {
                if(x>z)
                {
                    Console.WriteLine("y la gia tri lon nhat");
                }
                else
                {
                    if(z<y)
                    {
                        Console.WriteLine("y la gia tri lon nhat");
                    }
                    else
                    {
                        Console.WriteLine("z la gia tri lon nhat");
                    }  
                }
                    
            }
            Console.WriteLine("Nhap vao dayofweeK:");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                default:
                    Console.WriteLine("not value");
                    break;

            }
        }
    }
}

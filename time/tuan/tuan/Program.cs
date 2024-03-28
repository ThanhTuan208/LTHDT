using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            author author = new author("tuan", "@gmail.com", 'm');  
            book book= new book("toan",author,50.5);
            book.ToString();

        }
        static void nhapMang(author[] arr)
        {
            for(int i =0; i< arr.Length; i++)
            {
                arr[i] = new author();
                Console.WriteLine("ten sach: ");
                arr[i].Name = Console.ReadLine();
                Console.WriteLine("tac gia: ");
                arr[i].Name = Console.ReadLine();
                arr[i].Email = Console.ReadLine();
                arr[i].Gender = char.Parse(Console.ReadLine());
                Console.WriteLine("gia sach: ");
                


            }
        }
    }
}

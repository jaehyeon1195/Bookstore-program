using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0930_시험
{
    class Control
    {
        BookStore bookstore = new BookStore();
       
        public static Control Instance
        {
            get; private set;
        }

        static Control()
        {
            Instance = new Control();
        }
        private Control()
        {
            bookstore.c = GetCountValue;
        }

        //9.저장
        public void CInsert()
        {
            try
            {
                Console.Write("책 제목: ");
                string name = Console.ReadLine();

                Console.Write("가격 : ");
                int price = int.Parse(Console.ReadLine());

                bookstore.Insert(name, price);
                Console.WriteLine("저장완료");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        //10전체출력
        public void CPrintAll()
        {
            try
            {
                bookstore.PrintAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        //11.검색기능
        public void CSelect()
        {
            try
            {
                Console.Write("검색할 책 제목: ");
                string name = Console.ReadLine();
                bookstore.Select(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //12.수정기능
        public void CUpdate()
        {
            try
            {
                Console.Write("수정할 책 제목: ");
                string name = Console.ReadLine();
                Console.Write("판매량 : ");
                int count = int.Parse(Console.ReadLine());
                bookstore.Update(name, count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        //13.삭제기능
        public void CDelete()
        {
            try
            {
                Console.Write("삭제할 책 제목: ");
                string name = Console.ReadLine();
                bookstore.Delelte(name);
                Console.WriteLine("삭제완료");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        //18.콜백정의
        public void GetCountValue(int c)
        {
            Console.WriteLine("누적판매량 : {0}",c);
        }
    }
}

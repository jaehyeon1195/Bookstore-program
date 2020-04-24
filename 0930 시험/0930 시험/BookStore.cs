using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0930_시험
{
    delegate void DelCount(int c);
    class BookStore
    {
        List<Book> booklist;
        public DelCount c=null;

        public BookStore()
        {
            booklist = new List<Book>();
        }

        //3.저장
        public void Insert(string n,int p)
        {
            Book book = new Book(n,p);
            booklist.Add(book);
        }

        //4.전체출력
        public void PrintAll()
        {
            foreach(Book b in booklist)
            {
                Console.WriteLine(b);
            }
        }

        //5.검색기능
        public void Select(string s)
        {
            foreach (Book b in booklist)
            {
                if (b.Name.Equals(s))
                {
                    Console.WriteLine(b);
                    return;
                }
            }
            throw new Exception("책이 존재하지않습니다.");
        }

        //6.업데이트
        public void Update(string s,int cou)
        {
            foreach (Book b in booklist)
            {
                if (b.Name.Equals(s))
                {
                    b.UpdateSal(cou);
                    c(b.Salcount);
                    return;
                }     
            }
            throw new Exception("책이 존재하지않습니다.");
        }

        //7.삭제
        public void Delelte(string s)
        {
            for (int i = 0; i < booklist.Count; i++)
            {
                Book mem = booklist[i];
                if (mem.Name.Equals(s))
                {
                    booklist.Remove(mem);
                    return;
                }
            }
            throw new Exception("책이 존재하지않습니다.");
        }


    }
}

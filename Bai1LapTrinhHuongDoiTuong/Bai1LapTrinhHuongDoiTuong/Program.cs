using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1LapTrinhHuongDoiTuong
{
    class Program
    {
        static void Main(string[] args)
        {
                                // Ví dụ về class
            //Animal dog = new Animal(); //khởi tại đối tượng dog quá lớp Animal
            //dog.chieucao = 10; //vì dog là 1 biến(1 đối tượng ) mới với 2 thuốc tính chieucao va chieurong chưa có giá trị gì nên h ta sẽ gán giá trị vào 2 thuộc tính đó
            //dog.chieurong = 20;

            //Animal cat = new Animal();
            //cat.chieucao = 5;
            //cat.chieurong = 10;

            //dog.info();  //sau khi gán giá trị rồi ta sẽ gọi phương thức đối tượng này có 
            //cat.info();

                                //#region Ví dụ về Contructor 
            cat meoden = new cat(); // Để ý khi bạn gọi new Cat bạn không truyền tham số vào thì Contructor mặc định(Contructor không tham số)
            meoden.info();          //sẽ tự động được gọi để khởi tạo giá trị mặc định cho các thuộc tính của đối tượng meoden

            cat meotrang = new cat(20,30);//Lần này ta khởi tạo đối tượng và có truyền vào 2 tham số như vậy contructor có tham số sẽ được gọi
            meotrang.info();              //như vậy thuộc tính chieucao,chieurong sẽ 0 mang giá trị mặc định nữa mà sẽ được gán theo giá trị mà ta nhập 

            Console.ReadKey();
        }
    }
    class cat  //đây là 1 class kiểu contructor
    {   public double chieucao;
        public double chieurong;
        
        //Contructor không tham số 
        public cat()
        {
            chieucao = 5;
            chieurong = 10;
        }
       
        //Contructor có tham số 
             /*
             * Các phương thức bên trong lớp có thể gọi đến các thành phần khác (bao gồm thuộc tính và phương thức)
             * trong lớp đó có nghĩa là hàm info() có thể gọi chieucao và chieurong để thực hiện bài toàn nào đó
             */
        public cat(int cc,int cr)
        {
            chieucao = cc;
            chieurong = cr;
        }
        public void info()
        {
            Console.WriteLine("Chiều cao : " + chieucao + " Chiều rộng : " + chieurong);
        }
    }
    class Animal //đây là 1 class mới 
    {
        public double chieucao; //đây là thuộc tinh của lớp động vật
        public double chieurong;
        public void info() 
        {

            /*
             * Các phương thức bên trong lớp có thể gọi đến các thành phần khác (bao gồm thuộc tính và phương thức)
             * trong lớp đó có nghĩa là hàm info() có thể gọi chieucao và chieurong để thực hiện bài toàn nào đó
             */
            Console.WriteLine("Chiều cao : " + chieucao + " Chiều rộng : " + chieurong);
        }

    }
    
}


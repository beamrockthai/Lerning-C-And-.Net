using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lean_C__and.Net // ชื่อโปรเจค
{
    internal class Lerning
    {
        static void Main(string[] args) // main ใช้สําหรับรันตัวของโปรเเกรม เวลาเขียนไว้จะทําการวิ่งเข้าหา method main เพื่ออ่านเเละทําการรัน
        {
            //// คําสั่งเเสดงผล เเบบขึ้นบรรทัดใหม่
            //Console.WriteLine(" Hello " + 5); 
            //Console.WriteLine(" World " + 5);

            //// คําสั่งเเสดงผล เเบบไม่ขึ้นบรรทัดใหม่
            //Console.Write(" Hello1 " + 5);
            //Console.Write(" World2 " + 5);

            //// การเปรียบเทียบค่าโดยใช้ == 
            //Console.WriteLine(10==5);

            // การลดรูปประโยค โดย ใช้ ลําดับการเเสดงผล {}
            //Console.WriteLine(" First Name = {0} LastName = {2} Age = {1} " , " Thatchanon " , " Rodwong " , 23 );
            //Console.WriteLine("{0} + {1} = {2}" ,  5 , 10 ,15 );

            //การนิยามตัวเเปล

            //int

            //int a = 10;
            //int b = 10;
            //int c = a + b;
            //Console.WriteLine(c);

            //float
            //float a;
            //float b;
            //float c;
            //a = 10.5f;
            //b = 15.2f;
            //c = a + b;
            //Console.WriteLine(c);

            //double
            //double a = 500;
            //double b = 50.5;
            //double c = a + b;
            //Console.WriteLine(c);

            //boolean
            //bool a = true;
            //Console.WriteLine(a);

            //Character and String
            //char N = 'A'; // เก็บ ได้เเค่ตัว อักษรเดียว โดยการครอบ ''
            //Console.WriteLine(N);
            //string Name = "Beam"; // เก็บ ได้หลายตัวอักษร โดยการครอบ ""
            //Console.WriteLine(Name);

            //รวบบรรทัด
            //int x = 10, y = 20;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Constant ค่าคงที่

            // รูปเเบบไม่ใช้ Constant
            //int Number = 1000;
            //Number = 2000; 
            //Console.WriteLine(Number);

            // รูปเเบบใช้ Constant
            //EX1
            //const float Number = 1000.4f;
            //const float Number2 = 2000.5f;
            //Console.WriteLine(Number+Number2);

            //EX2
            //const int Number = 1000;
            //Number = 2000;
            //Console.WriteLine(Number); // จะเกิด Error เพราะว่า Number เป็นค่าคงที่

            //กฏการตั้งชื่อ
            // ความหมายเหมือนกันเเต่เขียนไม่เหมือนกัน ตัวพิมใหญ่เล็กบ้างมันมองเป็นคนละคํา
            //string Name = "Beam";
            //string NAME = "Beam2";
            //Console.WriteLine(NAME);            

            //Formating String

            //int Number = 12000;
            //Console.WriteLine("Number = {0}" , Number);

            ////รูปเเบบ Exponential : Eหรือe เป็นรูปเเบบตัวเลขชี้กําลัง ใส่หลัง : เพือบงบอกรูปเเบบ Formating String
            //Console.WriteLine("NumberE = {0:E}", Number);

            ////รูปเเบบ FolatingPoint : Fหรือf เป็นรูปเเบบเเสดงทศนิยม ปกติจะเเสดงรูปเเบบ 2 ตําเเหน่ง ใส่หลัง : เพือบงบอกรูปเเบบ Formating String
            //Console.WriteLine("NumberF = {0:F}", Number);
            //Console.WriteLine("NumberF = {0:F5}", Number); //เเสดงทศนิยม 5 ตําเเหน่ง

            ////รูปเเบบ เเสดงตัวเลขรูปเเบบสั้นที่สุด : Gหรือg เป็นรูปเเบบคล้าย Exponential  ใส่หลัง : เพือบงบอกรูปเเบบ Formating String
            //Console.WriteLine("NumberG = {0:G}", Number);

            ////รูปเเบบ Number : Nหรือn เป็นรูปเเบบเเสดง , ให้กับตัวเลข เวลามีตัวเลขเยอะๆจะได้อ่านง่ายว่าหลักอะไรพร้อมทศนิยม 2 ตําเเหน่ง  ใส่หลัง : เพือบงบอกรูปเเบบ Formating String
            //Console.WriteLine("NumberN = {0:N}", Number);

            ////รูปเเบบ Percentage : Pหรือp เป็นรูปเเบบเเสดงเปอร์เซ็น พร้อมทศนิยม 2 ตําเเหน่ง  ใส่หลัง : เพือบงบอกรูปเเบบ Formating String
            //Console.WriteLine("NumberP = {0:P}", Number);

            ////รูปเเบบ Hexadecimal : Xหรือx เป็นรูปเเบบฐาน 16  ใส่หลัง : เพือบงบอกรูปเเบบ Formating String
            //Console.WriteLine("NumberP = {0:X}", Number);

            //รับค่าผ่านทางคีย์บอร์ด


            //Read ผลลัพธ์ออกมาเป็น ASCII Code  
            //int Result = Console.Read();
            //Console.WriteLine(Result); 

            //ReadLine จะรับค่าได้เเค่ String เท่านั้น เเต่ เวลากรอก สามารถพิมอะไรก็ได้เพราะมันมองเป็น string
            //Console.Write("InputFristName : "); // เเสดงผลเเบบไม่ขึ้นบรรทัดใหม่ เพราะใช้ write ไม่ได้ใช้ writeLine
            //string FristName = Console.ReadLine(); //ค่าที่ถูกกรอกจะถูกเก็บในตัวเเปล FristName 
            //Console.WriteLine("FristName = {0} ", FristName); //เเสดงผลรับที่ได้จากการพิมพ์ที่เก็บในตัวเเปล FristName เเละต้องเเสดงตําเเหน่งที่ ให้มันด้วย

            //Console.Write("InputLastName : ");
            //string LastName = Console.ReadLine();
            //Console.WriteLine("LastName = {0} ", LastName);

            //Console.Write("InputAddress = ");
            //string Address = Console.ReadLine();
            //Console.WriteLine("Address = {0}", Address);

            //ตัวดําเนินการ + - * / %
            //int a = 40;
            //int b = 30;
            //int c = a * b;
            //Console.WriteLine("OUTPUT = {0} ",c);

            //double Number = 12.5;
            //double Number2 = 14.3;
            //double Result = Number + Number2;
            //Console.WriteLine("Number = {0} Number2 = {1} Result = {2} ",Number ,Number2,Result);

            //double Number = 20.5;
            //double Number2 = 4.3;
            //Console.WriteLine("Result = {0} ", Number + Number2);
            //Console.WriteLine("Result = {0} ", Number - Number2);
            //Console.WriteLine("Result = {0} ", Number * Number2);
            //Console.WriteLine("Result = {0} ", Number / Number2);
            //Console.WriteLine("Result = {0} ", Number % Number2);




            //Console.ReadKey(); //รอให้กดปุ่มเเล้วหยุดการทํางาน
            Console.ReadLine(); //กด Enter เเล้วหยุดการทํางาน
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void NhapTTMotHoadon(object[]a )
        {

            Console.Write("Quý Ông(Bà): ");
            a[0] = Console.ReadLine();
            Console.Write("Số ngày ở: ");
            a[1] = int.Parse(Console.ReadLine());
            Console.Write("Số bữa ăn: ");
            a[2] = int.Parse(Console.ReadLine());
            Console.Write("Tiền ở: ");
            a[3] = int.Parse(Console.ReadLine());
            Console.Write("Tiền ăn: ");
            a[4] = int.Parse(Console.ReadLine());
            Console.Write("Phí phục vụ: ");
            a[5] = int.Parse(Console.ReadLine());

        }
        static long TongCong(object[]a)
        {
            return (long)(int)a[1] * (int)a[3] + (int)a[2] * (int)a[4] + (int)a[5];
        }
        
        static string XuatTTMotHoadon(object[]a)
        {

            string result = "";
            result += "\n\nKhách sạn Five Stars\n";
            result += "Hoá đơn khách sạn\n";
            result += $"Quý Ông(Bà): {a[0]}\n";
            result += $"Số ngày ở: {a[1]}\t\t";
            result += $"Số bữa ăn: {a[2]}\n";
            result += $"Tiền ở: {a[3]}\t";
            result += $"Tiền ăn: {a[4]}\t";
            result += $"Phí phục vụ: {a[5]}\n";
            result += $"Tổng Cộng: {TongCong(a)}\n";
            result += "\tHân hạnh phục vụ quý khách";
            return result;

        }
        static void NhapTTNhieuHoadon(object[][]b)
        {
            for(int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"Nhập thông tin khách hàng: {i}");
                NhapTTMotHoadon(b[i]);
            }
        }
        static string XuatTTNhieuHoadon(object[][]b)
        {
            string result = "";
            for (int i = 0; i < b.Length; i++)
                result += XuatTTMotHoadon(b[i]) + "\n\n";
            return result;

        }
        static object[][] KhoiTaoMang(int n)
        {
            object[][] b = new object[n][];
            for (int i = 0; i < b.Length; i++)
                b[i] = new object[6];
            return b;
        }
        static float Phan2(int x)
        {
            double Mau = 0;
            for (int i = x; i >= 0; i--)
            {
                Mau = Math.Pow(i + 1 + Mau, (1.0 / (x + 1)));

            }
            float sum = 1 / (float)Mau;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string blank = "";
            string DoAn = "ĐỒ ÁN: CƠ SỞ LẬP TRÌNH";
            string gioithieu = "SINH VIÊN: HỒ TRẦN HẢI ĐĂNG, LỚP: CY0001";
            Console.WriteLine(blank.PadLeft(110, '='));
            Console.WriteLine(DoAn.PadLeft(70,' '));
            Console.WriteLine(gioithieu.PadLeft(80,' '));
            Console.WriteLine(blank.PadLeft(110, '='));
        Menu:
            Console.WriteLine("MENU CHỌN BÀI TẬP:");
            Console.WriteLine("Bài tập 2: Tính giá trị của biểu thức\nBài tập 5: Nhập họ tên sau đó tách tên trong khoảng 40 kí tự\nBài tập 6: Tạo bảng quản lý khách sạn\nNhập q nếu bạn muốn thoát");
            Console.Write("Hãy chọn bài bạn muốn: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "q":
                    return;
                case "2":
                    //Phan 2
                    Console.WriteLine("\n\nBài tập 2:");
                    Console.Write("Nhập giá trị x: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tổng là: {0}", Phan2(x));
                    
                    goto Menu;
                    
                    

                case "5":
                //Phan 5, Bai 3
                Phan5:
                    Console.WriteLine("\n\nBài tập 5:");
                    Console.WriteLine("Nhập họ và tên: ");
                    string HovaTen = Console.ReadLine();
                    HovaTen = HovaTen.Trim();
                    int last = HovaTen.LastIndexOf(' ') + 1;
                    if (last > 1)
                    {
                        string Ten = HovaTen.Substring(last);
                        string HovaTendem = HovaTen.Substring(0, last);
                        string FullName = $"{HovaTendem, -20} {Ten.PadLeft(20)}";
                        Console.WriteLine("Vậy họ tên bạn là:\n{0}", FullName);
                    }
                    else
                    {
                        Console.WriteLine("Vui lòng nhập đầy đủ họ tên");
                        goto Phan5;
                    }
                    goto Menu;
                default:
                    Console.WriteLine("Số không chính xác, hãy chọn lại");
                    goto Menu;

                case "6":

                    Console.WriteLine("\n\nBài tập 6");
                    Console.Write("Nhập số Khách hàng: ");
                    int kh = int.Parse(Console.ReadLine());
                    object[][] b = KhoiTaoMang(kh);
                    NhapTTNhieuHoadon(b);
                    
                    Console.WriteLine(XuatTTNhieuHoadon(b));
                    goto Menu;
            }
            
        }
    }
}

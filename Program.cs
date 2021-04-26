using System;
using System.Collections;
using System.Collections.Generic;

namespace Quyen_Ngo_Assignment_1
{
    class Program
    {
        // Used for "delegate practice" 
        delegate double myDelegate_double(double first_num, char expression, double second_num);
        delegate void myDelegate_void(double first_num, char expression, double second_num);
        static void Main(string[] args)
        {
            #region  Phương Trình Bậc Hai
            //double a, b, c, Delta, x1, x2;

            //// Input
            //Console.WriteLine("Tim nghiem cua phuong trinh : ax^2 + bx + c = 0");
            //Console.Write("Nhap a : ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap b : ");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("Nhap c : ");
            //c = int.Parse(Console.ReadLine());

            //// Calculate
            //if (a == 0)
            //{
            //    if (b == 0)
            //    {
            //        if (c == 0)
            //        {
            //            // Phuong trinh vo so nghiem
            //            Console.WriteLine("Phuong trinh vo so nghiem");
            //            Console.ReadKey();
            //        }
            //        else
            //        {
            //            // Phuong trinh vo nghiem
            //            Console.WriteLine("Phuong trinh vo nghiem");
            //            Console.ReadKey();
            //        }
            //    }
            //    else
            //    {
            //        double x = -c / b;
            //        Console.WriteLine("Phuong trinh co nghiem duy nhat x = {0}", x);
            //        Console.ReadKey();
            //    }
            //}
            //else
            //{
            //    Delta = Math.Pow(b, 2) - 4 * a * c;
            //    if (Delta > 0)
            //    {
            //        x1 = (-b - Math.Sqrt(Delta)) / (2 * a);
            //        x2 = (-b + Math.Sqrt(Delta)) / (2 * a);
            //        Console.WriteLine("Phuong trinh co hai nghiem phan biet : x1 = {0}, x2 = {1}", x1, x2);
            //        Console.ReadKey();
            //    }
            //    else if (Delta < 0)
            //    {
            //        // Phuong trinh vo nghiem
            //        Console.WriteLine("Phuong trinh vo nghiem");
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        double x = -b / (2 * a);
            //        Console.WriteLine("Phuong trinh co nghiem kep : x = {0}", x);
            //        Console.ReadKey();
            //    }
            //}
            #endregion

            #region Kiểm tra Nam Nữ

            //Console.Write("Nhap ho ten, pleaseeeee... : ");
            //string name = Console.ReadLine();
            //name = name.ToUpper();
            //// nguyen Thi hoAnG --> NGUYEN THI HOANG
            //if (name.Contains("THI"))
            //{
            //    Console.WriteLine("This is a GIRL");
            //}
            //else
            //{
            //    Console.WriteLine("This is a BOY");
            //}
            //Console.ReadKey();
            #endregion

            #region Giả lập máy tính đơn giản
            //double First_num, Second_num = 0;
            //string input_expression;
            //Console.Write("Nhap bieu thuc : ");
            //input_expression = Console.ReadLine();
            //// Sqrt expression
            //if (input_expression.Contains("sqrt") || input_expression.Contains("SQRT"))
            //{
            //    input_expression.Replace('.', ',');
            //    input_expression.Replace(')', '0');
            //    input_expression.Replace('(', '0');
            //    First_num = Convert.ToDouble(input_expression.Substring(input_expression.IndexOf('0')));
            //    First_num = Math.Sqrt(First_num);
            //    Console.WriteLine($"{input_expression} = {First_num}");
            //}
            //else
            //{
            //    // Regular expression
            //    int signal = input_expression.IndexOf('+') + input_expression.IndexOf('-') + input_expression.IndexOf('*') + input_expression.IndexOf('/') + 3;
            //    input_expression.Replace('.', ',');
            //    First_num = Convert.ToDouble(input_expression.Substring(0, signal));
            //    Second_num = Convert.ToDouble(input_expression.Substring(signal + 1));
            //    double result;
            //    if (input_expression.IndexOf('+') != -1)
            //    {
            //        result = First_num + Second_num;
            //    }
            //    else if (input_expression.IndexOf('-') != -1)
            //    {
            //        result = First_num - Second_num;
            //    }
            //    else if (input_expression.IndexOf('*') != -1)
            //    {
            //        result = First_num * Second_num;
            //    }
            //    else if (input_expression.IndexOf('/') != -1)
            //    {
            //        result = First_num / Second_num;
            //    }
            //    else
            //    {
            //        result = -999999;
            //    }
            //    Console.WriteLine("{0} = {1:0.000}", input_expression, result);
            //}
            //Console.ReadKey();
            #endregion

            #region Hệ phương trình
            //double a1, b1, c1, a2, b2, c2;

            //Console.WriteLine("Nhap 6 so : ");
            //a1 = double.Parse(Console.ReadLine());
            //b1 = double.Parse(Console.ReadLine());
            //c1 = double.Parse(Console.ReadLine());
            //a2 = double.Parse(Console.ReadLine());
            //b2 = double.Parse(Console.ReadLine());
            //c2 = double.Parse(Console.ReadLine());

            //// calculate
            //if (a1 == 0 && b1 == 0 && c1 == 0 && a2 == 0 && b2 == 0 && c2 == 0)
            //{
            //    Console.WriteLine("Phuong trinh vo nghiem");
            //    Console.ReadKey();
            //}
            //else if ((a1 == 0 && b1 == 0 && c1 != 0 )||(a2 == 0 && b2 == 0 && c2 != 0))
            //{
            //    Console.WriteLine("Phuong trinh vo nghiem");
            //    Console.ReadKey();
            //}
            //else if (b1 == 0 || b1 * a2 == b2 * a1)
            //{
            //    Console.WriteLine("Phuong trinh vo nghiem");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    double x = (c2 * b1 - b2 * c1) / (b1 * a2 - b2 * a1);
            //    double y = (c1 - a1 * x) / (b1);
            //    Console.WriteLine("x = {0}, y = {1}", x, y);
            //    Console.ReadKey();
            //}
            #endregion

            #region Max 4 số
            //int a, b, c, d;
            //Console.WriteLine("Nhap so : ");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());
            //d = int.Parse(Console.ReadLine());
            //int e, f;

            //if (a > b)
            //{
            //    e = a;
            //}
            //else //
            //{
            //    e = b;
            //}

            //if (c > d)
            //{
            //    f = c;
            //}
            //else
            //{
            //    f = d;
            //}

            //if (e > f)
            //{
            //    Console.WriteLine(e);
            //}
            //else
            //{
            //    Console.WriteLine(f);
            //}
            #endregion

            #region Năm nhuận
            //Console.Write("Nhap nam : ");
            //int year = int.Parse(Console.ReadLine());
            //if (year % 400 == 0)
            //{
            //    Console.WriteLine("Nam nhuan");
            //    Console.ReadKey();
            //}
            //else if (year % 4 == 0 && year % 100 != 0)
            //{
            //    Console.WriteLine("Nam nhuan");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("Khong phai nam nhuan");
            //    Console.ReadKey();
            //}
            #endregion

            #region Tìm thứ trong tuần
            //Console.Write("Nhap ngay : ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Nhap thang : ");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("Nhap nam : ");
            //int year = int.Parse(Console.ReadLine());
            //if (month < 3)
            //{
            //    month = month + 12;
            //    year = year - 1;
            //}
            //int result = Math.Abs(day + 2 * month + 3 * (month + 1) / 5 + year + year / 4) % 7;
            //if (result == 0)
            //{
            //    Console.WriteLine("Chu nhat");
            //}
            //else if (result == 1)
            //{
            //    Console.WriteLine("Thu hai");
            //}
            //else if (result == 2)
            //{
            //    Console.WriteLine("Thu ba");
            //}
            //else if (result == 3)
            //{
            //    Console.WriteLine("Thu tu");
            //}
            //else if (result == 4)
            //{
            //    Console.WriteLine("Thu nam");
            //}
            //else if (result == 5)
            //{
            //    Console.WriteLine("Thu sau");
            //}
            //else if (result == 6)
            //{
            //    Console.WriteLine("Thu bay");
            //}
            //Console.ReadKey();
            #endregion

            #region In giảm dần
            //int a, b, c, d;
            //Console.WriteLine("Nhap so : ");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());
            //d = int.Parse(Console.ReadLine());
            //int e, f, g, h;
            //// 1 2 3 4
            //// Tim max 4 so
            //if (a > b)
            //{
            //    e = a;
            //    g = b;
            //}
            //else
            //{
            //    e = b; // 2
            //    g = a; // 1
            //}
            //if (c > d)
            //{
            //    f = c;
            //    h = d;
            //}
            //else
            //{
            //    f = d; // 4
            //    h = c; // 3
            //}
            //if (e > f)
            //{
            //    Console.Write("{0} {1} ", e, f);
            //}
            //else
            //{
            //    Console.Write("{0} {1} ", f, e);
            //}
            //if (g > h)
            //{
            //    Console.Write("{0} {1} ", g, h);
            //}
            //else
            //{
            //    Console.Write("{0} {1} ", h, g);
            //}
            #endregion

            #region  Phương Trình Bậc Bốn
            //double a, b, c, Delta, x1, x2;

            //// Input
            //Console.WriteLine("Tim nghiem cua phuong trinh : ax^4 + bx^2 + c = 0");
            //Console.Write("Nhap a : ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap b : ");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("Nhap c : ");
            //c = int.Parse(Console.ReadLine());

            //// Calculate
            //if (a == 0)
            //{
            //    if (b == 0)
            //    {
            //        if (c == 0)
            //        {
            //            // Phuong trinh vo so nghiem
            //            Console.WriteLine("Phuong trinh vo so nghiem");
            //            Console.ReadKey();
            //        }
            //        else
            //        {
            //            // Phuong trinh vo nghiem
            //            Console.WriteLine("Phuong trinh vo nghiem");
            //            Console.ReadKey();
            //        }
            //    }
            //    else
            //    {
            //        double x = -c / b;
            //        if (x < 0)
            //        {
            //            Console.WriteLine("Phuong trinh vo nghiem");
            //            Console.ReadKey();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Phuong trinh co hai nghiem x1 = {0:0.00}, x2 = {1:0.00}", -Math.Sqrt(x), Math.Sqrt(x));
            //            Console.ReadKey();
            //        }
            //    }
            //}
            //else
            //{
            //    Delta = Math.Pow(b, 2) - 4 * a * c;
            //    if (Delta > 0)
            //    {
            //        x1 = (-b - Math.Sqrt(Delta)) / (2 * a);
            //        x2 = (-b + Math.Sqrt(Delta)) / (2 * a);
            //        if (x1 < 0 && x2 < 0)
            //        {
            //            Console.WriteLine("Phuong trinh vo nghiem");
            //        }
            //        else if (x1 >= 0 && x2 < 0)
            //        {
            //            Console.WriteLine("Phuong trinh co hai nghiem phan biet : x1 = {0:0.00}, x2 = {1:0.00}", -Math.Sqrt(x1), Math.Sqrt(x1));
            //            Console.ReadKey();
            //        }
            //        else if (x1 < 0 && x2 >= 0)
            //        {
            //            Console.WriteLine("Phuong trinh co hai nghiem phan biet : x1 = {0:0.00}, x2 = {1:0.00}", -Math.Sqrt(x2), Math.Sqrt(x2));
            //            Console.ReadKey();
            //        }
            //        else if (x1 >= 0 && x2 >= 0)
            //        {
            //            Console.WriteLine("Phuong trinh co bon nghiem phan biet : x1 = {0:0.00}, x2 = {1:0.00}, x3 = {2:0.00}, x4 = {3:0.00}", -Math.Sqrt(x1), Math.Sqrt(x1), -Math.Sqrt(x2), Math.Sqrt(x2));
            //            Console.ReadKey();
            //        }

            //    }
            //    else if (Delta < 0)
            //    {
            //        // Phuong trinh vo nghiem
            //        Console.WriteLine("Phuong trinh vo nghiem");
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        double x = -b / (2 * a);
            //        if (x >= 0)
            //        {
            //            Console.WriteLine("Phuong trinh co hai nghiem : x1 = {0:0.00}, x2 = {1:0.00}", -Math.Sqrt(x), Math.Sqrt(x));
            //            Console.ReadKey();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Phuong trinh vo nghiem");
            //            Console.ReadKey();
            //        }

            //    }
            //}
            #endregion

            #region Format Họ Tên
            //Console.Write("Nhap ho ten : ");
            //string name = Console.ReadLine();
            //name = name.Trim();
            //while (name.IndexOf("  ") != -1)
            //{
            //    name = name.Replace("  ", " ");
            //}
            //var collection = name.Split(' ');
            //for (var i = 0; i < collection.Length; i++)
            //{
            //    string First_Char = collection[i].Substring(0, 1);
            //    string Other_Char = collection[i].Substring(1);
            //    First_Char = First_Char.ToUpper();
            //    Other_Char = Other_Char.ToLower();
            //    collection[i] = First_Char + Other_Char;
            //}
            //Console.WriteLine("After formating : ");
            //foreach (var item in collection)
            //{
            //    Console.Write("{0} ", item);
            //}
            //Console.ReadKey();
            #endregion

            #region Standard Library
            //ArrayList myList = new ArrayList();
            //myList.Add(1);
            //myList.Add("1");
            //myList.Add(true);
            //myList.Add(0.99);
            //foreach (var i in myList)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //Hashtable myHash = new Hashtable();
            //myHash.Add(1, 1000);
            //myHash.Add(2, 2000);
            //myHash.Add(6, 3000);
            //myHash.Add(4, 4000);
            //myHash.Add(5, 5000);
            //foreach (DictionaryEntry item in myHash)
            //{
            //    Console.WriteLine("{0} : {1} ", item.Key, item.Value);
            //}
            //foreach (var i in myHash.Keys)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.ReadKey();
            #endregion

            #region Chuỗi tuần hoàn
            //Console.Write("Nhap chuoi : ");
            //string myString = Console.ReadLine();
            //string result = myString;
            //bool is_circular = true;
            //myString = myString.Replace(myString[0], ' ');
            //myString = myString.Trim();
            //var collection = myString.Split(' ');
            //if (collection.Length <= 1)
            //{
            //    is_circular = false;
            //}
            //for (var i = 0; i < collection.Length - 1; i++)
            //{
            //    if (collection[i] != collection[i+1])
            //    {
            //        is_circular = false;
            //        break;
            //    }
            //}
            //if (is_circular)
            //{
            //    Console.WriteLine("Chuoi {0} tuan hoan", result);
            //}
            //else
            //{
            //    Console.WriteLine("Chuoi {0} khong tuan hoan", result);
            //}
            //Console.ReadKey();
            #endregion

            #region Tuple lấy ngày tháng năm
            //Tuple<int, int, int, int, int, int> Timer = Get_current_date_time();
            //Console.WriteLine("{0}-{1}-{2} | {3}:{4}:{5}", Timer.Item1, Timer.Item2, Timer.Item3, Timer.Item4, Timer.Item5, Timer.Item6);
            #endregion

            #region delegate practice with simple calculation
            myDelegate_void show = new myDelegate_void(Show_equation);
            show(5, '+', 6);
            show(5, '-', 6);
            show(5, 'x', 6);
            show(5, '/', 6);
            show(5, '%', 6);
            Console.ReadKey();
            #endregion
        }

        static Tuple<int, int, int, int, int, int> Get_current_date_time()
        {
            DateTime result = DateTime.Now;
            return new Tuple<int, int, int, int, int, int>(result.Day, result.Month, result.Year, result.Hour, result.Minute, result.Second);
        }

        static double calculator(double a, char e, double b)
        {
            double result = 0;
            switch (e)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case 'x':
                case '*':
                    result = a * b;
                    break;
                case '/':
                case ':':
                    result = a / b;
                    break;
                case '%':
                    result = a % b;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            return result;
        }

        static void Show_equation(double a, char e, double b)
        {
            myDelegate_double result = new myDelegate_double(calculator);
            Console.WriteLine("{0} {1} {2} = {3:0.00}", a, e, b, result(a, e, b));
        }
    }
}

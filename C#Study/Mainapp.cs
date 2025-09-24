using System;
using static System.Console;

namespace C_Study
{
    internal class Mainapp
    {
        static void Main(string[] args)
        {
            /*// 03.IntegralTypes
            sbyte a = -10;
            byte b = 40;

            WriteLine($"a = {a}, b = {b}");

            short c = -30000;
            ushort d = 60000;

            WriteLine($"c = {c}, d = {d}");

            int e = -1000_0000; // 0이 7개
            uint f = 3_0000_0000; // 0이 8개

            WriteLine($"e = {e}, f = {f}");

            long g = -5000_0000_0000; // 0이 11개
            ulong h = 200_0000_0000_0000_0000; // 0이 18개

            WriteLine($"g = {g}, h = {h}");*/

            /*// 03.IntegerLiterals
            byte a = 240;       // 10진수리터럴
            WriteLine($"a = {a}");

            byte b = 0b1111_0000; // 2진수리터럴
            WriteLine($"b = {b}");

            byte c = 0xF0;      // 16진수리터럴
            WriteLine($"c = {c}");

            uint d = 0x1234_abcd; // 16진수리터럴
            WriteLine($"d = {d}");*/

            /*// 03.signedUnsigned
            byte a = 255;
            sbyte b = (sbyte)a; // 2의 보수 표현법에 의해 -1로 변환됨 (음수를 표현할 때 2의 보수 사용)

            WriteLine($"a = {a}, b = {b}"); // b = -1*/

            /*// 03.Overflow
            uint a = uint.MaxValue;

            WriteLine(a);

            a = a + 1; // 오버플로우 발생

            // 담을 수 있는 비트수를 넘어가면 오른쪽을 채택하고 왼쪽의 넘쳐흐름 비트는 버리기때문에 앞의 1이 날라가고 가장 낮은 수가 됨.
            WriteLine(a);*/

            /*// 03.FloatingPoint
            // 부동 소수점의 의미는 소수점이 고정되지 않고 계속해서 움직이면서 수를 표현한다는 의미
            // 8bit = 1byte, float = 4byte, double = 8byte, float는 1bit를 부호비트, 8bit를 지수부, 23bit를 가수부로 사용
            float a = 3.1415_9265_3589_7932_3846f; // 뒤에 f를 붙여야 float형으로 인식
            WriteLine(a); // float형은 소수점 아래 7자리 정도까지만 정확하게 표현

            double b = 3.1415_9265_3589_7932_3846; // double형은 소수점 아래 15~16자리 정도까지 정확하게 표현
            WriteLine(b);
            // double형이 float형보다 더 정밀하게 표현 가능하며 float형보다 메모리를 2배 더 사용. 그러나 데이터 손실이 적음.*/

            /*// 03.Decimal
            // decimal형은 128bit(16byte)로 float형과 double형보다 훨씬 더 많은 메모리를 사용
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m; // 뒤에 m을 붙여야 decimal형으로 인식

            // decimal형은 회계나 금융 계산에 주로 사용.
            WriteLine($"float: {a}");
            WriteLine($"double: {b}");
            WriteLine($"decimal: {c}");*/

            /*// 03.Char
            // char형은 2byte(16bit)로 유니코드 문자 하나를 저장 가능. '' (작은따옴표)로 감싸서 표현
            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Write(a);
            Write(b);
            Write(c);
            Write(d);
            Write(e);
            WriteLine();*/

            /*// 03.String
            string a = "안녕하세요";
            string b = "반갑습니다";

            WriteLine(a);
            WriteLine(b);*/
        }
    }
}

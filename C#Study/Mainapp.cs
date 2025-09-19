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
        }
    }
}

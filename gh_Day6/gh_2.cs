using System;

namespace gh_Day6
{
    internal class gh_2
    {
        // 계산기 제작 조건 :
        // 1. 클래스 내 연산에 관련된 메서드는 모두 static으로, 프로그램 전역에서 사용할 수 있어야한다. = public 사용
        // 2. 모든 메서드는 두 개의 double 타입 입력을 받고, 결과 또한 double 타입으로 반환해야 한다.
        // 3. Divide 메서드에서 0으로 나눌 경우, 콘솔에서 에러 발생 텍스트를 출력해야 한다.

        static class MyCalculator  // 클래스 이름 : MyCalculator
        {
            public static double One;  // static 사용으로 어디서든 사용이 가능해짐
            public static double Two;

            public static double Add()
            {
                return One + Two;  // = Add : 두 개의 숫자를 받아 그 합을 반환한다.
            }

            public static double Subtract() // = Subtract : 두 개의 숫자를 받아 첫번째 - 두번째 = 결과를 반환한다.
            {
                return One - Two;
            }

            public static double Multiply() // = Multiply : 두 개의 숫자를 받아 그 곱을 반환한다.
            {
                return One * Two;
            }

            public static double Divide() // =  Divide : 두 개의 숫자를 받아 첫 번째 / 두번째 = 결과를 반환한다.
            {                                                                    
                return One / Two;
            }

            public static double Squared() // = 첫번째 숫자^두번째숫자 의 기능을 추가한다.
            {
                return Math.Pow (One, Two); // = 제곱 구현법 : Math.Pow (첫번째 숫자, 두번째 숫자)
            }
        }


        static void Main(string[] args)
        {
            Console.Write("첫번째 수를 입력하세요. : ");
            MyCalculator.One = Double.Parse(Console.ReadLine());

            Console.Write("두번째 수를 입력하세요. : ");
            MyCalculator.Two = Double.Parse(Console.ReadLine());


            Console.WriteLine("다음 보기 중 사용하고 싶은 기능을 선택해주세요.");

            Console.WriteLine("1. 덧셈 \n2. 뺄셈 \n3. 곱셈 \n4. 나눗셈 \n5. 제곱");

            string Input = Console.ReadLine();

            switch (Input)
            {
                case "1":
                    Console.WriteLine($"{MyCalculator.One} + {MyCalculator.Two} = {MyCalculator.Add()}");
                    break;

                case "2":
                    Console.WriteLine($"{MyCalculator.One} - {MyCalculator.Two} = {MyCalculator.Subtract()}");
                    break;

                case "3":
                    Console.WriteLine($"{MyCalculator.One} X {MyCalculator.Two} = {MyCalculator.Multiply()}");
                    break;

                case "4":
                    if (MyCalculator.Two <= 0) //  =  0으로 나누는 경우에는 적절한 에러 메시지를 반환해야 한다.     
                    {  Console.WriteLine($"에러! \n{MyCalculator.Two}는 0보다 작으므로, 해당 계산기에서는 나눌 수 없습니다. \n다른 수를 입력해주세요."); break; }
                    Console.WriteLine($"{MyCalculator.One} ÷ {MyCalculator.Two} = {MyCalculator.Divide()}");
                    break;

                case "5":
                    Console.WriteLine($"{MyCalculator.One} ^ {MyCalculator.Two} = {MyCalculator.Squared()}");
                    break;
            }
        }
    }
}

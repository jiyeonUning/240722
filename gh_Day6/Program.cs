using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gh_Day6
{
    internal class Program
    {
        class Chracter
        {                              //         ~ 필드 ~
            public int Level;          //  = 레벨
            private int hp = 100;      //  = 체력, 기본값 100 설정
            public float speed;        //  = 이동속도
            public int AttackDamage = 10;   //  = 공격력, 기본값 10 설정


            public void Move()           //        ~ 메서드 ~
            {

                string input = Console.ReadLine();  // = 방향키 설정.

                switch(input)                       // = 움직임 동작
                {
                    case "w":
                        Console.WriteLine("앞으로 전진 합니다.");
                        break;
                    case "s":
                        Console.WriteLine("뒤로 후진합니다.");
                        break;
                    case "a":
                        Console.WriteLine("90도로 좌회전 합니다.");
                        break;
                    case "d":
                        Console.WriteLine("90도로 우회전 합니다.");
                        break;
                }
            }

            public void Attack(Slime slime)  //  = 공격
            {
                Console.WriteLine($"적에게 {AttackDamage} 만큼의 데미지를 입혔습니다!");
                slime.TakeDamage(AttackDamage);
            }

            public void TakeDamage(int damage) // = 피격
            {
                Console.WriteLine($"플레이어가 {damage}의 데미지를 받았습니다.");
                hp -= damage;
                Console.WriteLine($"플레이어의 체력은 현재 {hp} 입니다.");
                
                if (hp <= 0 ) { Console.WriteLine("플레이어가 쓰러졌습니다..."); }
            }
        }

        class Slime  // 테스트를 위해 구현한 적대 대상 : 슬라임
        {
            public string name = "슬라임";
            public int hp = 30;
            public int attackChracter = 5;

            public void Attack(Chracter chracter)
            {
                Console.WriteLine($"{name}이(가) 플레이어에게 {attackChracter}의 데미지를 입혔습니다!");
                chracter.TakeDamage(attackChracter);
            }


            public void TakeDamage(int damage) 
            {
                Console.WriteLine($"{name}이(가) {damage}의 데미지를 받았습니다.");
                hp -= damage;
                Console.WriteLine($"{name}의 체력은 현재 {hp} 입니다.");

                if (hp <= 0) { Console.WriteLine($"{name}이(가) 쓰러집니다..."); }
            }
        }


        static void Main(string[] args) // 구현 테스트
        {
            Chracter chracter = new Chracter();
            Slime slime = new Slime();

            slime.Attack(chracter);
            chracter.Attack(slime);
            slime.Attack(chracter);
            chracter.Attack(slime);
            slime.Attack(chracter);
            chracter.Attack(slime);
        }
    }
}

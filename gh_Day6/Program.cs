namespace gh_Day6
{
    /*
     과제 1. Chracter 클래스 선언하기
    Chracter 클래스를 선언하고, 클래스가 가져야 할 필드와 메서드는 아래와 같다.
    필드
    레벨
    체력
    이동 속도
    공격력

    메서드
    전진
    후진
    좌회전(90도)
    우회전(90도)
    공격
    피격

    제출 형태
    C# 콘솔 프로젝트
    개인 과제용 Git Repository 디렉토리 생성 후 Push
    디렉토리 이름 : 내 제출일 6자 (Ex> 240619)
     */

    internal class Program
    {
        class Chracter
        {                              //   ~필드~
            public int Level;          //  = 레벨
            private int hp = 100;      //  = 체력, 기본값 100 설정
            public float speed;        //  = 이동속도
            public int damage;         //  = 공격력
        }

        static void Main(string[] args)
        {
            Console.WriteLine("테스트");
        }
    }
}

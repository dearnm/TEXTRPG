using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Txet_RPG2
{
    internal class Program
    {

        static string name = "";
        static string choosejob = "";
        static int level = 1;
        static int attack = 10;
        static int defense = 5;
        static int hp = 100;
        static int money = 1500;

        public static void Main()
        {
            

            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 이름을 설정해주세요.");
            Console.WriteLine("");
            
            name = Console.ReadLine()??"";
            Console.WriteLine("입력하신 이름은 {0} 입니다.", name);
            Console.WriteLine("");
            Console.WriteLine("1. 저장");
            Console.WriteLine("2. 취소");

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            string choose = Console.ReadLine()??"";

            if (choose == "1")
            {
                Save();
            }

            else if (choose == "2")
            {
                Cancel();
            }
        }

        public static void Save()
        {
            Console.Clear();
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("원하시는 직업을 선택해주세요.");
            Console.WriteLine("");
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 도적");
            Console.WriteLine("");
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            choosejob = Console.ReadLine()??"";

            if (choosejob == "1" && choosejob == "2")
            {
                GameStart();
            }

        }

        public static void Cancel()
        {
            Console.Clear ();
            Main();
        }

        public static void GameStart()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("");
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            string active = Console.ReadLine()??"";

            if (active == "1")
            {
                Condition();
            }

            else if (active == "2")
            {
                Inventory();
            }

            else if (active == "3")
            {
                Shop();
            }

            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }

        public static void Condition()
        {
            

            Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine("");

            Console.WriteLine("Lv. " + level);
            if (choosejob == "1")
            {
                Console.WriteLine(name + "( 전사 )");

            }

            else if (choosejob == "2")
            {
                Console.WriteLine(name + "( 도적 )");

            }
            Console.WriteLine("공격력 : " + attack);
            Console.WriteLine("방어력 : " + defense);
            Console.WriteLine("체  력 : " + hp);
            Console.WriteLine("Gold : " + money + "G");
            Console.WriteLine("");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("");
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            string outt = Console.ReadLine()??"";

            if (outt == "0")
            {
                GameStart();
            }

        }



        public static void Inventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("");
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            string inventorychoose = Console.ReadLine()??"";

            if(inventorychoose == "1")
            {
                Inventorymanager();
            }

            if (inventorychoose == "0")
            {
                GameStart();
            }

        }

        public static void Shop()
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
        }

        public static void Inventorymanager()
        {
            Console.Clear();
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("- 1 무쇠갑옷       | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.");
            Console.WriteLine("- 2 스파르타의 창  | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.");
            Console.WriteLine("- 3 낡은 검        | 공격력 +2 | 쉽게 볼 수 있는 낡은 검입니다.");
            Console.WriteLine("");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("");
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");
            string inventorychoose = Console.ReadLine()??"";

            if(inventorychoose == "1")
            {
                defense += 5;
            }

            if (inventorychoose == "0")
            {
                Inventory();
            }

        }


    }
}

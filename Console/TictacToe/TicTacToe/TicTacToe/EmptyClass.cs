using System;

class TicTacToeGame
{
    static char bb00, bb01, bb02, bb10, bb11, bb12, bb20, bb21, bb22;
    static string selected = "abcdefghi";
    static void Main()
    {
        Init();
        Display();
        while (true) //게임이 계속 진행 되도록 반복, break => 반복문 종료
        {
            HumanInput();
            Display();
            if (Judge2()) // 플레이어가 승리한 경우
            {
                Finish('O');
                break;
            }
            if (selected == "_________") //무승부의 조건
            {
                Finish(' ');
                break;
            }
            ComInput();
            Display();
            if (Judge2()) // 컴퓨터가 승리한 경우
            {
                Finish('X');
                break;
            }
            if (selected == "_________") //무슨부의 조건 
            {
                Finish(' ');
                break;
            }
        }
    }
    static void Init() //변수의 값 초기화
    {
        bb00 = 'a'; bb01 = 'b'; bb02 = 'c';
        bb10 = 'd'; bb11 = 'e'; bb12 = 'f';
        bb20 = 'g'; bb21 = 'h'; bb22 = 'i';
    }
    static void Display() //틱택토 기본 화면
    {
        Console.Clear();

        Console.WriteLine($" {bb00} | {bb01} | {bb02} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {bb10} | {bb11} | {bb12} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {bb20} | {bb21} | {bb22} ");
        Console.WriteLine("\n선택 가능한 변수: " + selected); //selected의 값 출력
    }
    static bool Judge1()
    {
        // '_'' 위치를 선택한 경우에는 잘못된 선택으로 처리
        if (selected.Contains("_"))
        {
            Console.WriteLine("잘못된 선택입니다.");
            return false;
        }
        return true;
    }
    static void HumanInput()
    {
        Console.WriteLine("원하는 위치를 선택하세요 (a-i 중 하나):");
        string input = Console.ReadLine().ToLower();
        if (selected.Contains(input)) //selected의 값에 입력한 값이 있다면 switch~case문 조건 실행 
        {
            switch (input) //input 값에 따른 위치에 'O'를 입력
            {
                case "a":
                    bb00 = 'O';
                    break;
                case "b":
                    bb01 = 'O';
                    break;
                case "c":
                    bb02 = 'O';
                    break;
                case "d":
                    bb10 = 'O';
                    break;
                case "e":
                    bb11 = 'O';
                    break;
                case "f":
                    bb12 = 'O';
                    break;
                case "g":
                    bb20 = 'O';
                    break;
                case "h":
                    bb21 = 'O';
                    break;
                case "i":
                    bb22 = 'O';
                    break;
            }selected = selected.Replace(input, "_"); //사람이 입력한 값을 selected 값에서 '_'로 변환 
        }
        else //selected의 값에 입력한 값이 없다면 judge1() 함수 실행 및 재입력 할 수 있게 HumanInput()으로 돌아감
        {
            Console.WriteLine("잘못 입력하셨습니다.");
            Judge1();
            HumanInput();
        }
    }

    static void ComInput()
    {
        char com = ' '; //com이라는 문자 변수를 선언하고 공백 문자로 초기화 - 컴퓨터의 선택
        foreach (char c in selected) //selected 안에 있는 각 문자를 순차적으로 검사
        {
            if (c != '_') // foreach문에서 현재 검사하고 있는 문자가 '_'가 아닐 경우 실행
            {
                com = c;
                break;
            }
        }
        switch (com) //com값에 따른 위치에 'X'를 입력
        {
            case 'a':
                bb00 = 'X';
                break;
            case 'b':
                bb01 = 'X';
                break;
            case 'c':
                bb02 = 'X';
                break;
            case 'd':
                bb10 = 'X';
                break;
            case 'e':
                bb11 = 'X';
                break;
            case 'f':
                bb12 = 'X';
                break;
            case 'g':
                bb20 = 'X';
                break;
            case 'h':
                bb21 = 'X';
                break;
            case 'i':
                bb22 = 'X';
                break;
        } selected = selected.Replace(com.ToString(), "_"); //컴퓨터가 입력한 값을 selected 값에서 '_'로 변환 
    }
    static bool Judge2() //void일때 return뒤에 개체식이 나올수 없으므로 bool 사용
    {
        //컴퓨터의 결과
        if ((bb00 == bb01 && bb01 == bb02 && bb00 == 'X') || // 가로
            (bb10 == bb11 && bb11 == bb12 && bb10 == 'X') ||
            (bb20 == bb21 && bb21 == bb22 && bb20 == 'X') ||
            (bb00 == bb10 && bb10 == bb20 && bb00 == 'X') || // 세로
            (bb01 == bb11 && bb11 == bb21 && bb01 == 'X') ||
            (bb02 == bb12 && bb12 == bb22 && bb02 == 'X') ||
            (bb00 == bb11 && bb11 == bb22 && bb00 == 'X') || // 대각선
            (bb02 == bb11 && bb11 == bb20 && bb02 == 'X'))
        {
            return true;
        }
        //사람의 결과
        if ((bb00 == bb01 && bb01 == bb02 && bb00 == 'O') || // 가로
            (bb10 == bb11 && bb11 == bb12 && bb10 == 'O') ||
            (bb20 == bb21 && bb21 == bb22 && bb20 == 'O') ||
            (bb00 == bb10 && bb10 == bb20 && bb00 == 'O') || // 세로
            (bb01 == bb11 && bb11 == bb21 && bb01 == 'O') ||
            (bb02 == bb12 && bb12 == bb22 && bb02 == 'O') ||
            (bb00 == bb11 && bb11 == bb22 && bb00 == 'O') || // 대각선
            (bb02 == bb11 && bb11 == bb20 && bb02 == 'O'))
        {
            return true;
        }
        return false;
    }
    static void Finish(char winner)
    {
        if (winner == 'O') //judge2에서 사람의 결과값이 true일때 사람 승리
        {
            Console.WriteLine("사람이 승리했습니다!");
        }
        else if (winner == 'X') //judge2에서 컴퓨터의 결과값이 true일때 컴퓨터 승리
        {
            Console.WriteLine("컴퓨터가 승리했습니다!");
        }
        else //judge2에서 return 값이 false일때 무승부
        {
            Console.WriteLine("무승부입니다.");
        }
        Console.WriteLine("게임 종료되었습니다.");
    }
}

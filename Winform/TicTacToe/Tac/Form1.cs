using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace Tac
{
    public partial class Form1 : Form
    {
        char bb00 = 'a', bb01 = 'b', bb02 = 'c', bb10 = 'd', bb11 = 'e', bb12 = 'f', bb20 = 'g', bb21 = 'h', bb22 = 'i';
        string selected = "abcdefghi";
        bool isPlayerX = true; // 현재 차례 (X 또는 O)
        bool gameOver = false; // 게임 종료 여부
        int turn = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void draw_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Black;
            Turtle.PenUp();
            Turtle.MoveTo(-170, 170);

            Turtle.PenDown();
            Turtle.MoveTo(170, 170);
            Turtle.MoveTo(170, -170);
            Turtle.MoveTo(-170, -170);
            Turtle.MoveTo(-170, 170);

            Turtle.PenUp();
            Turtle.MoveTo(-55, 170);
            Turtle.PenDown();
            Turtle.MoveTo(-55, -170);

            Turtle.PenUp();
            Turtle.MoveTo(55, 170);
            Turtle.PenDown();
            Turtle.MoveTo(55, -170);

            Turtle.PenUp();
            Turtle.MoveTo(-170, 55);
            Turtle.PenDown();
            Turtle.MoveTo(170, 55);

            Turtle.PenUp();
            Turtle.MoveTo(-170, -55);
            Turtle.PenDown();
            Turtle.MoveTo(170, -55);
        }
        private void btn_a_Click(object sender, EventArgs e) //버튼 a를 클릭 했을 때
        {
            Button button = (Button)sender;
            if (button.Text == "a")
            {
                button.Text = isPlayerX ? "O" : "X"; // 사용자 또는 컴퓨터가 선택한 버튼에 표시 설정
                isPlayerX = !isPlayerX; // 차례 변경
                turn++;
                selected = selected.Replace("a", "_");
                select.Text = selected;
                if (Judge2()) // 게임이 종료 되면 결과 확인
                {
                    string winner = isPlayerX ? "X" : "사람";
                    result.Text = ($"게임 종료! {winner}이 이겼습니다!");
                    gameOver = true;
                }
                else if (turn == 9)
                {
                    result.Text = ("게임 종료! 무승부입니다!");
                    gameOver = true;
                }
                // 컴퓨터 차례
                if (!gameOver) // 게임이 종료되지 않았고 아직 무승부가 아닌 경우에만 컴퓨터 차례 활성화
                {
                    ComInput();
                }
            }
        }
        private void btn_b_Click(object sender, EventArgs e) //버튼 b를 클릭 했을 때
        {
            Button button = (Button)sender;
            if (button.Text == "b")
            {
                button.Text = isPlayerX ? "O" : "X"; // 사용자 또는 컴퓨터가 선택한 버튼에 표시 설정
                isPlayerX = !isPlayerX; // 차례 변경
                turn++;
                selected = selected.Replace("b", "_");
                select.Text = selected;
                if (Judge2()) // 게임이 종료 되면 결과 확인
                {
                    string winner = isPlayerX ? "X" : "사람";
                    result.Text = ($"게임 종료! {winner}이 이겼습니다!");
                    gameOver = true;
                }
                else if (turn == 9)
                {
                    result.Text = ("게임 종료! 무승부입니다!");
                    gameOver = true;
                }
                // 컴퓨터 차례
                if (!gameOver) // 게임이 종료되지 않았고 아직 무승부가 아닌 경우에만 컴퓨터 차례 활성화
                {
                    ComInput();
                }
            }
        }
        private void btn_c_Click(object sender, EventArgs e) //버튼 c를 클릭 했을 때
        {
            Button button = (Button)sender;
            if (button.Text == "c")
            {
                button.Text = isPlayerX ? "O" : "X"; // 사용자 또는 컴퓨터가 선택한 버튼에 표시 설정
                isPlayerX = !isPlayerX; // 차례 변경
                turn++;
                selected = selected.Replace("c", "_");
                select.Text = selected;
                if (Judge2()) // 게임이 종료 되면 결과 확인
                {
                    string winner = isPlayerX ? "X" : "사람";
                    result.Text = ($"게임 종료! {winner}이 이겼습니다!");
                    gameOver = true;
                }
                else if (turn == 9)
                {
                    result.Text = ("게임 종료! 무승부입니다!");
                    gameOver = true;
                }
                // 컴퓨터 차례
                if (!gameOver) // 게임이 종료되지 않았고 아직 무승부가 아닌 경우에만 컴퓨터 차례 활성화
                {
                    ComInput();
                }
            }
        }
        private void btn_d_Click(object sender, EventArgs e) //버튼 d를 클릭 했을 때
        {
            Button button = (Button)sender;
            if (button.Text == "d")
            {
                button.Text = isPlayerX ? "O" : "X"; // 사용자 또는 컴퓨터가 선택한 버튼에 표시 설정
                isPlayerX = !isPlayerX; // 차례 변경
                turn++;
                selected = selected.Replace("d", "_");
                select.Text = selected;
                if (Judge2()) // 게임이 종료 되면 결과 확인
                {
                    string winner = isPlayerX ? "X" : "사람";
                    result.Text = ($"게임 종료! {winner}이 이겼습니다!");
                    gameOver = true;
                }
                else if (turn == 9)
                {
                    result.Text = ("게임 종료! 무승부입니다!");
                    gameOver = true;
                }
                // 컴퓨터 차례
                if (!gameOver) // 게임이 종료되지 않았고 아직 무승부가 아닌 경우에만 컴퓨터 차례 활성화
                {
                    ComInput();
                }
            }
        }
        private void btn_e_Click(object sender, EventArgs e) //버튼 e를 클릭 했을 때
        {
            Button button = (Button)sender;
            if (button.Text == "e")
            {
                button.Text = isPlayerX ? "O" : "X"; // 사용자 또는 컴퓨터가 선택한 버튼에 표시 설정
                isPlayerX = !isPlayerX; // 차례 변경
                turn++;
                selected = selected.Replace("e", "_");
                select.Text = selected;
                if (Judge2()) // 게임이 종료 되면 결과 확인
                {
                    string winner = isPlayerX ? "X" : "사람";
                    result.Text = ($"게임 종료! {winner}이 이겼습니다!");
                    gameOver = true;
                }
                else if (turn == 9)
                {
                    result.Text = ("게임 종료! 무승부입니다!");
                    gameOver = true;
                }
                // 컴퓨터 차례
                if (!gameOver) // 게임이 종료되지 않았고 아직 무승부가 아닌 경우에만 컴퓨터 차례 활성화
                {
                    ComInput();
                }
            }
        }
        private void btn_f_Click(object sender, EventArgs e) //버튼 f를 클릭 했을 때
        {
            Button button = (Button)sender;
            if (button.Text == "f")
            {
                button.Text = isPlayerX ? "O" : "X"; // 사용자 또는 컴퓨터가 선택한 버튼에 표시 설정
                isPlayerX = !isPlayerX; // 차례 변경
                turn++;
                selected = selected.Replace("f", "_");
                select.Text = selected;
                if (Judge2()) // 게임이 종료 되면 결과 확인
                {
                    string winner = isPlayerX ? "X" : "사람";
                    result.Text = ($"게임 종료! {winner}이 이겼습니다!");
                    gameOver = true;
                }
                else if (turn == 9)
                {
                    result.Text = ("게임 종료! 무승부입니다!");
                    gameOver = true;
                }
                // 컴퓨터 차례
                if (!gameOver) // 게임이 종료되지 않았고 아직 무승부가 아닌 경우에만 컴퓨터 차례 활성화
                {
                    ComInput();
                }
            }
        }
        private void btn_g_Click(object sender, EventArgs e)//버튼 g를 클릭 했을 때
        {
            Button button = (Button)sender;
            if (button.Text == "g")
            {
                button.Text = isPlayerX ? "O" : "X"; // 사용자 또는 컴퓨터가 선택한 버튼에 표시 설정
                isPlayerX = !isPlayerX; // 차례 변경
                turn++;
                selected = selected.Replace("g", "_");
                select.Text = selected;
                if (Judge2()) // 게임이 종료 되면 결과 확인
                {
                    string winner = isPlayerX ? "X" : "사람";
                    result.Text = ($"게임 종료! {winner}이 이겼습니다!");
                    gameOver = true;
                }
                else if (turn == 9)
                {
                    result.Text = ("게임 종료! 무승부입니다!");
                    gameOver = true;
                }
                // 컴퓨터 차례
                if (!gameOver) // 게임이 종료되지 않았고 아직 무승부가 아닌 경우에만 컴퓨터 차례 활성화
                {
                    ComInput();
                }
            }
        }
        private void btn_h_Click(object sender, EventArgs e)//버튼 h를 클릭 했을 때
        {
            Button button = (Button)sender;
            if (button.Text == "h")
            {
                button.Text = isPlayerX ? "O" : "X"; // 사용자 또는 컴퓨터가 선택한 버튼에 표시 설정
                isPlayerX = !isPlayerX; // 차례 변경
                turn++;
                selected = selected.Replace("h", "_");
                select.Text = selected;
                if (Judge2()) // 게임이 종료 되면 결과 확인
                {
                    string winner = isPlayerX ? "X" : "사람";
                    result.Text = ($"게임 종료! {winner}이 이겼습니다!");
                    gameOver = true;
                }
                else if (turn == 9)
                {
                    result.Text = ("게임 종료! 무승부입니다!");
                    gameOver = true;
                }
                // 컴퓨터 차례
                if (!gameOver) // 게임이 종료되지 않았고 아직 무승부가 아닌 경우에만 컴퓨터 차례 활성화
                {
                    ComInput();
                }
            }
        }
        private void btn_i_Click(object sender, EventArgs e) //버튼 i를 클릭 했을 때
        {
            Button button = (Button)sender;
            if (button.Text == "i")
            {
                button.Text = isPlayerX ? "O" : "X"; // 사용자 또는 컴퓨터가 선택한 버튼에 표시 설정
                isPlayerX = !isPlayerX; // 차례 변경
                turn++;
                selected = selected.Replace("i", "_");
                select.Text = selected;
                if (Judge2()) // 게임이 종료 되면 결과 확인
                {
                    string winner = isPlayerX ? "X" : "사람";
                    result.Text = ($"게임 종료! {winner}이 이겼습니다!");
                    gameOver = true;
                }
                else if (turn==9)
                {
                    result.Text = ("게임 종료! 무승부입니다!");
                    gameOver = true;
                }
                // 컴퓨터 차례
                if (!gameOver) // 게임이 종료되지 않았고 아직 무승부가 아닌 경우에만 컴퓨터 차례 활성화
                {
                    ComInput();
                }
            }
        }
        private void ComInput()
        {
            // selected에서 '_'가 아닌 값을 앞에서부터 차례대로 선택
            for (int i = 0; i < selected.Length; i++) //selected의 문자열의 길이만큼 반복
            {
                if (selected[i] != '_') //selceted에서 '_'가 아닐때
                {
                    string buttonName = "btn_" + selected[i]; // 선택한 버튼의 이름을 문자열로 구성
                    //폼(Form)에서 buttonName과 일치하는 이름을 가진 버튼을 찾아서 배열로 반환, 반환된 버튼은 게임판에서 해당 위치를 나타내며, 그 텍스트를 'X'로 변경
                    Control[] controls = this.Controls.Find(buttonName, true); 
                    if (controls.Length > 0 && controls[0] is Button)
                    {
                        Button button = (Button)controls[0];
                        button.Text = "X";
                    }
                    selected = selected.Remove(i, 1).Insert(i, "_"); // 선택된 버튼의 원래 텍스트 값을 selected에 '_'로 저장
                    select.Text = selected;
                    // 승리 확인
                    if (Judge2())
                    {
                        string winner = isPlayerX ? "X" : "컴퓨터";
                        result.Text = $"게임 종료! {winner}가 이겼습니다!";
                        gameOver = true;
                        return;
                    }
                    if (!gameOver)
                    {
                        // 차례 변경
                        isPlayerX = !isPlayerX;
                        turn++;
                        return;
                    }        
                }
            }
        }
        private bool Judge2()
        {
            // 가로, 세로, 대각선 승리 조건을 확인하는 로직을 작성합니다.
            if ((btn_a.Text == btn_b.Text && btn_b.Text == btn_c.Text && btn_a.Text != "O") ||
                (btn_d.Text == btn_e.Text && btn_e.Text == btn_f.Text && btn_d.Text != "O") ||
                (btn_g.Text == btn_h.Text && btn_h.Text == btn_i.Text && btn_g.Text != "O") ||
                (btn_a.Text == btn_d.Text && btn_d.Text == btn_g.Text && btn_a.Text != "O") ||
                (btn_b.Text == btn_e.Text && btn_e.Text == btn_h.Text && btn_b.Text != "O") ||
                (btn_c.Text == btn_f.Text && btn_f.Text == btn_i.Text && btn_c.Text != "O") ||
                (btn_a.Text == btn_e.Text && btn_e.Text == btn_i.Text && btn_a.Text != "O") ||
                (btn_c.Text == btn_e.Text && btn_e.Text == btn_g.Text && btn_c.Text != "O"))
            {
                return true;
            }
            if ((btn_a.Text == btn_b.Text && btn_b.Text == btn_c.Text && btn_a.Text != "X") ||
                (btn_d.Text == btn_e.Text && btn_e.Text == btn_f.Text && btn_d.Text != "X") ||
                (btn_g.Text == btn_h.Text && btn_h.Text == btn_i.Text && btn_g.Text != "X") ||
                (btn_a.Text == btn_d.Text && btn_d.Text == btn_g.Text && btn_a.Text != "X") ||
                (btn_b.Text == btn_e.Text && btn_e.Text == btn_h.Text && btn_b.Text != "X") ||
                (btn_c.Text == btn_f.Text && btn_f.Text == btn_i.Text && btn_c.Text != "X") ||
                (btn_a.Text == btn_e.Text && btn_e.Text == btn_i.Text && btn_a.Text != "X") ||
                (btn_c.Text == btn_e.Text && btn_e.Text == btn_g.Text && btn_c.Text != "X"))
            {
                return true;
            }
            if (turn == 9) // 턴의 횟수가 9번인 경우 무승부로 처리
                {
                result.Text = "무승부입니다.";
                return true;
            }
            else
            {
                result.Text = "게임 중...";
                return false;
            }
            
        }
    }
}
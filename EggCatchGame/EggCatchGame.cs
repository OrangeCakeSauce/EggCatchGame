using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EggCatchGame
{
    public partial class frmEggCatchGame : Form
    {
        public frmEggCatchGame()
        {
            InitializeComponent();
        }

        //卵を落とす位置
        string _dropLocation = "";

        //卵を落とす速度
        int _dropSpeed = 1000;

        //キャッチ成功フラグ
        bool _couldCaught = false;

        //ゲームオーバーフラグ
        bool _isGameOver = false;

        //リセットフラグ
        bool _isReset = false;

        //開始ボタンが押されたときに行う処理
        private void btnBegin_Click(object sender, EventArgs e)
        {
            //各コントロールと変数を開始状態にする
            lblStatus.Text = "ゲーム開始";
            btnBegin.Enabled = false;
            btnReset.Enabled = true;
            _isReset = false;

            //卵を落とすタスクを開始する
            Task _taskDropEgg = new Task(DropEgg);
            _taskDropEgg.Start();

            //ゲームオーバーフラグを監視するタスクを開始する
            Task _taskMonitorGameOver = new Task(MonitorGameOver);
            _taskMonitorGameOver.Start();
        }

        //リセットボタンが押されたときに行う処理
        private void btnReset_Click(object sender, EventArgs e)
        {
            //各コントロールと変数をリセット状態にする
            _isReset = true;
            btnBegin.Enabled = true;
            btnReset.Enabled = false;
            _isGameOver = false;
            lblCatcher.Location = new Point(347, 236);
            lblStatus.Text = "ゲーム開始前";
            lblEgg.Visible = true;
            lblCrushedEgg.Visible = false;
            lblEgg.Location = new Point(382, 12);
            _dropSpeed = 1000; 
        }

        //中央ボタンが押されたときに行う処理
        private void btnCenter_Click(object sender, EventArgs e)
        {
            lblCatcher.Location = new Point(347, 236);
        }

        //右ボタンが押されたときに行う処理
        private void btnRight_Click(object sender, EventArgs e)
        {
            lblCatcher.Location = new Point(476, 236);
        }

        //左ボタンが押されたときに行う処理
        private void btnLeft_Click(object sender, EventArgs e)
        {
            lblCatcher.Location = new Point(218, 236);
        }

        //卵を落とす処理
        private void DropEgg()
        {
            for(int _cnt = 0; _cnt<10; _cnt++)
            {
                //卵を落とす位置をランダムに決める
                _dropLocation = GetRandomLocation();

                if(_dropLocation == "中央")
                {
                    //中央から落とす(リセットボタンが押されたら処理を抜ける)
                    if (_isReset == true){ break; }
                    Invoke(new Action(MoveCenterFirstDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveCenterSecondDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveCenterThirdDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveCenterForthDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    //クッションが卵の下にあるか判定し、なければゲームオーバーにする
                    Invoke(new Action(JudgeCenterCatch));
                    if (_isGameOver == true){ break; }
                }
                else if(_dropLocation == "右")
                {
                    //右から落とす(リセットボタンが押されたら処理を抜ける)
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveRightFirstDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveRightSecondDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveRightThirdDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveRightForthDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    //クッションが卵の下にあるか判定し、なければゲームオーバーにする
                    Invoke(new Action(JudgeRightCatch));
                    if (_isGameOver == true){ break; }
                }
                else if(_dropLocation == "左")
                {
                    //左から落とす(リセットボタンが押されたら処理を抜ける)
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveLeftFirstDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveLeftSecondDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveLeftThirdDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true) { break; }
                    Invoke(new Action(MoveLeftForthDropLocation));
                    System.Threading.Thread.Sleep(_dropSpeed);
                    if (_isReset == true){ break; }
                    //クッションが卵の下にあるか判定し、なければゲームオーバーにする
                    Invoke(new Action(JudgeLeftCatch));
                    if (_isGameOver == true){ break; }
                }
                //卵を落とす速度を上げる
                _dropSpeed -= 100;
            }

            //10回連続でキャッチに成功した場合、ステータスを「ゲームクリア」にする
            if(_isGameOver == false && _isReset == false)
            {
                Invoke(new Action(ChangeStatusGameClear));
            }
        }

        //配列から要素をランダムに取り出す
        private string GetRandomLocation()
        {
            string[] _dropLocations = new string[3] { "中央", "右", "左" };
            Random random = new Random();
            return _dropLocations[random.Next(_dropLocations.Length)];
        }

        //卵を中央から落とす場合の1番目の位置
        private void MoveCenterFirstDropLocation()
        {
            lblEgg.Location = new Point(382, 12);
        }

        //卵を中央から落とす場合の2番目の位置
        private void MoveCenterSecondDropLocation()
        {
            lblEgg.Location = new Point(382, 68);
        }

        //卵を中央から落とす場合の3番目の位置
        private void MoveCenterThirdDropLocation()
        {
            lblEgg.Location = new Point(382, 124);
        }

        //卵を中央から落とす場合の4番目の位置
        private void MoveCenterForthDropLocation()
        {
            lblEgg.Location = new Point(382, 180);
        }

        //卵を右から落とす場合の1番目の位置
        private void MoveRightFirstDropLocation()
        {
            lblEgg.Location = new Point(511, 12);
        }

        //卵を右から落とす場合の2番目の位置
        private void MoveRightSecondDropLocation()
        {
            lblEgg.Location = new Point(511, 68);
        }

        //卵を右から落とす場合の3番目の位置
        private void MoveRightThirdDropLocation()
        {
            lblEgg.Location = new Point(511, 124);
        }

        //卵を右から落とす場合の4番目の位置
        private void MoveRightForthDropLocation()
        {
            lblEgg.Location = new Point(511, 180);
        }

        //卵を左から落とす場合の1番目の位置
        private void MoveLeftFirstDropLocation()
        {
            lblEgg.Location = new Point(253, 12);
        }

        //卵を左から落とす場合の2番目の位置
        private void MoveLeftSecondDropLocation()
        {
            lblEgg.Location = new Point(253, 68);
        }

        //卵を左から落とす場合の3番目の位置
        private void MoveLeftThirdDropLocation()
        {
            lblEgg.Location = new Point(253, 124);
        }

        //卵を左から落とす場合の4番目の位置
        private void MoveLeftForthDropLocation()
        {
            lblEgg.Location = new Point(253, 180);
        }

        //中央でキャッチできたかどうかを判断する
        private void JudgeCenterCatch()
        {
            if (lblCatcher.Location.X == 347 && lblCatcher.Location.Y == 236)
            {
                _couldCaught = true;
            }
            else
            {
                _couldCaught = false;
            }
            //キャッチできなかった場合、壊れた卵を中央に表示する
            if (_couldCaught == false)
            {
                lblCrushedEgg.Location = new Point(382, 265);
                lblCrushedEgg.Visible = true;
                _isGameOver = true;
            }
        }

        //右でキャッチできたかどうかを判断する
        private void JudgeRightCatch()
        {
            if (lblCatcher.Location.X == 476 && lblCatcher.Location.Y == 236)
            {
                _couldCaught = true;
            }
            else
            {
                _couldCaught = false;
            }
            //キャッチできなかった場合、壊れた卵を右に表示する
            if (_couldCaught == false)
            {   
                lblCrushedEgg.Location = new Point(511, 265);
                lblCrushedEgg.Visible = true;
                _isGameOver = true;
            }
        }

        //左でキャッチできたかどうかを判断する
        private void JudgeLeftCatch()
        {
            if (lblCatcher.Location.X == 218 && lblCatcher.Location.Y == 236)
            {
                _couldCaught = true;
            }
            else
            {
                _couldCaught = false;
            }
            //キャッチできなかった場合、壊れた卵を左に表示する
            if (_couldCaught == false)
            {
                lblCrushedEgg.Location = new Point(253, 265);
                lblCrushedEgg.Visible = true;
                _isGameOver = true;
            }
        }

        //ゲームオーバーフラグを監視する
        private void MonitorGameOver()
        {
            while(_isGameOver == false)
            {
                System.Threading.Thread.Sleep(100);
            }
            //ゲームオーバーフラグが立った場合、卵を非表示にし、ステータスを「ゲームオーバー」にする
            Invoke(new Action(HideEgg));
            Invoke(new Action(ChangeStatusGameOver));
        }

        //卵を非表示にする
        private void HideEgg()
        {
            lblEgg.Visible = false;
        }

        //ステータスを「ゲームオーバー」にする
        private void ChangeStatusGameOver()
        {
            lblStatus.Text = "ゲームオーバー";
        }

        //ステータスを「ゲームクリア」にする
        private void ChangeStatusGameClear()
        {
            lblStatus.Text = "ゲームクリア!";
        }
    }
}

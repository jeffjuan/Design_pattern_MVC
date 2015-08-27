using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class Form1 : Form, IView
    {
        private PlayerController controller;
        private PlayerModel model;
        private double value;

        public Form1(PlayerModel model, PlayerController controller)
        {
            InitializeComponent();
            this.model = model;
            this.controller = controller;
            model.RegisterView(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model.PlayLists.Add("寶貴十架.mp3");
            model.PlayLists.Add("盡情的敬拜.mp3");
            model.PlayLists.Add("恩典之路.mp3");
            foreach (var list in model.PlayLists)
            {
                playList.Items.Add(list);
            }
            playList.SelectedIndex = 0;// 預設：從第一首歌播放
            model.TotalNumberOfList = model.PlayLists.Count;// 播放清單項目總數
        }

        // 觀察者模式：提供這個方法給[發佈者]通知用
        public void UpdateView()
        {
            label2.Text = model.Title;
            playList.SelectedIndex = model.LatestSongIndex;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            controller.Play(playList.SelectedIndex);
            timer1.Start();//run progess bar
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            controller.Stop(1);// 1是stop代碼
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            controller.Next(playList.SelectedIndex);
            timer1.Start();//run progess bar
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            controller.Previous(playList.SelectedIndex);
            timer1.Start();//run progess bar
        }

        private void buttonRandomPlay_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            controller.RandomPlay();
            timer1.Start();//run progess bar
        }

        private void buttonCycle_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            controller.Cycle();
            timer1.Start();//run progess bar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            value = controller.GetProgress();
            progressBar.Value = (int)(value * progressBar.Maximum);
            controller.CheckPlayerState();
        }
    }
}
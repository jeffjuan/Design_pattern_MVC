using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace AudioPlayer
{
    public class PlayerModel : IModel
    {
        private List<IView> views = new List<IView>();
        private double percent = 0;
        private List<string> playLists = new List<string>();
        private WMPLib.WindowsMediaPlayer Player;

        public PlayerModel()
        {
            if (Player == null)
            {
                Player = new WindowsMediaPlayer();
            }
        }

        public List<string> PlayLists
        {
            get
            {
                return playLists;
            }
            set
            {
                playLists = value;
            }
        }

        //紀錄目前指定的歌
        public int LatestSongIndex { get; set; }

        public void RegisterView(IView v)
        {
            views.Add(v);
        }

        public void RemoveView(IView v)
        {
            views.Remove(v);
        }

        //觀察者模式
        public void NotifyVews()
        {
            foreach (var v in views)
            {
                v.UpdateView();
            }
        }

        // 歌名
        public string Title { get; set; }

        // 播放清單項目總數
        public int TotalNumberOfList { get; set; }

        public void Play(int SongIndex)
        {
            ExecutePlay(SongIndex);
        }

        //停止播放
        public void Stop(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
                Player.controls.stop();
        }

        public void Next(int SongIndex)
        {
            SongIndex++;
            if (SongIndex == TotalNumberOfList)
                SongIndex = 0;//指標回到第一首
            LatestSongIndex = SongIndex;
            ExecutePlay(SongIndex);
        }

        public void Previous(int SongIndex)
        {
            SongIndex--;
            if (SongIndex <= 0)
                SongIndex = 0;//指標回到第一首
            LatestSongIndex = SongIndex;
            ExecutePlay(SongIndex);
        }

        public void RandomPlay()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, TotalNumberOfList);
            LatestSongIndex = index;
            ExecutePlay(index);
        }

        public void Cycle()
        {
            int index = 0;
            LatestSongIndex = index;
            ExecutePlay(index);
        }

        private void ExecutePlay(int index)
        {
            Player.URL = playLists[index].ToString();
            Player.controls.play();
            Title = Player.currentMedia.getItemInfo("Title");
            NotifyVews();//通知View做更新
        }

        //計算播放進度
        public double GetProgress()
        {
            if (Player.controls.currentItem.duration > 0)
                percent = ((double)Player.controls.currentPosition / Player.controls.currentItem.duration);

            return percent;
        }

        //執行循環播放
        public void CheckPlayerState()
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.LatestSongIndex++;
                if (LatestSongIndex == TotalNumberOfList) //當指標等於清單項目總數
                    LatestSongIndex = 0;//指標回到第一首
                ExecutePlay(LatestSongIndex);
            }
        }
    }
}
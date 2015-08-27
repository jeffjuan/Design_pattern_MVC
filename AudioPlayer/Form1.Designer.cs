namespace AudioPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonRandomPlay = new System.Windows.Forms.Button();
            this.buttonCycle = new System.Windows.Forms.Button();
            this.playList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DimGray;
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(480, 44);
            this.panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(103, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "歌名：";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 60);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(480, 23);
            this.progressBar.TabIndex = 1;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPlay.Location = new System.Drawing.Point(12, 90);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 31);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "播放";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStop.Location = new System.Drawing.Point(93, 90);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 31);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNext.Location = new System.Drawing.Point(174, 90);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 31);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "下一首";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPrevious.Location = new System.Drawing.Point(255, 90);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 31);
            this.buttonPrevious.TabIndex = 5;
            this.buttonPrevious.Text = "上一首";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonRandomPlay
            // 
            this.buttonRandomPlay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRandomPlay.Location = new System.Drawing.Point(336, 90);
            this.buttonRandomPlay.Name = "buttonRandomPlay";
            this.buttonRandomPlay.Size = new System.Drawing.Size(75, 31);
            this.buttonRandomPlay.TabIndex = 6;
            this.buttonRandomPlay.Text = "隨機";
            this.buttonRandomPlay.UseVisualStyleBackColor = true;
            this.buttonRandomPlay.Click += new System.EventHandler(this.buttonRandomPlay_Click);
            // 
            // buttonCycle
            // 
            this.buttonCycle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCycle.Location = new System.Drawing.Point(417, 90);
            this.buttonCycle.Name = "buttonCycle";
            this.buttonCycle.Size = new System.Drawing.Size(75, 31);
            this.buttonCycle.TabIndex = 7;
            this.buttonCycle.Text = "循環";
            this.buttonCycle.UseVisualStyleBackColor = true;
            this.buttonCycle.Click += new System.EventHandler(this.buttonCycle_Click);
            // 
            // playList
            // 
            this.playList.FormattingEnabled = true;
            this.playList.ItemHeight = 12;
            this.playList.Location = new System.Drawing.Point(12, 125);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(480, 124);
            this.playList.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 261);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.buttonCycle);
            this.Controls.Add(this.buttonRandomPlay);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "音樂播放器--實作MVC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonRandomPlay;
        private System.Windows.Forms.Button buttonCycle;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Timer timer1;
    }
}


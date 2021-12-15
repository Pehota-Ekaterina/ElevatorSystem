using System;
using System.Windows.Forms;

namespace ElevatorSystem
{
    partial class FirstForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonCreatPerson = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerLift = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(11, 11);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(157, 88);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Запустить систему";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonCreatPerson
            // 
            this.buttonCreatPerson.Location = new System.Drawing.Point(182, 11);
            this.buttonCreatPerson.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreatPerson.Name = "buttonCreatPerson";
            this.buttonCreatPerson.Size = new System.Drawing.Size(142, 88);
            this.buttonCreatPerson.TabIndex = 3;
            this.buttonCreatPerson.Text = "Добавить человека";
            this.buttonCreatPerson.UseVisualStyleBackColor = true;
            this.buttonCreatPerson.Click += new System.EventHandler(this.buttonCreatPerson_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 5;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // timerLift
            // 
            this.timerLift.Interval = 10;
            this.timerLift.Tick += new System.EventHandler(this.timerLift_Tick);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(920, 528);
            this.Controls.Add(this.buttonCreatPerson);
            this.Controls.Add(this.buttonStart);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FirstForm";
            this.Text = "Elevator System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCreatPerson;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerRefresh;
        private Timer timerLift;
    }
}


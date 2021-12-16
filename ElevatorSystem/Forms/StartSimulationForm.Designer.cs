namespace ElevatorSystem
{
    partial class StartSimulationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumberFloor = new System.Windows.Forms.Label();
            this.NumberPerson = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 0;
            // 
            // NumberFloor
            // 
            this.NumberFloor.AutoSize = true;
            this.NumberFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberFloor.Location = new System.Drawing.Point(18, 27);
            this.NumberFloor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberFloor.Name = "NumberFloor";
            this.NumberFloor.Size = new System.Drawing.Size(239, 20);
            this.NumberFloor.TabIndex = 1;
            this.NumberFloor.Text = "Исходное количество этажей:";
            // 
            // NumberPerson
            // 
            this.NumberPerson.AutoSize = true;
            this.NumberPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPerson.Location = new System.Drawing.Point(18, 91);
            this.NumberPerson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberPerson.Name = "NumberPerson";
            this.NumberPerson.Size = new System.Drawing.Size(246, 20);
            this.NumberPerson.TabIndex = 2;
            this.NumberPerson.Text = "Исходное количество человек:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 93);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(230, 180);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(76, 35);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Запуск";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(22, 202);
            this.error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 5;
            // 
            // labelError
            // 
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(216, 153);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(111, 25);
            this.labelError.TabIndex = 6;
            // 
            // StartSimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 236);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.error);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NumberPerson);
            this.Controls.Add(this.NumberFloor);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartSimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartSimulationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NumberFloor;
        private System.Windows.Forms.Label NumberPerson;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label labelError;
    }
}
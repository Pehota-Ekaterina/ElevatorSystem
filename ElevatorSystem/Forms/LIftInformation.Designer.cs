
namespace ElevatorSystem.Forms
{
    partial class LiftInformation
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
            this.buttonMove = new System.Windows.Forms.Button();
            this.labelOverload = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(186, 12);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 0;
            this.buttonMove.Text = "Ход";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // labelOverload
            // 
            this.labelOverload.AutoEllipsis = true;
            this.labelOverload.BackColor = System.Drawing.Color.Lime;
            this.labelOverload.Location = new System.Drawing.Point(12, 9);
            this.labelOverload.Name = "labelOverload";
            this.labelOverload.Size = new System.Drawing.Size(100, 23);
            this.labelOverload.TabIndex = 1;
            this.labelOverload.Text = "не перегружен";
            // 
            // labelWeight
            // 
            this.labelWeight.Location = new System.Drawing.Point(86, 55);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(100, 23);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Вес:";
            this.labelWeight.Click += new System.EventHandler(this.labelWeight_Click);
            // 
            // LiftInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 333);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelOverload);
            this.Controls.Add(this.buttonMove);
            this.Name = "LiftInformation";
            this.Text = "LIftInformation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label labelOverload;
        private System.Windows.Forms.Label labelWeight;
    }
}
using System;
using System.Windows.Forms;
using System.Drawing;
using DustCatMicroService;

namespace DCMSExampleApplication
{
    public class FormService : MicroService
    {
        public override event MessageEvent sendToBus;

        public FormService()
        {
            baseBusName = "Main";
        }

        public override void receive(object sender, MicroServiceEventArgs args)
        {

        }

        public override void RunService()
        {
            Application.Run(new ExampleForm());
        }

        class ExampleForm : Form
        {
            private System.Windows.Forms.Button button;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.Button button3;
            private System.Windows.Forms.Button button4;
            private System.Windows.Forms.Button button5;
            private System.Windows.Forms.Button button6;
            private System.Windows.Forms.Button button7;
            private System.Windows.Forms.Button button8;
            private System.Windows.Forms.Button button9;
            private System.Windows.Forms.Button button10;
            private System.Windows.Forms.Button button11;
            private System.Windows.Forms.Button button12;

            public ExampleForm()
            {
                InitializeComponent();
            }

            // THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
            // DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
            void InitializeComponent()
            {
                this.button6 = new System.Windows.Forms.Button();
                this.button8 = new System.Windows.Forms.Button();
                this.button9 = new System.Windows.Forms.Button();
                this.button11 = new System.Windows.Forms.Button();
                this.button10 = new System.Windows.Forms.Button();
                this.button4 = new System.Windows.Forms.Button();
                this.button5 = new System.Windows.Forms.Button();
                this.button = new System.Windows.Forms.Button();
                this.button7 = new System.Windows.Forms.Button();
                this.button12 = new System.Windows.Forms.Button();
                this.button2 = new System.Windows.Forms.Button();
                this.button3 = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // button6
                // 
                this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button6.Location = new System.Drawing.Point(8, 128);
                this.button6.Name = "button6";
                this.button6.Size = new System.Drawing.Size(480, 24);
                this.button6.TabIndex = 5;
                this.button6.Text = "A normal button : FlatStyle=Flat";
                // 
                // button8
                // 
                this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                this.button8.Location = new System.Drawing.Point(8, 192);
                this.button8.Name = "button8";
                this.button8.Size = new System.Drawing.Size(480, 24);
                this.button8.TabIndex = 7;
                this.button8.Text = "A normal button : Font.Bold=true";
                // 
                // button9
                // 
                this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                this.button9.Location = new System.Drawing.Point(8, 224);
                this.button9.Name = "button9";
                this.button9.Size = new System.Drawing.Size(480, 24);
                this.button9.TabIndex = 8;
                this.button9.Text = "A normal button : Font.Italic=true";
                // 
                // button11
                // 
                this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                this.button11.Location = new System.Drawing.Point(8, 288);
                this.button11.Name = "button11";
                this.button11.Size = new System.Drawing.Size(480, 24);
                this.button11.TabIndex = 10;
                this.button11.Text = "A normal button : Font.Underline=true";
                // 
                // button10
                // 
                this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                this.button10.Location = new System.Drawing.Point(8, 256);
                this.button10.Name = "button10";
                this.button10.Size = new System.Drawing.Size(480, 24);
                this.button10.TabIndex = 9;
                this.button10.Text = "A normal button : Font.Strikeout=true";
                // 
                // button4
                // 
                this.button4.Enabled = false;
                this.button4.Location = new System.Drawing.Point(8, 64);
                this.button4.Name = "button4";
                this.button4.Size = new System.Drawing.Size(480, 24);
                this.button4.TabIndex = 3;
                this.button4.Text = "A normal button : Enabled=false";
                // 
                // button5
                // 
                this.button5.BackColor = System.Drawing.Color.Red;
                this.button5.Location = new System.Drawing.Point(8, 96);
                this.button5.Name = "button5";
                this.button5.Size = new System.Drawing.Size(480, 24);
                this.button5.TabIndex = 4;
                this.button5.Text = "A normal button : BackColor=Red";
                // 
                // button
                // 
                this.button.Dock = System.Windows.Forms.DockStyle.Top;
                this.button.Location = new System.Drawing.Point(0, 0);
                this.button.Name = "button";
                this.button.Size = new System.Drawing.Size(496, 24);
                this.button.TabIndex = 0;
                this.button.Text = "A normal button : Dock=Top";
                // 
                // button7
                // 
                this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button7.Location = new System.Drawing.Point(8, 160);
                this.button7.Name = "button7";
                this.button7.Size = new System.Drawing.Size(480, 24);
                this.button7.TabIndex = 6;
                this.button7.Text = "A normal button : FlatStyle=Popup";
                // 
                // button12
                // 
                this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
                this.button12.Location = new System.Drawing.Point(8, 320);
                this.button12.Name = "button12";
                this.button12.Size = new System.Drawing.Size(480, 24);
                this.button12.TabIndex = 11;
                this.button12.Text = "A normal button : Font.Size=10";
                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(8, 32);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(480, 24);
                this.button2.TabIndex = 1;
                this.button2.Text = "A normal button";
                // 
                // button3
                // 
                this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
                this.button3.Location = new System.Drawing.Point(0, 765);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(496, 24);
                this.button3.TabIndex = 2;
                this.button3.Text = "A normal button : Dock=Bottom";
                // 
                // MainForm
                // 
                this.ClientSize = new System.Drawing.Size(496, 789);
                this.Controls.AddRange(new System.Windows.Forms.Control[] {
                    this.button12, this.button11, this.button10, this.button9,  this.button8,
                    this.button7,  this.button6,  this.button5,  this.button4,  this.button3,
                    this.button2,  this.button});
                this.Text = "SWF-Buttons";
                this.ResumeLayout(false);
                this.FormClosing += ExampleForm_FormClosing;

            }

            void ExampleForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                Application.ExitThread();
            }

        }
        //
    }
}


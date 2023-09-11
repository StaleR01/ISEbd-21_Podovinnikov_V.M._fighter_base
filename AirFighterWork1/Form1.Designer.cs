namespace AirFighterWork1
{
    partial class Title1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            buttonLeft = new Button();
            buttonUp = new Button();
            buttonRight = new Button();
            buttonDown = new Button();
            removeEngine = new Button();
            addEngine = new Button();
            rocket = new Button();
            wings = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1188, 627);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.Location = new Point(1068, 573);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(30, 30);
            buttonLeft.TabIndex = 1;
            buttonLeft.Text = "<-";
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonMove_Click;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUp.Location = new Point(1104, 537);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(30, 30);
            buttonUp.TabIndex = 2;
            buttonUp.Text = "^";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonMove_Click;
            // 
            // buttonRight
            // 
            buttonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRight.Location = new Point(1140, 573);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(30, 30);
            buttonRight.TabIndex = 3;
            buttonRight.Text = "->";
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonMove_Click;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.Location = new Point(1104, 573);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(30, 30);
            buttonDown.TabIndex = 4;
            buttonDown.Text = "\\/";
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonMove_Click;
            // 
            // removeEngine
            // 
            removeEngine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeEngine.Location = new Point(1079, 12);
            removeEngine.Name = "removeEngine";
            removeEngine.Size = new Size(91, 27);
            removeEngine.TabIndex = 5;
            removeEngine.Text = "Remove engine";
            removeEngine.UseVisualStyleBackColor = true;
            removeEngine.Click += buttonMove_Click;
            // 
            // addEngine
            // 
            addEngine.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addEngine.Location = new Point(1079, 45);
            addEngine.Name = "addEngine";
            addEngine.Size = new Size(91, 27);
            addEngine.TabIndex = 6;
            addEngine.Text = "Add engine";
            addEngine.UseVisualStyleBackColor = true;
            addEngine.Click += buttonMove_Click;
            // 
            // rocket
            // 
            rocket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rocket.Location = new Point(1079, 111);
            rocket.Name = "rocket";
            rocket.Size = new Size(91, 27);
            rocket.TabIndex = 7;
            rocket.Text = "Rocket add/remove";
            rocket.UseVisualStyleBackColor = true;
            rocket.Click += buttonMove_Click;
            // 
            // wings
            // 
            wings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            wings.Location = new Point(1079, 78);
            wings.Name = "wings";
            wings.Size = new Size(91, 27);
            wings.TabIndex = 8;
            wings.Text = "Wings add/remove";
            wings.UseVisualStyleBackColor = true;
            wings.Click += buttonMove_Click;
            // 
            // Title1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 627);
            Controls.Add(wings);
            Controls.Add(rocket);
            Controls.Add(addEngine);
            Controls.Add(removeEngine);
            Controls.Add(buttonDown);
            Controls.Add(buttonRight);
            Controls.Add(buttonUp);
            Controls.Add(buttonLeft);
            Controls.Add(pictureBox1);
            Name = "Title1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pictureBoxAirFighter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonLeft;
        private Button buttonUp;
        private Button buttonRight;
        private Button buttonDown;
        private Button removeEngine;
        private Button addEngine;
        private Button rocket;
        private Button wings;
    }
}
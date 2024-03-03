namespace RysowanieKrzywejBeziera
{
    partial class Form1
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
            button1 = new Button();
            P1X = new TextBox();
            P1Y = new TextBox();
            label1 = new Label();
            label2 = new Label();
            P2Y = new TextBox();
            P2X = new TextBox();
            label3 = new Label();
            C2Y = new TextBox();
            C2X = new TextBox();
            label4 = new Label();
            C1Y = new TextBox();
            C1X = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            bufforSizeCtrl = new TextBox();
            groupBox3 = new GroupBox();
            checkBoxMoveControlPoint = new CheckBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(108, 260);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(130, 31);
            button1.TabIndex = 0;
            button1.Text = "Przelicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // P1X
            // 
            P1X.Location = new Point(42, 18);
            P1X.Margin = new Padding(2);
            P1X.Name = "P1X";
            P1X.Size = new Size(52, 23);
            P1X.TabIndex = 1;
            // 
            // P1Y
            // 
            P1Y.Location = new Point(42, 40);
            P1Y.Margin = new Padding(2);
            P1Y.Name = "P1Y";
            P1Y.Size = new Size(52, 23);
            P1Y.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 3;
            label1.Text = "P1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 6;
            label2.Text = "P2";
            // 
            // P2Y
            // 
            P2Y.Location = new Point(48, 42);
            P2Y.Margin = new Padding(2);
            P2Y.Name = "P2Y";
            P2Y.Size = new Size(52, 23);
            P2Y.TabIndex = 5;
            // 
            // P2X
            // 
            P2X.Location = new Point(48, 20);
            P2X.Margin = new Padding(2);
            P2X.Name = "P2X";
            P2X.Size = new Size(52, 23);
            P2X.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 12;
            label3.Text = "C2";
            // 
            // C2Y
            // 
            C2Y.Location = new Point(158, 42);
            C2Y.Margin = new Padding(2);
            C2Y.Name = "C2Y";
            C2Y.Size = new Size(52, 23);
            C2Y.TabIndex = 11;
            // 
            // C2X
            // 
            C2X.Location = new Point(158, 20);
            C2X.Margin = new Padding(2);
            C2X.Name = "C2X";
            C2X.Size = new Size(52, 23);
            C2X.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 30);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 9;
            label4.Text = "C1";
            // 
            // C1Y
            // 
            C1Y.Location = new Point(152, 40);
            C1Y.Margin = new Padding(2);
            C1Y.Name = "C1Y";
            C1Y.Size = new Size(52, 23);
            C1Y.TabIndex = 8;
            // 
            // C1X
            // 
            C1X.Location = new Point(152, 18);
            C1X.Margin = new Padding(2);
            C1X.Name = "C1X";
            C1X.Size = new Size(52, 23);
            C1X.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(P1X);
            groupBox1.Controls.Add(P1Y);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(C1X);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(C1Y);
            groupBox1.Location = new Point(15, 22);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(223, 73);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(P2X);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(P2Y);
            groupBox2.Controls.Add(C2Y);
            groupBox2.Controls.Add(C2X);
            groupBox2.Location = new Point(14, 98);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(224, 73);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            // 
            // bufforSizeCtrl
            // 
            bufforSizeCtrl.Location = new Point(108, 185);
            bufforSizeCtrl.Margin = new Padding(2);
            bufforSizeCtrl.Name = "bufforSizeCtrl";
            bufforSizeCtrl.Size = new Size(106, 23);
            bufforSizeCtrl.TabIndex = 15;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(checkBoxMoveControlPoint);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(bufforSizeCtrl);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(12, 435);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 307);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // checkBoxMoveControlPoint
            // 
            checkBoxMoveControlPoint.AutoSize = true;
            checkBoxMoveControlPoint.Location = new Point(39, 226);
            checkBoxMoveControlPoint.Name = "checkBoxMoveControlPoint";
            checkBoxMoveControlPoint.Size = new Size(121, 19);
            checkBoxMoveControlPoint.TabIndex = 17;
            checkBoxMoveControlPoint.Text = "with control point";
            checkBoxMoveControlPoint.UseVisualStyleBackColor = true;
            checkBoxMoveControlPoint.CheckedChanged += checkBoxMoveControlPoint_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 188);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 16;
            label5.Text = "Buffor size:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 754);
            Controls.Add(groupBox3);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Krzywa Beziera - POC";
            Resize += Form1_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox P1X;
        private TextBox P1Y;
        private Label label1;
        private Label label2;
        private TextBox P2Y;
        private TextBox P2X;
        private Label label3;
        private TextBox C2Y;
        private TextBox C2X;
        private Label label4;
        private TextBox C1Y;
        private TextBox C1X;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox bufforSizeCtrl;
        private GroupBox groupBox3;
        private Label label5;
        private CheckBox checkBoxMoveControlPoint;
    }
}

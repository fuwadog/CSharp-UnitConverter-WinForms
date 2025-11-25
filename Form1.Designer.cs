namespace UnitConverter
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputTXT = new TextBox();
            resultTXT = new TextBox();
            fromBX = new ComboBox();
            toBX = new ComboBox();
            convertBTN = new Button();
            clearBTN = new Button();
            historyBTN = new Button();
            slidertimer = new System.Windows.Forms.Timer(components);
            panelHistory = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(209, 40);
            label1.TabIndex = 0;
            label1.Text = "Unit Converter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(25, 99);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "Input :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(184, 99);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "From :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(267, 99);
            label4.Name = "label4";
            label4.Size = new Size(35, 21);
            label4.TabIndex = 3;
            label4.Text = "To :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(25, 193);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 4;
            label5.Text = "Result :";
            // 
            // inputTXT
            // 
            inputTXT.Location = new Point(25, 137);
            inputTXT.Name = "inputTXT";
            inputTXT.Size = new Size(144, 27);
            inputTXT.TabIndex = 5;
            // 
            // resultTXT
            // 
            resultTXT.Location = new Point(25, 216);
            resultTXT.Name = "resultTXT";
            resultTXT.Size = new Size(144, 27);
            resultTXT.TabIndex = 6;
            // 
            // fromBX
            // 
            fromBX.FormattingEnabled = true;
            fromBX.Location = new Point(184, 136);
            fromBX.Name = "fromBX";
            fromBX.Size = new Size(50, 28);
            fromBX.TabIndex = 7;
            // 
            // toBX
            // 
            toBX.FormattingEnabled = true;
            toBX.Location = new Point(267, 137);
            toBX.Name = "toBX";
            toBX.Size = new Size(50, 28);
            toBX.TabIndex = 8;
            // 
            // convertBTN
            // 
            convertBTN.Location = new Point(356, 101);
            convertBTN.Name = "convertBTN";
            convertBTN.Size = new Size(79, 35);
            convertBTN.TabIndex = 9;
            convertBTN.Text = "Convert";
            convertBTN.UseVisualStyleBackColor = true;
            convertBTN.Click += convertBTN_Click;
            // 
            // clearBTN
            // 
            clearBTN.Location = new Point(356, 147);
            clearBTN.Name = "clearBTN";
            clearBTN.Size = new Size(79, 35);
            clearBTN.TabIndex = 10;
            clearBTN.Text = "Clear";
            clearBTN.UseVisualStyleBackColor = true;
            clearBTN.Click += clearBTN_Click;
            // 
            // historyBTN
            // 
            historyBTN.Location = new Point(356, 193);
            historyBTN.Name = "historyBTN";
            historyBTN.Size = new Size(79, 35);
            historyBTN.TabIndex = 11;
            historyBTN.Text = "History";
            historyBTN.UseVisualStyleBackColor = true;
            historyBTN.Click += historyBTN_Click;
            // 
            // panelHistory
            // 
            panelHistory.BorderStyle = BorderStyle.Fixed3D;
            panelHistory.Dock = DockStyle.Top;
            panelHistory.Location = new Point(0, 0);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(472, 139);
            panelHistory.TabIndex = 12;
            panelHistory.Paint += panelHistory_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(472, 277);
            Controls.Add(panelHistory);
            Controls.Add(historyBTN);
            Controls.Add(clearBTN);
            Controls.Add(convertBTN);
            Controls.Add(toBX);
            Controls.Add(fromBX);
            Controls.Add(resultTXT);
            Controls.Add(inputTXT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox inputTXT;
        private TextBox resultTXT;
        private ComboBox fromBX;
        private ComboBox toBX;
        private Button convertBTN;
        private Button clearBTN;
        private Button historyBTN;
        private System.Windows.Forms.Timer slidertimer;
        private Panel panelHistory;
    }
}

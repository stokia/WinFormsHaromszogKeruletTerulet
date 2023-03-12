namespace WinFormsHaromszogKeruletTerulet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            labelA = new Label();
            textBoxC = new TextBox();
            labelB = new Label();
            labelC = new Label();
            labelKerulet = new Label();
            labelTerulet = new Label();
            button1 = new Button();
            labelHibauzenet = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // textBoxA
            // 
            resources.ApplyResources(textBoxA, "textBoxA");
            textBoxA.Name = "textBoxA";
            // 
            // textBoxB
            // 
            resources.ApplyResources(textBoxB, "textBoxB");
            textBoxB.Name = "textBoxB";
            // 
            // labelA
            // 
            resources.ApplyResources(labelA, "labelA");
            labelA.Name = "labelA";
            labelA.Click += label1_Click;
            // 
            // textBoxC
            // 
            resources.ApplyResources(textBoxC, "textBoxC");
            textBoxC.Name = "textBoxC";
            // 
            // labelB
            // 
            resources.ApplyResources(labelB, "labelB");
            labelB.Name = "labelB";
            labelB.Click += bOldal_Click;
            // 
            // labelC
            // 
            resources.ApplyResources(labelC, "labelC");
            labelC.Name = "labelC";
            labelC.Click += label3_Click;
            // 
            // labelKerulet
            // 
            resources.ApplyResources(labelKerulet, "labelKerulet");
            labelKerulet.Name = "labelKerulet";
            labelKerulet.Click += label2_Click;
            // 
            // labelTerulet
            // 
            resources.ApplyResources(labelTerulet, "labelTerulet");
            labelTerulet.Name = "labelTerulet";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelHibauzenet
            // 
            resources.ApplyResources(labelHibauzenet, "labelHibauzenet");
            labelHibauzenet.Name = "labelHibauzenet";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHibauzenet);
            Controls.Add(button1);
            Controls.Add(labelTerulet);
            Controls.Add(labelKerulet);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(textBoxC);
            Controls.Add(labelA);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Label labelA;
        private TextBox textBoxC;
        private Label labelB;
        private Label labelC;
        private Label labelKerulet;
        private Label labelTerulet;
        private Button button1;
        private Label labelHibauzenet;
    }
}
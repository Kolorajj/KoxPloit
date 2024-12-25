namespace Koxploit
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
            richTextBox1 = new RichTextBox();
            Execute = new Button();
            Clear = new Button();
            KillRoblox = new Button();
            Inject = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(763, 319);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // Execute
            // 
            Execute.Location = new Point(149, 12);
            Execute.Name = "Execute";
            Execute.Size = new Size(94, 29);
            Execute.TabIndex = 1;
            Execute.Text = "Execute";
            Execute.UseVisualStyleBackColor = true;
            Execute.Click += Execute_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(511, 12);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 2;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // KillRoblox
            // 
            KillRoblox.Location = new Point(149, 409);
            KillRoblox.Name = "KillRoblox";
            KillRoblox.Size = new Size(94, 29);
            KillRoblox.TabIndex = 3;
            KillRoblox.Text = "Kill Roblox";
            KillRoblox.UseVisualStyleBackColor = true;
            KillRoblox.Click += KillRoblox_Click;
            // 
            // Inject
            // 
            Inject.Location = new Point(511, 409);
            Inject.Name = "Inject";
            Inject.Size = new Size(94, 29);
            Inject.TabIndex = 4;
            Inject.Text = "Inject";
            Inject.UseVisualStyleBackColor = true;
            Inject.Click += Inject_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Inject);
            Controls.Add(KillRoblox);
            Controls.Add(Clear);
            Controls.Add(Execute);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button Execute;
        private Button Clear;
        private Button KillRoblox;
        private Button Inject;
    }
}

namespace cs535_server
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listenButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(140, 12);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(132, 210);
            this.logs.TabIndex = 0;
            this.logs.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(24, 173);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(110, 20);
            this.messageBox.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(40, 199);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // listenButton
            // 
            this.listenButton.Location = new System.Drawing.Point(40, 60);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(75, 23);
            this.listenButton.TabIndex = 6;
            this.listenButton.Text = "Listen";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(59, 34);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(66, 20);
            this.portBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.logs);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button listenButton;
        private System.Windows.Forms.TextBox portBox;
    }
}


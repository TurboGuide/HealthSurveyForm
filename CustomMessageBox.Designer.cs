namespace Health_Survey_Form
{
    partial class CustomMessageBox
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
            panelMessage = new Panel();
            lblMessage = new Label();
            panelMessage.SuspendLayout();
            SuspendLayout();
            // 
            // panelMessage
            // 
            panelMessage.AutoScroll = true;
            panelMessage.Controls.Add(lblMessage);
            panelMessage.Location = new Point(12, 12);
            panelMessage.Name = "panelMessage";
            panelMessage.Size = new Size(822, 890);
            panelMessage.TabIndex = 0;
            panelMessage.Paint += panelMessage_Paint;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(3, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 25);
            lblMessage.TabIndex = 0;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 965);
            Controls.Add(panelMessage);
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message";
            panelMessage.ResumeLayout(false);
            panelMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMessage;
        private Label lblMessage;
    }
}
namespace COMM2ES
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
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.jasonInput = new System.Windows.Forms.RichTextBox();
            this.jasonOutput = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlTxt
            // 
            this.urlTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlTxt.Location = new System.Drawing.Point(0, 0);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(729, 22);
            this.urlTxt.TabIndex = 0;
            this.urlTxt.Text = "http://localhost:9200/hello/world/1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.comboBox1.Location = new System.Drawing.Point(0, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "POST";
            // 
            // jasonInput
            // 
            this.jasonInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jasonInput.Location = new System.Drawing.Point(0, 58);
            this.jasonInput.Name = "jasonInput";
            this.jasonInput.Size = new System.Drawing.Size(729, 96);
            this.jasonInput.TabIndex = 2;
            this.jasonInput.Text = "{\"title\":\"Elasticsearch Server\", \"published\": 2013}";
            // 
            // jasonOutput
            // 
            this.jasonOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jasonOutput.Location = new System.Drawing.Point(0, 199);
            this.jasonOutput.Name = "jasonOutput";
            this.jasonOutput.Size = new System.Drawing.Size(729, 237);
            this.jasonOutput.TabIndex = 3;
            this.jasonOutput.Text = "";
            // 
            // Send
            // 
            this.Send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Send.Location = new System.Drawing.Point(0, 160);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(729, 33);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 448);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.jasonOutput);
            this.Controls.Add(this.jasonInput);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.urlTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox jasonInput;
        private System.Windows.Forms.RichTextBox jasonOutput;
        private System.Windows.Forms.Button Send;
    }
}


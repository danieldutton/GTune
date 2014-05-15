namespace GTuner.Presentation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._comboBoxFrequency = new System.Windows.Forms.ComboBox();
            this._comboBoxString = new System.Windows.Forms.ComboBox();
            this._btnPlay = new System.Windows.Forms.Button();
            this._btnStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._comboBoxFrequency);
            this.panel1.Controls.Add(this._comboBoxString);
            this.panel1.Controls.Add(this._btnPlay);
            this.panel1.Controls.Add(this._btnStop);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 49);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Frequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Note";
            // 
            // _comboBoxFrequency
            // 
            this._comboBoxFrequency.BackColor = System.Drawing.Color.White;
            this._comboBoxFrequency.FormattingEnabled = true;
            this._comboBoxFrequency.Location = new System.Drawing.Point(72, 17);
            this._comboBoxFrequency.Name = "_comboBoxFrequency";
            this._comboBoxFrequency.Size = new System.Drawing.Size(53, 21);
            this._comboBoxFrequency.TabIndex = 12;
            // 
            // _comboBoxString
            // 
            this._comboBoxString.BackColor = System.Drawing.Color.White;
            this._comboBoxString.FormattingEnabled = true;
            this._comboBoxString.Location = new System.Drawing.Point(13, 17);
            this._comboBoxString.Name = "_comboBoxString";
            this._comboBoxString.Size = new System.Drawing.Size(53, 21);
            this._comboBoxString.TabIndex = 13;
            // 
            // _btnPlay
            // 
            this._btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("_btnPlay.Image")));
            this._btnPlay.Location = new System.Drawing.Point(154, 17);
            this._btnPlay.Name = "_btnPlay";
            this._btnPlay.Size = new System.Drawing.Size(40, 23);
            this._btnPlay.TabIndex = 11;
            this._btnPlay.UseVisualStyleBackColor = true;
            this._btnPlay.Click += new System.EventHandler(this.PlayNote_Click);
            // 
            // _btnStop
            // 
            this._btnStop.Image = ((System.Drawing.Image)(resources.GetObject("_btnStop.Image")));
            this._btnStop.Location = new System.Drawing.Point(200, 17);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(39, 23);
            this._btnStop.TabIndex = 10;
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Click += new System.EventHandler(this.StopNote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 48);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "G-Tune";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboBoxFrequency;
        private System.Windows.Forms.ComboBox _comboBoxString;
        private System.Windows.Forms.Button _btnPlay;
        private System.Windows.Forms.Button _btnStop;
    }
}


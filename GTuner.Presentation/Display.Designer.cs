namespace GTuner.Presentation
{
    partial class Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this._panelMain = new System.Windows.Forms.Panel();
            this._lblLoop = new System.Windows.Forms.Label();
            this._lblNote = new System.Windows.Forms.Label();
            this._comboBoxLoopBy = new System.Windows.Forms.ComboBox();
            this._comboBoxNotes = new System.Windows.Forms.ComboBox();
            this._btnPlay = new System.Windows.Forms.Button();
            this._btnStop = new System.Windows.Forms.Button();
            this._panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelMain
            // 
            this._panelMain.BackColor = System.Drawing.Color.CadetBlue;
            this._panelMain.Controls.Add(this._lblLoop);
            this._panelMain.Controls.Add(this._lblNote);
            this._panelMain.Controls.Add(this._comboBoxLoopBy);
            this._panelMain.Controls.Add(this._comboBoxNotes);
            this._panelMain.Controls.Add(this._btnPlay);
            this._panelMain.Controls.Add(this._btnStop);
            this._panelMain.Location = new System.Drawing.Point(-1, -1);
            this._panelMain.Name = "_panelMain";
            this._panelMain.Size = new System.Drawing.Size(251, 49);
            this._panelMain.TabIndex = 5;
            // 
            // _lblLoop
            // 
            this._lblLoop.AutoSize = true;
            this._lblLoop.BackColor = System.Drawing.Color.Transparent;
            this._lblLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblLoop.ForeColor = System.Drawing.Color.White;
            this._lblLoop.Location = new System.Drawing.Point(69, 3);
            this._lblLoop.Name = "_lblLoop";
            this._lblLoop.Size = new System.Drawing.Size(31, 13);
            this._lblLoop.TabIndex = 14;
            this._lblLoop.Text = "Loop";
            // 
            // _lblNote
            // 
            this._lblNote.AutoSize = true;
            this._lblNote.BackColor = System.Drawing.Color.Transparent;
            this._lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNote.ForeColor = System.Drawing.Color.White;
            this._lblNote.Location = new System.Drawing.Point(13, 3);
            this._lblNote.Name = "_lblNote";
            this._lblNote.Size = new System.Drawing.Size(29, 13);
            this._lblNote.TabIndex = 15;
            this._lblNote.Text = "Note";
            // 
            // _comboBoxLoopBy
            // 
            this._comboBoxLoopBy.BackColor = System.Drawing.Color.White;
            this._comboBoxLoopBy.FormattingEnabled = true;
            this._comboBoxLoopBy.Location = new System.Drawing.Point(72, 17);
            this._comboBoxLoopBy.Name = "_comboBoxLoopBy";
            this._comboBoxLoopBy.Size = new System.Drawing.Size(53, 21);
            this._comboBoxLoopBy.TabIndex = 12;
            // 
            // _comboBoxNotes
            // 
            this._comboBoxNotes.BackColor = System.Drawing.Color.White;
            this._comboBoxNotes.FormattingEnabled = true;
            this._comboBoxNotes.Location = new System.Drawing.Point(13, 17);
            this._comboBoxNotes.Name = "_comboBoxNotes";
            this._comboBoxNotes.Size = new System.Drawing.Size(53, 21);
            this._comboBoxNotes.TabIndex = 13;
            // 
            // _btnPlay
            // 
            this._btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("_btnPlay.Image")));
            this._btnPlay.Location = new System.Drawing.Point(154, 17);
            this._btnPlay.Name = "_btnPlay";
            this._btnPlay.Size = new System.Drawing.Size(40, 23);
            this._btnPlay.TabIndex = 11;
            this._btnPlay.UseVisualStyleBackColor = true;
            this._btnPlay.Click += new System.EventHandler(this.PlaySelectedNote_Click);
            // 
            // _btnStop
            // 
            this._btnStop.Image = ((System.Drawing.Image)(resources.GetObject("_btnStop.Image")));
            this._btnStop.Location = new System.Drawing.Point(200, 17);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(39, 23);
            this._btnStop.TabIndex = 10;
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Click += new System.EventHandler(this.StopSelectedNote_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 48);
            this.Controls.Add(this._panelMain);
            this.MaximumSize = new System.Drawing.Size(266, 86);
            this.MinimumSize = new System.Drawing.Size(266, 86);
            this.Name = "Display";
            this.Text = "G-Tune";
            this._panelMain.ResumeLayout(false);
            this._panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelMain;
        private System.Windows.Forms.Label _lblLoop;
        private System.Windows.Forms.Label _lblNote;
        private System.Windows.Forms.ComboBox _comboBoxLoopBy;
        private System.Windows.Forms.ComboBox _comboBoxNotes;
        private System.Windows.Forms.Button _btnPlay;
        private System.Windows.Forms.Button _btnStop;
    }
}


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
            this._comboBoxInstruments = new System.Windows.Forms.ComboBox();
            this._comboBoxNotes = new System.Windows.Forms.ComboBox();
            this._btnPlay = new System.Windows.Forms.Button();
            this._btnStop = new System.Windows.Forms.Button();
            this._panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelMain
            // 
            this._panelMain.BackColor = System.Drawing.Color.CadetBlue;
            this._panelMain.Controls.Add(this._comboBoxInstruments);
            this._panelMain.Controls.Add(this._comboBoxNotes);
            this._panelMain.Controls.Add(this._btnPlay);
            this._panelMain.Controls.Add(this._btnStop);
            this._panelMain.Location = new System.Drawing.Point(-1, -1);
            this._panelMain.Name = "_panelMain";
            this._panelMain.Size = new System.Drawing.Size(167, 109);
            this._panelMain.TabIndex = 5;
            // 
            // _comboBoxInstruments
            // 
            this._comboBoxInstruments.BackColor = System.Drawing.Color.Gold;
            this._comboBoxInstruments.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxInstruments.ForeColor = System.Drawing.Color.Maroon;
            this._comboBoxInstruments.FormattingEnabled = true;
            this._comboBoxInstruments.Location = new System.Drawing.Point(38, 13);
            this._comboBoxInstruments.Name = "_comboBoxInstruments";
            this._comboBoxInstruments.Size = new System.Drawing.Size(85, 21);
            this._comboBoxInstruments.TabIndex = 13;
            this._comboBoxInstruments.SelectionChangeCommitted += new System.EventHandler(this.OnInstrumentTypeChanged);
            // 
            // _comboBoxNotes
            // 
            this._comboBoxNotes.BackColor = System.Drawing.Color.Gold;
            this._comboBoxNotes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxNotes.ForeColor = System.Drawing.Color.Maroon;
            this._comboBoxNotes.FormattingEnabled = true;
            this._comboBoxNotes.Location = new System.Drawing.Point(38, 40);
            this._comboBoxNotes.Name = "_comboBoxNotes";
            this._comboBoxNotes.Size = new System.Drawing.Size(85, 21);
            this._comboBoxNotes.TabIndex = 13;
            // 
            // _btnPlay
            // 
            this._btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("_btnPlay.Image")));
            this._btnPlay.Location = new System.Drawing.Point(38, 74);
            this._btnPlay.Name = "_btnPlay";
            this._btnPlay.Size = new System.Drawing.Size(40, 23);
            this._btnPlay.TabIndex = 11;
            this._btnPlay.UseVisualStyleBackColor = true;
            this._btnPlay.Click += new System.EventHandler(this.PlaySelectedNote_Click);
            // 
            // _btnStop
            // 
            this._btnStop.Image = ((System.Drawing.Image)(resources.GetObject("_btnStop.Image")));
            this._btnStop.Location = new System.Drawing.Point(84, 74);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(39, 23);
            this._btnStop.TabIndex = 10;
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Click += new System.EventHandler(this.StopNotePlay_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(165, 108);
            this.Controls.Add(this._panelMain);
            this.Name = "Display";
            this.Text = "G-Tune";
            this._panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelMain;
        private System.Windows.Forms.ComboBox _comboBoxNotes;
        private System.Windows.Forms.Button _btnPlay;
        private System.Windows.Forms.Button _btnStop;
        private System.Windows.Forms.ComboBox _comboBoxInstruments;
    }
}


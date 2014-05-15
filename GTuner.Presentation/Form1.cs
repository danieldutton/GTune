using GTuner.Audio.Interfaces;
using GTuner.Audio.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GTuner.Presentation
{
    public partial class Form1 : Form
    {
        private readonly ISoundPlayer _guitarPlayer;

        public Form1(ISoundPlayer soundPlayer)
        {
            _guitarPlayer = soundPlayer;
            
            InitializeComponent();
            PopulateGuitarStringComboBox();
            PopulateFrequencyComboBox();
        }

        private void PopulateGuitarStringComboBox()
        {
            Array strings = Enum.GetValues(typeof (Notes));

            _comboBoxString.DataSource = strings;
        }

        private void PopulateFrequencyComboBox()
        {
            IEnumerable<int> frequency = new List<int> {1, 2, 3};

            _comboBoxFrequency.DataSource = frequency;
        }

        private void PlayNote_Click(object sender, EventArgs e)
        {
            string gOpenNote = GetResourceFileName();
            int frequency = GetPlayFrequency();

            _guitarPlayer.Play(gOpenNote, frequency);
        }

        private string GetResourceFileName()
        {
            var note = (Notes)_comboBoxString.SelectedValue;

            return note.ToString();
        }

        private int GetPlayFrequency()
        {
            return (int)_comboBoxFrequency.SelectedValue;
        }

        private void FormClosing_Click(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
        }

        private void StopNote_Click(object sender, EventArgs e)
        {
            _guitarPlayer.Stop();    
        }        
    }
}

using GTuner.Audio.Interfaces;
using GTuner.Audio.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GTuner.Presentation
{
    public partial class Display : Form
    {
        private readonly ISoundPlayer _soundPlayer;

        private int LoopBy
        {
            get { return (int)_comboBoxLoopBy.SelectedValue; }
        }

        private string ResourceName
        {
            get { return _comboBoxNotes.SelectedValue.ToString(); }
        }

        public Display(ISoundPlayer soundPlayer)
        {
            _soundPlayer = soundPlayer;
            
            InitializeComponent();
            PopulateGuitarNoteComboBox();
            PopulateLoopByComboBox();
        }

        private void PopulateGuitarNoteComboBox()
        {
            Array notes = Enum.GetValues(typeof(Notes));

            _comboBoxNotes.DataSource = notes;
        }

        private void PopulateLoopByComboBox()
        {
            IEnumerable<int> loopBy = new List<int> {1, 2, 3};

            _comboBoxLoopBy.DataSource = loopBy;
        }

        private void PlaySelectedNote_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play(ResourceName, LoopBy);
        }

        private void StopSelectedNote_Click(object sender, EventArgs e)
        {
            _soundPlayer.Stop();
        }            
    }
}

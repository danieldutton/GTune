using GTuner.Audio.Interfaces;
using GTuner.Audio.Model;
using System;
using System.Windows.Forms;

namespace GTuner.Presentation
{
    public partial class Display : Form
    {
        private readonly ISoundPlayer _soundPlayer;

        private readonly IResourceHandler _resourceHandler;

        private string ResourceName
        {
            get { return _comboBoxInstruments.SelectedValue + "_" + _comboBoxNotes.SelectedValue; }
        }

        public Display(ISoundPlayer soundPlayer, IResourceHandler resourceHandler)
        {
            _soundPlayer = soundPlayer;
            _resourceHandler = resourceHandler;
            
            InitializeComponent();
            DisplayAvailableInstruments();
            DisplayInstrumentNotes();
        }

        private void DisplayAvailableInstruments()
        {
            Array availableInstruments = Enum.GetValues(typeof (Instrument));

            _comboBoxInstruments.DataSource = availableInstruments;
        }

        private void DisplayInstrumentNotes()
        {
            Array notes = Enum.GetValues(typeof(GuitarNotes));

            _comboBoxNotes.DataSource = notes;
        }

        private void PlaySelectedNote_Click(object sender, EventArgs e)
        {
            object resource = _resourceHandler.GetResource(ResourceName);

            _soundPlayer.Play(resource);
        }

        private void StopNotePlay_Click(object sender, EventArgs e)
        {
            _soundPlayer.Stop();
        }

        private void OnInstrumentTypeChanged(object sender, EventArgs e)
        {
            object result = _comboBoxInstruments.SelectedValue;

            if (result.ToString().Equals(Instrument.Guitar.ToString()))
            {
                Array notes = Enum.GetValues(typeof(GuitarNotes));

                _comboBoxNotes.DataSource = notes;
            }

            if (result.ToString().Equals(Instrument.Bass.ToString()))
            {
                Array notes = Enum.GetValues(typeof(BassNotes));

                _comboBoxNotes.DataSource = notes;
            }
        }
  
    }
}

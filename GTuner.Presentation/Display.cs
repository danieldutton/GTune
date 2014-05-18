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
            get { return _comboBoxNotes.SelectedValue.ToString(); }
        }

        public Display(ISoundPlayer soundPlayer, IResourceHandler resourceHandler)
        {
            _soundPlayer = soundPlayer;
            _resourceHandler = resourceHandler;
            
            InitializeComponent();
            DisplayNotes();
        }


        private void DisplayNotes()
        {
            Array notes = Enum.GetValues(typeof(GuitarNotes));

            _comboBoxNotes.DataSource = notes;
        }

        private void PlayNote_Click(object sender, EventArgs e)
        {
            object resource = _resourceHandler.GetResource(ResourceName);

            _soundPlayer.Play(resource);
        }

        private void StopNote_Click(object sender, EventArgs e)
        {
            _soundPlayer.Stop();
        }           
    }
}

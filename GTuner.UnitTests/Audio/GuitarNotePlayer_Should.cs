using GTuner.Audio;
using NUnit.Framework;
using System;

namespace GTuner.UnitTests.Audio
{
    [TestFixture]
    public class GuitarNotePlayer_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Play_ThrowAnArgumentNullException_IfResourceReturnedIsNull()
        {
            var sut = new GuitarNotePlayer();

            sut.Play(null);
        }
    }
}

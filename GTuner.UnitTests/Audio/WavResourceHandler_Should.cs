using GTuner.Audio;
using GTuner.Audio.Interfaces;
using NUnit.Framework;
using System;

namespace GTuner.UnitTests.Audio
{
    [TestFixture]
    public class WavResourceHandler_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void GetResource_ThrowAnArgumentException_IfParamIsNull()
        {
            IResourceHandler sut = new WavResourceHandler();
            
            sut.GetResource(null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void GetResource_ThrowAnArgumentException_IfParamIsEmptyString()
        {
            IResourceHandler sut = new WavResourceHandler();

            sut.GetResource(string.Empty);
        }

        [Test]
        public void GetResource_ReturnNull_IfResourceDoesntExist()
        {
            IResourceHandler sut = new WavResourceHandler();

            object actual = sut.GetResource("NonExistantResource");

            Assert.IsNull(actual);
        }
    }
}

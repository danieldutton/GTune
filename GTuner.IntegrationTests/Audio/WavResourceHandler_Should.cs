using System.IO;
using GTuner.Audio;
using GTuner.Audio.Interfaces;
using GTuner.Audio.Model;
using NUnit.Framework;
using System;

namespace GTuner.IntegrationTests.Audio
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
            Assert.IsNotInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavELow()
        {
            IResourceHandler sut = new WavResourceHandler();

            object actual = sut.GetResource(Notes.ELow.ToString());

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavLowA()
        {
            IResourceHandler sut = new WavResourceHandler();

            object actual = sut.GetResource(Notes.A.ToString());

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavD()
        {
            IResourceHandler sut = new WavResourceHandler();

            object actual = sut.GetResource(Notes.D.ToString());

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavG()
        {
            IResourceHandler sut = new WavResourceHandler();

            object actual = sut.GetResource(Notes.G.ToString());

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavB()
        {
            IResourceHandler sut = new WavResourceHandler();

            object actual = sut.GetResource(Notes.B.ToString());

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavEHigh()
        {
            IResourceHandler sut = new WavResourceHandler();

            object actual = sut.GetResource(Notes.EHigh.ToString());

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }
    }
}

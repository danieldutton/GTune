﻿using GTuner.Audio;
using GTuner.Audio.Interfaces;
using GTuner.Audio.Model;
using NUnit.Framework;
using System.IO;

namespace GTuner.IntegrationTests.Audio
{
    [TestFixture]
    public class WavResourceHandler_Should
    {
        private IResourceHandler _sut;

        [SetUp]
        public void Init()
        {
            _sut = new WavResourceHandler();
        }

        [Test]
        public void GetResource_ReturnNull_IfResourceDoesntExist()
        {
            object actual = _sut.GetResource("NonExistantResource");

            Assert.IsNull(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavELow()
        {
            object actual = _sut.GetResource("Guitar_ELow");

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavLowA()
        {
            object actual = _sut.GetResource("Guitar_A");

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavD()
        {
            object actual = _sut.GetResource("Guitar_D");

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavG()
        {
            object actual = _sut.GetResource("Guitar_G");

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavB()
        {
            object actual = _sut.GetResource("Guitar_B");

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [Test]
        public void GetResource_ReturnAStream_ForWavEHigh()
        {
            object actual = _sut.GetResource("Guitar_EHigh");

            Assert.IsNotNull(actual);
            Assert.IsInstanceOf<Stream>(actual);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}

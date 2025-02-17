﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.ParameterSet;

namespace MIDTesters.ParameterSet
{
    [TestClass]
    public class TestMid0013 : MidTester
    {
        [TestMethod]
        public void Mid0013Revision1()
        {
            string pack = @"01040013            0100102Airbag1                  0310403050012000600150007001400080036009007201000480";
            var mid = _midInterpreter.Parse<Mid0013>(pack);

            Assert.AreEqual(typeof(Mid0013), mid.GetType());
            Assert.IsNotNull(mid.ParameterSetId);
            Assert.IsNotNull(mid.ParameterSetName);
            Assert.IsNotNull(mid.RotationDirection);
            Assert.IsNotNull(mid.BatchSize);
            Assert.IsNotNull(mid.MinTorque);
            Assert.IsNotNull(mid.MaxTorque);
            Assert.IsNotNull(mid.TorqueFinalTarget);
            Assert.IsNotNull(mid.MinAngle);
            Assert.IsNotNull(mid.MaxAngle);
            Assert.IsNotNull(mid.AngleFinalTarget);
            Assert.AreEqual(pack, mid.Pack());
        }

        [TestMethod]
        public void Mid0013ByteRevision1()
        {
            string package = "01040013            0100102Airbag1                  0310403050012000600150007001400080036009007201000480";
            byte[] bytes = GetAsciiBytes(package);
            var mid = _midInterpreter.Parse<Mid0013>(bytes);

            Assert.AreEqual(typeof(Mid0013), mid.GetType());
            Assert.IsNotNull(mid.ParameterSetId);
            Assert.IsNotNull(mid.ParameterSetName);
            Assert.IsNotNull(mid.RotationDirection);
            Assert.IsNotNull(mid.BatchSize);
            Assert.IsNotNull(mid.MinTorque);
            Assert.IsNotNull(mid.MaxTorque);
            Assert.IsNotNull(mid.TorqueFinalTarget);
            Assert.IsNotNull(mid.MinAngle);
            Assert.IsNotNull(mid.MaxAngle);
            Assert.IsNotNull(mid.AngleFinalTarget);
            Assert.IsTrue(mid.PackBytes().SequenceEqual(bytes));
        }

        [TestMethod]
        public void Mid0013Revision2()
        {
            string pack = @"01200013002         0100102Airbag1                  03104030500120006001500070014000800360090072010004801102021112017854";
            var mid = _midInterpreter.Parse<Mid0013>(pack);

            Assert.AreEqual(typeof(Mid0013), mid.GetType());
            Assert.IsNotNull(mid.ParameterSetId);
            Assert.IsNotNull(mid.ParameterSetName);
            Assert.IsNotNull(mid.RotationDirection);
            Assert.IsNotNull(mid.BatchSize);
            Assert.IsNotNull(mid.MinTorque);
            Assert.IsNotNull(mid.MaxTorque);
            Assert.IsNotNull(mid.TorqueFinalTarget);
            Assert.IsNotNull(mid.MinAngle);
            Assert.IsNotNull(mid.MaxAngle);
            Assert.IsNotNull(mid.AngleFinalTarget);
            Assert.IsNotNull(mid.FirstTarget);
            Assert.IsNotNull(mid.StartFinalAngle);
            Assert.AreEqual(pack, mid.Pack());
        }

        [TestMethod]
        public void Mid0013ByteRevision2()
        {
            string package = @"01200013002         0100102Airbag1                  03104030500120006001500070014000800360090072010004801102021112017854";
            byte[] bytes = GetAsciiBytes(package);
            var mid = _midInterpreter.Parse<Mid0013>(bytes);

            Assert.AreEqual(typeof(Mid0013), mid.GetType());
            Assert.IsNotNull(mid.ParameterSetId);
            Assert.IsNotNull(mid.ParameterSetName);
            Assert.IsNotNull(mid.RotationDirection);
            Assert.IsNotNull(mid.BatchSize);
            Assert.IsNotNull(mid.MinTorque);
            Assert.IsNotNull(mid.MaxTorque);
            Assert.IsNotNull(mid.TorqueFinalTarget);
            Assert.IsNotNull(mid.MinAngle);
            Assert.IsNotNull(mid.MaxAngle);
            Assert.IsNotNull(mid.AngleFinalTarget);
            Assert.IsNotNull(mid.FirstTarget);
            Assert.IsNotNull(mid.StartFinalAngle);
            Assert.IsTrue(mid.PackBytes().SequenceEqual(bytes));
        }

        [TestMethod]
        public void Mid0013Revision5()
        {
            string pack = @"01410013005         0100102Airbag1                  03104030500120006001500070014000800360090072010004801102021112017854132001-05-29:12:34:33";
            var mid = _midInterpreter.Parse<Mid0013>(pack);

            Assert.AreEqual(typeof(Mid0013), mid.GetType());
            Assert.IsNotNull(mid.ParameterSetId);
            Assert.IsNotNull(mid.ParameterSetName);
            Assert.IsNotNull(mid.RotationDirection);
            Assert.IsNotNull(mid.BatchSize);
            Assert.IsNotNull(mid.MinTorque);
            Assert.IsNotNull(mid.MaxTorque);
            Assert.IsNotNull(mid.TorqueFinalTarget);
            Assert.IsNotNull(mid.MinAngle);
            Assert.IsNotNull(mid.MaxAngle);
            Assert.IsNotNull(mid.AngleFinalTarget);
            Assert.IsNotNull(mid.FirstTarget);
            Assert.IsNotNull(mid.StartFinalAngle);
            Assert.IsNotNull(mid.LastChangeInParameterSet);
            Assert.AreEqual(pack, mid.Pack());
        }

        [TestMethod]
        public void Mid0013ByteRevision5()
        {
            string package = @"01410013005         0100102Airbag1                  03104030500120006001500070014000800360090072010004801102021112017854132001-05-29:12:34:33";
            byte[] bytes = GetAsciiBytes(package);
            var mid = _midInterpreter.Parse<Mid0013>(bytes);

            Assert.AreEqual(typeof(Mid0013), mid.GetType());
            Assert.IsNotNull(mid.ParameterSetId);
            Assert.IsNotNull(mid.ParameterSetName);
            Assert.IsNotNull(mid.RotationDirection);
            Assert.IsNotNull(mid.BatchSize);
            Assert.IsNotNull(mid.MinTorque);
            Assert.IsNotNull(mid.MaxTorque);
            Assert.IsNotNull(mid.TorqueFinalTarget);
            Assert.IsNotNull(mid.MinAngle);
            Assert.IsNotNull(mid.MaxAngle);
            Assert.IsNotNull(mid.AngleFinalTarget);
            Assert.IsNotNull(mid.FirstTarget);
            Assert.IsNotNull(mid.StartFinalAngle);
            Assert.IsNotNull(mid.LastChangeInParameterSet);
            Assert.IsTrue(mid.PackBytes().SequenceEqual(bytes));
        }
    }
}

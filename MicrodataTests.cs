using System;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using JoshCodes.Core;

namespace JoshCodes.Web.Testing.Unit
{
    [TestClass]
    public class MicrodataTests
    {
        [DataContract(Name = "Organization", Namespace="")]
        private class ExampleType1
        {
            [DataMember(Name="name")]
            public string Name { get; set; }
        }

        [TestMethod]
        public void DeserializeOrganization()
        {
            var microdataString = Properties.Resources.microdata_example1;
            var xmlString = Properties.Resources.organization;

            using (var microdataStream = microdataString.ToStream())
            using (var xmlStream = xmlString.ToStream())
            {
                var parser = new Web.Microdata.Parser(microdataStream);
                var readerMicrodata = parser.XmlReaders.First();

                var readerXml = System.Xml.XmlReader.Create(xmlStream);

                var serializer = new DataContractSerializer(typeof(ExampleType1));
                var exmaple1Xml = (ExampleType1)serializer.ReadObject(readerXml);
                var exmaple1Microdata = (ExampleType1)serializer.ReadObject(readerMicrodata);

                Assert.AreEqual(exmaple1Xml.Name, "Legendary Code");
                Assert.AreEqual(exmaple1Microdata.Name, "Legendary Code");
            }
        }

        private static void AssertXmlReaders(System.Xml.XmlReader reader1, System.Xml.XmlReader reader2)
        {
            var name1 = reader1.LocalName;
            var name2 = reader2.LocalName;
            Assert.AreEqual(name1, name2);

            var value1 = reader1.Value;
            var value2 = reader2.Value;
            Assert.AreEqual(value1, value2);

            var type1 = reader1.NodeType;
            var type2 = reader2.NodeType;
            Assert.AreEqual(type1, type2);

            var state1 = reader1.ReadState;
            var state2 = reader2.ReadState;
            Assert.AreEqual(state1, state2);

            var depth1 = reader1.Depth;
            var depth2 = reader2.Depth;
            Assert.AreEqual(depth1, depth2);
        }

        [TestMethod]
        public void CompareOrganization()
        {
            var microdataString = Properties.Resources.microdata_example1;
            var xmlString = Properties.Resources.organization;

            using (var microdataStream = microdataString.ToStream())
            using (var xmlStream = xmlString.ToStream())
            {
                var parser = new Web.Microdata.Parser(microdataStream);
                var readerMicrodata = parser.XmlReaders.First();

                var readerXml = System.Xml.XmlReader.Create(xmlStream);

                AssertXmlReaders(readerMicrodata, readerXml);

                do
                {
                    readerXml.Read();
                    if (readerXml.NodeType == System.Xml.XmlNodeType.Whitespace)
                        continue;
                    readerMicrodata.Read();

                    AssertXmlReaders(readerMicrodata, readerXml);

                    if (readerMicrodata.EOF)
                    {
                        Assert.IsTrue(readerXml.EOF);
                        break;
                    }
                } while (true);
            }
        }
    }
}

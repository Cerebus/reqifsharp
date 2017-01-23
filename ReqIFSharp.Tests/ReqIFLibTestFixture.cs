﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ReqIFLibTestFixture.cs" company="RHEA System S.A.">
//
//   Copyright 2017 RHEA System S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//
// </copyright>
// ------------------------------------------------------------------------------------------------

namespace ReqIFSharp.Tests
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    using NUnit.Framework;
    using ReqIFSharp;

    [TestFixture]
    public class ReqIFLibTestFixture
    {
        private const string ReqIFNamespace = @"http://www.omg.org/spec/ReqIF/20110401/reqif.xsd";
        private XmlSerializer serializer;

        [SetUp]
        public void Setup()
        {
            this.serializer = new XmlSerializer(typeof(ReqIF), ReqIFNamespace);
        }

        [Test]
        public void VerifyThatReqIfObjectIsCreatedCorrectly()
        {
            using (var xmlreader = XmlReader.Create(@"../../test.xml"))
            {
                var reqif = (ReqIF)this.serializer.Deserialize(xmlreader);

                //Assert.IsNotNull(reqif);
                //Assert.IsNotNull(reqif.TheHeader);                
                //Assert.IsNotNullOrEmpty(reqif.TheHeader.Comment);
                //Assert.IsNotNullOrEmpty(reqif.TheHeader.Identifier);
                //Assert.IsNotNullOrEmpty(reqif.TheHeader.RepositoryId);
                //Assert.IsNotNullOrEmpty(reqif.TheHeader.ReqIFToolId);
                //Assert.IsNotNullOrEmpty(reqif.TheHeader.ReqIFVersion);
                //Assert.IsNotNullOrEmpty(reqif.TheHeader.SourceToolId);
                //Assert.IsNotNullOrEmpty(reqif.TheHeader.Title);
                //Assert.IsNotNull(reqif.TheHeader.CreationTime);

                //Assert.IsNotNull(reqif.CoreContent);
                //Assert.IsNotEmpty(reqif.CoreContent.DataTypes);
                //Assert.IsNotEmpty(reqif.CoreContent.SpecObjects);
                //Assert.IsEmpty(reqif.CoreContent.SpecRelationGroups);
                //Assert.IsNotEmpty(reqif.CoreContent.SpecRelations);
                //Assert.IsNotEmpty(reqif.CoreContent.SpecTypes);
                //Assert.IsNotEmpty(reqif.CoreContent.Specifications);
            }
        }
    }
}
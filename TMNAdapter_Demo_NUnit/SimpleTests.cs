using NUnit.Framework;
using System;
using System.IO;
using TMNAdapter.Tracking.Attributes;

[assembly: AssemblyAction]

namespace TMNAdapter_Demo_NUnit
{
    [TestFixture]
    class SimpleTests : BaseTest
    {
        [Test]
        [JiraIssueKey("EPMFARMATS-2464")]
        public void TestParametersAdding()
        {
            JiraInfoProvider.SaveParameter("Username", "Mr.Smith");
            JiraInfoProvider.SaveParameter("Password", "QwErTy_123");
            JiraInfoProvider.SaveParameter("Email", "MrSmith@gmail.com");

            Assert.IsTrue(true);
        }

        [Test]
        [JiraIssueKey("EPMFARMATS-2472")]
        public void TestExeptionInTest()
        {
            throw new Exception("Testing test with exeption");
        }

        [Test]
        [JiraIssueKey("EPMFARMATS-2447")]
        public void CheckArtifacts()
        {
            var random = new Random();

            JiraInfoProvider.SaveParameter("Random number", Convert.ToString(random.Next()));
            JiraInfoProvider.SaveParameter("Random boolean", Convert.ToString(random.Next(0, 1)));
            JiraInfoProvider.SaveParameter("Some static string", "Hello, world!");

            JiraInfoProvider.SaveAttachment(new FileInfo($@"{AppDomain.CurrentDomain.BaseDirectory}..\..\Resources\jenkins-oops.jpg"));
            JiraInfoProvider.SaveAttachment(new FileInfo($@"{AppDomain.CurrentDomain.BaseDirectory}..\..\Resources\jenkins-oops.jpg"));

            Assert.Fail("Testing failed test behavior");
        }
    }
}

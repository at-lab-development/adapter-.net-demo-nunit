using NUnit.Framework;
using TMNAdapter.Tracking;

namespace TMNAdapter_Demo_NUnit
{
    [TestFixture]
    public class BaseTest
    {
        protected JiraInfoProvider JiraInfoProvider { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            JiraInfoProvider = new JiraInfoProvider();
        }
    }
}

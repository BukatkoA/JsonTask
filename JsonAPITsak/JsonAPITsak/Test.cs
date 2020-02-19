using NUnit.Framework;

namespace JsonTask
{
    [TestFixture]
    public class Test
    {
        private ReqresClient ReqresClient => new ReqresClient();

        [Test]
        public void GetSingleUserTest()
        {
            string expectedFirstName = "Janet";

            var user = this.ReqresClient.GetSingleUser();

            Assert.AreEqual(expectedFirstName, user.data.first_name);
        }
    }
}

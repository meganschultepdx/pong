using Microsoft.VisualStudio.TestTools.UnitTesting;
using pong;
namespace pong.Tests
{
    [TestClass]
    public class PongTest
    {
            [TestMethod]
        public void IsPong_DivisibleBy3And5_PingPong()
        {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Pong testIsPong = new Pong();
            Assert.AreEqual("Ping-Pong", testIsPong.IsPong(15));
        }

        [TestMethod]
        public void IsPong_DivisibleBy3_Ping()
        {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Pong testIsPong = new Pong();
            Assert.AreEqual("Ping", testIsPong.IsPong(3));
        }

        [TestMethod]
        public void IsPong_DivisibleBy5_Pong()
        {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Pong testIsPong = new Pong();
            Assert.AreEqual("Pong", testIsPong.IsPong(5));
        }

        [TestMethod]
        public void IsPong_DivisibleByNone_Num()
        {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Pong testIsPong = new Pong();
            Assert.AreEqual("2", testIsPong.IsPong(2));
        }

        [TestMethod]
        public void AddPong_OutputsList_String()
        {
            // any necessary logic to prep for test; instantiating new classes, etc.
            Pong testIsPong = new Pong();
            Assert.AreEqual("0, 1, 2", testIsPong.AddPong(2));
        }
    }
}

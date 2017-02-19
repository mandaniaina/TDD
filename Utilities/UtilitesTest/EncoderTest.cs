using NUnit.Framework;
using Utilities;

namespace UtilitesTest
{
    [TestFixture]
    public class EncoderTest
    {
        [Test]
        public void StringToArayOfInt()
        {
            int[] verify = { 2, 2, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2 };
            string value = "aBabcd zyxz";
            Encoder encoder = new Encoder();
            int[] encodedValue = encoder.LetterToArrayOfInt(value);
            Assert.AreEqual(verify, encodedValue);
        }

    }
}

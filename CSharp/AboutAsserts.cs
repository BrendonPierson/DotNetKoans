using Xunit;

namespace DotNetKoans.CSharp
{
    public class AboutAsserts : Koan
    {
        //We shall contemplate truth by testing reality, via asserts.
        [Koan(1)]
        public void AssertTruth() 
        {
			Assert.True(true); //This should be true
        }

        //Enlightenment may be more easily achieved with appropriate messages
        [Koan(2)]
        public void AssertTruthWithMessage() 
        {
            Assert.True(true, "This should be true -- Please fix this");
            // You get the message if it fails
        }

        //To understand reality, we must compare our expectations against reality
        [Koan(3)]
        public void AssertEquality() 
        {
            var expectedValue = 3;
            var actualValue = 2 + 1;
            Assert.True(expectedValue == actualValue);
        }

        //Some ways of asserting equality are better than others
        // Gives nice hint by supplying expected and actual values
        [Koan(4)]
        public void ABetterWayOfAssertingEquality() 
        {
            var expectedValue = 3;
            var actualValue = 2 + 1;
            Assert.Equal(expectedValue, actualValue);
        }

        //Sometimes we will ask you to fill in the values
        [Koan(5)]
        public void FillInValues() 
        {
            Assert.Equal(2, 1 + 1);
        }
    }
}

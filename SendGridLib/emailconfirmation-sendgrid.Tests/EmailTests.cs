using System;
using Xunit;

namespace emailconfirmation_sendgrid.Tests
{
    public class EmailTests
    {
        [Theory]
        [InLineData("sseethoff@wtamu.edu")]
        [InLineData("notavalidemail")]
        public void TestEmail(string expectedEmail)
        {
            var emailaddress = expectedEmail.ToString();
            Assert.Equal(expectedEmail);
        }

        [Fact]
        public void PassingTest()
        {
            Assert.True(x);
            
        }
        string passEmail(string x)
        {
            return x;

        }
        bool isEmail()
        {
            if(x.EndsWith(".com"))
            {
                return x;
            }
        }
    }
}

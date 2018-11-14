/* using System;
using Xunit;
using SendGrid.Helpers.Reliability;

namespace emailconfirmation_sendgrid.Tests
{
    public class ReliabilityTests
    {
        [Fact]
        public void ShouldNotAllowNegativeRetryCount()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => 
                new ReliabilitySettings(-1, 
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(1)));

            Assert.Contains("maximumNumberOfRetries must be greater than 0", exception.Message);
        }
    }
}
*/

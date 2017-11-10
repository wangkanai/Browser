﻿using Xunit;

namespace Wangkanai.Detection.Test
{
    public class UserAgentTests
    {
        [Fact]
        public void Ctor_Default_Success()
        {
            var userAgent = new UserAgent();

            Assert.Null(userAgent.ToString());
        }

        [Fact]
        public void Ctor_String_Success()
        {
            var name = "Agent";
            var expectedName = "agent";
            var userAgent = new UserAgent(name);

            Assert.Equal(expectedName, userAgent.ToString());
        }

        [Fact]
        public void Ctor_Null_Success()
        {
            var userAgent = new UserAgent(null);

            Assert.Null(userAgent.ToString());
        }
    }
}

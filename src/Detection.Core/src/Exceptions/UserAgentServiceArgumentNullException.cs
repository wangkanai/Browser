// Copyright (c) 2019 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

namespace System
{
    public class UserAgentServiceArgumentNullException: ArgumentNullException
    {
        public UserAgentServiceArgumentNullException(string paramName) : base(paramName) { }
    }
}

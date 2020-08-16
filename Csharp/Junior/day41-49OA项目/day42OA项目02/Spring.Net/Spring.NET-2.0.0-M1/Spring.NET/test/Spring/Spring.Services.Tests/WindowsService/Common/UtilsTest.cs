#region License
/*
* Copyright 2002-2010 the original author or authors.
* 
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
* 
*      http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/
#endregion
using NUnit.Framework;

namespace Spring.Services.WindowsService.Common
{
    [TestFixture]
	public class UtilsTest
	{
        [Test]
        public void CanBeUsedToCheckOnePathIsChildOfAnotherOne ()
        {
            Assert.IsTrue(Utils.AreParentAndChild(@"c:\parent", @"c:\parent\child"));
            Assert.IsTrue(Utils.AreParentAndChild(@"parent", @"parent\child"));
            Assert.IsTrue(Utils.AreParentAndChild(@"\\server\share", @"\\server\share\app"));
            Assert.IsTrue(Utils.AreParentAndChild(@"c:\parent", @"c:\parent\child\foo.bar"));
            Assert.IsFalse(Utils.AreParentAndChild(@"c:\parent", @"c:\parent2"));
            Assert.IsFalse(Utils.AreParentAndChild(@"c:\parent", @"d:\parent\child"));
        }
	}
}

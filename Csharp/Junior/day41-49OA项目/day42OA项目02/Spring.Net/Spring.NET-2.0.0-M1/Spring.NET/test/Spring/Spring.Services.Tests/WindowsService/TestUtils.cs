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

using System.IO;
using System.Threading;
using log4net.Config;
using Spring.Core.IO;

namespace Spring.Services.WindowsService
{
    public class TestUtils
    {
        public static void ConfigureLog4Net()
        {
            AssemblyResource resource =
                new AssemblyResource("assembly://Spring.Services.WindowsService.Tests/Spring.Services/tests.config");
            XmlConfigurator.Configure(resource.InputStream);
        }

        public static void SafeDeleteFile (string file)
        {
            while(File.Exists(file))
            {
                try
                {
                    File.Delete(file);
                } 
                catch
                {                    
                    Thread.Sleep(100);
                }
            }
        }

        public static void SafeDeleteFile (string file, int maxTimes)
        {
            int times = 0;
            while(File.Exists(file))
            {
                try
                {
                    File.Delete(file);
                } 
                catch
                {                    
                    if (++times > maxTimes)
                    {
                        return;
                    }
                    Thread.Sleep(100);
                }
            }
        }

        public static void SafeDeleteDirectory (string directory)
        {
            while(Directory.Exists(directory))
            {
                try
                {
                    Directory.Delete(directory, true);
                } 
                catch
                {                    
                    Thread.Sleep(100);
                }
            }
        }

        public static void SafeDeleteDirectory (string directory, int maxTimes)
        {
            int times = 0;
            while(Directory.Exists(directory))
            {
                try
                {
                    Directory.Delete(directory, true);
                } 
                catch
                {   
                    if (++times > maxTimes)
                    {
                        return;
                    }
                    Thread.Sleep(100);
                }
            }
        }

        public static void SafeCopyFile (string filePath, string destPath, bool overWrite)
        {
            while(true)
            {
                try
                {
                    File.Copy(filePath, destPath, overWrite);
                    return;
                } 
                catch
                {                    
                    Thread.Sleep(100);
                }
            }
        }
    }
}

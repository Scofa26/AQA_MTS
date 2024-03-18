using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOfObjects.Core;

namespace ValueOfObjects.Tests
{
    [SetUpFixture]
    internal class BaseSuite
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        [OneTimeSetUp]
        public static void SuiteSetup()
        {
            new NLogConfig().Config();
            Logger.Info("NLog setted up.");
        }
    }
}

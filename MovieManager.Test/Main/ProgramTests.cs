using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieManager.Test
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMain()
        {
            MovieManager.Program.Main(new string[]{""});
        }
    }
}

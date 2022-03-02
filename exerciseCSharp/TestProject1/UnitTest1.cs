using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          

           
            Assert.True(Program.capToFront("hApPy") == "APhpy");
            Assert.True(Program.capToFront("hApPy") == "APhpy");
            Assert.True(Program.capToFront("hApPy") == "APhpy");
        }
    }
}
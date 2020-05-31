using System;
using Xunit;
using NumberToTextGenerator;

namespace NumberToTextGeneratorTests
{
    public class NumberToTextGeneratorTests
    {
        [Fact]
        public void NumberToWordTest()
        {
            try
            {
                int numberToanalyze = 89;
                string outputText = NumberToTextGenerator.NumberToTextGenerator.NumberToWord(numberToanalyze);
                //assert
                Assert.Equal("Eighty Nine", outputText);
            }
           catch (Exception ex)
            {
                 throw ex;
            }
    }
}

using NUnit.Framework;

namespace censusAnalyzerTest
{
    public class Tests
    {

        AnalyzeCensusData analyzeCensus;
       string INDIAN_STATE_CNESUS_DATA_PATH= @"C:\Users\hp\source\repos\censusAnalyzer\censusAnalyzerTest\Assets\IndiaStateCensusData.csv";
        string INDIAN_STATE_CODE = @"C:\Users\hp\source\repos\censusAnalyzer\censusAnalyzerTest\Assets\IndiaStateCode.csv";

        [SetUp]
        public void setup()
        {

            analyzeCensus = new AnalyzeCensusData();
        }

        [Test]
        public void LoadingIndianCensusData_withValidPath_shouldReturnCount()
        {
            int expectedCount = 29;
            var censusDataList = analyzeCensus.loadCensusData(INDIAN_STATE_CNESUS_DATA_PATH);
            Assert.AreEqual(expectedCount,censusDataList.Count);
        }

        [Test]
        public void LoadingIndianStateCode_withValidPath_shouldReturnCount()
        {
            int expectedCount = 36;
            var censusDataList = analyzeCensus.loadCensusStateCode(INDIAN_STATE_CODE);
            Assert.AreEqual(expectedCount, censusDataList.Count);
        }
    }
}
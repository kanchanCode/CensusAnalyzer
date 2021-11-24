using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace censusAnalyzerTest
{
    class AnalyzeCensusData
    {

        public AnalyzeCensusData()
        {

        }

        public List<IndianStateCensusDataClass> loadCensusData(string filePath)
        {

            StreamReader streamReader = File.OpenText(filePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            return csvReader.GetRecords<IndianStateCensusDataClass>().ToList();

        }
        public List<IndianStateCodeClass> loadCensusStateCode(string filePath)
        {

            StreamReader streamReader = File.OpenText(filePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            return csvReader.GetRecords<IndianStateCodeClass>().ToList();

        }
    }
}

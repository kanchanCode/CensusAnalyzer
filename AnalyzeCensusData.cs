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

          List<IndianStateCensusDataClass> indianCensusDataList;
        Dictionary<string, IndianCensusDto> indianCensusDto = new Dictionary<string, IndianCensusDto>();
        public List<IndianStateCensusDataClass> loadCensusData(string filePath)
        {

            StreamReader streamReader = File.OpenText(filePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            indianCensusDataList = csvReader.GetRecords<IndianStateCensusDataClass>().ToList();
            foreach(var element in indianCensusDataList)
            {
                indianCensusDto.Add(element.State, new IndianCensusDto(element));
            }
            return indianCensusDataList;
        }
       
    }
}

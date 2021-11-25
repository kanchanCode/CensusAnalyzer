using System;
using System.Collections.Generic;
using System.Text;

namespace censusAnalyzerTest
{
    public class IndianCensusDto
    {
        public string State { get; set; }
        public long Population { get; set; }
        public long AreaInSqKm { get; set; }
        public long DensityPerSqKm { get; set; }
        

        public IndianCensusDto()
        {

        }
        public IndianCensusDto(IndianStateCensusDataClass indianStateCensusData) 
        {
            this.State = indianStateCensusData.State;
            this.Population = indianStateCensusData.Population;
            this.AreaInSqKm = indianStateCensusData.AreaInSqKm;
            this.DensityPerSqKm = indianStateCensusData.DensityPerSqKm;
        }

      
    }
}

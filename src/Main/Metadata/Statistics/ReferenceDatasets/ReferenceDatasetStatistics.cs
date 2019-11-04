//using USC.GISResearchLab.Common.Utils.Reflections;
using System.Collections.Generic;
using System.Text;
using USC.GISResearchLab.Geocoding.Core.ReferenceDatasets.ReferenceSourceQueries;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.Statistics.ReferenceDatasets
{
    /// <summary>
    /// Summary description for AddressStatistics.
    /// </summary>
    public class ReferenceDatasetStatistics
    {
        #region Properties

        public string ReferenceDatasetName { get; set; }
        public List<ReferenceSourceQuery> ReferenceSourceQueries { get; set; }
        public ReferenceSourceQueryResultSet ReferenceSourceQueryResultSet { get; set; }

        #endregion

        public ReferenceDatasetStatistics() : this(null)
        {
        }

        public ReferenceDatasetStatistics(string referenceDataSourceName)
        {
            ReferenceDatasetName = referenceDataSourceName;
            ReferenceSourceQueries = new List<ReferenceSourceQuery>();
        }

        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            foreach (ReferenceSourceQuery referenceSourceQuery in ReferenceSourceQueries)
            {
                ret.Append(ReferenceDatasetName);
                ret.Append("\t");
                ret.Append(referenceSourceQuery.Attempted);
                ret.Append("\t");
                ret.Append(referenceSourceQuery.Duration.TotalMilliseconds);
                ret.Append("\t");
                ret.Append(referenceSourceQuery.NumberOfResultRows);
                ret.Append("\t");
                ret.Append(referenceSourceQuery.RelaxedAttributes);
                ret.Append("\t");
                ret.Append(referenceSourceQuery.Sql);
                ret.Append("\t");
                ret.Append(referenceSourceQuery.StreetAddress);
                ret.AppendLine();
            }
            return ret.ToString();
        }
    }
}

//using USC.GISResearchLab.Common.Utils.Reflections;
using System.Collections.Generic;
using System.Text;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.Statistics.ReferenceDatasets
{
	/// <summary>
	/// Summary description for AddressStatistics.
	/// </summary>
	public class ReferenceDatasetsStatistics
    {
        #region Properties

        public List<ReferenceDatasetStatistics> ReferenceDatasetStatistics { get; set; }

        #endregion

        public ReferenceDatasetsStatistics()
		{
            ReferenceDatasetStatistics = new List<ReferenceDatasetStatistics>();
		}

        public void AddReferenceDatasetStatistics(List<ReferenceDatasetStatistics> referenceDatasetStatistics)
        {
            ReferenceDatasetStatistics.AddRange(referenceDatasetStatistics);
        }

        public void AddReferenceDatasetStatistics(ReferenceDatasetStatistics[] referenceDatasetStatistics)
        {
            ReferenceDatasetStatistics.AddRange(referenceDatasetStatistics);
        }

        public void AddReferenceDatasetStatistics(ReferenceDatasetStatistics referenceDatasetStatistics)
        {
            ReferenceDatasetStatistics.Add(referenceDatasetStatistics);
        }

        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine(GetType().Name);

            foreach (ReferenceDatasetStatistics referenceDatasetStatistics in ReferenceDatasetStatistics)
            {
                if (referenceDatasetStatistics != null)
                {
                    ret.AppendFormat("{0}", referenceDatasetStatistics.ToString());
                    ret.AppendLine();
                }
            }
            return ret.ToString();
        }
	}
}

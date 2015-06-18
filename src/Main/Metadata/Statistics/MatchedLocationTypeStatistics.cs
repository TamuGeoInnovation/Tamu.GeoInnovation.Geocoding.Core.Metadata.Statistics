////using USC.GISResearchLab.Common.Utils.Reflections;
using System.Text;
using USC.GISResearchLab.Geocoding.Core.Metadata.Qualities;
using USC.GISResearchLab.Geocoding.Core.Utils.Qualities;

namespace USC.GISResearchLab.Geocoding.Core.Metadata
{
	/// <summary>
	/// Summary description for QualityStatistics.
	/// </summary>
	public class MatchedLocationTypeStatistics
    {
        #region Properties

        private int _MatchedLocationTypeIndex;
        public int MatchedLocationTypeIndex
        {
            get { return _MatchedLocationTypeIndex; }
            set { _MatchedLocationTypeIndex = value; }
        }

        private string _MatchedLocationTypeName;
        public string MatchedLocationTypeName
        {
            get { return _MatchedLocationTypeName; }
            set { _MatchedLocationTypeName = value; }
        }

        private string _MatchedLocationTypeDescription;
        public string MatchedLocationTypeDescription
        {
            get { return _MatchedLocationTypeDescription; }
            set { _MatchedLocationTypeDescription = value; }
        }

        #endregion


        public MatchedLocationTypeStatistics()
		{
            MatchedLocationTypeIndex = (int)MatchedLocationTypes.Unknown;
            MatchedLocationTypeName = MatchedLocationTypeUtils.GetMatchedLocationTypeName(MatchedLocationTypes.Unknown);
            MatchedLocationTypeDescription = MatchedLocationTypeUtils.GetMatchedLocationTypeDescription(MatchedLocationTypes.Unknown);
		}

        public void setMatchedLocationType(int matchedLocationType)
		{
            MatchedLocationTypeIndex = matchedLocationType;
            MatchedLocationTypeName = MatchedLocationTypeUtils.GetMatchedLocationTypeName((MatchedLocationTypes)matchedLocationType);
            MatchedLocationTypeDescription = MatchedLocationTypeUtils.GetMatchedLocationTypeDescription((MatchedLocationTypes)matchedLocationType);
		}

        public void setMatchedLocationType(string matchedLocationTypeName)
        {
            MatchedLocationTypeIndex = (int)MatchedLocationTypeUtils.GetQualityTypeFromName( matchedLocationTypeName);
            MatchedLocationTypeName = matchedLocationTypeName;
            MatchedLocationTypeDescription = MatchedLocationTypeUtils.GetMatchedLocationTypeDescription((MatchedLocationTypes)MatchedLocationTypeIndex);
        }

        public void setMatchedLocationType(MatchedLocationTypes matchedLocationType)
        {
            MatchedLocationTypeIndex = (int)matchedLocationType;
            MatchedLocationTypeName = matchedLocationType.ToString();
            MatchedLocationTypeDescription = MatchedLocationTypeUtils.GetMatchedLocationTypeDescription(matchedLocationType);
        }

        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
            ret.AppendLine(GetType().Name);
            //string[][] properties = ReflectionUtils.GetObjectProperties(this);
            //for (int i = 0; i < properties.Length; i++)
            //{
            //    ret.AppendFormat("{0}: {1}", properties[i][0], properties[i][1]);
            //    ret.AppendLine();
            //}
            return ret.ToString();
        }
	}
}
    
using System.Text;

//using USC.GISResearchLab.Common.Utils.Reflections;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.MatchedFeatures
{
	/// <summary>
	/// Summary description for ZipCodeStatistics.
	/// </summary>
	public class ParcelStatistics : FIPSStatistics
    {
        #region Properties

        public int _Id;
        public int _Hasmultipleassessorids;
        public string _AssessorId;
        public string _Pre;
        public string _Number;
        public string _Name;
        public string _Suffix;
        public string _Post;
        public string _City;
        public string _State;
        public string _Zip;
        #endregion

        public ParcelStatistics()
        {
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

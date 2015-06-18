using System.Text;

//using USC.GISResearchLab.Common.Utils.Reflections;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.MatchedFeatures
{
	/// <summary>
	/// Summary description for ZipCodeStatistics.
	/// </summary>
	public class CountyStatistics : FIPSStatistics
    {
        #region Properties
        private int county;
        public int County
        {
            get { return county; }
            set { county = value; }
        }

		public CountyStatistics()
		{
			county = 0;
        }
        #endregion

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

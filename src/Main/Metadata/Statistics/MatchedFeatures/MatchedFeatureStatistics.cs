using System.Text;

//using USC.GISResearchLab.Common.Utils.Reflections;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.MatchedFeatures
{
	/// <summary>
	/// Summary description for MatchedFeatureStatistics.
	/// </summary>
	public class MatchedFeatureStatistics
    {
        #region Properties
        private ParcelStatistics _ParcelStatistics;
        private StreetStatistics _StreetStatistics;
	    private ZipCodeStatistics _ZIPCodeStatistics;
	    private CityStatistics _CityStatistics;
	    private CountySubregionStatistics _CountySubregionStatistics;
	    private CountyStatistics _CountyStatistics;
	    private StateStatistics _StateStatistics;

	    public StreetStatistics StreetStatistics
	    {
	        get { return _StreetStatistics; }
	        set { _StreetStatistics = value; }
	    }

	    public ZipCodeStatistics ZIPCodeStatistics
	    {
	        get { return _ZIPCodeStatistics; }
	        set { _ZIPCodeStatistics = value; }
	    }

	    public CityStatistics CityStatistics
	    {
	        get { return _CityStatistics; }
	        set { _CityStatistics = value; }
	    }

        public ParcelStatistics ParcelStatistics
        {
            get { return _ParcelStatistics; }
            set { _ParcelStatistics = value; }
        }

	    public CountySubregionStatistics CountySubregionStatistics
	    {
	        get { return _CountySubregionStatistics; }
	        set { _CountySubregionStatistics = value; }
	    }

	    public CountyStatistics CountyStatistics
	    {
	        get { return _CountyStatistics; }
	        set { _CountyStatistics = value; }
	    }

	    public StateStatistics StateStatistics
	    {
	        get { return _StateStatistics; }
	        set { _StateStatistics = value; }
        }
        #endregion

        public MatchedFeatureStatistics()
        {
            ParcelStatistics = new ParcelStatistics();
            StreetStatistics = new StreetStatistics();
            ZIPCodeStatistics = new ZipCodeStatistics();
            CityStatistics = new CityStatistics();
            CountyStatistics = new CountyStatistics();
            CountySubregionStatistics = new CountySubregionStatistics();
            StateStatistics = new StateStatistics();
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

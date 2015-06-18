//using USC.GISResearchLab.Common.Utils.Reflections;
using System;
using System.Text;
using USC.GISResearchLab.Geocoding.Core.Metadata.MatchedFeatures;
using USC.GISResearchLab.Geocoding.Core.Metadata.Statistics.ReferenceDatasets;

namespace USC.GISResearchLab.Geocoding.Core.Metadata
{
	/// <summary>
	/// Summary description for Statistics.
	/// </summary>
	public class GeocodeStatistics
    {
        #region Properties

        public DateTime StartTime { get; set; }

        private DateTime _EndTime;
        public DateTime EndTime
        {
            get { return _EndTime; }
            set 
            { 
                _EndTime = value;
                TimeTaken = (EndTime - StartTime);
            }
        }

        public TimeSpan TimeTaken { get; set; }

        public string StartTimestring
        {
            get { return StartTime.ToLocalTime().ToString("MM/dd/yyyy h:mm:ss"); }
        }

        public string EndTimestring
        {
            get { return EndTime.ToLocalTime().ToString("MM/dd/yyyy h:mm:ss"); }
        }

        public string TimeTakenstring
        {
            get { return TimeTaken.ToString(); }
        }

        public QualityStatistics QualityStatistics { get; set; }
        public InterpolationStatistics InterpolationStatistics { get; set; }
        public MatchedFeatureStatistics MatchedFeatureStatistics { get; set; }
        public MatchedLocationTypeStatistics MatchedLocationTypeStatistics { get; set; }
        public ParameterStatistics ParameterStatistics { get; set; }
        public AddressStatistics AddressStatistics { get; set; }
        public ReferenceDatasetsStatistics ReferenceDatasetsStatistics { get; set; }

        #endregion

        public GeocodeStatistics()
		{
			QualityStatistics = new QualityStatistics();
			InterpolationStatistics = new InterpolationStatistics();
			StartTime = DateTime.Now;
			EndTime = new DateTime(0);
			TimeTaken = new TimeSpan(0);
			MatchedFeatureStatistics = new MatchedFeatureStatistics();
            MatchedLocationTypeStatistics = new MatchedLocationTypeStatistics();
			ParameterStatistics = new ParameterStatistics();
			AddressStatistics = new AddressStatistics();
            ReferenceDatasetsStatistics = new ReferenceDatasetsStatistics();
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

        public void Add(GeocodeStatistics statisitics)
        {
            TimeTaken = (TimeTaken + statisitics.TimeTaken);
        }
	}
}

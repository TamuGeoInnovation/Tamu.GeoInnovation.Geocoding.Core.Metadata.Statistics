using System.Text;

//using USC.GISResearchLab.Common.Utils.Reflections;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.MatchedFeatures
{
    /// <summary>
    /// Summary description for FIPSStatistics.
    /// </summary>
    public class FIPSStatistics
    {
        #region Properties

        private string _Abbrv;
        private bool _Attempted;
        private string _Error;
        private double _Housing;
        private double _LandAreaMeters;
        private double _LandAreaMiles;
        private double _Latitude;
        private double _Longitude;
        private string _Name;
        private double _Population;
        private string _State;
        private bool _Valid;
        private double _WaterAreaMeters;
        private double _WaterAreaMiles;

        public string Abbrv
        {
            get { return _Abbrv; }
            set { _Abbrv = value; }
        }

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public double Population
        {
            get { return _Population; }
            set { _Population = value; }
        }

        public double Housing
        {
            get { return _Housing; }
            set { _Housing = value; }
        }

        public double LandAreaMeters
        {
            get { return _LandAreaMeters; }
            set { _LandAreaMeters = value; }
        }

        public double WaterAreaMeters
        {
            get { return _WaterAreaMeters; }
            set { _WaterAreaMeters = value; }
        }

        public double LandAreaMiles
        {
            get { return _LandAreaMiles; }
            set { _LandAreaMiles = value; }
        }

        public double WaterAreaMiles
        {
            get { return _WaterAreaMiles; }
            set { _WaterAreaMiles = value; }
        }

        public double Latitude
        {
            get { return _Latitude; }
            set { _Latitude = value; }
        }

        public double Longitude
        {
            get { return _Longitude; }
            set { _Longitude = value; }
        }

        public bool Attempted
        {
            get { return _Attempted; }
            set { _Attempted = value; }
        }

        public bool Valid
        {
            get { return _Valid; }
            set { _Valid = value; }
        }

        public string Error
        {
            get { return _Error; }
            set { _Error = value; }
        }

        #endregion

        public FIPSStatistics()
        {
            Abbrv = "";
            State = "";
            Name = "";
            Population = 0;
            Housing = 0;
            LandAreaMeters = 0;
            WaterAreaMeters = 0;
            LandAreaMiles = 0;
            WaterAreaMiles = 0;
            Latitude = 0;
            Longitude = 0;
            Attempted = false;
            Valid = false;
            Error = "";
        }

        public override string ToString()
        {
            StringBuilder ret = new StringBuilder();
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
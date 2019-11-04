using System.Text;
using USC.GISResearchLab.Common.Geometries.Directions;

//using USC.GISResearchLab.Common.Utils.Reflections;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.MatchedFeatures

{
    /// <summary>
    /// Summary description for StreetStatistics.
    /// </summary>
    public class StreetStatistics
    {
        #region Properties
        private double _ToLat;
        private double _ToLon;
        private double _FromLat;
        private double _FromLon;

        private int _FromAddressRight;
        private int _ToAddressRight;
        private int _FromAddressLeft;
        private int _ToAddressLeft;

        private string _FePreDir;
        private string _FeName;
        private string _FeType;
        private string _FePostDir;
        private string _CFCC;

        private string _ZIPLeft;
        private string _ZIPRight;

        private string _CensusTractLeft;
        private string _CensusTractRight;
        private string _CensusBlockLeft;
        private string _CensusBlockRight;

        private string _FIPSCountySubLeft;
        private string _FIPSCountySubRight;
        private string _FIPSPlaceLeft;
        private string _FIPSPlaceRight;


        private string _Hand;
        private string _StreetDirection;
        private string _DropbackDirection;

        private bool _Attempted;
        private bool _Valid;
        private string _Error;

        public double ToLat
        {
            get { return _ToLat; }
            set { _ToLat = value; }
        }

        public double ToLon
        {
            get { return _ToLon; }
            set { _ToLon = value; }
        }

        public double FromLat
        {
            get { return _FromLat; }
            set { _FromLat = value; }
        }

        public double FromLon
        {
            get { return _FromLon; }
            set { _FromLon = value; }
        }

        public int FromAddressRight
        {
            get { return _FromAddressRight; }
            set { _FromAddressRight = value; }
        }

        public int ToAddressRight
        {
            get { return _ToAddressRight; }
            set { _ToAddressRight = value; }
        }

        public int FromAddressLeft
        {
            get { return _FromAddressLeft; }
            set { _FromAddressLeft = value; }
        }

        public int ToAddressLeft
        {
            get { return _ToAddressLeft; }
            set { _ToAddressLeft = value; }
        }

        public string FePreDir
        {
            get { return _FePreDir; }
            set { _FePreDir = value; }
        }

        public string FeName
        {
            get { return _FeName; }
            set { _FeName = value; }
        }

        public string FeType
        {
            get { return _FeType; }
            set { _FeType = value; }
        }

        public string FePostDir
        {
            get { return _FePostDir; }
            set { _FePostDir = value; }
        }

        public string CFCC
        {
            get { return _CFCC; }
            set { _CFCC = value; }
        }

        public string ZIPLeft
        {
            get { return _ZIPLeft; }
            set { _ZIPLeft = value; }
        }

        public string ZIPRight
        {
            get { return _ZIPRight; }
            set { _ZIPRight = value; }
        }

        public string CensusTractLeft
        {
            get { return _CensusTractLeft; }
            set { _CensusTractLeft = value; }
        }

        public string CensusTractRight
        {
            get { return _CensusTractRight; }
            set { _CensusTractRight = value; }
        }

        public string CensusBlockLeft
        {
            get { return _CensusBlockLeft; }
            set { _CensusBlockLeft = value; }
        }

        public string CensusBlockRight
        {
            get { return _CensusBlockRight; }
            set { _CensusBlockRight = value; }
        }

        public string FIPSCountySubLeft
        {
            get { return _FIPSCountySubLeft; }
            set { _FIPSCountySubLeft = value; }
        }

        public string FIPSCountySubRight
        {
            get { return _FIPSCountySubRight; }
            set { _FIPSCountySubRight = value; }
        }

        public string FIPSPlaceLeft
        {
            get { return _FIPSPlaceLeft; }
            set { _FIPSPlaceLeft = value; }
        }

        public string FIPSPlaceRight
        {
            get { return _FIPSPlaceRight; }
            set { _FIPSPlaceRight = value; }
        }

        public string Hand
        {
            get { return _Hand; }
            set { _Hand = value; }
        }

        public string StreetDirection
        {
            get { return _StreetDirection; }
            set { _StreetDirection = value; }
        }

        public string DropbackDirection
        {
            get { return _DropbackDirection; }
            set { _DropbackDirection = value; }
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


        public StreetStatistics()
        {
            ToLat = 0.0;
            ToLon = 0.0;
            FromLat = 0.0;
            FromLon = 0.0;

            FromAddressRight = 0;
            ToAddressRight = 0;
            FromAddressLeft = 0;
            ToAddressLeft = 0;

            FePreDir = "";
            FeName = "";
            FeType = "";
            FePostDir = "";
            CFCC = "";

            Hand = "";
            StreetDirection = "";
            DropbackDirection = "";
            CensusTractLeft = "";
            CensusTractRight = "";
            CensusBlockLeft = "";
            CensusBlockRight = "";

            FIPSCountySubLeft = "";
            FIPSCountySubRight = "";
            FIPSPlaceLeft = "";
            FIPSPlaceRight = "";

            ZIPLeft = "";
            ZIPRight = "";

            Attempted = false;
            Valid = false;
            Error = "";

        }



        public void setHand(int a_hand)
        {
            _Hand = USC.GISResearchLab.Common.Geometries.Hands.Hand.getHandName(a_hand);
        }

        public void setDirection(int a_direction)
        {
            _StreetDirection = CardinalDirection.getDirectionName(a_direction);
        }

        public void setDropbackDirection(int a_direction)
        {
            _DropbackDirection = CardinalDirection.getDirectionName(a_direction);
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

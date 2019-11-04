using System.Text;

//using USC.GISResearchLab.Common.Utils.Reflections;

namespace USC.GISResearchLab.Geocoding.Core.Metadata
{
    /// <summary>
    /// Summary description for AddressStatistics.
    /// </summary>
    public class AddressStatistics
    {
        #region Properties
        private string _Valid;
        private string _AssessorId;
        private string _UsingAddress;

        public string Valid
        {
            get { return _Valid; }
            set { _Valid = value; }
        }

        public string AssessorId
        {
            get { return _AssessorId; }
            set { _AssessorId = value; }
        }

        public string UsingAddress
        {
            get { return _UsingAddress; }
            set { _UsingAddress = value; }
        }
        #endregion

        public AddressStatistics()
        {
            Valid = "unknown";
            AssessorId = "";
            UsingAddress = "";
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

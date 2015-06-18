using System.Text;

////using USC.GISResearchLab.Common.Utils.Reflections;

namespace USC.GISResearchLab.Geocoding.Core.Metadata
{
	/// <summary>
	/// Summary description for ParameterStatistics.
	/// </summary>
	public class ParameterStatistics
    {
        #region Properties
        
        private string _Method;
        private string _Source;
        private string _Number;
        private string _Pre;
        private string _Name;
        private string _Suffix;
        private string _Post;
        private string _City;
        private string _State;
        private string _Zip;

        public string Method
        {
            get { return _Method; }
            set { _Method = value; }
        }
        public string Source
        {
            get { return _Source; }
            set { _Source = value; }
        }
        public string Number
        {
            get { return _Number; }
            set { _Number = value; }
        }
        public string Pre
        {
            get { return _Pre; }
            set { _Pre = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Suffix
        {
            get { return _Suffix; }
            set { _Suffix = value; }
        }
        public string Post
        {
            get { return _Post; }
            set { _Post = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        public string Zip
        {
            get { return _Zip; }
            set { _Zip = value; }
        }


        #endregion

        public ParameterStatistics()
		{
			Method = "";
			Source = "";
			Number = "";
			Pre = "";
			Name = "";
			Suffix = "";
			Post = "";
			City = "";
			State = "";
			Zip = "";
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

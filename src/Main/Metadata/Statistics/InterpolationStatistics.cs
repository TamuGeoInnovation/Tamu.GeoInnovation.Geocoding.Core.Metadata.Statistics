using System.Text;

//using USC.GISResearchLab.Common.Utils.Reflections;

namespace USC.GISResearchLab.Geocoding.Core.Metadata
{
    /// <summary>
    /// Summary description for UniformLotStatistics.
    /// </summary>
    public class InterpolationStatistics
    {
        #region Properties

        private double _ParcelsOnBlock;
        private double _DropbackValue;

        public double ParcelsOnBlock
        {
            get { return _ParcelsOnBlock; }
            set { _ParcelsOnBlock = value; }
        }
        public double DropbackValue
        {
            get { return _DropbackValue; }
            set { _DropbackValue = value; }
        }

        #endregion

        public InterpolationStatistics()
        {
            ParcelsOnBlock = 0.0;
            DropbackValue = 0.0;

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

//using USC.GISResearchLab.Common.Utils.Reflections;

namespace USC.GISResearchLab.Geocoding.Core.Metadata
{
    /// <summary>
    /// Summary description for QualityStatistics.
    /// </summary>
    public class QualityStatistics
    {
        #region Properties

        //private int _QualityIndex;
        //private string _QualityName;
        //private string _QualityDescription;

        //public int QualityIndex
        //{
        //    get { return _QualityIndex; }
        //    set { _QualityIndex = value; }
        //}
        //public string QualityName
        //{
        //    get { return _QualityName; }
        //    set { _QualityName = value; }
        //}
        //public string QualityDescription
        //{
        //    get { return _QualityDescription; }
        //    set { _QualityDescription = value; }
        //}

        #endregion


        public QualityStatistics()
        {
            //QualityIndex = (int) GeocodeQualityType.Unknown;
            //QualityName = QualityUtils.getQualityName(GeocodeQualityType.Unknown);
            //QualityDescription = QualityUtils.getQualityDescription(GeocodeQualityType.Unknown);
        }

        //public void SetQuality(GeocodeQualityType quality)
        //{
        //    setQuality((int)quality);
        //}

        //public void setQuality(int quality)
        //{
        //    QualityIndex = quality;
        //    QualityName = QualityUtils.getQualityName((GeocodeQualityType)quality);
        //    QualityDescription = QualityUtils.getQualityDescription((GeocodeQualityType)quality);
        //}

        //public void setQuality(string qualityName)
        //{
        //    QualityIndex = (int) QualityUtils.GetQualityTypeFromName(qualityName);
        //    QualityName = qualityName;
        //    QualityDescription = QualityUtils.getQualityDescription((GeocodeQualityType) QualityIndex);
        //}

        //public override string ToString()
        //{
        //    StringBuilder ret = new StringBuilder();
        //    ret.AppendLine(GetType().Name);
        //    string[][] properties = ReflectionUtils.GetObjectProperties(this);
        //    for (int i = 0; i < properties.Length; i++)
        //    {
        //        ret.AppendFormat("{0}: {1}", properties[i][0], properties[i][1]);
        //        ret.AppendLine();
        //    }
        //    return ret.ToString();
        //}
    }
}

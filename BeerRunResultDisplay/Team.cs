using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BeerRunResultDisplay
{   
    [Serializable]
    public class Team : IComparable
    {
        [XmlElement(ElementName = "TeamName", Type = typeof(string))]
        public string TeamName { get; set; }
        [XmlElement(ElementName = "StartTime", Type =typeof(DateTime))]
        public DateTime StartTime { get; set; }
        [XmlElement(ElementName = "EndTime", Type = typeof(DateTime))]
        public DateTime EndTime { get; set; }
        [XmlElement(ElementName = "PenaltyMinutes", Type = typeof(int))]
        public int PenaltyMinutes { get; set; }
        [XmlElement(ElementName = "TeamMembersName", Type = typeof(string))]
        public string TeamMembersName { get; set; }
        [XmlIgnore]
        public string TotalTime
        {
            get { return this.GetTotalTime.ToString(@"hh\:mm\:ss"); }
        }
        [XmlIgnore]
        public TimeSpan GetTotalTime
        {
            get
            {
                if (EndTime != null && StartTime != null)
                {
                    var lResult = EndTime - StartTime;
                    lResult = lResult.Add(new TimeSpan(0, PenaltyMinutes, 0));
                    return lResult;
                }
                return new TimeSpan(23, 59, 59);
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is Team)
                return ((IComparable)GetTotalTime).CompareTo((obj as Team).GetTotalTime);
            else
                return 0;
        }


        public override string ToString()
        {
            return this.TeamName;
        }
    }
}

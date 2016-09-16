using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BeerRunResultDisplay
{   
    [Serializable]
    public class Team
    {
        [XmlElement(ElementName = "TeamName", Type = typeof(string))]
        public string TeamName { get; set; }
        [XmlElement(ElementName = "StartTime", Type =typeof(DateTime))]
        public DateTime StartTime { get; set; }
        [XmlElement(ElementName = "EndTime", Type = typeof(DateTime))]
        public DateTime EndTime { get; set; }
        [XmlElement(ElementName = "PenaltyMinutes", Type = typeof(List<int>))]
        public List<int> PenaltyMinutes { get; set; }
        [XmlElement(ElementName = "TeamMembersName", Type = typeof(List<string>))]
        public List<string> TeamMembersName { get; set; }

        
        public TimeSpan GetTotalTime()
        {
            if(EndTime != null && StartTime != null)
            {
                var lResult = EndTime - StartTime;
                foreach (var nPenaltyMinute in PenaltyMinutes)
                {
                    lResult.Add(new TimeSpan(0, (nPenaltyMinute), 0));
                }

                return lResult;
            }
            return new TimeSpan(23, 59, 59);
        }
    }
}

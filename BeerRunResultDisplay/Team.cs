using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BeerRunResultDisplay
{   
    [Serializable]
    public class Team : IComparable, INotifyPropertyChanged, ICloneable
    {   
        private string mTeamName;
        [XmlElement(ElementName = "TeamName", Type = typeof(string))]
        public string TeamName
        {
            get { return mTeamName; }
            set { mTeamName = value; OnPropertyChanged("TeamName"); }
        }
        private long mLongStartTime;
        [XmlElement(ElementName = "StartTime", Type = typeof(long))]
        public long LongStartTime { get { return this.mLongStartTime; } set { this.mLongStartTime = value; OnPropertyChanged("LongStartTime"); OnPropertyChanged("StartTime"); } }
        [XmlIgnore]
        public TimeSpan StartTime { get { return new TimeSpan(this.mLongStartTime); } set { this.mLongStartTime = value.Ticks; OnPropertyChanged("LongStartTime"); OnPropertyChanged("StartTime"); } }

        private long mLongEndTime;
        [XmlElement(ElementName = "EndTime", Type = typeof(long))]
        public long LongEndTime { get { return this.mLongEndTime; } set { this.mLongEndTime = value; OnPropertyChanged("LongEndTime"); OnPropertyChanged("EndTime"); } }
        [XmlIgnore]
        public TimeSpan EndTime { get { return new TimeSpan(this.mLongEndTime); } set { this.mLongEndTime = value.Ticks; OnPropertyChanged("LongEndTime"); OnPropertyChanged("EndTime"); } }

        private int mPenaltyMinutes;
        [XmlElement(ElementName = "PenaltyMinutes", Type = typeof(int))]
        public int PenaltyMinutes
        {
            get { return mPenaltyMinutes; }
            set { mPenaltyMinutes = value; OnPropertyChanged("PenaltyMinutes"); }
        }

        private string mTeamMembersName;
        [XmlElement(ElementName = "TeamMembersName", Type = typeof(string))]
        public string TeamMembersName { get { return this.mTeamMembersName; } set { this.mTeamMembersName = value; OnPropertyChanged("TeamMembersName"); } }
        [XmlIgnore]
        public TimeSpan TotalTime => EndTime - StartTime + new TimeSpan(0, PenaltyMinutes, 0);
        
        #region [Implementation of INotifyPropertyChanged]
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string aPropertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(aPropertyName));
        #endregion

        public int CompareTo(object obj)
        {
            if (obj is Team)
                return (TotalTime).CompareTo((obj as Team).TotalTime);
            else
                return 0;
        }

        public override string ToString()
        {
            return this.TeamName;
        }

        public object Clone()
        {
            return new Team
            {
                TeamName = this.TeamName,
                StartTime = this.StartTime,
                EndTime = this.EndTime,
                LongEndTime = this.LongEndTime,
                LongStartTime = this.LongStartTime,
                PenaltyMinutes = this.PenaltyMinutes,
                TeamMembersName = this.TeamMembersName
            };
        }
    }
}

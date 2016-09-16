using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BeerRunResultDisplay
{
    public class TableModelView : INotifyPropertyChanged
    {
        private List<Team> mTeams;

        [XmlElement(DataType ="List<Team>", ElementName = "Teams", Type = typeof(List<Team>))]
        public List<Team> Teams
        {
            get { return mTeams; }
            set
            {
                mTeams = value;
                NotifyPropertyChanged("Teams");
            }
        }

        public TableModelView()
        {
            this.mTeams = new List<Team>();
        }

        #region [Inplementation of INotifyPropertyChanged]
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string aPropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(aPropertyName));
            }
        }
        #endregion
        
        /// <summary>
        /// Přidá nový tým
        /// </summary>
        /// <param name="aNewTeam">Nový tým</param>
        public void Add(Team aNewTeam)
        {
            if (aNewTeam != null)
            {
                Teams.Add(aNewTeam);
                NotifyPropertyChanged("Teams");
            }
        }

        /// <summary>
        /// Odstraní existující tým ze seznamu
        /// </summary>
        /// <param name="aExistingTeam">Tým, který už je v seznamu</param>
        public void Remove(Team aExistingTeam)
        {
            if(aExistingTeam != null && this.Teams.Contains(aExistingTeam))
            {
                this.Teams.Remove(aExistingTeam);
                NotifyPropertyChanged("Teams");
            }
        }

        /// <summary>
        /// Uloží aktuální stav týmů do XML souboru
        /// </summary>
        /// <param name="aPathToFile">Cesta k XML souboru, do kterého se stav uloží</param>
        public void SaveState(string aPathToFile)
        {
            try
            {
                XmlSerializer lSerializer = new XmlSerializer(typeof(List<Team>));
                using (TextWriter lWriter = new StreamWriter(aPathToFile, false, Encoding.Default))
                {
                    lSerializer.Serialize(lWriter, this.Teams);
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
        }

        /// <summary>
        /// Načte předchozí stav z XML souboru
        /// </summary>
        /// <param name="aPathToFile">Cesta k XML souboru obsahující týmy</param>
        public void LoadState(string aPathToFile)
        {
            try
            {
                using (FileStream lFs = new FileStream(aPathToFile, FileMode.Open))
                {
                    XmlSerializer lSerializer = new XmlSerializer(typeof(List<Team>));
                    this.Teams = (List<Team>)(lSerializer.Deserialize(lFs));
                }
            }            
            catch (Exception lEx)
            {
                throw lEx;
            }
        }
    }
}

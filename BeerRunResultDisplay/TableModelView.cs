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
    public class TableModelView
    {
        [XmlElement(DataType ="BindingList<Team>", ElementName = "Teams", Type = typeof(BindingList<Team>))]
        public BindingList<Team> Teams { get; set; }

        public TableModelView()
        {
            this.Teams = new BindingList<Team>();
            //this.Teams.ListChanged += Teams_ListChanged;            
        }
        
        private void Teams_ListChanged(object sender, ListChangedEventArgs e)
        {
            this.Teams.Sort();
            Console.WriteLine("Changed Item");
        }

        /// <summary>
        /// Přidá nový tým
        /// </summary>
        /// <param name="aNewTeam">Nový tým</param>
        public void Add(Team aNewTeam)
        {
            if (aNewTeam != null)
            {                
                Teams.Add(aNewTeam);
                this.Teams.Sort();
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
                this.Teams.Sort();
            }
        }

        public void Edit(Team aEditedTeam, int aIndex)
        {
            if(aEditedTeam != null && this.Teams.Count > aIndex)
            {
                this.Teams[aIndex] = aEditedTeam;
                this.Teams.Sort();
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
                XmlSerializer lSerializer = new XmlSerializer(typeof(BindingList<Team>));
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
                    XmlSerializer lSerializer = new XmlSerializer(typeof(BindingList<Team>));
                    this.Teams = (BindingList<Team>)(lSerializer.Deserialize(lFs));                    
                    this.Teams.Sort();
                }
            }            
            catch (Exception lEx)
            {
                throw lEx;
            }
        }        
    }
}

using MissionPlanner.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionPlanner.GCSViews
{
    public class Project
    {
        public string name;
        public int selectedMission = 0;
        public List<Mission> missions = new List<Mission>();
        public Project(string inputName)
        {
            name = inputName;
        }
    }
    public class Mission
    {
        public string name;
        public MyDataGridView commands;
        public Mission(string inputName)
        {
            name = inputName;
        }
    }
}

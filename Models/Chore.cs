using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore.Models
{
    public class Chore
    {
    public Chore(string name, int time, string description)
    {
        Name = name;
        Time = time;
        Description = description;
    }

    public string Name { get; set; }
        public int Time { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; private set; } = false;

        public void ChoreDone(){
            this.IsDone = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chore.Repositories
{
    public class ChoresRepository
    {
        private List<Chore> dbChores = new List<Chore>();

        public ChoresRepository(){
            dbChores.Add(new Chore("Sweep", 20, "Living Room"));
            dbChores.Add(new Chore("Vaccume", 30, "Bedrooms"));
        }

    internal List<Chore> getAllChores()
    {
        return dbChores;
    }

    internal Chore getChoreByName(string choreName)
    {
        Chore chore = dbChores.Find(c => c.Name == choreName);
        return chore;
    }
    }
}
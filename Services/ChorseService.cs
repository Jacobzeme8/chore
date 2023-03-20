namespace chore.Services{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


  public class ChorseService{

    private readonly ChoresRepository _repo;
public ChorseService(ChoresRepository repo)
    {
        _repo = repo;
    }

    internal List<Chore> getAllChores()
    {
        return _repo.getAllChores();
    }

    internal Chore getChoreByName(string choreName)
    {
        Chore chore = _repo.getChoreByName(choreName);
        return chore;
    }
    }
}
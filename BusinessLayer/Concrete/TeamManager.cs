using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamdal;

        public TeamManager(ITeamDal teamdal)
        {
            _teamdal = teamdal;
        }

        public void Delete(Team delete)
        {
            _teamdal.Delete(delete);
        }

        public Team getbyid(int id)
        {
           return _teamdal.Getbyid(id);
        }

        public List<Team> GetList()
        {
            return _teamdal.Getlist();
        }

        public void Update(Team Update)
        {
            _teamdal.Update(Update);
        }

        public void İnsert(Team insert)
        {
            _teamdal.İnsert(insert);
        }
    }
}

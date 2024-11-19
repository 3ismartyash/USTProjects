using DotNetWebAPI.Models;

namespace DotNetWebAPI.Services
{
    public interface IOurHeroServices
    {
        List<OurHero> GetAllHeros(bool? isActive);

        OurHero? GetHerosByID(int id);

        OurHero AddOurHero(AddUpdateOurHero obj);

        OurHero? UpdateOurHero(int id, AddUpdateOurHero obj);

        bool DeleteHerosByID(int id);
    }
}

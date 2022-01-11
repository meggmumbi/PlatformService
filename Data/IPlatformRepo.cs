using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo {
        bool SaveChanges();
        //use Api 
        IEnumerable<Platform> GetAllPlatforms();
        //return an individual platform
        Platform GetPlatformById(int id);
        //create a platform
        void CreatePlatform(Platform plat);
    }
    
}
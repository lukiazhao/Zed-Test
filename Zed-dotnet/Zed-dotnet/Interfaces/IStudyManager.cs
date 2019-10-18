using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zeddotnet.Models;

namespace Zeddotnet.Interfaces
{
    public interface IStudyManager
    {
        Dictionary<string, Study> LoadStudies();

        Dictionary<string, Study> GetAll();

        Study GetStudyByGUID(string guid);
    }
}

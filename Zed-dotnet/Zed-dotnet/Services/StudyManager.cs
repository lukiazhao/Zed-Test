using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Zeddotnet.Interfaces;
using Zeddotnet.Models;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Zeddotnet.Services
{
    /// <summary>
    /// The main class for managing Study
    /// Contains all methods for performing reading and returning studies 
    /// </summary>
    public class StudyManager : IStudyManager
    {
        private readonly IFileLoader _fileLoader;
        private readonly string fileRoot = "./Files";

        public StudyManager(IFileLoader fileLoader)
        {
            _fileLoader = fileLoader;
        }

        // Return a dictionary of all studies stored in the File folder
        public Dictionary<string, Study> GetAll()
        {
            return _fileLoader.LoadStudies(fileRoot);
        }

        // Return a single study object found by guid.
        public Study GetStudyByGUID(string guid)
        {
            var studies = _fileLoader.LoadStudies(fileRoot);

            if (studies.ContainsKey(guid) == true)
            {
                return studies[guid];
            }
            return null;
        }
    }
}

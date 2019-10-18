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
    /// Contains all methods for performing basic loading and returning functions
    /// </summary>
    public class StudyManager : IStudyManager
    {
        private Dictionary<string, Study> studies;

        public StudyManager()
        {
            if (studies == null || studies.Count == 0)
            {
                studies = LoadStudies();
            }

        }

        // Read json files and deserialise to study object.
        // Return a dictionary of studies
        public Dictionary<string, Study> LoadStudies()
        {

            string root = "./Files";
            string[] fileNames = Directory.GetFiles(root);

            Dictionary<string, Study> tempStudies = new Dictionary<string, Study>();

            foreach (string fileName in fileNames)
            {
                var jsonText = File.ReadAllText(fileName);
                Study study = JsonConvert.DeserializeObject<Study>(jsonText);
                tempStudies.Add(study.GUID, study);
            }

            return tempStudies;
        }

        // Return a dictionary of all studies stored in the File folder
        public Dictionary<string, Study> GetAll()
        {
            return studies;
        }

        // Return a single study object found by guid.
        public Study GetStudyByGUID(string guid)
        {
            if (studies.ContainsKey(guid) == true)
            {
                return studies[guid];
            }
            else
            {
                return null;
            }
        }
    }
}

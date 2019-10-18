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

        public Dictionary<string, Study> GetAll()
        {
            return studies;
        }

        public Study GetStudyByGUID(string guid)
        {
            return studies[guid];
        }
    }
}

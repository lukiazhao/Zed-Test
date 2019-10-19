using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Zeddotnet.Interfaces;
using Zeddotnet.Models;

namespace Zeddotnet.Services
{
    public class FileLoader : IFileLoader
    {
        // Read json files and deserialise to study object.
        // Return a dictionary of studies
        public Dictionary<string, Study> LoadStudies(string fileRoot)
        {
            string[] fileNames = Directory.GetFiles(fileRoot);

            Dictionary<string, Study> tempStudies = new Dictionary<string, Study>();

            foreach (string fileName in fileNames)
            {
                var jsonText = File.ReadAllText(fileName);
                Study study = JsonConvert.DeserializeObject<Study>(jsonText);
                tempStudies.Add(study.GUID, study);
            }

            return tempStudies;
        }
    }
}

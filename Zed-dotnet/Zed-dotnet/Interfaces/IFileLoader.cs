using System;
using System.Collections.Generic;
using Zeddotnet.Models;

namespace Zeddotnet.Interfaces
{
    /// <summary>
    /// Interface of File Loader that declares functions
    /// for load studies from json files
    /// </summary>
    public interface IFileLoader
    {
        Dictionary<string, Study> LoadStudies();
    }
}

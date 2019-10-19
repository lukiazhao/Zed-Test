﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Zeddotnet.Interfaces;
using Zeddotnet.Models;
using Zeddotnet.Services;

namespace Zeddotnet.Controllers
{
    [Route("api/[controller]")]
    public class StudyController : Controller
    {
        private readonly IStudyManager _studyManger;

        public StudyController(IStudyManager studyManager)
        {
            _studyManger = studyManager;
        }

        // GET: api/study
        [HttpGet]
        public ActionResult<IEnumerable<Study>> Get()
        {
            try
            {
                return _studyManger.GetAll().Values.ToList<Study>();

            } catch (System.IO.DirectoryNotFoundException)
            {
                // catch IO exceptions
                return Json("Study files not found.");
            }
        }

        // GET api/study/{guid}
        [HttpGet("{guid}")]
        public ActionResult<Study> Get(string guid)
        {
            return _studyManger.GetStudyByGUID(guid);
        }
    }
}

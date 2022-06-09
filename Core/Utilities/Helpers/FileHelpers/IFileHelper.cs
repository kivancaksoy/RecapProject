﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelpers
{
    public interface IFileHelper
    {
        string Upload(IFormFile file, string root);
        void Delete(string filepath);
        string Update(IFormFile file, string filepath, string root);
    }
}

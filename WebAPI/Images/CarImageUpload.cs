using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Images
{
    public class CarImageUpload
    {
        public IFormFile files { get; set; }
    }
}

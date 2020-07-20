using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RichEditSubmit.Models
{
    public class TestModel
    {
        [BindProperty]
        public int ID { set; get; }
        [BindProperty]
        public string Base64 { set; get; }
        [BindProperty]
        public int Format { set; get; }
        [BindProperty]
        public string Description { set; get; }
    }
}

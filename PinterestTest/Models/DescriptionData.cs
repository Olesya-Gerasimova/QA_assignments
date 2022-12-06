using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinterestTest.Models
{
    public class ProfileData
    {
        public ProfileData(string description)
        {
            Description = description;
        }

        public string Description { get; set; }

    }
}

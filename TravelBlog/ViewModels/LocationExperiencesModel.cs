using System;
using System.Collections.Generic;
using TravelBlog.Models;

namespace TravelBlog.ViewModels
{
    public class LocationExperiencesModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public LocationExperiencesModel(int locationId)
        {
            LocationId = locationId;
        }
    }
}

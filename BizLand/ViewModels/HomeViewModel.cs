using BizLand.Models;
using System.Collections.Generic;

namespace BizLand.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }
        public List<Feature> Features { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}

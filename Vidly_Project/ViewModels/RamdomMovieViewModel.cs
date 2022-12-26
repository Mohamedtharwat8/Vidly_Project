using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Project.Models;

namespace Vidly_Project.ViewModels
{
    public class RamdomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }

    }
}
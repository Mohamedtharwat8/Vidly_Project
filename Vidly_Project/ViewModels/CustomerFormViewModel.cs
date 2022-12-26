using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Project.Models;

namespace Vidly_Project.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
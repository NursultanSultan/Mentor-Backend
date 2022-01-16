using Mentor.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mentor.Services
{
    public class HomeService
    {

        private AppDbContext _context { get; }
        public HomeService(AppDbContext context)
        {
            _context = context;
        }

        public Dictionary<string,string> GetSetting()
        {
            return _context.Settings.AsEnumerable().ToDictionary(s => s.Key, s => s.Value);
        }
    }
}

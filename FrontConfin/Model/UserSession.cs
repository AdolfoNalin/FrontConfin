using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontConfin.Model
{
    public static class UserSession 
    {
        public static Guid Id { get; set; }
        public static string Name { get; set; }
        public static string Login { get; set; }
        public static string Function { get; set; }
    }
}

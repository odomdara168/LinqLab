using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> WhereToGetIdBiggerThen8()
        {
            var result = Source.Where(i => i.Id > 8);
            return result.ToList();
        }

        public List<Sample> WhereToGetPrizeBiggerThen200()
        {
            var result = Source.Where(i => i.Price > 200);
                
            return result.ToList();
        }

        public List<Sample> WhereToGetUserNameStartWithD()
        {
            var result = Source.Where(i => i.UserName.StartsWith("d"));
            return result.ToList();
        }

        public List<Sample> WhereToGetUserNameContainE()
        {
            var result = Source.Where(i => i.UserName.Contains("e"));
            return result.ToList();
        }

        public List<Sample> WhereToGetUserNameEndWithO()
        {
            var result = Source.Where(i => i.UserName.EndsWith("o"));
            return result.ToList();
        }

        public List<Sample> WhereToGetUserNameEqualToDemoAndJoey()
        {
            var whereStr = new[] {"demo","joey" };
            var result = Source.Where(i => whereStr.Contains(i.UserName));
            return result.ToList();
        }

        public bool WhereToCheckIsAnyIdEqualTo99()
        {
            return Source.Any(i => i.Id == 99);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jf0414
{
    class LINQ_2
    {
        static void Main(string[] args)
        {
            var types = new List<TwelveTypes>(){ 
                // SDW="start date in Western", EDW="end date in Western", LW="last days in wstern", SDThai, EDThai, LThai
                new TwelveTypes() {ID=1, Name="Aquarius", SDW="0121", EDW="0219", LW=29, SDThai="0213", EDThai="0314", LThai=29};
                new TwelveTypes() { ID = 2, Name = "Pisces", SDW = "0220", EDW = "0320", LW = 28, SDThai = "0315", EDThai = "0412", LThai = 28 };
                new TwelveTypes() { ID = 3, Name = "Aries", SDW = "0321", EDW = "0420", LW = 30, SDThai = "0413", EDThai = "0514", LThai = 31 };
                new TwelveTypes() { ID = 4, Name = "Taurus", SDW = "0421", EDW = "0521", LW = 30, SDThai = "0515", EDThai = "0614", LThai = 30 };
                new TwelveTypes() { ID = 5, Name = "Gemini", SDW = "0522", EDW = "0621", LW = 30, SDThai = "0615", EDThai = "0715", LThai = 30 };
                new TwelveTypes() { ID = 6, Name = "Cancer", SDW = "0622", EDW = "0722", LW = 30, SDThai = "0716", EDThai = "0816", LThai = 31 };
                new TwelveTypes() { ID = 7, Name = "Leo", SDW = "0723", EDW = "0821", LW = 29, SDThai = "0817", EDThai = "0916", LThai = 30 };
                new TwelveTypes() { ID = 8, Name = "Virgo", SDW = "0822", EDW = "0923", LW = 32, SDThai = "0917", EDThai = "1016", LThai = 29 };
                new TwelveTypes() { ID = 9, Name = "Libra", SDW = "0924", EDW = "1023", LW = 29, SDThai = "1017", EDThai = "1115", LThai = 29 };
                new TwelveTypes() { ID = 10, Name = "Scorpio", SDW = "1024", EDW = "1122", LW = 29, SDThai = "1116", EDThai = "1215", LThai = 29 };
                new TwelveTypes() { ID = 11, Name = "Sagittarius", SDW = "1123", EDW = "1222", LW = 29, SDThai = "1216", EDThai = "0114", LThai = 29 };
                new TwelveTypes() { ID = 12, Name = "capricorn", SDW = "1223", EDW = "0120", LW = 28, SDThai = "0115", EDThai = "0212", LThai = 28 };
            }

            var Days29InW = from W in types
                            where W.LW == 29 && W.LW < W.LThai
                            select W;
            foreach (var type in Days29InW)
            {
                var result = type.Name + " " + type.SDW + type.EDW;
                Console.WriteLine(result);
            }

            var Days30 = types.Where(id => id.LW == 30 && id.LThai == 30);
            foreach (var type in Days29InW)
            {
                var results = type.Name + " " + type.SDW + type.EDW + type.SDThai + type.EDThai;
                Console.WriteLine(results);
            }
        }
    }

    class TwelveTypes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SDW { get; set; }
        public string EDW { get; set; }
        public int LW { get; set; }
        public string SDThai { get; set; }
        public string EDThai { get; set; }
        public int LThai { get; set; }
    }
}
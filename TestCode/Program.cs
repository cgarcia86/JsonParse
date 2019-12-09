using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            LstSuperheroes newHero = new LstSuperheroes();

            string MsgData = "{ \"LstSuperheroes\": [ { \"Id\": 1, \"Name\": \"John Priest\" }, { \"Id\": 2, \"Name\": \"John Wick\" } ] }";

            newHero.ParseProfileInfo(MsgData);

        }
    }

    public class LstSuperheroes
    {
        public string Id { get; set; }
        public string Name { get; set; }


        public void ParseProfileInfo(string msgData)
        {
            
            var heroDetails = JsonConvert.DeserializeObject<List<LstSuperheroes>>(msgData);
            
        }

    }

}

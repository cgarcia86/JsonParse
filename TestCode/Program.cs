using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace TestCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            LstSuperheroes newHero = new LstSuperheroes();

            //string MsgData = "{ \"LstSuperheroes\": [ { \"Id\": 1, \"Name\": \"John Priest\" }, { \"Id\": 2, \"Name\": \"John Wick\" } ] }";

            string MsgData = "[ { \"Id\": 1, \"Name\": \"John Priest\" }, { \"Id\": 2, \"Name\": \"John Wick\" }] ";


            newHero.ParseProfileInfo(MsgData);

            Console.WriteLine(newHero.Id);
            Console.WriteLine(newHero.Name);

        }
    }

    public class LstSuperheroes
    {
        public string Id { get; set; }
        public string Name { get; set; }


        public void ParseProfileInfo(string msgData)
        {
            
            var heroDetails = JsonConvert.DeserializeObject<List<LstSuperheroes>>(msgData);

            this.Id = heroDetails[0].Id;
            this.Name = heroDetails[0].Name;

            //Console.WriteLine(heroDetails.Count);
            //Console.WriteLine(heroDetails[0].Name);


        }

    }

}

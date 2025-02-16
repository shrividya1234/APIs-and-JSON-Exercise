﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public  class RonVSKanyeAPI
        {
            public static void KanyeQuote()
            {
                var client = new HttpClient();
                var kanyeURL = "https://api.kanye.rest";
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
                Console.WriteLine($"---------");
                Console.WriteLine($"Kanye: '{kanyeQuote}'");
                Console.WriteLine($"---------");
            }

            public static void RonQuote()
            {
                var client = new HttpClient();
                var RonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var RonQuoteResponse = client.GetStringAsync(RonURL).Result;
                var ronQuote = JArray.Parse(RonQuoteResponse).ToString();
                Console.WriteLine($"---------");
                Console.WriteLine($"Ron:'{ronQuote}'");
                Console.WriteLine($"---------");
                
            }
        }
    }


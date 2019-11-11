﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PolarisAICore.Response {
    class ShowNews {
        static readonly Random _random = new Random();

        static readonly String[] _noEntityResponses =
        {
            "Of course! Here's today's news:",
            "Sure! This is what is happening today:",
            "Alright! Here's today's news:",
            "You don't have to ask again! This is what is happening today:"
        };

        public static String SetResponse(Utterance u) {
            
            return _noEntityResponses[_random.Next(_noEntityResponses.Length)];
        }
    }
}
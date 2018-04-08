﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSONParser;
using System.IO;
using System.Web;
using System.Net;

namespace NP_lab3
{
    public class Complete
    {
        public static string[] CompleteWordAsync(string input, string predictorKey, string lang, int limit)
        {
            input = WebUtility.HtmlEncode(input);

            var parser = new JSONParser.JSONParser();

            var requestString =
                $"https://predictor.yandex.net/api/v1/predict.json/complete?key={predictorKey}&q={input}&lang={lang}&limit={limit}";

            var request = WebRequest.Create(requestString);
            request.Credentials = CredentialCache.DefaultCredentials;

            var respose = request.GetResponse();

            var reader = new StreamReader(respose.GetResponseStream());

            var poolString = reader.ReadToEnd();

            var responseJson = parser.Parse(poolString);

            var textArray = ((JSONObjectCollection)responseJson)["text"] as JSONArrayCollection;

            return ToStringArray(textArray);

        }

        static string[] ToStringArray(JSONArrayCollection arrayCollection)
        {
            var pool = new string[arrayCollection.Count];

            for (int i = 0; i < arrayCollection.Count; i++)
            {
                pool[i] = arrayCollection[i].GetValue() as string;
            }

            return pool;
        }
    }
}
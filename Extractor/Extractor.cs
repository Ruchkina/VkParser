using DatabaseModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using System.Threading;

namespace Extractor1
{
    public class Extractor
    {
        static HttpClient client/* = new HttpClient()*/;
        private String Version = "5.131";
        private String Token = "e4c43f9dc0b263bcd927c17a3326f1f28d474034bee3c9b2645ec1acc521eb76c85149bab39c52c9923da";
        private String Params = "id,sex,city,education,activities,bdate,occupation,relation,personal,home_town";

        public Extractor()
        {
            client = new HttpClient();
        }
        public async Task<List<string>> FetchInfoGroup(string id)
        {
            List<string> listOfNames = new List<string>();
            HttpResponseMessage followersOfGroup = await client.GetAsync($"https://api.vk.com/method/groups.getMembers?group_id={id}&offset=1&access_token={Token}&v={Version}Fields=UsersFields.All");
            if (followersOfGroup.IsSuccessStatusCode)
            {
                string json = await followersOfGroup.Content.ReadAsStringAsync();
                var obj = JToken.Parse(json);
                var jsonArray = obj["response"]["items"].ToString();

                listOfNames = new List<string>(jsonArray.Split(','));
            };
            return listOfNames;

        }

        public async Task<Response> FetchInfoUser(int id)  
        {
            HttpResponseMessage followersInfo;
            Response UserInfo = null;
            followersInfo = await client.GetAsync($"https://api.vk.com/method/users.get?user_ids={id}&access_token={Token}&v={Version}&fields={Params}");
            if (followersInfo.IsSuccessStatusCode)
            {
                Thread.Sleep(300);
                string json = await followersInfo.Content.ReadAsStringAsync();
                JObject obj = JObject.Parse(json);
                var jsonArray = JArray.Parse(obj["response"].ToString());
                UserInfo = JsonConvert.DeserializeObject<Response>(jsonArray.First().ToString());
            }
            return UserInfo;
        }
    }
}


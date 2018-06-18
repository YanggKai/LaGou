using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace LaGou
{
    class TestNewJson
    {
        public TestNewJson()
        {
            string json = @"{
  'channel': {
    'title': 'James Newton-King',
    'link': 'http://james.newtonking.com',
    'description': 'James Newton-King\'s blog.',
    'item': [
      {
        'title': 'Json.NET 1.3 + New license + Now on CodePlex',
        'description': 'Annoucing the release of Json.NET 1.3, the MIT license and the source on CodePlex',
        'link': 'http://james.newtonking.com/projects/json-net.aspx',
        'categories': [
          'Json.NET',
          'CodePlex'
        ]
      },
      {
        'title': 'LINQ to JSON beta',
        'description': 'Annoucing LINQ to JSON',
        'link': 'http://james.newtonking.com/projects/json-net.aspx',
        'categories': [
          'Json.NET',
          'LINQ'
        ]
      }
    ]
  }
}";
            JObject rss = JObject.Parse(json);
            string rssTitle = (string)rss["channel"]["title"];
            Console.WriteLine(rssTitle);
        }
    }
}

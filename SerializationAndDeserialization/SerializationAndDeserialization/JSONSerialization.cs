using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationAndDeserialization
{
    public class JSONSerialization
    {
        public void JsonSerialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Ashutosh",
                Description = "Welcome to the Serialization"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
            Console.WriteLine();
        }
        public void JsonDeserialize()
        {
            string json = @"{
                    'Name' : 'Ashutosh',
                    'Description' : 'Welcome to the Serialization'
            }";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
            Console.WriteLine(bsObj.Description);
            Console.WriteLine();
        }
    }
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
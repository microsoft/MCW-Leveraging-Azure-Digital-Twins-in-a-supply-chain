using System;
using Azure.DigitalTwins.Core;
using Azure.Identity;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

namespace AdtSdk
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var adtInstanceUrl = "https://ADT_INSTANCE_HOST_NAME";
            var credential = new DefaultAzureCredential();
            var client = new DigitalTwinsClient(new Uri(adtInstanceUrl), credential);
           
            //retrieve the factory twin - this query will take a moment longer due to the cold start
            var factoryId = "FA44212";
            var factory = client.GetDigitalTwin<BasicDigitalTwin>(factoryId);
            Console.WriteLine($"Factory {factory.Value.Id} retrieved.");
            foreach(KeyValuePair<string, object> prop in factory.Value.Contents){
            
                Console.WriteLine($"Factory {factory.Value.Id} has Property: {prop.Key} with value {prop.Value.ToString()}");
            }

            //output factory property metadata, indicating the last time the property was updated
            foreach(var md in factory.Value.Metadata.PropertyMetadata)
            {
                Console.WriteLine($"Factory {factory.Value.Id} Property: {md.Key} was last updated {md.Value.LastUpdatedOn}");
            }

            //retrieve factory relationships
            IAsyncEnumerable<BasicRelationship> relationships = client.GetRelationshipsAsync<BasicRelationship>(factoryId);
            await foreach (BasicRelationship relationship in relationships)
            {
                Console.WriteLine($"Factory {factory.Value.Id} has relationship '{relationship.Name}' with {relationship.TargetId}");
            }

            //retrieve only the Efficiency property value for the factory using a projection
            var projectionQuery1 = $"SELECT Factory.Efficiency FROM DIGITALTWINS Factory WHERE Factory.$dtId='{factoryId}'";
            IAsyncEnumerable<JsonElement> response = client.QueryAsync<JsonElement>(projectionQuery1);
            await foreach (JsonElement ret in response)
            {
               Console.WriteLine($"{factoryId} Efficiency is at {ret.GetProperty("Efficiency")}");
            }

            //retrieve factories with Efficiency equal to or over 90
            var queryByPropertyValue = $"SELECT Factory FROM DIGITALTWINS Factory WHERE Factory.Efficiency >= 90";
            IAsyncEnumerable<BasicDigitalTwin> response2 = client.QueryAsync<IDictionary<string, BasicDigitalTwin>>(queryByPropertyValue).Select(_ => _["Factory"]);
            await foreach (BasicDigitalTwin ret in response2)
            {
               Console.WriteLine($"Factory {ret.Id} has an Efficiency over 90.");
            }
        }
    }
}

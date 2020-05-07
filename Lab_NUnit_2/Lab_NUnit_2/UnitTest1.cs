using Newtonsoft.Json;
using NUnit.Framework;
using NUnitTestProject1;
using RestSharp;

namespace Tests
{
    public class Tests
    {
        Response deserializedProduct;

        [Test]
        public void Test1()
        {
            var client = new RestClient("https://disease.sh/v2/all?yesterday=true");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var d = client.Execute(request);
            Response deserializedProduct = JsonConvert.DeserializeObject<Response>(d.Content);
            Assert.IsTrue(d.StatusCode == System.Net.HttpStatusCode.OK);
        }

        [Test]
        public void Test2()
        {
            var client = new RestClient("https://disease.sh/v2/all?yesterday=true");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var d = client.Execute(request);
            Response deserializedProduct = JsonConvert.DeserializeObject<Response>(d.Content);
            Assert.IsTrue(d.ContentType.Equals("application/json; charset=utf-8"));
        }

        [Test]
        public void Test3()
        {
            var client = new RestClient("https://disease.sh/v2/all?yesterday=true");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var d = client.Execute(request);
            Response deserializedProduct = JsonConvert.DeserializeObject<Response>(d.Content);
            Assert.IsTrue(d.Content.Contains("updated"));
        }

        [Test]
        public void Test4()
        {
            var client = new RestClient("https://disease.sh/v2/all?yesterday=true");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var d = client.Execute(request);
            Response deserializedProduct = JsonConvert.DeserializeObject<Response>(d.Content);
            Assert.IsTrue(d.IsSuccessful);
        }

        [Test]
        public void Test5()
        {
            var client = new RestClient("https://disease.sh/v2/all?yesterday=true");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var d = client.Execute(request);
            Response deserializedProduct = JsonConvert.DeserializeObject<Response>(d.Content);
            Assert.IsNotNull(d);
        }

        [Test]
        public void Test6()
        {
            var client = new RestClient("https://disease.sh/v2/all?yesterday=true");
            var request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Accept", "application/json");
            var d = client.Execute(request);
            Response deserializedProduct = JsonConvert.DeserializeObject<Response>(d.Content);
            Assert.IsTrue(int.Parse(deserializedProduct.Cases) > 0);
        }

    }
}
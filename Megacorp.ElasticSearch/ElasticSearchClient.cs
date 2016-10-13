using System;
using Nest;

namespace Megacorp.ElasticSearch
{
    public class ElasticSearchClient
    {
        private readonly ElasticClient _elasticClient;

        public ElasticSearchClient()
        {
            var node = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(node);
            _elasticClient = new ElasticClient(settings);
        }

        public IIndexResponse Index(dynamic @object, string indexName, string indexType)
        {
            return _elasticClient.Index((object)@object, ix => ix.Index(indexName).Type(indexType).Id(@object.Id));
        }

        public IGetResponse<T> Get<T>(string indexName, string indexType, string id) where T : class
        {
            return _elasticClient.Get<T>(new GetRequest(indexName, indexType, id));
        }

        public ISearchResponse<T> Search<T>(string indexName, string indexType, string search) where T : class
        {
            return null;
            //return _elasticClient.Search<T>(x => x
            //    .Index(indexName)
            //    .Type(indexType)
            //    .Query(q => q.Match(qs => qs
            //        .
            //        .Query(search))));
        } 
    }
}
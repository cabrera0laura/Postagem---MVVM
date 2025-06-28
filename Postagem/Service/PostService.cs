using Postagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Postagem.Service
{
    internal class PostService
    {
        string base_url = "https://jsonplaceholder.typicode.com";
        List<PostModel> postagens;
        JsonSerializerOptions serializerOptions;

        public PostService()
        {
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };
        }

        // PostModel --> pasta Models
        public async Task<List<PostModel>> getPost()
        {

            Uri uri = new Uri($"{base_url}/posts");
            //responsavel por buscar a informação
            HttpClient client = new HttpClient();
            //responseMessage -->  retornando a resposta   Async --> n a parametro para retorno
            HttpResponseMessage responseMessage = await client.GetAsync(uri);
            string content = await responseMessage.Content.ReadAsStringAsync();
            postagens = JsonSerializer.Deserialize<List<PostModel>>(content, serializerOptions);
            return postagens;

        }
    }
}

﻿using MsCampus.Win8.Shared.Contracts.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MsCampus.Win8.Shared.Implementation.Services
{
    public class HttpClientService : IHttpClientService
    {
        public async Task<T> GetJsonAsync<T>(string url, CancellationToken cancellationToken)
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.AutomaticDecompression = System.Net.DecompressionMethods.GZip;
            var client = new HttpClient(httpClientHandler);
            var response = await client.GetAsync(url, cancellationToken).ConfigureAwait(false);
            if (response != null)
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
            else
                return default(T);
        }
    }
}

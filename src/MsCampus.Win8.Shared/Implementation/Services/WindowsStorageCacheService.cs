﻿using MsCampus.Win8.Shared.Contracts.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace MsCampus.Win8.Shared.Implementation.Services
{
    public class WindowsStorageCacheService : ICacheService
    {
        public async Task<bool> Exists(string key)
        {
            try
            {
                var localFolder = ApplicationData.Current.LocalFolder;
                await localFolder.GetFileAsync(key);
                return true;
            }
            catch
            {
                return false;
            }   
        }


        public async Task Put(string key, object value)
        {
            try
            {
                var localFolder = ApplicationData.Current.LocalFolder;
                var fileTask = localFolder.CreateFileAsync(
                        key, CreationCollisionOption.ReplaceExisting);
                var json = JsonConvert.SerializeObject(value);
                await FileIO.WriteTextAsync(await fileTask, json);
            }
            catch
            {
            }
        }

        public async Task<ICacheItem<T>> Get<T>(string key)
        {
            try
            {
                var localFolder = ApplicationData.Current.LocalFolder;
                var file = await localFolder.GetFileAsync(key);
                var json = await FileIO.ReadTextAsync(file);
                return new CacheItem<T>(JsonConvert.DeserializeObject<T>(json), file.DateCreated.LocalDateTime);
            }
            catch
            {
                return new CacheItem<T>(default(T), DateTime.MinValue);
            }
        }
    }
}
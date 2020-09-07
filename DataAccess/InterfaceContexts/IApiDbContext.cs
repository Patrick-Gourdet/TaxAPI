﻿using System.Threading.Tasks;
using Auth.Model;

namespace Auth.DataAccess.InterfaceContexts
{
    /// <summary>
    /// Api Context for access and storage of the
    /// configured api keys for authenticated users
    /// </summary>
    public interface IApiDbContext
    {
        

        /// <summary>
        /// Api key access function
        /// </summary>
        /// <param name="apiName"></param>
        /// <param name="compareHash"></param>
        /// <returns></returns>
        Task<string> GetApiKey(string apiName, byte[] compareHash);
        /// <summary>
        /// Save changes or new api keys the Item takes
        /// the apikeyitem model
        /// </summary>
        /// <param name="item"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<int> SaveChanges(ApiDbItem item);
    }
}
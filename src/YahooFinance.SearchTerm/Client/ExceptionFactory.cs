/* 
 * Yahoo Finance Search API
 *
 * This is the API from yahoo finance to search for symbols.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: kobeyoung81@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using RestSharp.Portable;

namespace YahooFinance.SearchTerm.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
        public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}

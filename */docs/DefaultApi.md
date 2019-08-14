# YahooFinance.SearchTerm.Api.DefaultApi

All URIs are relative to *https://finance.yahoo.com/_finance_doubledown/api/resource*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetQuote**](DefaultApi.md#getquote) | **GET** /quote | get quote for symbol
[**SearchTerm**](DefaultApi.md#searchterm) | **GET** /searchassist;searchTerm&#x3D;{term} | searches tickers

<a name="getquote"></a>
# **GetQuote**
> QuoteResponseContent GetQuote (string symbols)

get quote for symbol

By passing in the appropriate options, you can search for available inventory in the system 

### Example
```csharp
using System;
using System.Diagnostics;
using YahooFinance.SearchTerm.Api;
using YahooFinance.SearchTerm.Client;
using YahooFinance.SearchTerm.Model;

namespace Example
{
    public class GetQuoteExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var symbols = symbols_example;  // string | pass an optional search string for looking up inventory

            try
            {
                // get quote for symbol
                QuoteResponseContent result = apiInstance.GetQuote(symbols);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetQuote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbols** | **string**| pass an optional search string for looking up inventory | 

### Return type

[**QuoteResponseContent**](QuoteResponseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchterm"></a>
# **SearchTerm**
> List<SearchResponse> SearchTerm (string term)

searches tickers

By passing in the appropriate options, you can search for available inventory in the system 

### Example
```csharp
using System;
using System.Diagnostics;
using YahooFinance.SearchTerm.Api;
using YahooFinance.SearchTerm.Client;
using YahooFinance.SearchTerm.Model;

namespace Example
{
    public class SearchTermExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var term = term_example;  // string | pass an optional search string for looking up inventory

            try
            {
                // searches tickers
                List&lt;SearchResponse&gt; result = apiInstance.SearchTerm(term);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SearchTerm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | **string**| pass an optional search string for looking up inventory | 

### Return type

[**List<SearchResponse>**](SearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

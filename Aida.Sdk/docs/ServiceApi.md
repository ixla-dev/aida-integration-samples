# Aida.Sdk.Api.ServiceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelTest**](ServiceApi.md#canceltest) | **POST** /aida/v1/service/test/cancel |  |
| [**GetTestState**](ServiceApi.md#getteststate) | **GET** /aida/v1/service/test/state |  |
| [**StartTestAutopos**](ServiceApi.md#starttestautopos) | **POST** /aida/v1/service/autopos/start-test |  |
| [**StartTestMagStripe**](ServiceApi.md#starttestmagstripe) | **POST** /aida/v1/service/magstripe/start-test |  |
| [**StartTestOcr**](ServiceApi.md#starttestocr) | **POST** /aida/v1/service/ocr/start-test |  |
| [**StartTestTransport**](ServiceApi.md#starttesttransport) | **POST** /aida/v1/service/transport/start-test |  |

<a name="canceltest"></a>
# **CancelTest**
> void CancelTest ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class CancelTestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ServiceApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.CancelTest();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.CancelTest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelTestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CancelTestWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.CancelTestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteststate"></a>
# **GetTestState**
> DiagnosticTaskState GetTestState (DiagnosticTaskType? taskType = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class GetTestStateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ServiceApi(httpClient, config, httpClientHandler);
            var taskType = (DiagnosticTaskType) "None";  // DiagnosticTaskType? |  (optional) 

            try
            {
                DiagnosticTaskState result = apiInstance.GetTestState(taskType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.GetTestState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTestStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiagnosticTaskState> response = apiInstance.GetTestStateWithHttpInfo(taskType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.GetTestStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskType** | **DiagnosticTaskType?** |  | [optional]  |

### Return type

[**DiagnosticTaskState**](DiagnosticTaskState.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="starttestautopos"></a>
# **StartTestAutopos**
> void StartTestAutopos (TestAutoposStartParams testAutoposStartParams = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class StartTestAutoposExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ServiceApi(httpClient, config, httpClientHandler);
            var testAutoposStartParams = new TestAutoposStartParams(); // TestAutoposStartParams |  (optional) 

            try
            {
                apiInstance.StartTestAutopos(testAutoposStartParams);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.StartTestAutopos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartTestAutoposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.StartTestAutoposWithHttpInfo(testAutoposStartParams);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.StartTestAutoposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testAutoposStartParams** | [**TestAutoposStartParams**](TestAutoposStartParams.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="starttestmagstripe"></a>
# **StartTestMagStripe**
> void StartTestMagStripe (TestMagStripeStartParams testMagStripeStartParams = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class StartTestMagStripeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ServiceApi(httpClient, config, httpClientHandler);
            var testMagStripeStartParams = new TestMagStripeStartParams(); // TestMagStripeStartParams |  (optional) 

            try
            {
                apiInstance.StartTestMagStripe(testMagStripeStartParams);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.StartTestMagStripe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartTestMagStripeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.StartTestMagStripeWithHttpInfo(testMagStripeStartParams);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.StartTestMagStripeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testMagStripeStartParams** | [**TestMagStripeStartParams**](TestMagStripeStartParams.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="starttestocr"></a>
# **StartTestOcr**
> void StartTestOcr (TestOcrStartParams testOcrStartParams = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class StartTestOcrExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ServiceApi(httpClient, config, httpClientHandler);
            var testOcrStartParams = new TestOcrStartParams(); // TestOcrStartParams |  (optional) 

            try
            {
                apiInstance.StartTestOcr(testOcrStartParams);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.StartTestOcr: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartTestOcrWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.StartTestOcrWithHttpInfo(testOcrStartParams);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.StartTestOcrWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testOcrStartParams** | [**TestOcrStartParams**](TestOcrStartParams.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="starttesttransport"></a>
# **StartTestTransport**
> void StartTestTransport (TestTransportStartParams testTransportStartParams = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class StartTestTransportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ServiceApi(httpClient, config, httpClientHandler);
            var testTransportStartParams = new TestTransportStartParams(); // TestTransportStartParams |  (optional) 

            try
            {
                apiInstance.StartTestTransport(testTransportStartParams);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceApi.StartTestTransport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartTestTransportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.StartTestTransportWithHttpInfo(testTransportStartParams);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceApi.StartTestTransportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **testTransportStartParams** | [**TestTransportStartParams**](TestTransportStartParams.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


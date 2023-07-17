# Aida.Sdk.Api.DisplayApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AidaV1DisplayDataSendDataPost**](DisplayApi.md#aidav1displaydatasenddatapost) | **POST** /aida/v1/display-data/send-data |  |
| [**AidaV1DisplayDataShowErrorWindowPost**](DisplayApi.md#aidav1displaydatashowerrorwindowpost) | **POST** /aida/v1/display-data/show-error-window |  |
| [**AidaV1DisplayDataShowMainWindowPost**](DisplayApi.md#aidav1displaydatashowmainwindowpost) | **POST** /aida/v1/display-data/show-main-window |  |
| [**AidaV1DisplayDataShowResetButtonPost**](DisplayApi.md#aidav1displaydatashowresetbuttonpost) | **POST** /aida/v1/display-data/show-reset-button |  |

<a name="aidav1displaydatasenddatapost"></a>
# **AidaV1DisplayDataSendDataPost**
> DisplayActionResult AidaV1DisplayDataSendDataPost (byte[] body = null)



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
    public class AidaV1DisplayDataSendDataPostExample
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
            var apiInstance = new DisplayApi(httpClient, config, httpClientHandler);
            var body = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] |  (optional) 

            try
            {
                DisplayActionResult result = apiInstance.AidaV1DisplayDataSendDataPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisplayApi.AidaV1DisplayDataSendDataPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1DisplayDataSendDataPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DisplayActionResult> response = apiInstance.AidaV1DisplayDataSendDataPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisplayApi.AidaV1DisplayDataSendDataPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **byte[]** |  | [optional]  |

### Return type

[**DisplayActionResult**](DisplayActionResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidav1displaydatashowerrorwindowpost"></a>
# **AidaV1DisplayDataShowErrorWindowPost**
> DisplayActionResult AidaV1DisplayDataShowErrorWindowPost (ShowErrorWindowParamsDto showErrorWindowParamsDto = null)



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
    public class AidaV1DisplayDataShowErrorWindowPostExample
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
            var apiInstance = new DisplayApi(httpClient, config, httpClientHandler);
            var showErrorWindowParamsDto = new ShowErrorWindowParamsDto(); // ShowErrorWindowParamsDto |  (optional) 

            try
            {
                DisplayActionResult result = apiInstance.AidaV1DisplayDataShowErrorWindowPost(showErrorWindowParamsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisplayApi.AidaV1DisplayDataShowErrorWindowPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1DisplayDataShowErrorWindowPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DisplayActionResult> response = apiInstance.AidaV1DisplayDataShowErrorWindowPostWithHttpInfo(showErrorWindowParamsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisplayApi.AidaV1DisplayDataShowErrorWindowPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **showErrorWindowParamsDto** | [**ShowErrorWindowParamsDto**](ShowErrorWindowParamsDto.md) |  | [optional]  |

### Return type

[**DisplayActionResult**](DisplayActionResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidav1displaydatashowmainwindowpost"></a>
# **AidaV1DisplayDataShowMainWindowPost**
> DisplayActionResult AidaV1DisplayDataShowMainWindowPost (ShowMainWindowParamsDto showMainWindowParamsDto = null)



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
    public class AidaV1DisplayDataShowMainWindowPostExample
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
            var apiInstance = new DisplayApi(httpClient, config, httpClientHandler);
            var showMainWindowParamsDto = new ShowMainWindowParamsDto(); // ShowMainWindowParamsDto |  (optional) 

            try
            {
                DisplayActionResult result = apiInstance.AidaV1DisplayDataShowMainWindowPost(showMainWindowParamsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisplayApi.AidaV1DisplayDataShowMainWindowPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1DisplayDataShowMainWindowPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DisplayActionResult> response = apiInstance.AidaV1DisplayDataShowMainWindowPostWithHttpInfo(showMainWindowParamsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisplayApi.AidaV1DisplayDataShowMainWindowPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **showMainWindowParamsDto** | [**ShowMainWindowParamsDto**](ShowMainWindowParamsDto.md) |  | [optional]  |

### Return type

[**DisplayActionResult**](DisplayActionResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidav1displaydatashowresetbuttonpost"></a>
# **AidaV1DisplayDataShowResetButtonPost**
> DisplayActionResult AidaV1DisplayDataShowResetButtonPost (ShowResetButtonParamsDto showResetButtonParamsDto = null)



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
    public class AidaV1DisplayDataShowResetButtonPostExample
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
            var apiInstance = new DisplayApi(httpClient, config, httpClientHandler);
            var showResetButtonParamsDto = new ShowResetButtonParamsDto(); // ShowResetButtonParamsDto |  (optional) 

            try
            {
                DisplayActionResult result = apiInstance.AidaV1DisplayDataShowResetButtonPost(showResetButtonParamsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisplayApi.AidaV1DisplayDataShowResetButtonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1DisplayDataShowResetButtonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DisplayActionResult> response = apiInstance.AidaV1DisplayDataShowResetButtonPostWithHttpInfo(showResetButtonParamsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisplayApi.AidaV1DisplayDataShowResetButtonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **showResetButtonParamsDto** | [**ShowResetButtonParamsDto**](ShowResetButtonParamsDto.md) |  | [optional]  |

### Return type

[**DisplayActionResult**](DisplayActionResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


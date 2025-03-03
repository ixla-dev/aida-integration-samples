# Aida.Sdk.Api.APrintApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AidaV1AprintJobCurrentClosePost**](APrintApi.md#aidav1aprintjobcurrentclosepost) | **POST** /aida/v1/aprint/job/current/close |  |
| [**AidaV1AprintJobInsertImagePost**](APrintApi.md#aidav1aprintjobinsertimagepost) | **POST** /aida/v1/aprint/job/insert-image |  |
| [**AidaV1AprintJobPreviewJpegGet**](APrintApi.md#aidav1aprintjobpreviewjpegget) | **GET** /aida/v1/aprint/job/preview.jpeg |  |
| [**AidaV1AprintPrintDialogClosePost**](APrintApi.md#aidav1aprintprintdialogclosepost) | **POST** /aida/v1/aprint/print-dialog/close |  |
| [**AidaV1AprintPrintDialogOpenPost**](APrintApi.md#aidav1aprintprintdialogopenpost) | **POST** /aida/v1/aprint/print-dialog/open |  |
| [**AidaV1AprintPrintSettingsGet**](APrintApi.md#aidav1aprintprintsettingsget) | **GET** /aida/v1/aprint/print/settings |  |
| [**AidaV1AprintPrintSettingsPost**](APrintApi.md#aidav1aprintprintsettingspost) | **POST** /aida/v1/aprint/print/settings |  |
| [**AidaV1AprintPrintStartPost**](APrintApi.md#aidav1aprintprintstartpost) | **POST** /aida/v1/aprint/print/start |  |
| [**AidaV1AprintPrintStatusGet**](APrintApi.md#aidav1aprintprintstatusget) | **GET** /aida/v1/aprint/print/status |  |
| [**AidaV1AprintPrintStopPost**](APrintApi.md#aidav1aprintprintstoppost) | **POST** /aida/v1/aprint/print/stop |  |
| [**AidaV1AprintPrintheadTemperatureGet**](APrintApi.md#aidav1aprintprintheadtemperatureget) | **GET** /aida/v1/aprint/printhead-temperature |  |

<a name="aidav1aprintjobcurrentclosepost"></a>
# **AidaV1AprintJobCurrentClosePost**
> void AidaV1AprintJobCurrentClosePost ()



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
    public class AidaV1AprintJobCurrentClosePostExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.AidaV1AprintJobCurrentClosePost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintJobCurrentClosePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintJobCurrentClosePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1AprintJobCurrentClosePostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintJobCurrentClosePostWithHttpInfo: " + e.Message);
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

<a name="aidav1aprintjobinsertimagepost"></a>
# **AidaV1AprintJobInsertImagePost**
> void AidaV1AprintJobInsertImagePost (int? dataPageId = null, int? x = null, int? y = null, int? width = null, int? height = null, int? angle = null, FileParameter file = null)



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
    public class AidaV1AprintJobInsertImagePostExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);
            var dataPageId = 1;  // int? |  (optional)  (default to 1)
            var x = 0;  // int? |  (optional)  (default to 0)
            var y = 0;  // int? |  (optional)  (default to 0)
            var width = 0;  // int? |  (optional)  (default to 0)
            var height = 0;  // int? |  (optional)  (default to 0)
            var angle = 0;  // int? |  (optional)  (default to 0)
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                apiInstance.AidaV1AprintJobInsertImagePost(dataPageId, x, y, width, height, angle, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintJobInsertImagePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintJobInsertImagePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1AprintJobInsertImagePostWithHttpInfo(dataPageId, x, y, width, height, angle, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintJobInsertImagePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataPageId** | **int?** |  | [optional] [default to 1] |
| **x** | **int?** |  | [optional] [default to 0] |
| **y** | **int?** |  | [optional] [default to 0] |
| **width** | **int?** |  | [optional] [default to 0] |
| **height** | **int?** |  | [optional] [default to 0] |
| **angle** | **int?** |  | [optional] [default to 0] |
| **file** | **FileParameter****FileParameter** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidav1aprintjobpreviewjpegget"></a>
# **AidaV1AprintJobPreviewJpegGet**
> void AidaV1AprintJobPreviewJpegGet ()



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
    public class AidaV1AprintJobPreviewJpegGetExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.AidaV1AprintJobPreviewJpegGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintJobPreviewJpegGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintJobPreviewJpegGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1AprintJobPreviewJpegGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintJobPreviewJpegGetWithHttpInfo: " + e.Message);
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

<a name="aidav1aprintprintdialogclosepost"></a>
# **AidaV1AprintPrintDialogClosePost**
> void AidaV1AprintPrintDialogClosePost ()



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
    public class AidaV1AprintPrintDialogClosePostExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.AidaV1AprintPrintDialogClosePost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintDialogClosePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintPrintDialogClosePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1AprintPrintDialogClosePostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintDialogClosePostWithHttpInfo: " + e.Message);
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

<a name="aidav1aprintprintdialogopenpost"></a>
# **AidaV1AprintPrintDialogOpenPost**
> void AidaV1AprintPrintDialogOpenPost ()



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
    public class AidaV1AprintPrintDialogOpenPostExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.AidaV1AprintPrintDialogOpenPost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintDialogOpenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintPrintDialogOpenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1AprintPrintDialogOpenPostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintDialogOpenPostWithHttpInfo: " + e.Message);
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

<a name="aidav1aprintprintsettingsget"></a>
# **AidaV1AprintPrintSettingsGet**
> PrintSettingsDto AidaV1AprintPrintSettingsGet ()



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
    public class AidaV1AprintPrintSettingsGetExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);

            try
            {
                PrintSettingsDto result = apiInstance.AidaV1AprintPrintSettingsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintPrintSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrintSettingsDto> response = apiInstance.AidaV1AprintPrintSettingsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PrintSettingsDto**](PrintSettingsDto.md)

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

<a name="aidav1aprintprintsettingspost"></a>
# **AidaV1AprintPrintSettingsPost**
> void AidaV1AprintPrintSettingsPost (int? printSpeed = null, bool? verticalMirrorEnabled = null, bool? horizontalMirrorEnabled = null, bool? cMYKDirectEnabled = null, bool? enableC = null, bool? enableM = null, bool? enableY = null, bool? enableK = null, int? dropSize = null, int? dataPageId = null, PrintQuality? printQuality = null)



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
    public class AidaV1AprintPrintSettingsPostExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);
            var printSpeed = 56;  // int? |  (optional) 
            var verticalMirrorEnabled = true;  // bool? |  (optional) 
            var horizontalMirrorEnabled = true;  // bool? |  (optional) 
            var cMYKDirectEnabled = true;  // bool? |  (optional) 
            var enableC = true;  // bool? |  (optional) 
            var enableM = true;  // bool? |  (optional) 
            var enableY = true;  // bool? |  (optional) 
            var enableK = true;  // bool? |  (optional) 
            var dropSize = 56;  // int? |  (optional) 
            var dataPageId = 56;  // int? |  (optional) 
            var printQuality = (PrintQuality) "Draft";  // PrintQuality? |  (optional) 

            try
            {
                apiInstance.AidaV1AprintPrintSettingsPost(printSpeed, verticalMirrorEnabled, horizontalMirrorEnabled, cMYKDirectEnabled, enableC, enableM, enableY, enableK, dropSize, dataPageId, printQuality);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintSettingsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintPrintSettingsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1AprintPrintSettingsPostWithHttpInfo(printSpeed, verticalMirrorEnabled, horizontalMirrorEnabled, cMYKDirectEnabled, enableC, enableM, enableY, enableK, dropSize, dataPageId, printQuality);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintSettingsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **printSpeed** | **int?** |  | [optional]  |
| **verticalMirrorEnabled** | **bool?** |  | [optional]  |
| **horizontalMirrorEnabled** | **bool?** |  | [optional]  |
| **cMYKDirectEnabled** | **bool?** |  | [optional]  |
| **enableC** | **bool?** |  | [optional]  |
| **enableM** | **bool?** |  | [optional]  |
| **enableY** | **bool?** |  | [optional]  |
| **enableK** | **bool?** |  | [optional]  |
| **dropSize** | **int?** |  | [optional]  |
| **dataPageId** | **int?** |  | [optional]  |
| **printQuality** | **PrintQuality?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="aidav1aprintprintstartpost"></a>
# **AidaV1AprintPrintStartPost**
> void AidaV1AprintPrintStartPost ()



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
    public class AidaV1AprintPrintStartPostExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.AidaV1AprintPrintStartPost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintStartPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintPrintStartPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1AprintPrintStartPostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintStartPostWithHttpInfo: " + e.Message);
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

<a name="aidav1aprintprintstatusget"></a>
# **AidaV1AprintPrintStatusGet**
> PrintStatusInfo AidaV1AprintPrintStatusGet ()



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
    public class AidaV1AprintPrintStatusGetExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);

            try
            {
                PrintStatusInfo result = apiInstance.AidaV1AprintPrintStatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintPrintStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrintStatusInfo> response = apiInstance.AidaV1AprintPrintStatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PrintStatusInfo**](PrintStatusInfo.md)

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

<a name="aidav1aprintprintstoppost"></a>
# **AidaV1AprintPrintStopPost**
> void AidaV1AprintPrintStopPost ()



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
    public class AidaV1AprintPrintStopPostExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.AidaV1AprintPrintStopPost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintStopPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintPrintStopPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1AprintPrintStopPostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintStopPostWithHttpInfo: " + e.Message);
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

<a name="aidav1aprintprintheadtemperatureget"></a>
# **AidaV1AprintPrintheadTemperatureGet**
> float AidaV1AprintPrintheadTemperatureGet (bool? toggleDialog = null)



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
    public class AidaV1AprintPrintheadTemperatureGetExample
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
            var apiInstance = new APrintApi(httpClient, config, httpClientHandler);
            var toggleDialog = false;  // bool? |  (optional)  (default to false)

            try
            {
                float result = apiInstance.AidaV1AprintPrintheadTemperatureGet(toggleDialog);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintheadTemperatureGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1AprintPrintheadTemperatureGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<float> response = apiInstance.AidaV1AprintPrintheadTemperatureGetWithHttpInfo(toggleDialog);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APrintApi.AidaV1AprintPrintheadTemperatureGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **toggleDialog** | **bool?** |  | [optional] [default to false] |

### Return type

**float**

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


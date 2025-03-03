# Aida.Sdk.Api.ToolBoxApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LaserSightGrid**](ToolBoxApi.md#lasersightgrid) | **GET** /aida/v1/toolbox/laser-sight-grid | Lasers the grid for laser alignment on datapage 1 |
| [**PrintAndLaserCalibrationTemplate**](ToolBoxApi.md#printandlasercalibrationtemplate) | **GET** /aida/v1/toolbox/produce-laser-calibration-template | Lasers and prints the template for laser calibration on datapage 1 |
| [**PrintAndLaserSightGrid**](ToolBoxApi.md#printandlasersightgrid) | **GET** /aida/v1/toolbox/print-and-laser-sight-grid | Lasers and prints the grid for laser alignment on datapage 1 |
| [**PrintSightGrid**](ToolBoxApi.md#printsightgrid) | **GET** /aida/v1/toolbox/print-sight-grid | Prints the grid for laser alignment on datapage 1 |

<a name="lasersightgrid"></a>
# **LaserSightGrid**
> InkjetPrinterActionResult LaserSightGrid (string scannerid = null)

Lasers the grid for laser alignment on datapage 1

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
    public class LaserSightGridExample
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
            var apiInstance = new ToolBoxApi(httpClient, config, httpClientHandler);
            var scannerid = "scannerid_example";  // string |  (optional) 

            try
            {
                // Lasers the grid for laser alignment on datapage 1
                InkjetPrinterActionResult result = apiInstance.LaserSightGrid(scannerid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolBoxApi.LaserSightGrid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LaserSightGridWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lasers the grid for laser alignment on datapage 1
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.LaserSightGridWithHttpInfo(scannerid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolBoxApi.LaserSightGridWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerid** | **string** |  | [optional]  |

### Return type

[**InkjetPrinterActionResult**](InkjetPrinterActionResult.md)

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

<a name="printandlasercalibrationtemplate"></a>
# **PrintAndLaserCalibrationTemplate**
> InkjetPrinterActionResult PrintAndLaserCalibrationTemplate (string scannerid = null)

Lasers and prints the template for laser calibration on datapage 1

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
    public class PrintAndLaserCalibrationTemplateExample
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
            var apiInstance = new ToolBoxApi(httpClient, config, httpClientHandler);
            var scannerid = "scannerid_example";  // string |  (optional) 

            try
            {
                // Lasers and prints the template for laser calibration on datapage 1
                InkjetPrinterActionResult result = apiInstance.PrintAndLaserCalibrationTemplate(scannerid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolBoxApi.PrintAndLaserCalibrationTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintAndLaserCalibrationTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lasers and prints the template for laser calibration on datapage 1
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.PrintAndLaserCalibrationTemplateWithHttpInfo(scannerid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolBoxApi.PrintAndLaserCalibrationTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerid** | **string** |  | [optional]  |

### Return type

[**InkjetPrinterActionResult**](InkjetPrinterActionResult.md)

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

<a name="printandlasersightgrid"></a>
# **PrintAndLaserSightGrid**
> InkjetPrinterActionResult PrintAndLaserSightGrid (string scannerid = null)

Lasers and prints the grid for laser alignment on datapage 1

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
    public class PrintAndLaserSightGridExample
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
            var apiInstance = new ToolBoxApi(httpClient, config, httpClientHandler);
            var scannerid = "scannerid_example";  // string |  (optional) 

            try
            {
                // Lasers and prints the grid for laser alignment on datapage 1
                InkjetPrinterActionResult result = apiInstance.PrintAndLaserSightGrid(scannerid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolBoxApi.PrintAndLaserSightGrid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintAndLaserSightGridWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lasers and prints the grid for laser alignment on datapage 1
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.PrintAndLaserSightGridWithHttpInfo(scannerid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolBoxApi.PrintAndLaserSightGridWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerid** | **string** |  | [optional]  |

### Return type

[**InkjetPrinterActionResult**](InkjetPrinterActionResult.md)

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

<a name="printsightgrid"></a>
# **PrintSightGrid**
> InkjetPrinterActionResult PrintSightGrid ()

Prints the grid for laser alignment on datapage 1

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
    public class PrintSightGridExample
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
            var apiInstance = new ToolBoxApi(httpClient, config, httpClientHandler);

            try
            {
                // Prints the grid for laser alignment on datapage 1
                InkjetPrinterActionResult result = apiInstance.PrintSightGrid();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolBoxApi.PrintSightGrid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintSightGridWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Prints the grid for laser alignment on datapage 1
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.PrintSightGridWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolBoxApi.PrintSightGridWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InkjetPrinterActionResult**](InkjetPrinterActionResult.md)

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


# Aida.Sdk.Api.InkjetApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Action**](InkjetApi.md#action) | **POST** /aida/v1/inkjet/clean-printhead | Passes the wiper on the printhead |
| [**AddEntityToInkjetLayout**](InkjetApi.md#addentitytoinkjetlayout) | **POST** /aida/v1/inkjet/layouts/{inkjetLayoutId}/add-entity |  |
| [**AidaV1InkjetBoardCpuResetPost**](InkjetApi.md#aidav1inkjetboardcpuresetpost) | **POST** /aida/v1/inkjet/board/cpu/reset |  |
| [**AidaV1InkjetJobPreparePost**](InkjetApi.md#aidav1inkjetjobpreparepost) | **POST** /aida/v1/inkjet/job/prepare |  |
| [**AidaV1InkjetJobTranslatePost**](InkjetApi.md#aidav1inkjetjobtranslatepost) | **POST** /aida/v1/inkjet/job/translate |  |
| [**AidaV1InkjetLogerrorIdPut**](InkjetApi.md#aidav1inkjetlogerroridput) | **PUT** /aida/v1/inkjet/logerror/{id} |  |
| [**AidaV1InkjetLogerrorPost**](InkjetApi.md#aidav1inkjetlogerrorpost) | **POST** /aida/v1/inkjet/logerror |  |
| [**AidaV1InkjetPrintStatusGet**](InkjetApi.md#aidav1inkjetprintstatusget) | **GET** /aida/v1/inkjet/print-status |  |
| [**AidaV1InkjetPrintheadMoveToPrintareaPost**](InkjetApi.md#aidav1inkjetprintheadmovetoprintareapost) | **POST** /aida/v1/inkjet/printhead/move-to-printarea |  |
| [**AidaV1InkjetSetPrintheadOffsetPost**](InkjetApi.md#aidav1inkjetsetprintheadoffsetpost) | **POST** /aida/v1/inkjet/set-printhead-offset |  |
| [**AidaV1InkjetStartPrintPost**](InkjetApi.md#aidav1inkjetstartprintpost) | **POST** /aida/v1/inkjet/start-print |  |
| [**AidaV1InkjetTransportDebugPost**](InkjetApi.md#aidav1inkjettransportdebugpost) | **POST** /aida/v1/inkjet/transport/debug |  |
| [**CloseJob**](InkjetApi.md#closejob) | **POST** /aida/v1/inkjet/shingling-close-job |  |
| [**CreateInkjetLayout**](InkjetApi.md#createinkjetlayout) | **POST** /aida/v1/inkjet/layouts/create/{inkjetLayoutName} |  |
| [**CreateNewJob**](InkjetApi.md#createnewjob) | **POST** /aida/v1/inkjet/board/create-new-job |  |
| [**DeleteInkjetLayout**](InkjetApi.md#deleteinkjetlayout) | **DELETE** /aida/v1/inkjet/layouts/{id} |  |
| [**DisableVirtualPrintSignal**](InkjetApi.md#disablevirtualprintsignal) | **POST** /aida/v1/inkjet/features/virtualprintsignal/disable |  |
| [**EnableVirtualPrintSignal**](InkjetApi.md#enablevirtualprintsignal) | **POST** /aida/v1/inkjet/features/virtualprintsignal/enable |  |
| [**EnterMaintenanceMode**](InkjetApi.md#entermaintenancemode) | **POST** /aida/v1/inkjet/enter-maintenance-mode |  |
| [**ExitMaintenanceMode**](InkjetApi.md#exitmaintenancemode) | **POST** /aida/v1/inkjet/exit-maintenance-mode |  |
| [**FindInkjetLayouts**](InkjetApi.md#findinkjetlayouts) | **GET** /aida/v1/inkjet/layouts/find |  |
| [**GetActiveEntities**](InkjetApi.md#getactiveentities) | **GET** /aida/v1/inkjet/active-entities |  |
| [**GetAssignableInkjetLayoutsByJobTemplateId**](InkjetApi.md#getassignableinkjetlayoutsbyjobtemplateid) | **GET** /aida/v1/inkjet/job-templates/{id}/layouts/available |  |
| [**GetCleaningConfiguration**](InkjetApi.md#getcleaningconfiguration) | **GET** /aida/v1/inkjet/cleaning/configuration |  |
| [**GetCuringSettings**](InkjetApi.md#getcuringsettings) | **GET** /aida/v1/inkjet/settings/curing-settings |  |
| [**GetHeatersTemperature**](InkjetApi.md#getheaterstemperature) | **GET** /aida/v1/inkjet/settings/heaters-temperature |  |
| [**GetInkjetMaintenanceStatus**](InkjetApi.md#getinkjetmaintenancestatus) | **GET** /aida/v1/inkjet/maintenance/status |  |
| [**GetPinningSettings**](InkjetApi.md#getpinningsettings) | **GET** /aida/v1/inkjet/settings/pinning-settings |  |
| [**GetPrintLayoutPreview**](InkjetApi.md#getprintlayoutpreview) | **GET** /aida/v1/inkjet/get-print-layout-preview |  |
| [**GetPrinterPrintSettings**](InkjetApi.md#getprinterprintsettings) | **GET** /aida/v1/inkjet/settings/print-settings |  |
| [**GetSupportPrintMethods**](InkjetApi.md#getsupportprintmethods) | **GET** /aida/v1/inkjet/print-methods |  |
| [**GetVacuumPressure**](InkjetApi.md#getvacuumpressure) | **GET** /aida/v1/inkjet/cleaning/vacuum-pressure |  |
| [**GetXPrintModuleState**](InkjetApi.md#getxprintmodulestate) | **GET** /aida/v1/inkjet/xprint/state |  |
| [**GetXPrintState**](InkjetApi.md#getxprintstate) | **GET** /aida/v1/inkjet/state |  |
| [**InkjetLayoutPreview**](InkjetApi.md#inkjetlayoutpreview) | **GET** /aida/v1/inkjet/layouts/{inkjetLayoutId}/preview |  |
| [**InsertImage**](InkjetApi.md#insertimage) | **POST** /aida/v1/inkjet/board/insert-image |  |
| [**IsPrinting**](InkjetApi.md#isprinting) | **GET** /aida/v1/inkjet/board/is-printing |  |
| [**IsReady**](InkjetApi.md#isready) | **GET** /aida/v1/inkjet/board/is-ready |  |
| [**JobInsertImage**](InkjetApi.md#jobinsertimage) | **POST** /aida/v1/inkjet/shingling-load-image |  |
| [**LoadInkjetLayout**](InkjetApi.md#loadinkjetlayout) | **POST** /aida/v1/inkjet/layouts/{inkjetLayoutId}/load |  |
| [**LoadJobTemplateInkjetLayout**](InkjetApi.md#loadjobtemplateinkjetlayout) | **POST** /aida/v1/inkjet/load-job-template-inkjet-layout/{jobTemplateInkjetLayoutId} |  |
| [**MoveHeadToCapping**](InkjetApi.md#moveheadtocapping) | **POST** /aida/v1/inkjet/cleaning/move-to-capping |  |
| [**MoveHeadToMaintenance**](InkjetApi.md#moveheadtomaintenance) | **POST** /aida/v1/inkjet/cleaning/move-to-maintenance |  |
| [**MoveHeadToParking**](InkjetApi.md#moveheadtoparking) | **POST** /aida/v1/inkjet/cleaning/move-to-parking |  |
| [**NewJob**](InkjetApi.md#newjob) | **POST** /aida/v1/inkjet/shingling-new-job |  |
| [**NozzleCheck**](InkjetApi.md#nozzlecheck) | **POST** /aida/v1/inkjet/nozzle-check | Executes nozzle check by printing a 800x1000 image  With all channels enabled + CMYK Direct |
| [**PerformDeepCleaning**](InkjetApi.md#performdeepcleaning) | **POST** /aida/v1/inkjet/cleaning/perform-deep-cleaning |  |
| [**PerformLightCleaning**](InkjetApi.md#performlightcleaning) | **POST** /aida/v1/inkjet/cleaning/perform-light-cleaning |  |
| [**PerformNormalCleaning**](InkjetApi.md#performnormalcleaning) | **POST** /aida/v1/inkjet/cleaning/perform-normal-cleaning |  |
| [**PerformPurge**](InkjetApi.md#performpurge) | **POST** /aida/v1/inkjet/cleaning/perform-purge |  |
| [**PerformSpitting**](InkjetApi.md#performspitting) | **POST** /aida/v1/inkjet/cleaning/perform-spitting |  |
| [**PerformWiping**](InkjetApi.md#performwiping) | **POST** /aida/v1/inkjet/cleaning/perform-wiping |  |
| [**Print**](InkjetApi.md#print) | **POST** /aida/v1/inkjet/print | Handles the print process sending commands to APRINT for loading  and transferring images to the printhead manager board and moves  the axis to trigger the actual print of images |
| [**PrintImage**](InkjetApi.md#printimage) | **POST** /aida/v1/inkjet/print-image |  |
| [**PrintInkjetLayout**](InkjetApi.md#printinkjetlayout) | **POST** /aida/v1/inkjet/layouts/{inkjetLayoutId}/print |  |
| [**PrintJobInstance**](InkjetApi.md#printjobinstance) | **POST** /aida/v1/inkjet/job-template/{jobTemplateId}/instances/{jobInstanceId}/layouts/{inkjetLayoutId}/print | Fetches inkjet perso data for the selected JobInstance from the Data Exchange  Table associated with the selected JobTemplate |
| [**RenameInkjetLayout**](InkjetApi.md#renameinkjetlayout) | **PUT** /aida/v1/inkjet/layouts/{id} |  |
| [**ResetInkjetPrinter**](InkjetApi.md#resetinkjetprinter) | **POST** /aida/v1/inkjet/reset |  |
| [**Resolution**](InkjetApi.md#resolution) | **GET** /aida/v1/inkjet/board/resolution |  |
| [**SetCleaningConfiguration**](InkjetApi.md#setcleaningconfiguration) | **POST** /aida/v1/inkjet/cleaning/configuration | Writes configuration parameters in the database and applies parameters to the XEB00011. |
| [**SetCuringSettings**](InkjetApi.md#setcuringsettings) | **POST** /aida/v1/inkjet/settings/curing-settings |  |
| [**SetHeaterTemperature**](InkjetApi.md#setheatertemperature) | **POST** /aida/v1/inkjet/settings/heater-temperature |  |
| [**SetPinningSettings**](InkjetApi.md#setpinningsettings) | **POST** /aida/v1/inkjet/settings/pinning-settings |  |
| [**SetPrintSettings**](InkjetApi.md#setprintsettings) | **POST** /aida/v1/inkjet/settings/print-settings |  |
| [**Shutdown**](InkjetApi.md#shutdown) | **POST** /aida/v1/inkjet/shutdown |  |
| [**StartInkEmptyingCycle**](InkjetApi.md#startinkemptyingcycle) | **POST** /aida/v1/inkjet/ink-emptying/start |  |
| [**StopCurrentCycle**](InkjetApi.md#stopcurrentcycle) | **POST** /aida/v1/inkjet/current-cycle/stop |  |
| [**ToggleCapping**](InkjetApi.md#togglecapping) | **POST** /aida/v1/inkjet/cleaning/toggle-capping |  |
| [**ToggleCappingPump**](InkjetApi.md#togglecappingpump) | **POST** /aida/v1/inkjet/cleaning/toggle-capping-pump |  |
| [**ToggleInkPriming**](InkjetApi.md#toggleinkpriming) | **POST** /aida/v1/inkjet/cleaning/toggle-ink-priming |  |
| [**VacuumTest**](InkjetApi.md#vacuumtest) | **POST** /aida/v1/inkjet/vacuum-test |  |
| [**ValidateInkjetLayoutName**](InkjetApi.md#validateinkjetlayoutname) | **POST** /aida/v1/inkjet/layouts/validate-name |  |

<a name="action"></a>
# **Action**
> InkjetPrinterActionResult Action ()

Passes the wiper on the printhead

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
    public class ActionExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                // Passes the wiper on the printhead
                InkjetPrinterActionResult result = apiInstance.Action();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.Action: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Passes the wiper on the printhead
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.ActionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ActionWithHttpInfo: " + e.Message);
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

<a name="addentitytoinkjetlayout"></a>
# **AddEntityToInkjetLayout**
> void AddEntityToInkjetLayout (int inkjetLayoutId, string entityName = null, int? xPosition = null, int? yPosition = null, List<FileParameter> imageFile = null)



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
    public class AddEntityToInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutId = 56;  // int | 
            var entityName = "entityName_example";  // string |  (optional) 
            var xPosition = 56;  // int? |  (optional) 
            var yPosition = 56;  // int? |  (optional) 
            var imageFile = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                apiInstance.AddEntityToInkjetLayout(inkjetLayoutId, entityName, xPosition, yPosition, imageFile);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AddEntityToInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddEntityToInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AddEntityToInkjetLayoutWithHttpInfo(inkjetLayoutId, entityName, xPosition, yPosition, imageFile);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AddEntityToInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutId** | **int** |  |  |
| **entityName** | **string** |  | [optional]  |
| **xPosition** | **int?** |  | [optional]  |
| **yPosition** | **int?** |  | [optional]  |
| **imageFile** | **List&lt;FileParameter&gt;** |  | [optional]  |

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

<a name="aidav1inkjetboardcpuresetpost"></a>
# **AidaV1InkjetBoardCpuResetPost**
> XPrintModuleState AidaV1InkjetBoardCpuResetPost ()



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
    public class AidaV1InkjetBoardCpuResetPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                XPrintModuleState result = apiInstance.AidaV1InkjetBoardCpuResetPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetBoardCpuResetPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetBoardCpuResetPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<XPrintModuleState> response = apiInstance.AidaV1InkjetBoardCpuResetPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetBoardCpuResetPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**XPrintModuleState**](XPrintModuleState.md)

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

<a name="aidav1inkjetjobpreparepost"></a>
# **AidaV1InkjetJobPreparePost**
> PrintContext AidaV1InkjetJobPreparePost (PrintQuality? printQuality = null)



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
    public class AidaV1InkjetJobPreparePostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var printQuality = (PrintQuality) "Draft";  // PrintQuality? |  (optional) 

            try
            {
                PrintContext result = apiInstance.AidaV1InkjetJobPreparePost(printQuality);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetJobPreparePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetJobPreparePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrintContext> response = apiInstance.AidaV1InkjetJobPreparePostWithHttpInfo(printQuality);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetJobPreparePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **printQuality** | **PrintQuality?** |  | [optional]  |

### Return type

[**PrintContext**](PrintContext.md)

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

<a name="aidav1inkjetjobtranslatepost"></a>
# **AidaV1InkjetJobTranslatePost**
> void AidaV1InkjetJobTranslatePost (float? x = null, float? y = null)



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
    public class AidaV1InkjetJobTranslatePostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var x = 3.4F;  // float? |  (optional) 
            var y = 3.4F;  // float? |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetJobTranslatePost(x, y);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetJobTranslatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetJobTranslatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetJobTranslatePostWithHttpInfo(x, y);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetJobTranslatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **x** | **float?** |  | [optional]  |
| **y** | **float?** |  | [optional]  |

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

<a name="aidav1inkjetlogerroridput"></a>
# **AidaV1InkjetLogerrorIdPut**
> void AidaV1InkjetLogerrorIdPut (Guid id, AidaLogEntry aidaLogEntry = null)



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
    public class AidaV1InkjetLogerrorIdPutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | 
            var aidaLogEntry = new AidaLogEntry(); // AidaLogEntry |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetLogerrorIdPut(id, aidaLogEntry);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetLogerrorIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetLogerrorIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetLogerrorIdPutWithHttpInfo(id, aidaLogEntry);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetLogerrorIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **aidaLogEntry** | [**AidaLogEntry**](AidaLogEntry.md) |  | [optional]  |

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

<a name="aidav1inkjetlogerrorpost"></a>
# **AidaV1InkjetLogerrorPost**
> void AidaV1InkjetLogerrorPost (AidaLogEntry aidaLogEntry = null)



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
    public class AidaV1InkjetLogerrorPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var aidaLogEntry = new AidaLogEntry(); // AidaLogEntry |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetLogerrorPost(aidaLogEntry);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetLogerrorPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetLogerrorPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetLogerrorPostWithHttpInfo(aidaLogEntry);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetLogerrorPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aidaLogEntry** | [**AidaLogEntry**](AidaLogEntry.md) |  | [optional]  |

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

<a name="aidav1inkjetprintstatusget"></a>
# **AidaV1InkjetPrintStatusGet**
> PrintStatus AidaV1InkjetPrintStatusGet ()



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
    public class AidaV1InkjetPrintStatusGetExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                PrintStatus result = apiInstance.AidaV1InkjetPrintStatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetPrintStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetPrintStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrintStatus> response = apiInstance.AidaV1InkjetPrintStatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetPrintStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PrintStatus**](PrintStatus.md)

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

<a name="aidav1inkjetprintheadmovetoprintareapost"></a>
# **AidaV1InkjetPrintheadMoveToPrintareaPost**
> void AidaV1InkjetPrintheadMoveToPrintareaPost ()



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
    public class AidaV1InkjetPrintheadMoveToPrintareaPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.AidaV1InkjetPrintheadMoveToPrintareaPost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetPrintheadMoveToPrintareaPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetPrintheadMoveToPrintareaPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetPrintheadMoveToPrintareaPostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetPrintheadMoveToPrintareaPostWithHttpInfo: " + e.Message);
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

<a name="aidav1inkjetsetprintheadoffsetpost"></a>
# **AidaV1InkjetSetPrintheadOffsetPost**
> void AidaV1InkjetSetPrintheadOffsetPost (int? x = null)



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
    public class AidaV1InkjetSetPrintheadOffsetPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var x = 56;  // int? |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetSetPrintheadOffsetPost(x);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetSetPrintheadOffsetPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetSetPrintheadOffsetPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetSetPrintheadOffsetPostWithHttpInfo(x);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetSetPrintheadOffsetPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **x** | **int?** |  | [optional]  |

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

<a name="aidav1inkjetstartprintpost"></a>
# **AidaV1InkjetStartPrintPost**
> void AidaV1InkjetStartPrintPost (int? x = null, PrintCycleModes? modes = null)



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
    public class AidaV1InkjetStartPrintPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var x = 56;  // int? |  (optional) 
            var modes = (PrintCycleModes) "PrintAndLaser";  // PrintCycleModes? |  (optional) 

            try
            {
                apiInstance.AidaV1InkjetStartPrintPost(x, modes);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetStartPrintPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetStartPrintPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetStartPrintPostWithHttpInfo(x, modes);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetStartPrintPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **x** | **int?** |  | [optional]  |
| **modes** | **PrintCycleModes?** |  | [optional]  |

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

<a name="aidav1inkjettransportdebugpost"></a>
# **AidaV1InkjetTransportDebugPost**
> void AidaV1InkjetTransportDebugPost ()



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
    public class AidaV1InkjetTransportDebugPostExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.AidaV1InkjetTransportDebugPost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.AidaV1InkjetTransportDebugPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1InkjetTransportDebugPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AidaV1InkjetTransportDebugPostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.AidaV1InkjetTransportDebugPostWithHttpInfo: " + e.Message);
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

<a name="closejob"></a>
# **CloseJob**
> void CloseJob ()



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
    public class CloseJobExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.CloseJob();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.CloseJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloseJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CloseJobWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.CloseJobWithHttpInfo: " + e.Message);
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

<a name="createinkjetlayout"></a>
# **CreateInkjetLayout**
> int CreateInkjetLayout (string inkjetLayoutName)



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
    public class CreateInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutName = "inkjetLayoutName_example";  // string | 

            try
            {
                int result = apiInstance.CreateInkjetLayout(inkjetLayoutName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.CreateInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<int> response = apiInstance.CreateInkjetLayoutWithHttpInfo(inkjetLayoutName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.CreateInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutName** | **string** |  |  |

### Return type

**int**

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

<a name="createnewjob"></a>
# **CreateNewJob**
> void CreateNewJob ()



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
    public class CreateNewJobExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.CreateNewJob();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.CreateNewJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.CreateNewJobWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.CreateNewJobWithHttpInfo: " + e.Message);
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

<a name="deleteinkjetlayout"></a>
# **DeleteInkjetLayout**
> void DeleteInkjetLayout (int id)



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
    public class DeleteInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 

            try
            {
                apiInstance.DeleteInkjetLayout(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.DeleteInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DeleteInkjetLayoutWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.DeleteInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

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

<a name="disablevirtualprintsignal"></a>
# **DisableVirtualPrintSignal**
> void DisableVirtualPrintSignal ()



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
    public class DisableVirtualPrintSignalExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.DisableVirtualPrintSignal();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.DisableVirtualPrintSignal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableVirtualPrintSignalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DisableVirtualPrintSignalWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.DisableVirtualPrintSignalWithHttpInfo: " + e.Message);
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

<a name="enablevirtualprintsignal"></a>
# **EnableVirtualPrintSignal**
> void EnableVirtualPrintSignal ()



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
    public class EnableVirtualPrintSignalExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.EnableVirtualPrintSignal();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.EnableVirtualPrintSignal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableVirtualPrintSignalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.EnableVirtualPrintSignalWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.EnableVirtualPrintSignalWithHttpInfo: " + e.Message);
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

<a name="entermaintenancemode"></a>
# **EnterMaintenanceMode**
> InkjetPrinterActionResult EnterMaintenanceMode ()



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
    public class EnterMaintenanceModeExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetPrinterActionResult result = apiInstance.EnterMaintenanceMode();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.EnterMaintenanceMode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnterMaintenanceModeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.EnterMaintenanceModeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.EnterMaintenanceModeWithHttpInfo: " + e.Message);
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

<a name="exitmaintenancemode"></a>
# **ExitMaintenanceMode**
> InkjetPrinterActionResult ExitMaintenanceMode ()



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
    public class ExitMaintenanceModeExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetPrinterActionResult result = apiInstance.ExitMaintenanceMode();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ExitMaintenanceMode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExitMaintenanceModeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.ExitMaintenanceModeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ExitMaintenanceModeWithHttpInfo: " + e.Message);
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

<a name="findinkjetlayouts"></a>
# **FindInkjetLayouts**
> SearchInkjetLayoutsResultDto FindInkjetLayouts (bool? includeFile = null, bool? includeEntities = null, int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



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
    public class FindInkjetLayoutsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var includeFile = true;  // bool? |  (optional) 
            var includeEntities = true;  // bool? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                SearchInkjetLayoutsResultDto result = apiInstance.FindInkjetLayouts(includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.FindInkjetLayouts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindInkjetLayoutsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchInkjetLayoutsResultDto> response = apiInstance.FindInkjetLayoutsWithHttpInfo(includeFile, includeEntities, page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.FindInkjetLayoutsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeFile** | **bool?** |  | [optional]  |
| **includeEntities** | **bool?** |  | [optional]  |
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **sortCriteriaPropertyName** | **string** |  | [optional]  |
| **sortCriteriaDirection** | **SortDirection?** |  | [optional]  |

### Return type

[**SearchInkjetLayoutsResultDto**](SearchInkjetLayoutsResultDto.md)

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

<a name="getactiveentities"></a>
# **GetActiveEntities**
> InkjetLayoutDto GetActiveEntities ()



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
    public class GetActiveEntitiesExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetLayoutDto result = apiInstance.GetActiveEntities();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetActiveEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetActiveEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetLayoutDto> response = apiInstance.GetActiveEntitiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetActiveEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InkjetLayoutDto**](InkjetLayoutDto.md)

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

<a name="getassignableinkjetlayoutsbyjobtemplateid"></a>
# **GetAssignableInkjetLayoutsByJobTemplateId**
> SearchInkjetLayoutsResultDto GetAssignableInkjetLayoutsByJobTemplateId (int id, int? page = null, int? pageSize = null, string supportSide = null)



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
    public class GetAssignableInkjetLayoutsByJobTemplateIdExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 15;  // int? |  (optional)  (default to 15)
            var supportSide = "supportSide_example";  // string |  (optional) 

            try
            {
                SearchInkjetLayoutsResultDto result = apiInstance.GetAssignableInkjetLayoutsByJobTemplateId(id, page, pageSize, supportSide);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetAssignableInkjetLayoutsByJobTemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssignableInkjetLayoutsByJobTemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SearchInkjetLayoutsResultDto> response = apiInstance.GetAssignableInkjetLayoutsByJobTemplateIdWithHttpInfo(id, page, pageSize, supportSide);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetAssignableInkjetLayoutsByJobTemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 15] |
| **supportSide** | **string** |  | [optional]  |

### Return type

[**SearchInkjetLayoutsResultDto**](SearchInkjetLayoutsResultDto.md)

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

<a name="getcleaningconfiguration"></a>
# **GetCleaningConfiguration**
> CleaningConfigurationDto GetCleaningConfiguration ()



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
    public class GetCleaningConfigurationExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                CleaningConfigurationDto result = apiInstance.GetCleaningConfiguration();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetCleaningConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCleaningConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CleaningConfigurationDto> response = apiInstance.GetCleaningConfigurationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetCleaningConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CleaningConfigurationDto**](CleaningConfigurationDto.md)

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

<a name="getcuringsettings"></a>
# **GetCuringSettings**
> CuringSettingsDto GetCuringSettings ()



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
    public class GetCuringSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                CuringSettingsDto result = apiInstance.GetCuringSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetCuringSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCuringSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CuringSettingsDto> response = apiInstance.GetCuringSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetCuringSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CuringSettingsDto**](CuringSettingsDto.md)

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

<a name="getheaterstemperature"></a>
# **GetHeatersTemperature**
> InkjetTemperaturesDto GetHeatersTemperature ()



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
    public class GetHeatersTemperatureExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetTemperaturesDto result = apiInstance.GetHeatersTemperature();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetHeatersTemperature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHeatersTemperatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetTemperaturesDto> response = apiInstance.GetHeatersTemperatureWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetHeatersTemperatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InkjetTemperaturesDto**](InkjetTemperaturesDto.md)

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

<a name="getinkjetmaintenancestatus"></a>
# **GetInkjetMaintenanceStatus**
> InkjetMaintenanceStatusDto GetInkjetMaintenanceStatus ()



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
    public class GetInkjetMaintenanceStatusExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetMaintenanceStatusDto result = apiInstance.GetInkjetMaintenanceStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetInkjetMaintenanceStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInkjetMaintenanceStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetMaintenanceStatusDto> response = apiInstance.GetInkjetMaintenanceStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetInkjetMaintenanceStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InkjetMaintenanceStatusDto**](InkjetMaintenanceStatusDto.md)

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

<a name="getpinningsettings"></a>
# **GetPinningSettings**
> PinningSettingsDto GetPinningSettings ()



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
    public class GetPinningSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                PinningSettingsDto result = apiInstance.GetPinningSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetPinningSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPinningSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PinningSettingsDto> response = apiInstance.GetPinningSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetPinningSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PinningSettingsDto**](PinningSettingsDto.md)

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

<a name="getprintlayoutpreview"></a>
# **GetPrintLayoutPreview**
> void GetPrintLayoutPreview ()



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
    public class GetPrintLayoutPreviewExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetPrintLayoutPreview();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetPrintLayoutPreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrintLayoutPreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetPrintLayoutPreviewWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetPrintLayoutPreviewWithHttpInfo: " + e.Message);
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

<a name="getprinterprintsettings"></a>
# **GetPrinterPrintSettings**
> PrintSettingsDto GetPrinterPrintSettings ()



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
    public class GetPrinterPrintSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                PrintSettingsDto result = apiInstance.GetPrinterPrintSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetPrinterPrintSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrinterPrintSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrintSettingsDto> response = apiInstance.GetPrinterPrintSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetPrinterPrintSettingsWithHttpInfo: " + e.Message);
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

<a name="getsupportprintmethods"></a>
# **GetSupportPrintMethods**
> List&lt;GenericCycleTypes&gt; GetSupportPrintMethods ()



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
    public class GetSupportPrintMethodsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                List<GenericCycleTypes> result = apiInstance.GetSupportPrintMethods();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetSupportPrintMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSupportPrintMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<GenericCycleTypes>> response = apiInstance.GetSupportPrintMethodsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetSupportPrintMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GenericCycleTypes&gt;**](GenericCycleTypes.md)

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

<a name="getvacuumpressure"></a>
# **GetVacuumPressure**
> float GetVacuumPressure ()



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
    public class GetVacuumPressureExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                float result = apiInstance.GetVacuumPressure();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetVacuumPressure: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVacuumPressureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<float> response = apiInstance.GetVacuumPressureWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetVacuumPressureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a name="getxprintmodulestate"></a>
# **GetXPrintModuleState**
> XPrintModuleStateDto GetXPrintModuleState ()



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
    public class GetXPrintModuleStateExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                XPrintModuleStateDto result = apiInstance.GetXPrintModuleState();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetXPrintModuleState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetXPrintModuleStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<XPrintModuleStateDto> response = apiInstance.GetXPrintModuleStateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetXPrintModuleStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**XPrintModuleStateDto**](XPrintModuleStateDto.md)

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

<a name="getxprintstate"></a>
# **GetXPrintState**
> PrinterStateDto GetXPrintState ()



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
    public class GetXPrintStateExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                PrinterStateDto result = apiInstance.GetXPrintState();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.GetXPrintState: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetXPrintStateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrinterStateDto> response = apiInstance.GetXPrintStateWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.GetXPrintStateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PrinterStateDto**](PrinterStateDto.md)

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

<a name="inkjetlayoutpreview"></a>
# **InkjetLayoutPreview**
> void InkjetLayoutPreview (int inkjetLayoutId)



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
    public class InkjetLayoutPreviewExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutId = 56;  // int | 

            try
            {
                apiInstance.InkjetLayoutPreview(inkjetLayoutId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.InkjetLayoutPreview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InkjetLayoutPreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.InkjetLayoutPreviewWithHttpInfo(inkjetLayoutId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.InkjetLayoutPreviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutId** | **int** |  |  |

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

<a name="insertimage"></a>
# **InsertImage**
> void InsertImage (string entityName = null, int? x = null, int? y = null, int? pageId = null, List<FileParameter> images = null)



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
    public class InsertImageExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var entityName = "entityName_example";  // string |  (optional) 
            var x = 56;  // int? |  (optional) 
            var y = 56;  // int? |  (optional) 
            var pageId = 56;  // int? |  (optional) 
            var images = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                apiInstance.InsertImage(entityName, x, y, pageId, images);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.InsertImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InsertImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.InsertImageWithHttpInfo(entityName, x, y, pageId, images);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.InsertImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  | [optional]  |
| **x** | **int?** |  | [optional]  |
| **y** | **int?** |  | [optional]  |
| **pageId** | **int?** |  | [optional]  |
| **images** | **List&lt;FileParameter&gt;** |  | [optional]  |

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

<a name="isprinting"></a>
# **IsPrinting**
> void IsPrinting ()



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
    public class IsPrintingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.IsPrinting();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.IsPrinting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsPrintingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.IsPrintingWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.IsPrintingWithHttpInfo: " + e.Message);
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

<a name="isready"></a>
# **IsReady**
> void IsReady ()



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
    public class IsReadyExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.IsReady();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.IsReady: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsReadyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.IsReadyWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.IsReadyWithHttpInfo: " + e.Message);
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

<a name="jobinsertimage"></a>
# **JobInsertImage**
> void JobInsertImage (string imagePath = null, int? angle = null, int? x = null, int? y = null)



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
    public class JobInsertImageExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var imagePath = "imagePath_example";  // string |  (optional) 
            var angle = 56;  // int? |  (optional) 
            var x = 56;  // int? |  (optional) 
            var y = 56;  // int? |  (optional) 

            try
            {
                apiInstance.JobInsertImage(imagePath, angle, x, y);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.JobInsertImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JobInsertImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.JobInsertImageWithHttpInfo(imagePath, angle, x, y);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.JobInsertImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imagePath** | **string** |  | [optional]  |
| **angle** | **int?** |  | [optional]  |
| **x** | **int?** |  | [optional]  |
| **y** | **int?** |  | [optional]  |

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

<a name="loadinkjetlayout"></a>
# **LoadInkjetLayout**
> void LoadInkjetLayout (int inkjetLayoutId)



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
    public class LoadInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutId = 56;  // int | 

            try
            {
                apiInstance.LoadInkjetLayout(inkjetLayoutId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.LoadInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LoadInkjetLayoutWithHttpInfo(inkjetLayoutId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.LoadInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutId** | **int** |  |  |

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

<a name="loadjobtemplateinkjetlayout"></a>
# **LoadJobTemplateInkjetLayout**
> void LoadJobTemplateInkjetLayout (int jobTemplateInkjetLayoutId)



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
    public class LoadJobTemplateInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var jobTemplateInkjetLayoutId = 56;  // int | 

            try
            {
                apiInstance.LoadJobTemplateInkjetLayout(jobTemplateInkjetLayoutId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.LoadJobTemplateInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadJobTemplateInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LoadJobTemplateInkjetLayoutWithHttpInfo(jobTemplateInkjetLayoutId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.LoadJobTemplateInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateInkjetLayoutId** | **int** |  |  |

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

<a name="moveheadtocapping"></a>
# **MoveHeadToCapping**
> void MoveHeadToCapping ()



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
    public class MoveHeadToCappingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.MoveHeadToCapping();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.MoveHeadToCapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveHeadToCappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MoveHeadToCappingWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.MoveHeadToCappingWithHttpInfo: " + e.Message);
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

<a name="moveheadtomaintenance"></a>
# **MoveHeadToMaintenance**
> InkjetPrinterActionResult MoveHeadToMaintenance ()



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
    public class MoveHeadToMaintenanceExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetPrinterActionResult result = apiInstance.MoveHeadToMaintenance();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.MoveHeadToMaintenance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveHeadToMaintenanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.MoveHeadToMaintenanceWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.MoveHeadToMaintenanceWithHttpInfo: " + e.Message);
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

<a name="moveheadtoparking"></a>
# **MoveHeadToParking**
> void MoveHeadToParking ()



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
    public class MoveHeadToParkingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.MoveHeadToParking();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.MoveHeadToParking: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveHeadToParkingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MoveHeadToParkingWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.MoveHeadToParkingWithHttpInfo: " + e.Message);
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

<a name="newjob"></a>
# **NewJob**
> void NewJob (string imagePath = null)



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
    public class NewJobExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var imagePath = "imagePath_example";  // string |  (optional) 

            try
            {
                apiInstance.NewJob(imagePath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.NewJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.NewJobWithHttpInfo(imagePath);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.NewJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imagePath** | **string** |  | [optional]  |

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

<a name="nozzlecheck"></a>
# **NozzleCheck**
> InkjetPrinterActionResult NozzleCheck ()

Executes nozzle check by printing a 800x1000 image  With all channels enabled + CMYK Direct

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
    public class NozzleCheckExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                // Executes nozzle check by printing a 800x1000 image  With all channels enabled + CMYK Direct
                InkjetPrinterActionResult result = apiInstance.NozzleCheck();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.NozzleCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NozzleCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Executes nozzle check by printing a 800x1000 image  With all channels enabled + CMYK Direct
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.NozzleCheckWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.NozzleCheckWithHttpInfo: " + e.Message);
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

<a name="performdeepcleaning"></a>
# **PerformDeepCleaning**
> void PerformDeepCleaning (int? strongPurgeCount = null, int? normalPurgeCount = null, bool? includeLightCleaning = null)



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
    public class PerformDeepCleaningExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var strongPurgeCount = 1;  // int? |  (optional)  (default to 1)
            var normalPurgeCount = 1;  // int? |  (optional)  (default to 1)
            var includeLightCleaning = true;  // bool? |  (optional)  (default to true)

            try
            {
                apiInstance.PerformDeepCleaning(strongPurgeCount, normalPurgeCount, includeLightCleaning);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformDeepCleaning: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformDeepCleaningWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformDeepCleaningWithHttpInfo(strongPurgeCount, normalPurgeCount, includeLightCleaning);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformDeepCleaningWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **strongPurgeCount** | **int?** |  | [optional] [default to 1] |
| **normalPurgeCount** | **int?** |  | [optional] [default to 1] |
| **includeLightCleaning** | **bool?** |  | [optional] [default to true] |

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

<a name="performlightcleaning"></a>
# **PerformLightCleaning**
> void PerformLightCleaning (bool? wipeBefore = null)



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
    public class PerformLightCleaningExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var wipeBefore = true;  // bool? |  (optional)  (default to true)

            try
            {
                apiInstance.PerformLightCleaning(wipeBefore);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformLightCleaning: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformLightCleaningWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformLightCleaningWithHttpInfo(wipeBefore);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformLightCleaningWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wipeBefore** | **bool?** |  | [optional] [default to true] |

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

<a name="performnormalcleaning"></a>
# **PerformNormalCleaning**
> void PerformNormalCleaning (int? purgeCount = null, bool? includeLightCleaning = null)



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
    public class PerformNormalCleaningExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var purgeCount = 1;  // int? |  (optional)  (default to 1)
            var includeLightCleaning = true;  // bool? |  (optional)  (default to true)

            try
            {
                apiInstance.PerformNormalCleaning(purgeCount, includeLightCleaning);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformNormalCleaning: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformNormalCleaningWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformNormalCleaningWithHttpInfo(purgeCount, includeLightCleaning);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformNormalCleaningWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **purgeCount** | **int?** |  | [optional] [default to 1] |
| **includeLightCleaning** | **bool?** |  | [optional] [default to true] |

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

<a name="performpurge"></a>
# **PerformPurge**
> void PerformPurge (bool? useStrong = null)



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
    public class PerformPurgeExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var useStrong = false;  // bool? |  (optional)  (default to false)

            try
            {
                apiInstance.PerformPurge(useStrong);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformPurge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformPurgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformPurgeWithHttpInfo(useStrong);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformPurgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **useStrong** | **bool?** |  | [optional] [default to false] |

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

<a name="performspitting"></a>
# **PerformSpitting**
> void PerformSpitting (int? firingSpeed = null, int? numSpits = null)



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
    public class PerformSpittingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var firingSpeed = 56;  // int? |  (optional) 
            var numSpits = 56;  // int? |  (optional) 

            try
            {
                apiInstance.PerformSpitting(firingSpeed, numSpits);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformSpitting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformSpittingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformSpittingWithHttpInfo(firingSpeed, numSpits);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformSpittingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firingSpeed** | **int?** |  | [optional]  |
| **numSpits** | **int?** |  | [optional]  |

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

<a name="performwiping"></a>
# **PerformWiping**
> void PerformWiping ()



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
    public class PerformWipingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.PerformWiping();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PerformWiping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PerformWipingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PerformWipingWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PerformWipingWithHttpInfo: " + e.Message);
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

<a name="print"></a>
# **Print**
> InkjetPrinterActionResult Print (int? offsetX = null, int? offsetY = null, int? pageId = null, int? printSettingsId = null, PrintQuality? printQuality = null, MultiPassMaskType? maskType = null, PrintCycleModes? printCycle = null)

Handles the print process sending commands to APRINT for loading  and transferring images to the printhead manager board and moves  the axis to trigger the actual print of images

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
    public class PrintExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var offsetX = 56;  // int? |  (optional) 
            var offsetY = 56;  // int? |  (optional) 
            var pageId = 56;  // int? |  (optional) 
            var printSettingsId = 56;  // int? |  (optional) 
            var printQuality = (PrintQuality) "Draft";  // PrintQuality? |  (optional) 
            var maskType = (MultiPassMaskType) "Static";  // MultiPassMaskType? |  (optional) 
            var printCycle = (PrintCycleModes) "PrintAndLaser";  // PrintCycleModes? |  (optional) 

            try
            {
                // Handles the print process sending commands to APRINT for loading  and transferring images to the printhead manager board and moves  the axis to trigger the actual print of images
                InkjetPrinterActionResult result = apiInstance.Print(offsetX, offsetY, pageId, printSettingsId, printQuality, maskType, printCycle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.Print: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Handles the print process sending commands to APRINT for loading  and transferring images to the printhead manager board and moves  the axis to trigger the actual print of images
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.PrintWithHttpInfo(offsetX, offsetY, pageId, printSettingsId, printQuality, maskType, printCycle);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PrintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offsetX** | **int?** |  | [optional]  |
| **offsetY** | **int?** |  | [optional]  |
| **pageId** | **int?** |  | [optional]  |
| **printSettingsId** | **int?** |  | [optional]  |
| **printQuality** | **PrintQuality?** |  | [optional]  |
| **maskType** | **MultiPassMaskType?** |  | [optional]  |
| **printCycle** | **PrintCycleModes?** |  | [optional]  |

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

<a name="printimage"></a>
# **PrintImage**
> InkjetPrinterActionResult PrintImage (int? x = null, int? y = null, int? dataPage = null, PrintQuality? printQuality = null, MultiPassMaskType? maskType = null, BiLevelDropSize? biLevelDropSize = null, bool? cmykDirect = null, FileParameter image = null)



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
    public class PrintImageExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var x = 56;  // int? |  (optional) 
            var y = 56;  // int? |  (optional) 
            var dataPage = 1;  // int? |  (optional)  (default to 1)
            var printQuality = (PrintQuality) "Draft";  // PrintQuality? |  (optional) 
            var maskType = (MultiPassMaskType) "Static";  // MultiPassMaskType? |  (optional) 
            var biLevelDropSize = (BiLevelDropSize) "One";  // BiLevelDropSize? |  (optional) 
            var cmykDirect = false;  // bool? |  (optional)  (default to false)
            var image = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter |  (optional) 

            try
            {
                InkjetPrinterActionResult result = apiInstance.PrintImage(x, y, dataPage, printQuality, maskType, biLevelDropSize, cmykDirect, image);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PrintImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.PrintImageWithHttpInfo(x, y, dataPage, printQuality, maskType, biLevelDropSize, cmykDirect, image);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PrintImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **x** | **int?** |  | [optional]  |
| **y** | **int?** |  | [optional]  |
| **dataPage** | **int?** |  | [optional] [default to 1] |
| **printQuality** | **PrintQuality?** |  | [optional]  |
| **maskType** | **MultiPassMaskType?** |  | [optional]  |
| **biLevelDropSize** | **BiLevelDropSize?** |  | [optional]  |
| **cmykDirect** | **bool?** |  | [optional] [default to false] |
| **image** | **FileParameter****FileParameter** |  | [optional]  |

### Return type

[**InkjetPrinterActionResult**](InkjetPrinterActionResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="printinkjetlayout"></a>
# **PrintInkjetLayout**
> InkjetPrinterActionResult PrintInkjetLayout (int inkjetLayoutId, int? offsetX = null, int? offsetY = null)



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
    public class PrintInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var inkjetLayoutId = 56;  // int | 
            var offsetX = 56;  // int? |  (optional) 
            var offsetY = 56;  // int? |  (optional) 

            try
            {
                InkjetPrinterActionResult result = apiInstance.PrintInkjetLayout(inkjetLayoutId, offsetX, offsetY);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PrintInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.PrintInkjetLayoutWithHttpInfo(inkjetLayoutId, offsetX, offsetY);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PrintInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inkjetLayoutId** | **int** |  |  |
| **offsetX** | **int?** |  | [optional]  |
| **offsetY** | **int?** |  | [optional]  |

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

<a name="printjobinstance"></a>
# **PrintJobInstance**
> InkjetPrinterActionResult PrintJobInstance (int jobTemplateId, int inkjetLayoutId, int jobInstanceId, PrintCycleModes? printCycleMode = null, bool? skipEntityUpdates = null, float? offsetXmm = null, float? offsetYmm = null)

Fetches inkjet perso data for the selected JobInstance from the Data Exchange  Table associated with the selected JobTemplate

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
    public class PrintJobInstanceExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 
            var inkjetLayoutId = 56;  // int | 
            var jobInstanceId = 56;  // int | 
            var printCycleMode = (PrintCycleModes) "PrintAndLaser";  // PrintCycleModes? |  (optional) 
            var skipEntityUpdates = false;  // bool? |  (optional)  (default to false)
            var offsetXmm = 0F;  // float? |  (optional)  (default to 0F)
            var offsetYmm = 0F;  // float? |  (optional)  (default to 0F)

            try
            {
                // Fetches inkjet perso data for the selected JobInstance from the Data Exchange  Table associated with the selected JobTemplate
                InkjetPrinterActionResult result = apiInstance.PrintJobInstance(jobTemplateId, inkjetLayoutId, jobInstanceId, printCycleMode, skipEntityUpdates, offsetXmm, offsetYmm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.PrintJobInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintJobInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches inkjet perso data for the selected JobInstance from the Data Exchange  Table associated with the selected JobTemplate
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.PrintJobInstanceWithHttpInfo(jobTemplateId, inkjetLayoutId, jobInstanceId, printCycleMode, skipEntityUpdates, offsetXmm, offsetYmm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.PrintJobInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |
| **inkjetLayoutId** | **int** |  |  |
| **jobInstanceId** | **int** |  |  |
| **printCycleMode** | **PrintCycleModes?** |  | [optional]  |
| **skipEntityUpdates** | **bool?** |  | [optional] [default to false] |
| **offsetXmm** | **float?** |  | [optional] [default to 0F] |
| **offsetYmm** | **float?** |  | [optional] [default to 0F] |

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

<a name="renameinkjetlayout"></a>
# **RenameInkjetLayout**
> InkjetLayoutDto RenameInkjetLayout (int id, string name = null)



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
    public class RenameInkjetLayoutExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | 
            var name = "name_example";  // string |  (optional) 

            try
            {
                InkjetLayoutDto result = apiInstance.RenameInkjetLayout(id, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.RenameInkjetLayout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameInkjetLayoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetLayoutDto> response = apiInstance.RenameInkjetLayoutWithHttpInfo(id, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.RenameInkjetLayoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **name** | **string** |  | [optional]  |

### Return type

[**InkjetLayoutDto**](InkjetLayoutDto.md)

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

<a name="resetinkjetprinter"></a>
# **ResetInkjetPrinter**
> void ResetInkjetPrinter ()



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
    public class ResetInkjetPrinterExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ResetInkjetPrinter();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ResetInkjetPrinter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetInkjetPrinterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ResetInkjetPrinterWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ResetInkjetPrinterWithHttpInfo: " + e.Message);
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

<a name="resolution"></a>
# **Resolution**
> void Resolution ()



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
    public class ResolutionExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.Resolution();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.Resolution: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ResolutionWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ResolutionWithHttpInfo: " + e.Message);
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

<a name="setcleaningconfiguration"></a>
# **SetCleaningConfiguration**
> void SetCleaningConfiguration (CleaningConfigurationDto cleaningConfigurationDto = null)

Writes configuration parameters in the database and applies parameters to the XEB00011.

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
    public class SetCleaningConfigurationExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var cleaningConfigurationDto = new CleaningConfigurationDto(); // CleaningConfigurationDto |  (optional) 

            try
            {
                // Writes configuration parameters in the database and applies parameters to the XEB00011.
                apiInstance.SetCleaningConfiguration(cleaningConfigurationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetCleaningConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetCleaningConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Writes configuration parameters in the database and applies parameters to the XEB00011.
    apiInstance.SetCleaningConfigurationWithHttpInfo(cleaningConfigurationDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetCleaningConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cleaningConfigurationDto** | [**CleaningConfigurationDto**](CleaningConfigurationDto.md) |  | [optional]  |

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

<a name="setcuringsettings"></a>
# **SetCuringSettings**
> void SetCuringSettings (bool? curingEnabled = null, bool? dualCuringEnabled = null, bool? fumeExtractorEnabled = null, int? level = null, int? speed = null)



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
    public class SetCuringSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var curingEnabled = true;  // bool? |  (optional) 
            var dualCuringEnabled = true;  // bool? |  (optional) 
            var fumeExtractorEnabled = true;  // bool? |  (optional) 
            var level = 56;  // int? |  (optional) 
            var speed = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetCuringSettings(curingEnabled, dualCuringEnabled, fumeExtractorEnabled, level, speed);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetCuringSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetCuringSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetCuringSettingsWithHttpInfo(curingEnabled, dualCuringEnabled, fumeExtractorEnabled, level, speed);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetCuringSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **curingEnabled** | **bool?** |  | [optional]  |
| **dualCuringEnabled** | **bool?** |  | [optional]  |
| **fumeExtractorEnabled** | **bool?** |  | [optional]  |
| **level** | **int?** |  | [optional]  |
| **speed** | **int?** |  | [optional]  |

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

<a name="setheatertemperature"></a>
# **SetHeaterTemperature**
> void SetHeaterTemperature (int? heaterTemperature = null)



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
    public class SetHeaterTemperatureExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var heaterTemperature = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetHeaterTemperature(heaterTemperature);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetHeaterTemperature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetHeaterTemperatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetHeaterTemperatureWithHttpInfo(heaterTemperature);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetHeaterTemperatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **heaterTemperature** | **int?** |  | [optional]  |

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

<a name="setpinningsettings"></a>
# **SetPinningSettings**
> void SetPinningSettings (bool? enabled = null, int? level = null)



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
    public class SetPinningSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var enabled = true;  // bool? |  (optional) 
            var level = 56;  // int? |  (optional) 

            try
            {
                apiInstance.SetPinningSettings(enabled, level);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetPinningSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPinningSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetPinningSettingsWithHttpInfo(enabled, level);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetPinningSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enabled** | **bool?** |  | [optional]  |
| **level** | **int?** |  | [optional]  |

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

<a name="setprintsettings"></a>
# **SetPrintSettings**
> void SetPrintSettings (int? printSpeed = null, bool? verticalMirrorEnabled = null, bool? horizontalMirrorEnabled = null, bool? cMYKDirectEnabled = null, bool? enableC = null, bool? enableM = null, bool? enableY = null, bool? enableK = null, int? dropSize = null, int? dataPageId = null, PrintQuality? printQuality = null)



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
    public class SetPrintSettingsExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
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
                apiInstance.SetPrintSettings(printSpeed, verticalMirrorEnabled, horizontalMirrorEnabled, cMYKDirectEnabled, enableC, enableM, enableY, enableK, dropSize, dataPageId, printQuality);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.SetPrintSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPrintSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetPrintSettingsWithHttpInfo(printSpeed, verticalMirrorEnabled, horizontalMirrorEnabled, cMYKDirectEnabled, enableC, enableM, enableY, enableK, dropSize, dataPageId, printQuality);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.SetPrintSettingsWithHttpInfo: " + e.Message);
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

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shutdown"></a>
# **Shutdown**
> void Shutdown ()



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
    public class ShutdownExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.Shutdown();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.Shutdown: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShutdownWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ShutdownWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ShutdownWithHttpInfo: " + e.Message);
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

<a name="startinkemptyingcycle"></a>
# **StartInkEmptyingCycle**
> void StartInkEmptyingCycle ()



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
    public class StartInkEmptyingCycleExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.StartInkEmptyingCycle();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.StartInkEmptyingCycle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartInkEmptyingCycleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.StartInkEmptyingCycleWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.StartInkEmptyingCycleWithHttpInfo: " + e.Message);
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

<a name="stopcurrentcycle"></a>
# **StopCurrentCycle**
> void StopCurrentCycle ()



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
    public class StopCurrentCycleExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.StopCurrentCycle();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.StopCurrentCycle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StopCurrentCycleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.StopCurrentCycleWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.StopCurrentCycleWithHttpInfo: " + e.Message);
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

<a name="togglecapping"></a>
# **ToggleCapping**
> void ToggleCapping (bool? moveUp = null)



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
    public class ToggleCappingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var moveUp = false;  // bool? |  (optional)  (default to false)

            try
            {
                apiInstance.ToggleCapping(moveUp);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ToggleCapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToggleCappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ToggleCappingWithHttpInfo(moveUp);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ToggleCappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moveUp** | **bool?** |  | [optional] [default to false] |

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

<a name="togglecappingpump"></a>
# **ToggleCappingPump**
> void ToggleCappingPump (bool? stop = null)



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
    public class ToggleCappingPumpExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var stop = true;  // bool? |  (optional)  (default to true)

            try
            {
                apiInstance.ToggleCappingPump(stop);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ToggleCappingPump: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToggleCappingPumpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ToggleCappingPumpWithHttpInfo(stop);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ToggleCappingPumpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stop** | **bool?** |  | [optional] [default to true] |

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

<a name="toggleinkpriming"></a>
# **ToggleInkPriming**
> void ToggleInkPriming (bool? stop = null)



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
    public class ToggleInkPrimingExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var stop = true;  // bool? |  (optional)  (default to true)

            try
            {
                apiInstance.ToggleInkPriming(stop);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ToggleInkPriming: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ToggleInkPrimingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ToggleInkPrimingWithHttpInfo(stop);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ToggleInkPrimingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **stop** | **bool?** |  | [optional] [default to true] |

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

<a name="vacuumtest"></a>
# **VacuumTest**
> InkjetPrinterActionResult VacuumTest ()



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
    public class VacuumTestExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);

            try
            {
                InkjetPrinterActionResult result = apiInstance.VacuumTest();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.VacuumTest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VacuumTestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<InkjetPrinterActionResult> response = apiInstance.VacuumTestWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.VacuumTestWithHttpInfo: " + e.Message);
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

<a name="validateinkjetlayoutname"></a>
# **ValidateInkjetLayoutName**
> NameValidationResultDto ValidateInkjetLayoutName (string scannerId = null, string body = null)



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
    public class ValidateInkjetLayoutNameExample
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
            var apiInstance = new InkjetApi(httpClient, config, httpClientHandler);
            var scannerId = "scannerId_example";  // string |  (optional) 
            var body = "body_example";  // string |  (optional) 

            try
            {
                NameValidationResultDto result = apiInstance.ValidateInkjetLayoutName(scannerId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InkjetApi.ValidateInkjetLayoutName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateInkjetLayoutNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<NameValidationResultDto> response = apiInstance.ValidateInkjetLayoutNameWithHttpInfo(scannerId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InkjetApi.ValidateInkjetLayoutNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scannerId** | **string** |  | [optional]  |
| **body** | **string** |  | [optional]  |

### Return type

[**NameValidationResultDto**](NameValidationResultDto.md)

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


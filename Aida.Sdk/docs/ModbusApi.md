# Aida.Sdk.Api.ModbusApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetModbusClients**](ModbusApi.md#getmodbusclients) | **GET** /aida/v1/modbus/clients |  |
| [**ReadAllRegisters**](ModbusApi.md#readallregisters) | **GET** /aida/v1/modbus/{port}/{slaveIdHex}/registers/all |  |
| [**ReadFloat32Registers**](ModbusApi.md#readfloat32registers) | **POST** /aida/v1/modbus/{port}/read-float32 |  |
| [**ReadHoldingRegisters**](ModbusApi.md#readholdingregisters) | **POST** /aida/v1/modbus/{port}/read-holding-registers |  |
| [**ReadInt16**](ModbusApi.md#readint16) | **POST** /aida/v1/modbus/{port}/read-int16 |  |
| [**ReadInt32**](ModbusApi.md#readint32) | **POST** /aida/v1/modbus/{port}/read-int32 |  |
| [**WriteFloat32**](ModbusApi.md#writefloat32) | **POST** /aida/v1/modbus/{port}/write-float32 |  |
| [**WriteInt16**](ModbusApi.md#writeint16) | **POST** /aida/v1/modbus/{port}/write-int16 |  |
| [**WriteInt32**](ModbusApi.md#writeint32) | **POST** /aida/v1/modbus/{port}/write-int32 |  |
| [**WriteSingleRegister**](ModbusApi.md#writesingleregister) | **POST** /aida/v1/modbus/{port}/write-register |  |
| [**WriteString**](ModbusApi.md#writestring) | **POST** /aida/v1/modbus/{port}/write-multiple-registers |  |

<a name="getmodbusclients"></a>
# **GetModbusClients**
> void GetModbusClients ()



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
    public class GetModbusClientsExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.GetModbusClients();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.GetModbusClients: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetModbusClientsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetModbusClientsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.GetModbusClientsWithHttpInfo: " + e.Message);
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

<a name="readallregisters"></a>
# **ReadAllRegisters**
> List&lt;int&gt; ReadAllRegisters (string slaveIdHex, string port)



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
    public class ReadAllRegistersExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var slaveIdHex = "slaveIdHex_example";  // string | 
            var port = "port_example";  // string | 

            try
            {
                List<int> result = apiInstance.ReadAllRegisters(slaveIdHex, port);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.ReadAllRegisters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadAllRegistersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<int>> response = apiInstance.ReadAllRegistersWithHttpInfo(slaveIdHex, port);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.ReadAllRegistersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slaveIdHex** | **string** |  |  |
| **port** | **string** |  |  |

### Return type

**List<int>**

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

<a name="readfloat32registers"></a>
# **ReadFloat32Registers**
> float ReadFloat32Registers (string port, ReadFieldRequest readFieldRequest = null)



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
    public class ReadFloat32RegistersExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var readFieldRequest = new ReadFieldRequest(); // ReadFieldRequest |  (optional) 

            try
            {
                float result = apiInstance.ReadFloat32Registers(port, readFieldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.ReadFloat32Registers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadFloat32RegistersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<float> response = apiInstance.ReadFloat32RegistersWithHttpInfo(port, readFieldRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.ReadFloat32RegistersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **readFieldRequest** | [**ReadFieldRequest**](ReadFieldRequest.md) |  | [optional]  |

### Return type

**float**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readholdingregisters"></a>
# **ReadHoldingRegisters**
> void ReadHoldingRegisters (string port, ReadHoldingRegistersRequest readHoldingRegistersRequest = null)



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
    public class ReadHoldingRegistersExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var readHoldingRegistersRequest = new ReadHoldingRegistersRequest(); // ReadHoldingRegistersRequest |  (optional) 

            try
            {
                apiInstance.ReadHoldingRegisters(port, readHoldingRegistersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.ReadHoldingRegisters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadHoldingRegistersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ReadHoldingRegistersWithHttpInfo(port, readHoldingRegistersRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.ReadHoldingRegistersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **readHoldingRegistersRequest** | [**ReadHoldingRegistersRequest**](ReadHoldingRegistersRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readint16"></a>
# **ReadInt16**
> int ReadInt16 (string port, ReadFieldRequest readFieldRequest = null)



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
    public class ReadInt16Example
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var readFieldRequest = new ReadFieldRequest(); // ReadFieldRequest |  (optional) 

            try
            {
                int result = apiInstance.ReadInt16(port, readFieldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.ReadInt16: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadInt16WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<int> response = apiInstance.ReadInt16WithHttpInfo(port, readFieldRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.ReadInt16WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **readFieldRequest** | [**ReadFieldRequest**](ReadFieldRequest.md) |  | [optional]  |

### Return type

**int**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readint32"></a>
# **ReadInt32**
> int ReadInt32 (string port, ReadFieldRequest readFieldRequest = null)



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
    public class ReadInt32Example
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var readFieldRequest = new ReadFieldRequest(); // ReadFieldRequest |  (optional) 

            try
            {
                int result = apiInstance.ReadInt32(port, readFieldRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.ReadInt32: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadInt32WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<int> response = apiInstance.ReadInt32WithHttpInfo(port, readFieldRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.ReadInt32WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **readFieldRequest** | [**ReadFieldRequest**](ReadFieldRequest.md) |  | [optional]  |

### Return type

**int**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json, text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writefloat32"></a>
# **WriteFloat32**
> void WriteFloat32 (string port, WriteFloat32Request writeFloat32Request = null)



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
    public class WriteFloat32Example
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var writeFloat32Request = new WriteFloat32Request(); // WriteFloat32Request |  (optional) 

            try
            {
                apiInstance.WriteFloat32(port, writeFloat32Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.WriteFloat32: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteFloat32WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WriteFloat32WithHttpInfo(port, writeFloat32Request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.WriteFloat32WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **writeFloat32Request** | [**WriteFloat32Request**](WriteFloat32Request.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeint16"></a>
# **WriteInt16**
> void WriteInt16 (string port, WriteInt16Request writeInt16Request = null)



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
    public class WriteInt16Example
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var writeInt16Request = new WriteInt16Request(); // WriteInt16Request |  (optional) 

            try
            {
                apiInstance.WriteInt16(port, writeInt16Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.WriteInt16: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteInt16WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WriteInt16WithHttpInfo(port, writeInt16Request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.WriteInt16WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **writeInt16Request** | [**WriteInt16Request**](WriteInt16Request.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeint32"></a>
# **WriteInt32**
> void WriteInt32 (string port, WriteInt32Request writeInt32Request = null)



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
    public class WriteInt32Example
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var writeInt32Request = new WriteInt32Request(); // WriteInt32Request |  (optional) 

            try
            {
                apiInstance.WriteInt32(port, writeInt32Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.WriteInt32: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteInt32WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WriteInt32WithHttpInfo(port, writeInt32Request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.WriteInt32WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **writeInt32Request** | [**WriteInt32Request**](WriteInt32Request.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writesingleregister"></a>
# **WriteSingleRegister**
> void WriteSingleRegister (string port, WriteUInt16Request writeUInt16Request = null)



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
    public class WriteSingleRegisterExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var writeUInt16Request = new WriteUInt16Request(); // WriteUInt16Request |  (optional) 

            try
            {
                apiInstance.WriteSingleRegister(port, writeUInt16Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.WriteSingleRegister: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteSingleRegisterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WriteSingleRegisterWithHttpInfo(port, writeUInt16Request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.WriteSingleRegisterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **writeUInt16Request** | [**WriteUInt16Request**](WriteUInt16Request.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writestring"></a>
# **WriteString**
> void WriteString (string port, WriteMultipleRegistersRequest writeMultipleRegistersRequest = null)



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
    public class WriteStringExample
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
            var apiInstance = new ModbusApi(httpClient, config, httpClientHandler);
            var port = "port_example";  // string | 
            var writeMultipleRegistersRequest = new WriteMultipleRegistersRequest(); // WriteMultipleRegistersRequest |  (optional) 

            try
            {
                apiInstance.WriteString(port, writeMultipleRegistersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ModbusApi.WriteString: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WriteStringWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WriteStringWithHttpInfo(port, writeMultipleRegistersRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ModbusApi.WriteStringWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **port** | **string** |  |  |
| **writeMultipleRegistersRequest** | [**WriteMultipleRegistersRequest**](WriteMultipleRegistersRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


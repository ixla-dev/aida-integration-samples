# Aida.Sdk.Mini.Model.OcrExecutedMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Discriminator** | **string** |  | 
**JobId** | **string** |  | [optional] 
**CorrelationId** | **string** |  | [optional] 
**MessageId** | **string** |  | [optional] 
**WorkflowInstanceId** | **string** |  | [optional] 
**ErrorCode** | [**JobErrorCodes**](JobErrorCodes.md) |  | [optional] 
**MessageType** | [**MessageType**](MessageType.md) |  | [optional] 
**JobStatus** | [**JobStatus**](JobStatus.md) |  | [optional] 
**PersonalizationTasks** | [**List&lt;PersonalizationTask&gt;**](PersonalizationTask.md) |  | [optional] 
**DocumentProduced** | **bool** |  | [optional] 
**Hostname** | **string** |  | [optional] 
**Results** | [**List&lt;RuntimeOcrInspectionResult&gt;**](RuntimeOcrInspectionResult.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


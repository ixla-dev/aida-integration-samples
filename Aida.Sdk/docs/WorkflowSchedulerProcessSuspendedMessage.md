# Aida.Sdk.Model.WorkflowSchedulerProcessSuspendedMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Discriminator** | **string** |  | 
**JobId** | **string** |  | [optional] 
**BatchId** | **string** |  | [optional] 
**CorrelationId** | **string** |  | [optional] 
**MessageId** | **string** |  | [optional] 
**WorkflowInstanceId** | **string** |  | [optional] 
**MessageType** | [**MessageType**](MessageType.md) |  | [optional] 
**JobStatus** | [**JobStatus**](JobStatus.md) |  | [optional] 
**ErrorCode** | [**JobErrorCodes**](JobErrorCodes.md) |  | [optional] 
**AdditionalMetadata** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**PersonalizationTasks** | [**List&lt;PersonalizationTask&gt;**](PersonalizationTask.md) |  | [optional] 
**DocumentProduced** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


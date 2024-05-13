# Aida.Sdk.Model.DiagnosticTaskState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** |  | [optional] 
**Type** | **DiagnosticTaskType** |  | [optional] 
**Activities** | [**List&lt;DiagnosticActivity&gt;**](DiagnosticActivity.md) |  | [optional] 
**IsRunning** | **bool** |  | [optional] [readonly] 
**CurrentActivity** | [**DiagnosticActivity**](DiagnosticActivity.md) |  | [optional] 
**TotalActivitiesCount** | **int** |  | [optional] [readonly] 
**CompletedActivitiesCount** | **int** |  | [optional] [readonly] 
**FailedActivitiesCount** | **int** |  | [optional] [readonly] 
**IdleActivitiesCount** | **int** |  | [optional] [readonly] 
**AverageExecutionTime** | **double** |  | [optional] [readonly] 
**ErrorReason** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Aida.Sdk.Mini.Model.WorkflowInstance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**DefinitionId** | **string** |  | [optional] 
**DefinitionVersionId** | **string** |  | [optional] 
**TenantId** | **string** |  | [optional] 
**_Version** | **int** |  | [optional] 
**WorkflowStatus** | **WorkflowStatus** |  | [optional] 
**CorrelationId** | **string** |  | [optional] 
**ContextType** | **string** |  | [optional] 
**ContextId** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**CreatedAt** | **DateTime?** |  | [optional] 
**LastExecutedAt** | **DateTime?** |  | [optional] 
**FinishedAt** | **DateTime?** |  | [optional] 
**CancelledAt** | **DateTime?** |  | [optional] 
**FaultedAt** | **DateTime?** |  | [optional] 
**Variables** | [**Variables**](Variables.md) |  | [optional] 
**Input** | [**WorkflowInputReference**](WorkflowInputReference.md) |  | [optional] 
**Output** | [**WorkflowOutputReference**](WorkflowOutputReference.md) |  | [optional] 
**ActivityData** | **Dictionary&lt;string, Dictionary&lt;string, Object&gt;&gt;** |  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**BlockingActivities** | [**List&lt;BlockingActivity&gt;**](BlockingActivity.md) |  | [optional] 
**Fault** | [**WorkflowFault**](WorkflowFault.md) |  | [optional] 
**Faults** | [**List&lt;WorkflowFault&gt;**](WorkflowFault.md) |  | [optional] 
**ScheduledActivities** | [**List&lt;ScheduledActivity&gt;**](ScheduledActivity.md) |  | [optional] 
**Scopes** | [**List&lt;ActivityScope&gt;**](ActivityScope.md) |  | [optional] 
**CurrentActivity** | [**ScheduledActivity**](ScheduledActivity.md) |  | [optional] 
**LastExecutedActivityId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


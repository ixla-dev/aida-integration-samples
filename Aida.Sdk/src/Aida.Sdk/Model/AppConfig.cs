/*
 * aida
 *
 * 1.0.385
 *
 * The version of the OpenAPI document: 1.0.385
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// AppConfig
    /// </summary>
    [DataContract(Name = "AppConfig")]
    public partial class AppConfig : IEquatable<AppConfig>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MachineModel
        /// </summary>
        [DataMember(Name = "machineModel", EmitDefaultValue = false)]
        public MachineModel? MachineModel { get; set; }

        /// <summary>
        /// Gets or Sets ScannerAppType
        /// </summary>
        [DataMember(Name = "scannerAppType", EmitDefaultValue = false)]
        public ScannerAppType? ScannerAppType { get; set; }

        /// <summary>
        /// Gets or Sets CameraType
        /// </summary>
        [DataMember(Name = "cameraType", EmitDefaultValue = false)]
        public CameraType? CameraType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfig" /> class.
        /// </summary>
        /// <param name="machineModel">machineModel.</param>
        /// <param name="udpDiscoveryEnabled">udpDiscoveryEnabled.</param>
        /// <param name="eventTracingEnabled">eventTracingEnabled.</param>
        /// <param name="nodeId">nodeId.</param>
        /// <param name="role">role.</param>
        /// <param name="clusterName">clusterName.</param>
        /// <param name="masterBaseAddress">masterBaseAddress.</param>
        /// <param name="logSerialData">logSerialData.</param>
        /// <param name="laserBoardEnabled">laserBoardEnabled.</param>
        /// <param name="mockLaserBoardEnabled">mockLaserBoardEnabled.</param>
        /// <param name="boxTransportEnabled">boxTransportEnabled.</param>
        /// <param name="mockTransportEnabled">mockTransportEnabled.</param>
        /// <param name="magEncoderEnabled">magEncoderEnabled.</param>
        /// <param name="magEncoderPortName">magEncoderPortName.</param>
        /// <param name="pcScEnabled">pcScEnabled.</param>
        /// <param name="encoderEnabled">encoderEnabled.</param>
        /// <param name="workflowsEnabled">workflowsEnabled.</param>
        /// <param name="scannerAppType">scannerAppType.</param>
        /// <param name="scannerHeadEnabled">scannerHeadEnabled.</param>
        /// <param name="localScannerEnabled">localScannerEnabled.</param>
        /// <param name="cameraEnabled">cameraEnabled.</param>
        /// <param name="laserBoard">laserBoard.</param>
        /// <param name="pcScManager">pcScManager.</param>
        /// <param name="cameraType">cameraType.</param>
        /// <param name="blobTempPath">blobTempPath.</param>
        /// <param name="enableReverseProxy">enableReverseProxy.</param>
        /// <param name="modules">modules.</param>
        /// <param name="transport">transport.</param>
        /// <param name="opticSettings">opticSettings.</param>
        /// <param name="lamp">lamp.</param>
        /// <param name="supportedWorkflows">supportedWorkflows.</param>
        /// <param name="useUsbDisplay">useUsbDisplay.</param>
        /// <param name="samLight">samLight.</param>
        /// <param name="webHooks">webHooks.</param>
        public AppConfig(MachineModel? machineModel = default(MachineModel?), bool udpDiscoveryEnabled = default(bool), bool eventTracingEnabled = default(bool), string nodeId = default(string), string role = default(string), string clusterName = default(string), string masterBaseAddress = default(string), bool logSerialData = default(bool), bool laserBoardEnabled = default(bool), bool mockLaserBoardEnabled = default(bool), bool boxTransportEnabled = default(bool), bool mockTransportEnabled = default(bool), bool magEncoderEnabled = default(bool), string magEncoderPortName = default(string), bool pcScEnabled = default(bool), bool encoderEnabled = default(bool), bool workflowsEnabled = default(bool), ScannerAppType? scannerAppType = default(ScannerAppType?), bool scannerHeadEnabled = default(bool), bool localScannerEnabled = default(bool), bool cameraEnabled = default(bool), LaserBoardConfig laserBoard = default(LaserBoardConfig), PcScManagerConfiguration pcScManager = default(PcScManagerConfiguration), CameraType? cameraType = default(CameraType?), string blobTempPath = default(string), bool enableReverseProxy = default(bool), List<ModuleDefinition> modules = default(List<ModuleDefinition>), TransportConfig transport = default(TransportConfig), OpticSettings opticSettings = default(OpticSettings), LampConfig lamp = default(LampConfig), List<string> supportedWorkflows = default(List<string>), bool useUsbDisplay = default(bool), SamLightOptions samLight = default(SamLightOptions), WebHooksOptions webHooks = default(WebHooksOptions))
        {
            this.MachineModel = machineModel;
            this.UdpDiscoveryEnabled = udpDiscoveryEnabled;
            this.EventTracingEnabled = eventTracingEnabled;
            this.NodeId = nodeId;
            this.Role = role;
            this.ClusterName = clusterName;
            this.MasterBaseAddress = masterBaseAddress;
            this.LogSerialData = logSerialData;
            this.LaserBoardEnabled = laserBoardEnabled;
            this.MockLaserBoardEnabled = mockLaserBoardEnabled;
            this.BoxTransportEnabled = boxTransportEnabled;
            this.MockTransportEnabled = mockTransportEnabled;
            this.MagEncoderEnabled = magEncoderEnabled;
            this.MagEncoderPortName = magEncoderPortName;
            this.PcScEnabled = pcScEnabled;
            this.EncoderEnabled = encoderEnabled;
            this.WorkflowsEnabled = workflowsEnabled;
            this.ScannerAppType = scannerAppType;
            this.ScannerHeadEnabled = scannerHeadEnabled;
            this.LocalScannerEnabled = localScannerEnabled;
            this.CameraEnabled = cameraEnabled;
            this.LaserBoard = laserBoard;
            this.PcScManager = pcScManager;
            this.CameraType = cameraType;
            this.BlobTempPath = blobTempPath;
            this.EnableReverseProxy = enableReverseProxy;
            this.Modules = modules;
            this.Transport = transport;
            this.OpticSettings = opticSettings;
            this.Lamp = lamp;
            this.SupportedWorkflows = supportedWorkflows;
            this.UseUsbDisplay = useUsbDisplay;
            this.SamLight = samLight;
            this.WebHooks = webHooks;
        }

        /// <summary>
        /// Gets or Sets UdpDiscoveryEnabled
        /// </summary>
        [DataMember(Name = "udpDiscoveryEnabled", EmitDefaultValue = true)]
        public bool UdpDiscoveryEnabled { get; set; }

        /// <summary>
        /// Gets or Sets EventTracingEnabled
        /// </summary>
        [DataMember(Name = "eventTracingEnabled", EmitDefaultValue = true)]
        public bool EventTracingEnabled { get; set; }

        /// <summary>
        /// Gets or Sets NodeId
        /// </summary>
        [DataMember(Name = "nodeId", EmitDefaultValue = true)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = true)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets ClusterName
        /// </summary>
        [DataMember(Name = "clusterName", EmitDefaultValue = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Gets or Sets MasterBaseAddress
        /// </summary>
        [DataMember(Name = "masterBaseAddress", EmitDefaultValue = true)]
        public string MasterBaseAddress { get; set; }

        /// <summary>
        /// Gets or Sets LogSerialData
        /// </summary>
        [DataMember(Name = "logSerialData", EmitDefaultValue = true)]
        public bool LogSerialData { get; set; }

        /// <summary>
        /// Gets or Sets LaserBoardEnabled
        /// </summary>
        [DataMember(Name = "laserBoardEnabled", EmitDefaultValue = true)]
        public bool LaserBoardEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MockLaserBoardEnabled
        /// </summary>
        [DataMember(Name = "mockLaserBoardEnabled", EmitDefaultValue = true)]
        public bool MockLaserBoardEnabled { get; set; }

        /// <summary>
        /// Gets or Sets BoxTransportEnabled
        /// </summary>
        [DataMember(Name = "boxTransportEnabled", EmitDefaultValue = true)]
        public bool BoxTransportEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MockTransportEnabled
        /// </summary>
        [DataMember(Name = "mockTransportEnabled", EmitDefaultValue = true)]
        public bool MockTransportEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MagEncoderEnabled
        /// </summary>
        [DataMember(Name = "magEncoderEnabled", EmitDefaultValue = true)]
        public bool MagEncoderEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MagEncoderPortName
        /// </summary>
        [DataMember(Name = "magEncoderPortName", EmitDefaultValue = true)]
        public string MagEncoderPortName { get; set; }

        /// <summary>
        /// Gets or Sets PcScEnabled
        /// </summary>
        [DataMember(Name = "pcScEnabled", EmitDefaultValue = true)]
        public bool PcScEnabled { get; set; }

        /// <summary>
        /// Gets or Sets EncoderEnabled
        /// </summary>
        [DataMember(Name = "encoderEnabled", EmitDefaultValue = true)]
        public bool EncoderEnabled { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowsEnabled
        /// </summary>
        [DataMember(Name = "workflowsEnabled", EmitDefaultValue = true)]
        public bool WorkflowsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ElsaWorkflowsEnabled
        /// </summary>
        [DataMember(Name = "elsaWorkflowsEnabled", EmitDefaultValue = true)]
        public bool ElsaWorkflowsEnabled { get; private set; }

        /// <summary>
        /// Returns false as ElsaWorkflowsEnabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeElsaWorkflowsEnabled()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ScannerHeadEnabled
        /// </summary>
        [DataMember(Name = "scannerHeadEnabled", EmitDefaultValue = true)]
        public bool ScannerHeadEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LocalScannerEnabled
        /// </summary>
        [DataMember(Name = "localScannerEnabled", EmitDefaultValue = true)]
        public bool LocalScannerEnabled { get; set; }

        /// <summary>
        /// Gets or Sets CameraEnabled
        /// </summary>
        [DataMember(Name = "cameraEnabled", EmitDefaultValue = true)]
        public bool CameraEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LaserBoard
        /// </summary>
        [DataMember(Name = "laserBoard", EmitDefaultValue = false)]
        public LaserBoardConfig LaserBoard { get; set; }

        /// <summary>
        /// Gets or Sets PcScManager
        /// </summary>
        [DataMember(Name = "pcScManager", EmitDefaultValue = false)]
        public PcScManagerConfiguration PcScManager { get; set; }

        /// <summary>
        /// Gets or Sets BlobTempPath
        /// </summary>
        [DataMember(Name = "blobTempPath", EmitDefaultValue = true)]
        public string BlobTempPath { get; set; }

        /// <summary>
        /// Gets or Sets EnableReverseProxy
        /// </summary>
        [DataMember(Name = "enableReverseProxy", EmitDefaultValue = true)]
        public bool EnableReverseProxy { get; set; }

        /// <summary>
        /// Gets or Sets Modules
        /// </summary>
        [DataMember(Name = "modules", EmitDefaultValue = true)]
        public List<ModuleDefinition> Modules { get; set; }

        /// <summary>
        /// Gets or Sets Transport
        /// </summary>
        [DataMember(Name = "transport", EmitDefaultValue = false)]
        public TransportConfig Transport { get; set; }

        /// <summary>
        /// Gets or Sets OpticSettings
        /// </summary>
        [DataMember(Name = "opticSettings", EmitDefaultValue = false)]
        public OpticSettings OpticSettings { get; set; }

        /// <summary>
        /// Gets or Sets Lamp
        /// </summary>
        [DataMember(Name = "lamp", EmitDefaultValue = false)]
        public LampConfig Lamp { get; set; }

        /// <summary>
        /// Gets or Sets SupportedWorkflows
        /// </summary>
        [DataMember(Name = "supportedWorkflows", EmitDefaultValue = true)]
        public List<string> SupportedWorkflows { get; set; }

        /// <summary>
        /// Gets or Sets UseUsbDisplay
        /// </summary>
        [DataMember(Name = "useUsbDisplay", EmitDefaultValue = true)]
        public bool UseUsbDisplay { get; set; }

        /// <summary>
        /// Gets or Sets SamLight
        /// </summary>
        [DataMember(Name = "samLight", EmitDefaultValue = false)]
        public SamLightOptions SamLight { get; set; }

        /// <summary>
        /// Gets or Sets WebHooks
        /// </summary>
        [DataMember(Name = "webHooks", EmitDefaultValue = false)]
        public WebHooksOptions WebHooks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppConfig {\n");
            sb.Append("  MachineModel: ").Append(MachineModel).Append("\n");
            sb.Append("  UdpDiscoveryEnabled: ").Append(UdpDiscoveryEnabled).Append("\n");
            sb.Append("  EventTracingEnabled: ").Append(EventTracingEnabled).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  MasterBaseAddress: ").Append(MasterBaseAddress).Append("\n");
            sb.Append("  LogSerialData: ").Append(LogSerialData).Append("\n");
            sb.Append("  LaserBoardEnabled: ").Append(LaserBoardEnabled).Append("\n");
            sb.Append("  MockLaserBoardEnabled: ").Append(MockLaserBoardEnabled).Append("\n");
            sb.Append("  BoxTransportEnabled: ").Append(BoxTransportEnabled).Append("\n");
            sb.Append("  MockTransportEnabled: ").Append(MockTransportEnabled).Append("\n");
            sb.Append("  MagEncoderEnabled: ").Append(MagEncoderEnabled).Append("\n");
            sb.Append("  MagEncoderPortName: ").Append(MagEncoderPortName).Append("\n");
            sb.Append("  PcScEnabled: ").Append(PcScEnabled).Append("\n");
            sb.Append("  EncoderEnabled: ").Append(EncoderEnabled).Append("\n");
            sb.Append("  WorkflowsEnabled: ").Append(WorkflowsEnabled).Append("\n");
            sb.Append("  ElsaWorkflowsEnabled: ").Append(ElsaWorkflowsEnabled).Append("\n");
            sb.Append("  ScannerAppType: ").Append(ScannerAppType).Append("\n");
            sb.Append("  ScannerHeadEnabled: ").Append(ScannerHeadEnabled).Append("\n");
            sb.Append("  LocalScannerEnabled: ").Append(LocalScannerEnabled).Append("\n");
            sb.Append("  CameraEnabled: ").Append(CameraEnabled).Append("\n");
            sb.Append("  LaserBoard: ").Append(LaserBoard).Append("\n");
            sb.Append("  PcScManager: ").Append(PcScManager).Append("\n");
            sb.Append("  CameraType: ").Append(CameraType).Append("\n");
            sb.Append("  BlobTempPath: ").Append(BlobTempPath).Append("\n");
            sb.Append("  EnableReverseProxy: ").Append(EnableReverseProxy).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  OpticSettings: ").Append(OpticSettings).Append("\n");
            sb.Append("  Lamp: ").Append(Lamp).Append("\n");
            sb.Append("  SupportedWorkflows: ").Append(SupportedWorkflows).Append("\n");
            sb.Append("  UseUsbDisplay: ").Append(UseUsbDisplay).Append("\n");
            sb.Append("  SamLight: ").Append(SamLight).Append("\n");
            sb.Append("  WebHooks: ").Append(WebHooks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppConfig);
        }

        /// <summary>
        /// Returns true if AppConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AppConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MachineModel == input.MachineModel ||
                    this.MachineModel.Equals(input.MachineModel)
                ) && 
                (
                    this.UdpDiscoveryEnabled == input.UdpDiscoveryEnabled ||
                    this.UdpDiscoveryEnabled.Equals(input.UdpDiscoveryEnabled)
                ) && 
                (
                    this.EventTracingEnabled == input.EventTracingEnabled ||
                    this.EventTracingEnabled.Equals(input.EventTracingEnabled)
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.MasterBaseAddress == input.MasterBaseAddress ||
                    (this.MasterBaseAddress != null &&
                    this.MasterBaseAddress.Equals(input.MasterBaseAddress))
                ) && 
                (
                    this.LogSerialData == input.LogSerialData ||
                    this.LogSerialData.Equals(input.LogSerialData)
                ) && 
                (
                    this.LaserBoardEnabled == input.LaserBoardEnabled ||
                    this.LaserBoardEnabled.Equals(input.LaserBoardEnabled)
                ) && 
                (
                    this.MockLaserBoardEnabled == input.MockLaserBoardEnabled ||
                    this.MockLaserBoardEnabled.Equals(input.MockLaserBoardEnabled)
                ) && 
                (
                    this.BoxTransportEnabled == input.BoxTransportEnabled ||
                    this.BoxTransportEnabled.Equals(input.BoxTransportEnabled)
                ) && 
                (
                    this.MockTransportEnabled == input.MockTransportEnabled ||
                    this.MockTransportEnabled.Equals(input.MockTransportEnabled)
                ) && 
                (
                    this.MagEncoderEnabled == input.MagEncoderEnabled ||
                    this.MagEncoderEnabled.Equals(input.MagEncoderEnabled)
                ) && 
                (
                    this.MagEncoderPortName == input.MagEncoderPortName ||
                    (this.MagEncoderPortName != null &&
                    this.MagEncoderPortName.Equals(input.MagEncoderPortName))
                ) && 
                (
                    this.PcScEnabled == input.PcScEnabled ||
                    this.PcScEnabled.Equals(input.PcScEnabled)
                ) && 
                (
                    this.EncoderEnabled == input.EncoderEnabled ||
                    this.EncoderEnabled.Equals(input.EncoderEnabled)
                ) && 
                (
                    this.WorkflowsEnabled == input.WorkflowsEnabled ||
                    this.WorkflowsEnabled.Equals(input.WorkflowsEnabled)
                ) && 
                (
                    this.ElsaWorkflowsEnabled == input.ElsaWorkflowsEnabled ||
                    this.ElsaWorkflowsEnabled.Equals(input.ElsaWorkflowsEnabled)
                ) && 
                (
                    this.ScannerAppType == input.ScannerAppType ||
                    this.ScannerAppType.Equals(input.ScannerAppType)
                ) && 
                (
                    this.ScannerHeadEnabled == input.ScannerHeadEnabled ||
                    this.ScannerHeadEnabled.Equals(input.ScannerHeadEnabled)
                ) && 
                (
                    this.LocalScannerEnabled == input.LocalScannerEnabled ||
                    this.LocalScannerEnabled.Equals(input.LocalScannerEnabled)
                ) && 
                (
                    this.CameraEnabled == input.CameraEnabled ||
                    this.CameraEnabled.Equals(input.CameraEnabled)
                ) && 
                (
                    this.LaserBoard == input.LaserBoard ||
                    (this.LaserBoard != null &&
                    this.LaserBoard.Equals(input.LaserBoard))
                ) && 
                (
                    this.PcScManager == input.PcScManager ||
                    (this.PcScManager != null &&
                    this.PcScManager.Equals(input.PcScManager))
                ) && 
                (
                    this.CameraType == input.CameraType ||
                    this.CameraType.Equals(input.CameraType)
                ) && 
                (
                    this.BlobTempPath == input.BlobTempPath ||
                    (this.BlobTempPath != null &&
                    this.BlobTempPath.Equals(input.BlobTempPath))
                ) && 
                (
                    this.EnableReverseProxy == input.EnableReverseProxy ||
                    this.EnableReverseProxy.Equals(input.EnableReverseProxy)
                ) && 
                (
                    this.Modules == input.Modules ||
                    this.Modules != null &&
                    input.Modules != null &&
                    this.Modules.SequenceEqual(input.Modules)
                ) && 
                (
                    this.Transport == input.Transport ||
                    (this.Transport != null &&
                    this.Transport.Equals(input.Transport))
                ) && 
                (
                    this.OpticSettings == input.OpticSettings ||
                    (this.OpticSettings != null &&
                    this.OpticSettings.Equals(input.OpticSettings))
                ) && 
                (
                    this.Lamp == input.Lamp ||
                    (this.Lamp != null &&
                    this.Lamp.Equals(input.Lamp))
                ) && 
                (
                    this.SupportedWorkflows == input.SupportedWorkflows ||
                    this.SupportedWorkflows != null &&
                    input.SupportedWorkflows != null &&
                    this.SupportedWorkflows.SequenceEqual(input.SupportedWorkflows)
                ) && 
                (
                    this.UseUsbDisplay == input.UseUsbDisplay ||
                    this.UseUsbDisplay.Equals(input.UseUsbDisplay)
                ) && 
                (
                    this.SamLight == input.SamLight ||
                    (this.SamLight != null &&
                    this.SamLight.Equals(input.SamLight))
                ) && 
                (
                    this.WebHooks == input.WebHooks ||
                    (this.WebHooks != null &&
                    this.WebHooks.Equals(input.WebHooks))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.MachineModel.GetHashCode();
                hashCode = (hashCode * 59) + this.UdpDiscoveryEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.EventTracingEnabled.GetHashCode();
                if (this.NodeId != null)
                {
                    hashCode = (hashCode * 59) + this.NodeId.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
                }
                if (this.ClusterName != null)
                {
                    hashCode = (hashCode * 59) + this.ClusterName.GetHashCode();
                }
                if (this.MasterBaseAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MasterBaseAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LogSerialData.GetHashCode();
                hashCode = (hashCode * 59) + this.LaserBoardEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.MockLaserBoardEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.BoxTransportEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.MockTransportEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.MagEncoderEnabled.GetHashCode();
                if (this.MagEncoderPortName != null)
                {
                    hashCode = (hashCode * 59) + this.MagEncoderPortName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PcScEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.EncoderEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkflowsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ElsaWorkflowsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ScannerAppType.GetHashCode();
                hashCode = (hashCode * 59) + this.ScannerHeadEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.LocalScannerEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.CameraEnabled.GetHashCode();
                if (this.LaserBoard != null)
                {
                    hashCode = (hashCode * 59) + this.LaserBoard.GetHashCode();
                }
                if (this.PcScManager != null)
                {
                    hashCode = (hashCode * 59) + this.PcScManager.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CameraType.GetHashCode();
                if (this.BlobTempPath != null)
                {
                    hashCode = (hashCode * 59) + this.BlobTempPath.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableReverseProxy.GetHashCode();
                if (this.Modules != null)
                {
                    hashCode = (hashCode * 59) + this.Modules.GetHashCode();
                }
                if (this.Transport != null)
                {
                    hashCode = (hashCode * 59) + this.Transport.GetHashCode();
                }
                if (this.OpticSettings != null)
                {
                    hashCode = (hashCode * 59) + this.OpticSettings.GetHashCode();
                }
                if (this.Lamp != null)
                {
                    hashCode = (hashCode * 59) + this.Lamp.GetHashCode();
                }
                if (this.SupportedWorkflows != null)
                {
                    hashCode = (hashCode * 59) + this.SupportedWorkflows.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseUsbDisplay.GetHashCode();
                if (this.SamLight != null)
                {
                    hashCode = (hashCode * 59) + this.SamLight.GetHashCode();
                }
                if (this.WebHooks != null)
                {
                    hashCode = (hashCode * 59) + this.WebHooks.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

/*
 * aida
 *
 * 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
 *
 * The version of the OpenAPI document: 1.0.722-rc.3+496a5e11f6297a76e2b83a2b26e743e21a1c18c1
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
    /// PrinterStateDto
    /// </summary>
    [DataContract(Name = "PrinterStateDto")]
    public partial class PrinterStateDto : IEquatable<PrinterStateDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets XPrintHeadPosition
        /// </summary>
        [DataMember(Name = "xPrintHeadPosition", EmitDefaultValue = false)]
        public XPrintHeadAxisPositionFlags? XPrintHeadPosition { get; set; }

        /// <summary>
        /// Gets or Sets PositionsFlags
        /// </summary>
        [DataMember(Name = "positionsFlags", EmitDefaultValue = false)]
        public XPrintTransportAxisPositionFlags? PositionsFlags { get; set; }

        /// <summary>
        /// Gets or Sets DoorsStatusFlags
        /// </summary>
        [DataMember(Name = "doorsStatusFlags", EmitDefaultValue = false)]
        public XPrintDoorStatusFlags? DoorsStatusFlags { get; set; }

        /// <summary>
        /// Gets or Sets MainSystemStatus
        /// </summary>
        [DataMember(Name = "mainSystemStatus", EmitDefaultValue = false)]
        public XPrintMainSystemStatus? MainSystemStatus { get; set; }

        /// <summary>
        /// Gets or Sets MainSubSystemStatus
        /// </summary>
        [DataMember(Name = "mainSubSystemStatus", EmitDefaultValue = false)]
        public XPrintMainSubsystemStatus? MainSubSystemStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterStateDto" /> class.
        /// </summary>
        /// <param name="vacuumPressureMillibar">vacuumPressureMillibar.</param>
        /// <param name="xPrintHeadPosition">xPrintHeadPosition.</param>
        /// <param name="positionsFlags">positionsFlags.</param>
        /// <param name="temperatureReadings">temperatureReadings.</param>
        /// <param name="voltageReadings">voltageReadings.</param>
        /// <param name="doorsStatusFlags">doorsStatusFlags.</param>
        /// <param name="mainSystemStatus">mainSystemStatus.</param>
        /// <param name="mainSubSystemStatus">mainSubSystemStatus.</param>
        /// <param name="xAxis">xAxis.</param>
        /// <param name="yAxis">yAxis.</param>
        public PrinterStateDto(float vacuumPressureMillibar = default(float), XPrintHeadAxisPositionFlags? xPrintHeadPosition = default(XPrintHeadAxisPositionFlags?), XPrintTransportAxisPositionFlags? positionsFlags = default(XPrintTransportAxisPositionFlags?), TemperatureReadingsDto temperatureReadings = default(TemperatureReadingsDto), VoltageReadingsDto voltageReadings = default(VoltageReadingsDto), XPrintDoorStatusFlags? doorsStatusFlags = default(XPrintDoorStatusFlags?), XPrintMainSystemStatus? mainSystemStatus = default(XPrintMainSystemStatus?), XPrintMainSubsystemStatus? mainSubSystemStatus = default(XPrintMainSubsystemStatus?), int xAxis = default(int), int yAxis = default(int))
        {
            this.VacuumPressureMillibar = vacuumPressureMillibar;
            this.XPrintHeadPosition = xPrintHeadPosition;
            this.PositionsFlags = positionsFlags;
            this.TemperatureReadings = temperatureReadings;
            this.VoltageReadings = voltageReadings;
            this.DoorsStatusFlags = doorsStatusFlags;
            this.MainSystemStatus = mainSystemStatus;
            this.MainSubSystemStatus = mainSubSystemStatus;
            this.XAxis = xAxis;
            this.YAxis = yAxis;
        }

        /// <summary>
        /// Gets or Sets VacuumPressureMillibar
        /// </summary>
        [DataMember(Name = "vacuumPressureMillibar", EmitDefaultValue = false)]
        public float VacuumPressureMillibar { get; set; }

        /// <summary>
        /// Gets or Sets TemperatureReadings
        /// </summary>
        [DataMember(Name = "temperatureReadings", EmitDefaultValue = false)]
        public TemperatureReadingsDto TemperatureReadings { get; set; }

        /// <summary>
        /// Gets or Sets VoltageReadings
        /// </summary>
        [DataMember(Name = "voltageReadings", EmitDefaultValue = false)]
        public VoltageReadingsDto VoltageReadings { get; set; }

        /// <summary>
        /// Gets or Sets XAxis
        /// </summary>
        [DataMember(Name = "xAxis", EmitDefaultValue = false)]
        public int XAxis { get; set; }

        /// <summary>
        /// Gets or Sets YAxis
        /// </summary>
        [DataMember(Name = "yAxis", EmitDefaultValue = false)]
        public int YAxis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrinterStateDto {\n");
            sb.Append("  VacuumPressureMillibar: ").Append(VacuumPressureMillibar).Append("\n");
            sb.Append("  XPrintHeadPosition: ").Append(XPrintHeadPosition).Append("\n");
            sb.Append("  PositionsFlags: ").Append(PositionsFlags).Append("\n");
            sb.Append("  TemperatureReadings: ").Append(TemperatureReadings).Append("\n");
            sb.Append("  VoltageReadings: ").Append(VoltageReadings).Append("\n");
            sb.Append("  DoorsStatusFlags: ").Append(DoorsStatusFlags).Append("\n");
            sb.Append("  MainSystemStatus: ").Append(MainSystemStatus).Append("\n");
            sb.Append("  MainSubSystemStatus: ").Append(MainSubSystemStatus).Append("\n");
            sb.Append("  XAxis: ").Append(XAxis).Append("\n");
            sb.Append("  YAxis: ").Append(YAxis).Append("\n");
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
            return this.Equals(input as PrinterStateDto);
        }

        /// <summary>
        /// Returns true if PrinterStateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PrinterStateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrinterStateDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VacuumPressureMillibar == input.VacuumPressureMillibar ||
                    this.VacuumPressureMillibar.Equals(input.VacuumPressureMillibar)
                ) && 
                (
                    this.XPrintHeadPosition == input.XPrintHeadPosition ||
                    this.XPrintHeadPosition.Equals(input.XPrintHeadPosition)
                ) && 
                (
                    this.PositionsFlags == input.PositionsFlags ||
                    this.PositionsFlags.Equals(input.PositionsFlags)
                ) && 
                (
                    this.TemperatureReadings == input.TemperatureReadings ||
                    (this.TemperatureReadings != null &&
                    this.TemperatureReadings.Equals(input.TemperatureReadings))
                ) && 
                (
                    this.VoltageReadings == input.VoltageReadings ||
                    (this.VoltageReadings != null &&
                    this.VoltageReadings.Equals(input.VoltageReadings))
                ) && 
                (
                    this.DoorsStatusFlags == input.DoorsStatusFlags ||
                    this.DoorsStatusFlags.Equals(input.DoorsStatusFlags)
                ) && 
                (
                    this.MainSystemStatus == input.MainSystemStatus ||
                    this.MainSystemStatus.Equals(input.MainSystemStatus)
                ) && 
                (
                    this.MainSubSystemStatus == input.MainSubSystemStatus ||
                    this.MainSubSystemStatus.Equals(input.MainSubSystemStatus)
                ) && 
                (
                    this.XAxis == input.XAxis ||
                    this.XAxis.Equals(input.XAxis)
                ) && 
                (
                    this.YAxis == input.YAxis ||
                    this.YAxis.Equals(input.YAxis)
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
                hashCode = (hashCode * 59) + this.VacuumPressureMillibar.GetHashCode();
                hashCode = (hashCode * 59) + this.XPrintHeadPosition.GetHashCode();
                hashCode = (hashCode * 59) + this.PositionsFlags.GetHashCode();
                if (this.TemperatureReadings != null)
                {
                    hashCode = (hashCode * 59) + this.TemperatureReadings.GetHashCode();
                }
                if (this.VoltageReadings != null)
                {
                    hashCode = (hashCode * 59) + this.VoltageReadings.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DoorsStatusFlags.GetHashCode();
                hashCode = (hashCode * 59) + this.MainSystemStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.MainSubSystemStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.XAxis.GetHashCode();
                hashCode = (hashCode * 59) + this.YAxis.GetHashCode();
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

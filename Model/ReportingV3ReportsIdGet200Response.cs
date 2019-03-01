/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Report Log
    /// </summary>
    [DataContract]
    public partial class ReportingV3ReportsIdGet200Response :  IEquatable<ReportingV3ReportsIdGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Report Format
        /// </summary>
        /// <value>Report Format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportMimeTypeEnum
        {
            
            /// <summary>
            /// Enum ApplicationXml for "application/xml"
            /// </summary>
            [EnumMember(Value = "application/xml")]
            ApplicationXml,
            
            /// <summary>
            /// Enum TextCsv for "text/csv"
            /// </summary>
            [EnumMember(Value = "text/csv")]
            TextCsv
        }

        /// <summary>
        /// Report Frequency Value
        /// </summary>
        /// <value>Report Frequency Value</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportFrequencyEnum
        {
            
            /// <summary>
            /// Enum DAILY for "DAILY"
            /// </summary>
            [EnumMember(Value = "DAILY")]
            DAILY,
            
            /// <summary>
            /// Enum WEEKLY for "WEEKLY"
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY,
            
            /// <summary>
            /// Enum MONTHLY for "MONTHLY"
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY,
            
            /// <summary>
            /// Enum ADHOC for "ADHOC"
            /// </summary>
            [EnumMember(Value = "ADHOC")]
            ADHOC
        }

        /// <summary>
        /// Report Status Value
        /// </summary>
        /// <value>Report Status Value</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportStatusEnum
        {
            
            /// <summary>
            /// Enum COMPLETED for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED,
            
            /// <summary>
            /// Enum PENDING for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING,
            
            /// <summary>
            /// Enum QUEUED for "QUEUED"
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            QUEUED,
            
            /// <summary>
            /// Enum RUNNING for "RUNNING"
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING,
            
            /// <summary>
            /// Enum ERROR for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR,
            
            /// <summary>
            /// Enum NODATA for "NO_DATA"
            /// </summary>
            [EnumMember(Value = "NO_DATA")]
            NODATA,
            
            /// <summary>
            /// Enum RERUN for "RERUN"
            /// </summary>
            [EnumMember(Value = "RERUN")]
            RERUN
        }

        /// <summary>
        /// Report Format
        /// </summary>
        /// <value>Report Format</value>
        [DataMember(Name="reportMimeType", EmitDefaultValue=false)]
        public ReportMimeTypeEnum? ReportMimeType { get; set; }
        /// <summary>
        /// Report Frequency Value
        /// </summary>
        /// <value>Report Frequency Value</value>
        [DataMember(Name="reportFrequency", EmitDefaultValue=false)]
        public ReportFrequencyEnum? ReportFrequency { get; set; }
        /// <summary>
        /// Report Status Value
        /// </summary>
        /// <value>Report Status Value</value>
        [DataMember(Name="reportStatus", EmitDefaultValue=false)]
        public ReportStatusEnum? ReportStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3ReportsIdGet200Response" /> class.
        /// </summary>
        /// <param name="OrganizationId">CyberSource merchant id.</param>
        /// <param name="ReportId">Report ID Value.</param>
        /// <param name="ReportDefinitionId">Report definition Id.</param>
        /// <param name="ReportName">Report Name.</param>
        /// <param name="ReportMimeType">Report Format.</param>
        /// <param name="ReportFrequency">Report Frequency Value.</param>
        /// <param name="ReportFields">List of Integer Values.</param>
        /// <param name="ReportStatus">Report Status Value.</param>
        /// <param name="ReportStartTime">Report Start Time Value.</param>
        /// <param name="ReportEndTime">Report End Time Value.</param>
        /// <param name="Timezone">Time Zone Value.</param>
        /// <param name="ReportFilters">List of filters to apply.</param>
        /// <param name="ReportPreferences">ReportPreferences.</param>
        /// <param name="GroupId">Id for selected group..</param>
        public ReportingV3ReportsIdGet200Response(string OrganizationId = default(string), string ReportId = default(string), string ReportDefinitionId = default(string), string ReportName = default(string), ReportMimeTypeEnum? ReportMimeType = default(ReportMimeTypeEnum?), ReportFrequencyEnum? ReportFrequency = default(ReportFrequencyEnum?), List<string> ReportFields = default(List<string>), ReportStatusEnum? ReportStatus = default(ReportStatusEnum?), DateTime? ReportStartTime = default(DateTime?), DateTime? ReportEndTime = default(DateTime?), string Timezone = default(string), Dictionary<string, List<string>> ReportFilters = default(Dictionary<string, List<string>>), ReportingV3ReportsIdGet200ResponseReportPreferences ReportPreferences = default(ReportingV3ReportsIdGet200ResponseReportPreferences), string GroupId = default(string))
        {
            this.OrganizationId = OrganizationId;
            this.ReportId = ReportId;
            this.ReportDefinitionId = ReportDefinitionId;
            this.ReportName = ReportName;
            this.ReportMimeType = ReportMimeType;
            this.ReportFrequency = ReportFrequency;
            this.ReportFields = ReportFields;
            this.ReportStatus = ReportStatus;
            this.ReportStartTime = ReportStartTime;
            this.ReportEndTime = ReportEndTime;
            this.Timezone = Timezone;
            this.ReportFilters = ReportFilters;
            this.ReportPreferences = ReportPreferences;
            this.GroupId = GroupId;
        }
        
        /// <summary>
        /// CyberSource merchant id
        /// </summary>
        /// <value>CyberSource merchant id</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Report ID Value
        /// </summary>
        /// <value>Report ID Value</value>
        [DataMember(Name="reportId", EmitDefaultValue=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// Report definition Id
        /// </summary>
        /// <value>Report definition Id</value>
        [DataMember(Name="reportDefinitionId", EmitDefaultValue=false)]
        public string ReportDefinitionId { get; set; }

        /// <summary>
        /// Report Name
        /// </summary>
        /// <value>Report Name</value>
        [DataMember(Name="reportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }



        /// <summary>
        /// List of Integer Values
        /// </summary>
        /// <value>List of Integer Values</value>
        [DataMember(Name="reportFields", EmitDefaultValue=false)]
        public List<string> ReportFields { get; set; }


        /// <summary>
        /// Report Start Time Value
        /// </summary>
        /// <value>Report Start Time Value</value>
        [DataMember(Name="reportStartTime", EmitDefaultValue=false)]
        public DateTime? ReportStartTime { get; set; }

        /// <summary>
        /// Report End Time Value
        /// </summary>
        /// <value>Report End Time Value</value>
        [DataMember(Name="reportEndTime", EmitDefaultValue=false)]
        public DateTime? ReportEndTime { get; set; }

        /// <summary>
        /// Time Zone Value
        /// </summary>
        /// <value>Time Zone Value</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// List of filters to apply
        /// </summary>
        /// <value>List of filters to apply</value>
        [DataMember(Name="reportFilters", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> ReportFilters { get; set; }

        /// <summary>
        /// Gets or Sets ReportPreferences
        /// </summary>
        [DataMember(Name="reportPreferences", EmitDefaultValue=false)]
        public ReportingV3ReportsIdGet200ResponseReportPreferences ReportPreferences { get; set; }

        /// <summary>
        /// Id for selected group.
        /// </summary>
        /// <value>Id for selected group.</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3ReportsIdGet200Response {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  ReportDefinitionId: ").Append(ReportDefinitionId).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  ReportMimeType: ").Append(ReportMimeType).Append("\n");
            sb.Append("  ReportFrequency: ").Append(ReportFrequency).Append("\n");
            sb.Append("  ReportFields: ").Append(ReportFields).Append("\n");
            sb.Append("  ReportStatus: ").Append(ReportStatus).Append("\n");
            sb.Append("  ReportStartTime: ").Append(ReportStartTime).Append("\n");
            sb.Append("  ReportEndTime: ").Append(ReportEndTime).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  ReportFilters: ").Append(ReportFilters).Append("\n");
            sb.Append("  ReportPreferences: ").Append(ReportPreferences).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ReportingV3ReportsIdGet200Response);
        }

        /// <summary>
        /// Returns true if ReportingV3ReportsIdGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3ReportsIdGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3ReportsIdGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.ReportId == other.ReportId ||
                    this.ReportId != null &&
                    this.ReportId.Equals(other.ReportId)
                ) && 
                (
                    this.ReportDefinitionId == other.ReportDefinitionId ||
                    this.ReportDefinitionId != null &&
                    this.ReportDefinitionId.Equals(other.ReportDefinitionId)
                ) && 
                (
                    this.ReportName == other.ReportName ||
                    this.ReportName != null &&
                    this.ReportName.Equals(other.ReportName)
                ) && 
                (
                    this.ReportMimeType == other.ReportMimeType ||
                    this.ReportMimeType != null &&
                    this.ReportMimeType.Equals(other.ReportMimeType)
                ) && 
                (
                    this.ReportFrequency == other.ReportFrequency ||
                    this.ReportFrequency != null &&
                    this.ReportFrequency.Equals(other.ReportFrequency)
                ) && 
                (
                    this.ReportFields == other.ReportFields ||
                    this.ReportFields != null &&
                    this.ReportFields.SequenceEqual(other.ReportFields)
                ) && 
                (
                    this.ReportStatus == other.ReportStatus ||
                    this.ReportStatus != null &&
                    this.ReportStatus.Equals(other.ReportStatus)
                ) && 
                (
                    this.ReportStartTime == other.ReportStartTime ||
                    this.ReportStartTime != null &&
                    this.ReportStartTime.Equals(other.ReportStartTime)
                ) && 
                (
                    this.ReportEndTime == other.ReportEndTime ||
                    this.ReportEndTime != null &&
                    this.ReportEndTime.Equals(other.ReportEndTime)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.ReportFilters == other.ReportFilters ||
                    this.ReportFilters != null &&
                    this.ReportFilters.SequenceEqual(other.ReportFilters)
                ) && 
                (
                    this.ReportPreferences == other.ReportPreferences ||
                    this.ReportPreferences != null &&
                    this.ReportPreferences.Equals(other.ReportPreferences)
                ) && 
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.ReportId != null)
                    hash = hash * 59 + this.ReportId.GetHashCode();
                if (this.ReportDefinitionId != null)
                    hash = hash * 59 + this.ReportDefinitionId.GetHashCode();
                if (this.ReportName != null)
                    hash = hash * 59 + this.ReportName.GetHashCode();
                if (this.ReportMimeType != null)
                    hash = hash * 59 + this.ReportMimeType.GetHashCode();
                if (this.ReportFrequency != null)
                    hash = hash * 59 + this.ReportFrequency.GetHashCode();
                if (this.ReportFields != null)
                    hash = hash * 59 + this.ReportFields.GetHashCode();
                if (this.ReportStatus != null)
                    hash = hash * 59 + this.ReportStatus.GetHashCode();
                if (this.ReportStartTime != null)
                    hash = hash * 59 + this.ReportStartTime.GetHashCode();
                if (this.ReportEndTime != null)
                    hash = hash * 59 + this.ReportEndTime.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.ReportFilters != null)
                    hash = hash * 59 + this.ReportFilters.GetHashCode();
                if (this.ReportPreferences != null)
                    hash = hash * 59 + this.ReportPreferences.GetHashCode();
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

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
    /// Report Preferences
    /// </summary>
    [DataContract]
    public partial class Reportingv3reportsReportPreferences :  IEquatable<Reportingv3reportsReportPreferences>, IValidatableObject
    {
        /// <summary>
        /// Specify the field naming convention to be followed in reports (applicable to only csv report formats
        /// </summary>
        /// <value>Specify the field naming convention to be followed in reports (applicable to only csv report formats</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldNameConventionEnum
        {
            
            /// <summary>
            /// Enum SOAPI for "SOAPI"
            /// </summary>
            [EnumMember(Value = "SOAPI")]
            SOAPI,
            
            /// <summary>
            /// Enum SCMP for "SCMP"
            /// </summary>
            [EnumMember(Value = "SCMP")]
            SCMP
        }

        /// <summary>
        /// Specify the field naming convention to be followed in reports (applicable to only csv report formats
        /// </summary>
        /// <value>Specify the field naming convention to be followed in reports (applicable to only csv report formats</value>
        [DataMember(Name="fieldNameConvention", EmitDefaultValue=false)]
        public FieldNameConventionEnum? FieldNameConvention { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Reportingv3reportsReportPreferences" /> class.
        /// </summary>
        /// <param name="SignedAmounts">Indicator to determine whether negative sign infront of amount for all refunded transaction.</param>
        /// <param name="FieldNameConvention">Specify the field naming convention to be followed in reports (applicable to only csv report formats.</param>
        public Reportingv3reportsReportPreferences(bool? SignedAmounts = default(bool?), FieldNameConventionEnum? FieldNameConvention = default(FieldNameConventionEnum?))
        {
            this.SignedAmounts = SignedAmounts;
            this.FieldNameConvention = FieldNameConvention;
        }
        
        /// <summary>
        /// Indicator to determine whether negative sign infront of amount for all refunded transaction
        /// </summary>
        /// <value>Indicator to determine whether negative sign infront of amount for all refunded transaction</value>
        [DataMember(Name="signedAmounts", EmitDefaultValue=false)]
        public bool? SignedAmounts { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reportingv3reportsReportPreferences {\n");
            sb.Append("  SignedAmounts: ").Append(SignedAmounts).Append("\n");
            sb.Append("  FieldNameConvention: ").Append(FieldNameConvention).Append("\n");
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
            return this.Equals(obj as Reportingv3reportsReportPreferences);
        }

        /// <summary>
        /// Returns true if Reportingv3reportsReportPreferences instances are equal
        /// </summary>
        /// <param name="other">Instance of Reportingv3reportsReportPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reportingv3reportsReportPreferences other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SignedAmounts == other.SignedAmounts ||
                    this.SignedAmounts != null &&
                    this.SignedAmounts.Equals(other.SignedAmounts)
                ) && 
                (
                    this.FieldNameConvention == other.FieldNameConvention ||
                    this.FieldNameConvention != null &&
                    this.FieldNameConvention.Equals(other.FieldNameConvention)
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
                if (this.SignedAmounts != null)
                    hash = hash * 59 + this.SignedAmounts.GetHashCode();
                if (this.FieldNameConvention != null)
                    hash = hash * 59 + this.FieldNameConvention.GetHashCode();
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

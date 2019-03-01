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
    /// ReportingV3PurchaseRefundDetailsGet200Response
    /// </summary>
    [DataContract]
    public partial class ReportingV3PurchaseRefundDetailsGet200Response :  IEquatable<ReportingV3PurchaseRefundDetailsGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3PurchaseRefundDetailsGet200Response" /> class.
        /// </summary>
        /// <param name="Offset">Offset.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="PageResults">PageResults.</param>
        /// <param name="RequestDetails">List of Request Info values.</param>
        /// <param name="Settlements">List of Settlement Info values.</param>
        /// <param name="Authorizations">List of Authorization Info values.</param>
        /// <param name="FeeAndFundingDetails">List of Fee Funding Info values.</param>
        /// <param name="Others">List of Other Info values.</param>
        /// <param name="SettlementStatuses">List of Settlement Status Info values.</param>
        public ReportingV3PurchaseRefundDetailsGet200Response(int? Offset = default(int?), int? Limit = default(int?), int? PageResults = default(int?), List<ReportingV3PurchaseRefundDetailsGet200ResponseRequestDetails> RequestDetails = default(List<ReportingV3PurchaseRefundDetailsGet200ResponseRequestDetails>), List<ReportingV3PurchaseRefundDetailsGet200ResponseSettlements> Settlements = default(List<ReportingV3PurchaseRefundDetailsGet200ResponseSettlements>), List<ReportingV3PurchaseRefundDetailsGet200ResponseAuthorizations> Authorizations = default(List<ReportingV3PurchaseRefundDetailsGet200ResponseAuthorizations>), List<ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails> FeeAndFundingDetails = default(List<ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails>), List<ReportingV3PurchaseRefundDetailsGet200ResponseOthers> Others = default(List<ReportingV3PurchaseRefundDetailsGet200ResponseOthers>), List<ReportingV3PurchaseRefundDetailsGet200ResponseSettlementStatuses> SettlementStatuses = default(List<ReportingV3PurchaseRefundDetailsGet200ResponseSettlementStatuses>))
        {
            this.Offset = Offset;
            this.Limit = Limit;
            this.PageResults = PageResults;
            this.RequestDetails = RequestDetails;
            this.Settlements = Settlements;
            this.Authorizations = Authorizations;
            this.FeeAndFundingDetails = FeeAndFundingDetails;
            this.Others = Others;
            this.SettlementStatuses = SettlementStatuses;
        }
        
        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets PageResults
        /// </summary>
        [DataMember(Name="pageResults", EmitDefaultValue=false)]
        public int? PageResults { get; set; }

        /// <summary>
        /// List of Request Info values
        /// </summary>
        /// <value>List of Request Info values</value>
        [DataMember(Name="requestDetails", EmitDefaultValue=false)]
        public List<ReportingV3PurchaseRefundDetailsGet200ResponseRequestDetails> RequestDetails { get; set; }

        /// <summary>
        /// List of Settlement Info values
        /// </summary>
        /// <value>List of Settlement Info values</value>
        [DataMember(Name="settlements", EmitDefaultValue=false)]
        public List<ReportingV3PurchaseRefundDetailsGet200ResponseSettlements> Settlements { get; set; }

        /// <summary>
        /// List of Authorization Info values
        /// </summary>
        /// <value>List of Authorization Info values</value>
        [DataMember(Name="authorizations", EmitDefaultValue=false)]
        public List<ReportingV3PurchaseRefundDetailsGet200ResponseAuthorizations> Authorizations { get; set; }

        /// <summary>
        /// List of Fee Funding Info values
        /// </summary>
        /// <value>List of Fee Funding Info values</value>
        [DataMember(Name="feeAndFundingDetails", EmitDefaultValue=false)]
        public List<ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails> FeeAndFundingDetails { get; set; }

        /// <summary>
        /// List of Other Info values
        /// </summary>
        /// <value>List of Other Info values</value>
        [DataMember(Name="others", EmitDefaultValue=false)]
        public List<ReportingV3PurchaseRefundDetailsGet200ResponseOthers> Others { get; set; }

        /// <summary>
        /// List of Settlement Status Info values
        /// </summary>
        /// <value>List of Settlement Status Info values</value>
        [DataMember(Name="settlementStatuses", EmitDefaultValue=false)]
        public List<ReportingV3PurchaseRefundDetailsGet200ResponseSettlementStatuses> SettlementStatuses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3PurchaseRefundDetailsGet200Response {\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  PageResults: ").Append(PageResults).Append("\n");
            sb.Append("  RequestDetails: ").Append(RequestDetails).Append("\n");
            sb.Append("  Settlements: ").Append(Settlements).Append("\n");
            sb.Append("  Authorizations: ").Append(Authorizations).Append("\n");
            sb.Append("  FeeAndFundingDetails: ").Append(FeeAndFundingDetails).Append("\n");
            sb.Append("  Others: ").Append(Others).Append("\n");
            sb.Append("  SettlementStatuses: ").Append(SettlementStatuses).Append("\n");
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
            return this.Equals(obj as ReportingV3PurchaseRefundDetailsGet200Response);
        }

        /// <summary>
        /// Returns true if ReportingV3PurchaseRefundDetailsGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3PurchaseRefundDetailsGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3PurchaseRefundDetailsGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.PageResults == other.PageResults ||
                    this.PageResults != null &&
                    this.PageResults.Equals(other.PageResults)
                ) && 
                (
                    this.RequestDetails == other.RequestDetails ||
                    this.RequestDetails != null &&
                    this.RequestDetails.SequenceEqual(other.RequestDetails)
                ) && 
                (
                    this.Settlements == other.Settlements ||
                    this.Settlements != null &&
                    this.Settlements.SequenceEqual(other.Settlements)
                ) && 
                (
                    this.Authorizations == other.Authorizations ||
                    this.Authorizations != null &&
                    this.Authorizations.SequenceEqual(other.Authorizations)
                ) && 
                (
                    this.FeeAndFundingDetails == other.FeeAndFundingDetails ||
                    this.FeeAndFundingDetails != null &&
                    this.FeeAndFundingDetails.SequenceEqual(other.FeeAndFundingDetails)
                ) && 
                (
                    this.Others == other.Others ||
                    this.Others != null &&
                    this.Others.SequenceEqual(other.Others)
                ) && 
                (
                    this.SettlementStatuses == other.SettlementStatuses ||
                    this.SettlementStatuses != null &&
                    this.SettlementStatuses.SequenceEqual(other.SettlementStatuses)
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
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.PageResults != null)
                    hash = hash * 59 + this.PageResults.GetHashCode();
                if (this.RequestDetails != null)
                    hash = hash * 59 + this.RequestDetails.GetHashCode();
                if (this.Settlements != null)
                    hash = hash * 59 + this.Settlements.GetHashCode();
                if (this.Authorizations != null)
                    hash = hash * 59 + this.Authorizations.GetHashCode();
                if (this.FeeAndFundingDetails != null)
                    hash = hash * 59 + this.FeeAndFundingDetails.GetHashCode();
                if (this.Others != null)
                    hash = hash * 59 + this.Others.GetHashCode();
                if (this.SettlementStatuses != null)
                    hash = hash * 59 + this.SettlementStatuses.GetHashCode();
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

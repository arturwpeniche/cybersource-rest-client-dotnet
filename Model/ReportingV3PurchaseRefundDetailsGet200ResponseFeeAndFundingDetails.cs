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
    /// Fee Funding Section
    /// </summary>
    [DataContract]
    public partial class ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails :  IEquatable<ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails" /> class.
        /// </summary>
        /// <param name="RequestId">An unique identification number assigned by CyberSource to identify the submitted request..</param>
        /// <param name="InterchangePerItemFee">interchange Per Item Fee.</param>
        /// <param name="DiscountPercentage">Discount Percentage.</param>
        /// <param name="DiscountAmount">Discount Amount.</param>
        /// <param name="DiscountPerItemFee">Discount Per Item Fee.</param>
        /// <param name="TotalFee">Total Fee.</param>
        /// <param name="FeeCurrency">Fee Currency.</param>
        /// <param name="DuesAssessments">Dues Assessments.</param>
        /// <param name="FundingAmount">Funding Amount.</param>
        /// <param name="FundingCurrency">Funding Currency (ISO 4217).</param>
        public ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails(string RequestId = default(string), string InterchangePerItemFee = default(string), string DiscountPercentage = default(string), string DiscountAmount = default(string), string DiscountPerItemFee = default(string), string TotalFee = default(string), string FeeCurrency = default(string), string DuesAssessments = default(string), string FundingAmount = default(string), string FundingCurrency = default(string))
        {
            this.RequestId = RequestId;
            this.InterchangePerItemFee = InterchangePerItemFee;
            this.DiscountPercentage = DiscountPercentage;
            this.DiscountAmount = DiscountAmount;
            this.DiscountPerItemFee = DiscountPerItemFee;
            this.TotalFee = TotalFee;
            this.FeeCurrency = FeeCurrency;
            this.DuesAssessments = DuesAssessments;
            this.FundingAmount = FundingAmount;
            this.FundingCurrency = FundingCurrency;
        }
        
        /// <summary>
        /// An unique identification number assigned by CyberSource to identify the submitted request.
        /// </summary>
        /// <value>An unique identification number assigned by CyberSource to identify the submitted request.</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// interchange Per Item Fee
        /// </summary>
        /// <value>interchange Per Item Fee</value>
        [DataMember(Name="interchangePerItemFee", EmitDefaultValue=false)]
        public string InterchangePerItemFee { get; set; }

        /// <summary>
        /// Discount Percentage
        /// </summary>
        /// <value>Discount Percentage</value>
        [DataMember(Name="discountPercentage", EmitDefaultValue=false)]
        public string DiscountPercentage { get; set; }

        /// <summary>
        /// Discount Amount
        /// </summary>
        /// <value>Discount Amount</value>
        [DataMember(Name="discountAmount", EmitDefaultValue=false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// Discount Per Item Fee
        /// </summary>
        /// <value>Discount Per Item Fee</value>
        [DataMember(Name="discountPerItemFee", EmitDefaultValue=false)]
        public string DiscountPerItemFee { get; set; }

        /// <summary>
        /// Total Fee
        /// </summary>
        /// <value>Total Fee</value>
        [DataMember(Name="totalFee", EmitDefaultValue=false)]
        public string TotalFee { get; set; }

        /// <summary>
        /// Fee Currency
        /// </summary>
        /// <value>Fee Currency</value>
        [DataMember(Name="feeCurrency", EmitDefaultValue=false)]
        public string FeeCurrency { get; set; }

        /// <summary>
        /// Dues Assessments
        /// </summary>
        /// <value>Dues Assessments</value>
        [DataMember(Name="duesAssessments", EmitDefaultValue=false)]
        public string DuesAssessments { get; set; }

        /// <summary>
        /// Funding Amount
        /// </summary>
        /// <value>Funding Amount</value>
        [DataMember(Name="fundingAmount", EmitDefaultValue=false)]
        public string FundingAmount { get; set; }

        /// <summary>
        /// Funding Currency (ISO 4217)
        /// </summary>
        /// <value>Funding Currency (ISO 4217)</value>
        [DataMember(Name="fundingCurrency", EmitDefaultValue=false)]
        public string FundingCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  InterchangePerItemFee: ").Append(InterchangePerItemFee).Append("\n");
            sb.Append("  DiscountPercentage: ").Append(DiscountPercentage).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountPerItemFee: ").Append(DiscountPerItemFee).Append("\n");
            sb.Append("  TotalFee: ").Append(TotalFee).Append("\n");
            sb.Append("  FeeCurrency: ").Append(FeeCurrency).Append("\n");
            sb.Append("  DuesAssessments: ").Append(DuesAssessments).Append("\n");
            sb.Append("  FundingAmount: ").Append(FundingAmount).Append("\n");
            sb.Append("  FundingCurrency: ").Append(FundingCurrency).Append("\n");
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
            return this.Equals(obj as ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails);
        }

        /// <summary>
        /// Returns true if ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3PurchaseRefundDetailsGet200ResponseFeeAndFundingDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) && 
                (
                    this.InterchangePerItemFee == other.InterchangePerItemFee ||
                    this.InterchangePerItemFee != null &&
                    this.InterchangePerItemFee.Equals(other.InterchangePerItemFee)
                ) && 
                (
                    this.DiscountPercentage == other.DiscountPercentage ||
                    this.DiscountPercentage != null &&
                    this.DiscountPercentage.Equals(other.DiscountPercentage)
                ) && 
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
                ) && 
                (
                    this.DiscountPerItemFee == other.DiscountPerItemFee ||
                    this.DiscountPerItemFee != null &&
                    this.DiscountPerItemFee.Equals(other.DiscountPerItemFee)
                ) && 
                (
                    this.TotalFee == other.TotalFee ||
                    this.TotalFee != null &&
                    this.TotalFee.Equals(other.TotalFee)
                ) && 
                (
                    this.FeeCurrency == other.FeeCurrency ||
                    this.FeeCurrency != null &&
                    this.FeeCurrency.Equals(other.FeeCurrency)
                ) && 
                (
                    this.DuesAssessments == other.DuesAssessments ||
                    this.DuesAssessments != null &&
                    this.DuesAssessments.Equals(other.DuesAssessments)
                ) && 
                (
                    this.FundingAmount == other.FundingAmount ||
                    this.FundingAmount != null &&
                    this.FundingAmount.Equals(other.FundingAmount)
                ) && 
                (
                    this.FundingCurrency == other.FundingCurrency ||
                    this.FundingCurrency != null &&
                    this.FundingCurrency.Equals(other.FundingCurrency)
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
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                if (this.InterchangePerItemFee != null)
                    hash = hash * 59 + this.InterchangePerItemFee.GetHashCode();
                if (this.DiscountPercentage != null)
                    hash = hash * 59 + this.DiscountPercentage.GetHashCode();
                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountPerItemFee != null)
                    hash = hash * 59 + this.DiscountPerItemFee.GetHashCode();
                if (this.TotalFee != null)
                    hash = hash * 59 + this.TotalFee.GetHashCode();
                if (this.FeeCurrency != null)
                    hash = hash * 59 + this.FeeCurrency.GetHashCode();
                if (this.DuesAssessments != null)
                    hash = hash * 59 + this.DuesAssessments.GetHashCode();
                if (this.FundingAmount != null)
                    hash = hash * 59 + this.FundingAmount.GetHashCode();
                if (this.FundingCurrency != null)
                    hash = hash * 59 + this.FundingCurrency.GetHashCode();
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
            // RequestId (string) maxLength
            if(this.RequestId != null && this.RequestId.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestId, length must be less than 26.", new [] { "RequestId" });
            }

            yield break;
        }
    }

}

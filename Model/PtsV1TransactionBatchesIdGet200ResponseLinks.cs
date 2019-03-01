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
    /// PtsV1TransactionBatchesIdGet200ResponseLinks
    /// </summary>
    [DataContract]
    public partial class PtsV1TransactionBatchesIdGet200ResponseLinks :  IEquatable<PtsV1TransactionBatchesIdGet200ResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV1TransactionBatchesIdGet200ResponseLinks" /> class.
        /// </summary>
        /// <param name="Transactions">Transactions.</param>
        public PtsV1TransactionBatchesIdGet200ResponseLinks(List<PtsV1TransactionBatchesIdGet200ResponseLinksTransactions> Transactions = default(List<PtsV1TransactionBatchesIdGet200ResponseLinksTransactions>))
        {
            this.Transactions = Transactions;
        }
        
        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<PtsV1TransactionBatchesIdGet200ResponseLinksTransactions> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV1TransactionBatchesIdGet200ResponseLinks {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(obj as PtsV1TransactionBatchesIdGet200ResponseLinks);
        }

        /// <summary>
        /// Returns true if PtsV1TransactionBatchesIdGet200ResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV1TransactionBatchesIdGet200ResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV1TransactionBatchesIdGet200ResponseLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Transactions == other.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.SequenceEqual(other.Transactions)
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
                if (this.Transactions != null)
                    hash = hash * 59 + this.Transactions.GetHashCode();
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

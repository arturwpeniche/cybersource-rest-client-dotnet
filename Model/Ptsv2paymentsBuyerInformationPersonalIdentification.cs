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
    /// Ptsv2paymentsBuyerInformationPersonalIdentification
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsBuyerInformationPersonalIdentification :  IEquatable<Ptsv2paymentsBuyerInformationPersonalIdentification>, IValidatableObject
    {
        /// <summary>
        /// The type of the indentification.  Possible values:  - **NATIONAL**  - **CPF**  - **CURP**  - **SSN**  - **DRIVER_LICENSE**  This field is supported only on the processors listed in this description.  **ComercioLatino**\\ Set this field to the Cadastro de Pessoas Fisicas (CPF).  **CyberSource Latin American Processing**\\ Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil. **Note** CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.  ccAuthService (Required when the billing country is the U.S. or Canada; otherwise, optional.) This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. See \&quot;Relaxed Requirements for Address Data and Expiration Date,\&quot; page 75. Important It is your responsibility to determine whether a field is required for the transaction you are requesting. 
        /// </summary>
        /// <value>The type of the indentification.  Possible values:  - **NATIONAL**  - **CPF**  - **CURP**  - **SSN**  - **DRIVER_LICENSE**  This field is supported only on the processors listed in this description.  **ComercioLatino**\\ Set this field to the Cadastro de Pessoas Fisicas (CPF).  **CyberSource Latin American Processing**\\ Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil. **Note** CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.  ccAuthService (Required when the billing country is the U.S. or Canada; otherwise, optional.) This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. See \&quot;Relaxed Requirements for Address Data and Expiration Date,\&quot; page 75. Important It is your responsibility to determine whether a field is required for the transaction you are requesting. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Ssn for "ssn"
            /// </summary>
            [EnumMember(Value = "ssn")]
            Ssn,
            
            /// <summary>
            /// Enum Driverlicense for "driverlicense"
            /// </summary>
            [EnumMember(Value = "driverlicense")]
            Driverlicense
        }

        /// <summary>
        /// The type of the indentification.  Possible values:  - **NATIONAL**  - **CPF**  - **CURP**  - **SSN**  - **DRIVER_LICENSE**  This field is supported only on the processors listed in this description.  **ComercioLatino**\\ Set this field to the Cadastro de Pessoas Fisicas (CPF).  **CyberSource Latin American Processing**\\ Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil. **Note** CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.  ccAuthService (Required when the billing country is the U.S. or Canada; otherwise, optional.) This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. See \&quot;Relaxed Requirements for Address Data and Expiration Date,\&quot; page 75. Important It is your responsibility to determine whether a field is required for the transaction you are requesting. 
        /// </summary>
        /// <value>The type of the indentification.  Possible values:  - **NATIONAL**  - **CPF**  - **CURP**  - **SSN**  - **DRIVER_LICENSE**  This field is supported only on the processors listed in this description.  **ComercioLatino**\\ Set this field to the Cadastro de Pessoas Fisicas (CPF).  **CyberSource Latin American Processing**\\ Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil. **Note** CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.  ccAuthService (Required when the billing country is the U.S. or Canada; otherwise, optional.) This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. See \&quot;Relaxed Requirements for Address Data and Expiration Date,\&quot; page 75. Important It is your responsibility to determine whether a field is required for the transaction you are requesting. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsBuyerInformationPersonalIdentification" /> class.
        /// </summary>
        /// <param name="Type">The type of the indentification.  Possible values:  - **NATIONAL**  - **CPF**  - **CURP**  - **SSN**  - **DRIVER_LICENSE**  This field is supported only on the processors listed in this description.  **ComercioLatino**\\ Set this field to the Cadastro de Pessoas Fisicas (CPF).  **CyberSource Latin American Processing**\\ Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil. **Note** CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.  ccAuthService (Required when the billing country is the U.S. or Canada; otherwise, optional.) This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. See \&quot;Relaxed Requirements for Address Data and Expiration Date,\&quot; page 75. Important It is your responsibility to determine whether a field is required for the transaction you are requesting. .</param>
        /// <param name="Id">Personal Identifier for the customer based on various type. This field is supported only on the processors listed in this description.  **ComercioLatino** Set this field to the Cadastro de Pessoas Fisicas (CPF).  **CyberSource Latin American Processing** Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil. **Note** CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.  For processor-specific information, see the personal_id field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="IssuedBy">If type &#x3D; DRIVER_LICENSE, this is the State or province where the customer’s driver’s license was issued. Use the twocharacter State, Province, and Territory Codes for the United States and Canada.  ** TeleCheck ** Contact your TeleCheck representative to find out whether this field is required or optional.  ** All Other Processors ** Not used. .</param>
        public Ptsv2paymentsBuyerInformationPersonalIdentification(TypeEnum? Type = default(TypeEnum?), string Id = default(string), string IssuedBy = default(string))
        {
            this.Type = Type;
            this.Id = Id;
            this.IssuedBy = IssuedBy;
        }
        

        /// <summary>
        /// Personal Identifier for the customer based on various type. This field is supported only on the processors listed in this description.  **ComercioLatino** Set this field to the Cadastro de Pessoas Fisicas (CPF).  **CyberSource Latin American Processing** Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil. **Note** CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.  For processor-specific information, see the personal_id field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Personal Identifier for the customer based on various type. This field is supported only on the processors listed in this description.  **ComercioLatino** Set this field to the Cadastro de Pessoas Fisicas (CPF).  **CyberSource Latin American Processing** Supported for Redecard in Brazil. Set this field to the Cadastro de Pessoas Fisicas (CPF), which is required for AVS for Redecard in Brazil. **Note** CyberSource Latin American Processing is the name of a specific processing connection that CyberSource supports. In the CyberSource API documentation, CyberSource Latin American Processing does not refer to the general topic of processing in Latin America. The information in this field description is for the specific processing connection called CyberSource Latin American Processing. It is not for any other Latin American processors that CyberSource supports.  For processor-specific information, see the personal_id field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// If type &#x3D; DRIVER_LICENSE, this is the State or province where the customer’s driver’s license was issued. Use the twocharacter State, Province, and Territory Codes for the United States and Canada.  ** TeleCheck ** Contact your TeleCheck representative to find out whether this field is required or optional.  ** All Other Processors ** Not used. 
        /// </summary>
        /// <value>If type &#x3D; DRIVER_LICENSE, this is the State or province where the customer’s driver’s license was issued. Use the twocharacter State, Province, and Territory Codes for the United States and Canada.  ** TeleCheck ** Contact your TeleCheck representative to find out whether this field is required or optional.  ** All Other Processors ** Not used. </value>
        [DataMember(Name="issuedBy", EmitDefaultValue=false)]
        public string IssuedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsBuyerInformationPersonalIdentification {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuedBy: ").Append(IssuedBy).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsBuyerInformationPersonalIdentification);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsBuyerInformationPersonalIdentification instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsBuyerInformationPersonalIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsBuyerInformationPersonalIdentification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IssuedBy == other.IssuedBy ||
                    this.IssuedBy != null &&
                    this.IssuedBy.Equals(other.IssuedBy)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IssuedBy != null)
                    hash = hash * 59 + this.IssuedBy.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 26.", new [] { "Id" });
            }

            yield break;
        }
    }

}

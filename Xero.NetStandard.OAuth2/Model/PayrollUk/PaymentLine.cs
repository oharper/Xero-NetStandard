/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
 *
 * The version of the OpenAPI document: 2.7.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollUk
{
    /// <summary>
    /// PaymentLine
    /// </summary>
    [DataContract]
    public partial class PaymentLine :  IEquatable<PaymentLine>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier for payroll payment line
        /// </summary>
        /// <value>Xero identifier for payroll payment line</value>
        [DataMember(Name="paymentLineID", EmitDefaultValue=false)]
        public Guid? PaymentLineID { get; set; }

        /// <summary>
        /// The amount of the payment line
        /// </summary>
        /// <value>The amount of the payment line</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// The account number
        /// </summary>
        /// <value>The account number</value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The account sort code
        /// </summary>
        /// <value>The account sort code</value>
        [DataMember(Name="sortCode", EmitDefaultValue=false)]
        public string SortCode { get; set; }

        /// <summary>
        /// The account name
        /// </summary>
        /// <value>The account name</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentLine {\n");
            sb.Append("  PaymentLineID: ").Append(PaymentLineID).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  SortCode: ").Append(SortCode).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentLine);
        }

        /// <summary>
        /// Returns true if PaymentLine instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentLineID == input.PaymentLineID ||
                    (this.PaymentLineID != null &&
                    this.PaymentLineID.Equals(input.PaymentLineID))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.SortCode == input.SortCode ||
                    (this.SortCode != null &&
                    this.SortCode.Equals(input.SortCode))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
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
                if (this.PaymentLineID != null)
                    hashCode = hashCode * 59 + this.PaymentLineID.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.SortCode != null)
                    hashCode = hashCode * 59 + this.SortCode.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                return hashCode;
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

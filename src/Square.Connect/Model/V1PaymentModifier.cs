/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
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

namespace Square.Connect.Model
{
    /// <summary>
    /// V1PaymentModifier
    /// </summary>
    [DataContract]
    public partial class V1PaymentModifier :  IEquatable<V1PaymentModifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PaymentModifier" /> class.
        /// </summary>
        /// <param name="Name">The modifier option&#39;s name..</param>
        /// <param name="AppliedMoney">The amount of money that this modifier option adds to the payment..</param>
        /// <param name="ModifierOptionId">TThe ID of the applied modifier option, if available. Modifier options applied in older versions of Square Register might not have an ID..</param>
        public V1PaymentModifier(string Name = default(string), V1Money AppliedMoney = default(V1Money), string ModifierOptionId = default(string))
        {
            this.Name = Name;
            this.AppliedMoney = AppliedMoney;
            this.ModifierOptionId = ModifierOptionId;
        }
        
        /// <summary>
        /// The modifier option&#39;s name.
        /// </summary>
        /// <value>The modifier option&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The amount of money that this modifier option adds to the payment.
        /// </summary>
        /// <value>The amount of money that this modifier option adds to the payment.</value>
        [DataMember(Name="applied_money", EmitDefaultValue=false)]
        public V1Money AppliedMoney { get; set; }
        /// <summary>
        /// TThe ID of the applied modifier option, if available. Modifier options applied in older versions of Square Register might not have an ID.
        /// </summary>
        /// <value>TThe ID of the applied modifier option, if available. Modifier options applied in older versions of Square Register might not have an ID.</value>
        [DataMember(Name="modifier_option_id", EmitDefaultValue=false)]
        public string ModifierOptionId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PaymentModifier {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AppliedMoney: ").Append(AppliedMoney).Append("\n");
            sb.Append("  ModifierOptionId: ").Append(ModifierOptionId).Append("\n");
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
            return this.Equals(obj as V1PaymentModifier);
        }

        /// <summary>
        /// Returns true if V1PaymentModifier instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PaymentModifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PaymentModifier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AppliedMoney == other.AppliedMoney ||
                    this.AppliedMoney != null &&
                    this.AppliedMoney.Equals(other.AppliedMoney)
                ) && 
                (
                    this.ModifierOptionId == other.ModifierOptionId ||
                    this.ModifierOptionId != null &&
                    this.ModifierOptionId.Equals(other.ModifierOptionId)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AppliedMoney != null)
                    hash = hash * 59 + this.AppliedMoney.GetHashCode();
                if (this.ModifierOptionId != null)
                    hash = hash * 59 + this.ModifierOptionId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

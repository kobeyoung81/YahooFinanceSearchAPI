/* 
 * Yahoo Finance Search API
 *
 * This is the API from yahoo finance to search for symbols.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: kobeyoung81@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = YahooFinance.SearchTerm.Client.SwaggerDateConverter;

namespace YahooFinance.SearchTerm.Model
{
    /// <summary>
    /// YahooTicker
    /// </summary>
    [DataContract]
        public partial class YahooTicker :  IEquatable<YahooTicker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YahooTicker" /> class.
        /// </summary>
        /// <param name="symbol">symbol.</param>
        /// <param name="name">name.</param>
        /// <param name="exch">exch.</param>
        /// <param name="type">type.</param>
        /// <param name="exchDisp">exchDisp.</param>
        /// <param name="typeDisp">typeDisp.</param>
        public YahooTicker(string symbol = default(string), string name = default(string), string exch = default(string), string type = default(string), string exchDisp = default(string), string typeDisp = default(string))
        {
            this.Symbol = symbol;
            this.Name = name;
            this.Exch = exch;
            this.Type = type;
            this.ExchDisp = exchDisp;
            this.TypeDisp = typeDisp;
        }
        
        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Exch
        /// </summary>
        [DataMember(Name="exch", EmitDefaultValue=false)]
        public string Exch { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ExchDisp
        /// </summary>
        [DataMember(Name="exchDisp", EmitDefaultValue=false)]
        public string ExchDisp { get; set; }

        /// <summary>
        /// Gets or Sets TypeDisp
        /// </summary>
        [DataMember(Name="typeDisp", EmitDefaultValue=false)]
        public string TypeDisp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class YahooTicker {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Exch: ").Append(Exch).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExchDisp: ").Append(ExchDisp).Append("\n");
            sb.Append("  TypeDisp: ").Append(TypeDisp).Append("\n");
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
            return this.Equals(input as YahooTicker);
        }

        /// <summary>
        /// Returns true if YahooTicker instances are equal
        /// </summary>
        /// <param name="input">Instance of YahooTicker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YahooTicker input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Exch == input.Exch ||
                    (this.Exch != null &&
                    this.Exch.Equals(input.Exch))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ExchDisp == input.ExchDisp ||
                    (this.ExchDisp != null &&
                    this.ExchDisp.Equals(input.ExchDisp))
                ) && 
                (
                    this.TypeDisp == input.TypeDisp ||
                    (this.TypeDisp != null &&
                    this.TypeDisp.Equals(input.TypeDisp))
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Exch != null)
                    hashCode = hashCode * 59 + this.Exch.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ExchDisp != null)
                    hashCode = hashCode * 59 + this.ExchDisp.GetHashCode();
                if (this.TypeDisp != null)
                    hashCode = hashCode * 59 + this.TypeDisp.GetHashCode();
                return hashCode;
            }
        }
    }
}

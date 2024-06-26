/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = BeamPlayerClient.Client.OpenAPIDateConverter;

namespace BeamPlayerClient.Model
{
    /// <summary>
    /// GetAssetListingsResponseDataInnerPriceCurrency
    /// </summary>
    [DataContract(Name = "GetAssetListingsResponse_data_inner_price_currency")]
    public partial class GetAssetListingsResponseDataInnerPriceCurrency
    {
        /// <summary>
        /// Defines Symbol
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SymbolEnum
        {
            /// <summary>
            /// Enum BEAM for value: BEAM
            /// </summary>
            [EnumMember(Value = "BEAM")]
            BEAM = 1,

            /// <summary>
            /// Enum WBEAM for value: WBEAM
            /// </summary>
            [EnumMember(Value = "WBEAM")]
            WBEAM = 2,

            /// <summary>
            /// Enum USDC for value: USDC
            /// </summary>
            [EnumMember(Value = "USDC")]
            USDC = 3,

            /// <summary>
            /// Enum USDT for value: USDT
            /// </summary>
            [EnumMember(Value = "USDT")]
            USDT = 4,

            /// <summary>
            /// Enum IMX for value: IMX
            /// </summary>
            [EnumMember(Value = "IMX")]
            IMX = 5,

            /// <summary>
            /// Enum WIMX for value: WIMX
            /// </summary>
            [EnumMember(Value = "WIMX")]
            WIMX = 6
        }


        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = true)]
        public SymbolEnum? Symbol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetListingsResponseDataInnerPriceCurrency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAssetListingsResponseDataInnerPriceCurrency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetListingsResponseDataInnerPriceCurrency" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="decimals">decimals (required).</param>
        public GetAssetListingsResponseDataInnerPriceCurrency(string address = default(string), SymbolEnum? symbol = default(SymbolEnum?), int decimals = default(int))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for GetAssetListingsResponseDataInnerPriceCurrency and cannot be null");
            }
            this.Address = address;
            this.Decimals = decimals;
            this.Symbol = symbol;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [DataMember(Name = "decimals", IsRequired = true, EmitDefaultValue = true)]
        public int Decimals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetListingsResponseDataInnerPriceCurrency {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
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

    }

}

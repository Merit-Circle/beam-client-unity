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
    /// GetAllUsersResponse
    /// </summary>
    [DataContract(Name = "GetAllUsersResponse")]
    public partial class GetAllUsersResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllUsersResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAllUsersResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllUsersResponse" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="pagination">pagination (required).</param>
        public GetAllUsersResponse(List<GetAllUsersResponseDataInner> data = default(List<GetAllUsersResponseDataInner>), GetTransactionsResponsePagination pagination = default(GetTransactionsResponsePagination))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for GetAllUsersResponse and cannot be null");
            }
            this.Data = data;
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for GetAllUsersResponse and cannot be null");
            }
            this.Pagination = pagination;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public List<GetAllUsersResponseDataInner> Data { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", IsRequired = true, EmitDefaultValue = true)]
        public GetTransactionsResponsePagination Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAllUsersResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
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
    /// 
    /// </summary>
    /// <value></value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum V1FeeType
    {
        
        /// <summary>
        /// Enum CAGST for "CA_GST"
        /// </summary>
        [EnumMember(Value = "CA_GST")]
        CAGST,
        
        /// <summary>
        /// Enum CAHST for "CA_HST"
        /// </summary>
        [EnumMember(Value = "CA_HST")]
        CAHST,
        
        /// <summary>
        /// Enum CAPST for "CA_PST"
        /// </summary>
        [EnumMember(Value = "CA_PST")]
        CAPST,
        
        /// <summary>
        /// Enum CAQST for "CA_QST"
        /// </summary>
        [EnumMember(Value = "CA_QST")]
        CAQST,
        
        /// <summary>
        /// Enum JPCONSUMPTIONTAX for "JP_CONSUMPTION_TAX"
        /// </summary>
        [EnumMember(Value = "JP_CONSUMPTION_TAX")]
        JPCONSUMPTIONTAX,
        
        /// <summary>
        /// Enum CAPEIPST for "CA_PEI_PST"
        /// </summary>
        [EnumMember(Value = "CA_PEI_PST")]
        CAPEIPST,
        
        /// <summary>
        /// Enum USSALESTAX for "US_SALES_TAX"
        /// </summary>
        [EnumMember(Value = "US_SALES_TAX")]
        USSALESTAX,
        
        /// <summary>
        /// Enum OTHER for "OTHER"
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER
    }

}

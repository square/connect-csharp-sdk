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
    /// Enumerates the `Shift` fields to sort on.
    /// </summary>
    /// <value>Enumerates the `Shift` fields to sort on.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShiftSortField
    {
        
        /// <summary>
        /// Enum STARTAT for "START_AT"
        /// </summary>
        [EnumMember(Value = "START_AT")]
        STARTAT,
        
        /// <summary>
        /// Enum ENDAT for "END_AT"
        /// </summary>
        [EnumMember(Value = "END_AT")]
        ENDAT,
        
        /// <summary>
        /// Enum CREATEDAT for "CREATED_AT"
        /// </summary>
        [EnumMember(Value = "CREATED_AT")]
        CREATEDAT,
        
        /// <summary>
        /// Enum UPDATEDAT for "UPDATED_AT"
        /// </summary>
        [EnumMember(Value = "UPDATED_AT")]
        UPDATEDAT
    }

}
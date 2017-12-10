using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.TelstraTPN.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Error {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="ns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ns")]
    public string Ns { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="error-code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error-code")]
    public int? ErrorCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="error-message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error-message")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="error-auxiliary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error-auxiliary")]
    public string ErrorAuxiliary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Error {\n");
      sb.Append("  Ns: ").Append(Ns).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  ErrorAuxiliary: ").Append(ErrorAuxiliary).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

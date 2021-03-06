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
  public class Model100InventoryVnfendpointResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="success-auxiliary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success-auxiliary")]
    public string SuccessAuxiliary { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="success-code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success-code")]
    public int? SuccessCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="success-message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success-message")]
    public string SuccessMessage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="customeruuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customeruuid")]
    public string Customeruuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="vnfuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vnfuuid")]
    public string Vnfuuid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Model100InventoryVnfendpointResponse {\n");
      sb.Append("  SuccessAuxiliary: ").Append(SuccessAuxiliary).Append("\n");
      sb.Append("  SuccessCode: ").Append(SuccessCode).Append("\n");
      sb.Append("  SuccessMessage: ").Append(SuccessMessage).Append("\n");
      sb.Append("  Customeruuid: ").Append(Customeruuid).Append("\n");
      sb.Append("  Vnfuuid: ").Append(Vnfuuid).Append("\n");
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

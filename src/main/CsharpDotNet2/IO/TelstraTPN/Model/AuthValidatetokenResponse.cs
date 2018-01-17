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
  public class AuthValidatetokenResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="company-name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company-name")]
    public string CompanyName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="userid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userid")]
    public string Userid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="internalid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internalid")]
    public int? Internalid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="customerid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerid")]
    public string Customerid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="customer-account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customer-account")]
    public string CustomerAccount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="billings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billings")]
    public List<Billing> Billings { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<Role> Roles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthValidatetokenResponse {\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  Userid: ").Append(Userid).Append("\n");
      sb.Append("  Internalid: ").Append(Internalid).Append("\n");
      sb.Append("  Customerid: ").Append(Customerid).Append("\n");
      sb.Append("  CustomerAccount: ").Append(CustomerAccount).Append("\n");
      sb.Append("  Billings: ").Append(Billings).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
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

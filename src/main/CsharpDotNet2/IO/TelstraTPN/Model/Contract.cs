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
  public class Contract {
    /// <summary>
    /// Identifier of a contract
    /// </summary>
    /// <value>Identifier of a contract</value>
    [DataMember(Name="contractid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractid")]
    public string Contractid { get; set; }

    /// <summary>
    /// Duration of contract in minutes
    /// </summary>
    /// <value>Duration of contract in minutes</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Bandwidth in kB/s
    /// </summary>
    /// <value>Bandwidth in kB/s</value>
    [DataMember(Name="bandwidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bandwidth")]
    public int? Bandwidth { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public int? Price { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="contractStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contractStatus")]
    public int? ContractStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public int? Version { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="deletedtimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletedtimestamp")]
    public int? Deletedtimestamp { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="currencyCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyCode")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="currencyID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currencyID")]
    public string CurrencyID { get; set; }

    /// <summary>
    /// Renewal Option: 0=Auto Disconnect, 1=Auto Renew, 2=Pay per hour
    /// </summary>
    /// <value>Renewal Option: 0=Auto Disconnect, 1=Auto Renew, 2=Pay per hour</value>
    [DataMember(Name="renewal-option", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renewal-option")]
    public int? RenewalOption { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="contract-start-time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contract-start-time")]
    public int? ContractStartTime { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="contract-end-time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contract-end-time")]
    public int? ContractEndTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Contract {\n");
      sb.Append("  Contractid: ").Append(Contractid).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Bandwidth: ").Append(Bandwidth).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  ContractStatus: ").Append(ContractStatus).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Deletedtimestamp: ").Append(Deletedtimestamp).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
      sb.Append("  RenewalOption: ").Append(RenewalOption).Append("\n");
      sb.Append("  ContractStartTime: ").Append(ContractStartTime).Append("\n");
      sb.Append("  ContractEndTime: ").Append(ContractEndTime).Append("\n");
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

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
  public class Model100AccountResponse {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="fax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fax")]
    public string Fax { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "website")]
    public string Website { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="companyuuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "companyuuid")]
    public string Companyuuid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="companyname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "companyname")]
    public string Companyname { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="postalcode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postalcode")]
    public string Postalcode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="customertype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customertype")]
    public string Customertype { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="customeraccountid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customeraccountid")]
    public string Customeraccountid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Model100AccountResponse {\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Fax: ").Append(Fax).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
      sb.Append("  Companyuuid: ").Append(Companyuuid).Append("\n");
      sb.Append("  Companyname: ").Append(Companyname).Append("\n");
      sb.Append("  Postalcode: ").Append(Postalcode).Append("\n");
      sb.Append("  Customertype: ").Append(Customertype).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Customeraccountid: ").Append(Customeraccountid).Append("\n");
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

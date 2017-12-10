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
  public class User {
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="useruuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useruuid")]
    public string Useruuid { get; set; }

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
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="usercountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usercountry")]
    public string Usercountry { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="emailaddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailaddress")]
    public string Emailaddress { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="jobtitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobtitle")]
    public string Jobtitle { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="firstname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstname")]
    public string Firstname { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="middlename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "middlename")]
    public string Middlename { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="lastname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastname")]
    public string Lastname { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="phonenumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phonenumber")]
    public string Phonenumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="phoneext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneext")]
    public string Phoneext { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    [DataMember(Name="phonetype", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phonetype")]
    public string Phonetype { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      sb.Append("  Useruuid: ").Append(Useruuid).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Usercountry: ").Append(Usercountry).Append("\n");
      sb.Append("  Emailaddress: ").Append(Emailaddress).Append("\n");
      sb.Append("  Jobtitle: ").Append(Jobtitle).Append("\n");
      sb.Append("  Firstname: ").Append(Firstname).Append("\n");
      sb.Append("  Middlename: ").Append(Middlename).Append("\n");
      sb.Append("  Lastname: ").Append(Lastname).Append("\n");
      sb.Append("  Phonenumber: ").Append(Phonenumber).Append("\n");
      sb.Append("  Phoneext: ").Append(Phoneext).Append("\n");
      sb.Append("  Phonetype: ").Append(Phonetype).Append("\n");
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

using System;
using System.Runtime.Serialization;

namespace WebAPIClient
{
  public class Repository
  {
    [DataMember(Name="name")]
    public string Name { get; set; }
  }
}
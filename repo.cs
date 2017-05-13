using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace WebAPIClient
{
  public class repo
  {
    public string name;
    var serializer = new DataContractJsonSerializer(typeof(List<repo>));
  }
}
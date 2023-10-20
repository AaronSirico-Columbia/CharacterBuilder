using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder.Models
{
    public static class JSONSerializer
    {
        public static string JsonSerialize<T>(this T toSerialize)
        {
            return JsonConvert.SerializeObject(toSerialize);
        }

        public static T JsonDeserialize<T>(this string toDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(toDeserialize);
        }

    }
}

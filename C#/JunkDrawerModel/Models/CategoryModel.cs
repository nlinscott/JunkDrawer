using JunkDrawerModel.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkDrawerModel.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CategoryModel : ICategory, IJsonObject<ICategory>
    {
        private int _categoryID;
        private string _categoryName;

        [JsonConstructor]
        public CategoryModel()
        {
        }

        [JsonProperty]
        public string CategoryName
        {
            get
            {
                return _categoryName;
            }
            set
            {
                _categoryName = value;
            }
        }

        [JsonProperty]
        public int CategoryID
        {
            get
            {
                return _categoryID;
            }
            set
            {
                _categoryID = value;
            }
        }

        public string convertToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        private ICategory convertFromJSON(string catJson)
        {
            return JsonConvert.DeserializeObject<ICategory>(catJson);
        }
    }
}

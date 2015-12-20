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
    public class GoodIdeaModel : IGoodIdea, IJsonObject<IGoodIdea>
    {
        private string _author;
        private string _description;
        private int _id;
        private int _voteCount;
        private string _ideaName;
        private string _links;
        private string _category;

        [JsonConstructor]
        public GoodIdeaModel()
        {
        }

        public string convertToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        [JsonProperty]
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }

        [JsonProperty]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        [JsonProperty]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        [JsonProperty]
        public int VoteCount
        {
            get
            {
                return _voteCount;
            }
            set
            {
                _voteCount = value;
            }
        }

        [JsonProperty]
        public string IdeaName
        {
            get
            {
                return _ideaName;
            }
            set
            {
                _ideaName = value;
            }
        }

        [JsonProperty]
        public string Links
        {
            get
            {
                return _links;
            }
            set
            {
                _links = value;
            }
        }

        [JsonProperty]
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
    }
}

using JunkDrawerModel.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;


namespace JunkDrawerModel.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class IdeaModel : IIdea, IJsonObject<IIdea>
    {
        private int _id;
        private string _author;
        private int _voteCount;
        private string _description;
        private int _isPermanent;
        private string _category;
        private DateTime _expiration;
        private string _ideaName;

        [JsonConstructor]
        public IdeaModel()
        {
        }


        private void initialize(IIdea idea)
        {
            this._id = idea.ID;
            this._author = idea.Author;
            this._description = idea.Description;
            this._isPermanent = idea.IsPermanent;
            this._voteCount = idea.VoteCount;

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
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        [JsonProperty]
        public DateTime Expiration
        {
            get { return _expiration; }
            set
            {
                _expiration = value;
            }
        }

        [JsonProperty]
        public string IdeaName
        {
            get { return _ideaName; }
            set { _ideaName = value; }
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
        public int IsPermanent
        {
            get
            {
                return _isPermanent;
            }
            set
            {
                _isPermanent = value;
                
            }
        }

        public bool IsPermanentIdea
        {
            get
            {
                return _isPermanent > 0;
            }
        }

        public string convertToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        private IIdea convertFromJSON(string ideaJson)
        {
           return JsonConvert.DeserializeObject<IIdea>(ideaJson);
        }
    }
}

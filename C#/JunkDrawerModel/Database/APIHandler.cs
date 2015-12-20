using JunkDrawerModel.Constants;
using JunkDrawerModel.Interface;
using JunkDrawerModel.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace JunkDrawerModel.Database
{
    public class APIHandler
    {
        public IEnumerable<IBadIdea> GetBadIdeaList()
        {
            string json = GetJSON(Handles.BAD_IDEA_URL);

            return JsonConvert.DeserializeObject<List<BadIdeaModel>>(json);
        }

        public bool CastVote(int ID, int number)
        {
            return PostVote(ID, number);
        }

        public IEnumerable<ICategory> GetAllCategories()
        {
            string json = GetJSON(Handles.CATEGORIES_URL);

            return JsonConvert.DeserializeObject<List<CategoryModel>>(json);
        }

        public IEnumerable<IGoodIdea> GetGoodIdeaList()
        {
            string json = GetJSON(Handles.GOOD_IDEA_URL);

            return JsonConvert.DeserializeObject<List<GoodIdeaModel>>(json); 
        }

        public IEnumerable<IGoodIdea> GetIdeaByID(int id)
        {
            string json = GetJSON(Handles.GET_IDEA_URL + id);

            return JsonConvert.DeserializeObject < List<GoodIdeaModel>>(json);
        }

        public bool CreateItem(string author, string ideaName, string description, int catID)
        {
            return PostNewItem(author, ideaName, description, catID);
        }

        

        private bool PostNewItem(string author, string ideaName, string description, int catID)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Handles.CREATE_URL);
            request.Method = "POST";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();

            string data = string.Format("idea_name={0}&description={1}&category_id={2}&author={3}",
                HttpUtility.UrlEncode(ideaName),
                HttpUtility.UrlEncode(description), 
                catID,
                author);

            byte[] byteArray = encoding.GetBytes(data);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/x-www-form-urlencoded";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            long length = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    length = response.ContentLength;
                }
                return true;
            }
            catch (WebException ex)
            {
                // Log exception and throw as for GET example above
            }
            return false;
        }

        private bool PostVote(int ID, int number)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Handles.VOTE_URL);
            request.Method = "POST";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();

            string data = string.Format("Number={0}&ID={1}", number, ID);

            byte[] byteArray = encoding.GetBytes(data);

            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/x-www-form-urlencoded";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            long length = 0;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    length = response.ContentLength;
                }
                return true;
            }
            catch (WebException ex)
            {
                // Log exception and throw as for GET example above
            }
            return false;
        }

        private string GetJSON(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;

                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    string errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }

    }
}

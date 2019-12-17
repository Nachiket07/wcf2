using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace wcf2.service
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Serve
    {
        [OperationContract, WebGet(ResponseFormat = WebMessageFormat.Json)]
        public List<Heros> GetAllHeroes()
        {
            return DataHeros.SuperHeros;
        }
        [OperationContract, WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetHero/{id}")]
        public Heros GetHero(String id)
        {
            return DataHeros.SuperHeros.Find(sh =>sh.id == int.Parse(id));
        }
        [OperationContract, WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddHeros", BodyStyle =WebMessageBodyStyle.Bare,Method ="POST")]
        public Heros AddHeros(Heros h)
        {
            h.id = DataHeros.SuperHeros.Max(sh=>sh.id)+1;
            DataHeros.SuperHeros.Add(h);
            return h;
        }
        [OperationContract, WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteHeros/{id}", BodyStyle = WebMessageBodyStyle.Bare, Method = "DELETE")]
        public List<Heros> DeleteHeros(String id)
        {
            DataHeros.SuperHeros = DataHeros.SuperHeros.Where(sh => sh.id != int.Parse(id)).ToList();
            return DataHeros.SuperHeros;
        }

        [OperationContract, WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "UpdateHeros", BodyStyle = WebMessageBodyStyle.Bare, Method = "PUT")]
        public List<Heros> UpdateHeros(Heros h)
        {
            Heros d = DataHeros.SuperHeros.Where(sh => sh.id == h.id).FirstOrDefault();
            d.HeroName = h.HeroName;
            d.FirstName = h.LastName;
            d.LastName = h.LastName;
            d.PlcaeOfBirth = h.PlcaeOfBirth;
            d.Combat = h.Combat;
            return DataHeros.SuperHeros;
        }
    }
}

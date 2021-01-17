
using Matbaa.Services.BLL.Manager;
using Matbaa.Services.BLL.Manager.ApiProducts;
using ResellerWebProjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ResellerWebProjects.Controllers
{
    public class HomeController : Controller
    {

        Manager manager = new Manager();
        public string Token()
        {
            HttpCookie TokenCookie = Request.Cookies["token"];
            string token = "";
            if (TokenCookie == null || TokenCookie.Value == "")
            {
                Task.Run(() =>
                {
                    //Token parametreleri Api tarafında 1 günlük olarak alınır
                    CreateToken createToken = new CreateToken("API KEY");
                    HttpCookie cokieToken = new HttpCookie("token", createToken.token.token);
                    cokieToken.Expires = DateTime.UtcNow.AddDays(1);
                    Response.Cookies.Add(cokieToken);
                    token = createToken.token.token;

                }).Wait();
            }
            else
            {
                token = Request.Cookies["token"].Value.ToString();
            }

            return token;

        }
        // GET: Home
        public ActionResult Index()
        {
            List<spProductModels> AllModels = new List<spProductModels>();
            Task.Run(() =>
            {
                AllModels = manager.GetProductAlList(Token());
            }).Wait();
            return View(AllModels);
        }
        public ActionResult ModelDetail(int Id)
        {
            SingleModels singleModel = new SingleModels();
         
            Task.Run(() =>
            {
                ProductFilter filter = new ProductFilter
                {
                    Id = Id
                };
                singleModel = manager.GetProduct(filter, Token());
            }).Wait();

            return View(singleModel);
        }
        [AjaxChildActionOnly]
        [HttpPost]
        public string svgCallAction(FormCollection data)
        {

            Manager m = new Manager();

            var param = new Dictionary<object, object>();

            foreach (var item in data)
            {
                param.Add(item, data[item.ToString()].ToString());
            }
            var DataJson = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            return m.Models(DataJson, Token()).svg;
        }

        [AjaxChildActionOnly]
        [HttpPost]
        public string svgCall() 
        {
            string ls = "";
            //string ls = "https://kutumodeli.com/Content/models/Print.min.js";
            return ls;
        }
        public string UserHakRemove(int ImagesID)
        {
     
                return "";
        }
        #region Örnek APi Modelleri
        // Tüm Modeller
        public ActionResult AllModels()
        {
            List<spProductModels> AllModels = new List<spProductModels>();       
            Task.Run(() =>
            {
                AllModels = manager.GetProductAlList(Token());
            }).Wait();
            return View(AllModels);
        }
        // Bu method Group Modeller Id parametresi bir grubun Id numarasıdır 
        public ActionResult GroupModels()
        {
            List<spProductModels> GroupModel = new List<spProductModels>();
            int GroupId = 25;
            ProductFilter filter = new ProductFilter
            {
              GroupID = GroupId
            };
            Task.Run(() =>
            {
               
                GroupModel = manager.GetProductGroupList(filter, Token());
            }).Wait();
            return View(GroupModel);          
        }
 
        #endregion

    }
}
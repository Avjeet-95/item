using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace first_pgrogram_mvc.Controllers
{
    public class HomeController : Controller
    {
    
        
        public ActionResult index()
        {
            throw new Exception("this is a tool");
        }


        public string profile(int id)
        {

            string prof = string.Empty;
            if(id==1)
            {
                prof = "emp1";

            }
            else if(id==3)
            {
                prof = "emp2";
            }
            return prof;
        }




        public string data( int id)
        {
            string show = profile( id);
            return show;
        }


        public string address(int id, string dep)
        {
            return "id="+id+"dep="+dep;
        }


      public string ad(int id,int?code=null)
        {
            return "id=" + id + "dep=" + code;
        }
    }





}
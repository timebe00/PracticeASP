using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prt3.Controllers
{
    //  모든 컨트롤러는 System.Web.Mvc.Controller에서 파생된다.

    //  Home 시작점
    public class HomeController : Controller
    {
        // GET: Home

        //  액션 메서드에서 ViewResult외에도 RedirectResult or HttpUnauthorizedResult라는 Result객체를 사용할 수 있다.
        //  위와 같은 객체들은 Action Result라고 한다. 이 객체들은 Action Result클래스에서 파생된 객체들이다.

        //  RedirextResult : 브라우저가 다른 URL로 재요청 하게 한다.
        //  HttpUnauthorizedResult : 사용자 로그인 하도록 하게 한다.

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Insa = hour < 12 ? "좋은 아침" : "즐거운 오후";
            return View();  //  View() 메서든는 ViewResult 객체를 생성하는 메서드
        }


        //  뷰 이름과 컨트롤러 이름이 같아야 한다.
        /*public ViewResult Index()
        {
            return View();  //  View() 메서든는 ViewResult 객체를 생성하는 메서드
        }*/
        /*public string Index()
        {
            return "Hellow World";
        }*/
        /*public ActionResult Index()
        {
            return View();
        }*/
    }
}
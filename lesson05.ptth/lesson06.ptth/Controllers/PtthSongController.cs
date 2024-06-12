using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lesson06.ptth.Models;

namespace lesson06.ptth.Controllers
{
    public class PtthSongController : Controller
    {
        private static List<PtthSong> PtthSongs = new List<PtthSong>()
        {
            new PtthSong{Id="210900030", PtthTitle="Phạm Thị Thu Huyền", PtthAuthor="K22CNT4", PtthArtist="NTU", PtthYearRelease=2020 },
            new PtthSong{Id="1", PtthTitle=" Thu Huyền", PtthAuthor="K22CNT4", PtthArtist="NTU", PtthYearRelease=2020 }

        };
        // GET: PtthSong
        public ActionResult PtthIndex()
        {
            return View(PtthSongs);
        }
        //Get:PtthCreate 
        /// <summary>
        /// Form thêm mới bài hát
        /// Author: Phạm Thị Thu Huyền 
        /// </summary>
        /// <returns></returns>
        public ActionResult PtthCreate()
        {
            var PtthSong = new PtthSong();
            return View();
        }
    }
}
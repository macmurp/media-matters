using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using media_matters.Models;
using Microsoft.AspNetCore.Mvc;

namespace media_matters.Controllers
{
    public class HomeController : Controller
    {
        public List<Album> AlbumList = new List<Album>()
        {
            new Album("tobi lou and the Loop - EP", "tobi lou", "tobi lou and the loop.jpg", "The songs have a relaxing, chill trap style hip-hop beat and smooth rap."),
            new Album("Haus Party, Pt. 1", "Todrick Hall", "haus party.png", "The kind of songs that you'd hear in a dance club, and lyrics that slay."),
            new Album("Haus Party, Pt. 2", "Todrick Hall", "haus party2.jpg", "Same as Haus Party part 1: The kind of songs that you'd hear in a dance club, and lyrics that slay."),
            new Album("WHEN WE ALL FALL ASLEEP, WHERE DO WE GO?", "Billie Eilish", "when we all fall asleep.png", "Easy to catch yourself humming later, with a bit of a darker theme."),
            new Album("cheer up!", "suggi", "cheer up.png", "Each song sounds peppy, but it masks the not-so-happy lyrics.")
        };
        public List<Book> BookList = new List<Book>()
        {
            new Book("0-688-14627-9", "Turner", "Megan", "The Thief", "First ed.", "October 1996", "the thief.jpg", "The beginning of the Queen's Thief series, whose main character is a skilled thief given freedom from his crimes- if he does something for their king, first. The ending twist sets up the rest of the series."),
            new Book("0-688-17423-X", "Turner", "Megan", "The Queen of Attolia", "First ed.", "April 2000", "the queen of attolia.jpg", "Part of the Queen's Thief series, with a compelling cast of characters, who aren't the greatest people- including the main character, who goes through a lot of character growth and twists."),
            new Book("0-571-05686-5", "Golding", "William", "Lord of The Flies", "First ed.", "September 1954", "lord of the flies.jpg", "Started as required reading back in middle school, but it quickly became one of the few required books that I read weeks ahead due to thoroughly enjoying it."),
            new Book("0-7475-3269-9", "Rowling", "Joanne", "Harry Potter and the Philosopher's Stone", "First ed.", "September 1998", "harry potter and the philosophers stone.jpg", "A hallmark of my childhood, and an inspiration for my own art and writing whenever relating to magic."),
            new Book("978-0-439-02352-8", "Collins", "Suzanne", "The Hunger Games", "First ed.", "September 2008", "the hunger games.jpg", "Another large influence on my creativity in my childhood, even though I didn't like some of the last novels in the series.")
        };
        public List<Videogame> VideogameList = new List<Videogame>()
        {
            new Videogame("Majora's Mask", "Nintendo 64", "majoras mask.jpg", "Action-adventure", "For a long time we only owned a Nintendo 64, so this game was the majority of my childhood, and the one I replayed the most."),
            new Videogame("League of Legends", "PC", "league of legends.jpg", "MOBA", "A game my friends introduced to me about 2 years ago, that we still get together to play and mess around in."),
            new Videogame("Final Fantasy XIV", "PC", "ffxiv.png", "MMORPG", "One of the best MMORPGs I've played, with surprisingly good story for an MMO. Grindy but fun."),
            new Videogame("VRchat", "Oculus Rift/HTC Vive", "vrchat.jpg", "Casual MMO", "Essentially just a chat room but in VR, that gives power to its users by letting them be creators. I met most of my friends through here, and create worlds and 3D models to use ingame."),
            new Videogame("Ocarina of Time", "Nintendo 64", "ocarina of time.png", "Action-adventure", "Same explanation as Majora's Mask.")
        };
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Books()
        {
            ViewBag.BookList = BookList;
            ViewBag.BookCount = BookList.Count();
            return View();
        }
        public IActionResult Albums()
        {
            ViewBag.AlbumList = AlbumList;
            ViewBag.AlbumCount = AlbumList.Count();
            return View();
        }
        public IActionResult Videogames()
        {
            ViewBag.VideogameList = VideogameList;
            ViewBag.VideogameCount = VideogameList.Count();
            return View();
        }
    }
}
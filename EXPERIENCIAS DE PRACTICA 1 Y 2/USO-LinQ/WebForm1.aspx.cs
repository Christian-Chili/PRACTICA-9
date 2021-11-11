using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;



namespace Experiencia2___Practica_9

{

    public partial class LinqObjects : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)

        {

            var movies = GetMovies();



            this.GridView1.DataSource = movies; this.GridView1.DataBind();

        }

        public List<Movie> GetMovies()

        {

            return new List<Movie> {

                new Movie { Title="Shrek", Director="Andrew Adamson", Genre=0, ReleaseDate=DateTime.Parse("16/05/2001"), RunTime=89 },

                new Movie { Title="Fletch", Director="Michael Ritchie", Genre=0, ReleaseDate=DateTime.Parse("31/05/1985"), RunTime=96 },

                new Movie { Title="Casablanca", Director="Michael Curtiz", Genre=1, ReleaseDate=DateTime.Parse("01/01/1942"), RunTime=102 },

                new Movie { Title="Batman", Director="Tim Burton", Genre=1, ReleaseDate=DateTime.Parse("23/06/1989"), RunTime=126 },



            };

        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)

        {



        }



        public class Movie

        {

            public string Title { get; set; }

            public string Director { get; set; }

            public int Genre

            { get; set; }

            public int RunTime { get; set; }

            public DateTime ReleaseDate { get; set; }

        }

    }
    protected void Page_Load(object sender, EventArgs e)

    {

        var query = from m in XElement.Load(MapPath("Movies.xml")).Elements("Movie")

                    select new Movie

                    {

                        Title = (string)m.Element("Title"),

                        Director = (string)m.Element("Director"),

                        Genre = (int)m.Element("Genre"),

                        ReleaseDate = (DateTime)m.Element("ReleaseDate"),

                        RunTime = (int)m.Element("RunTime")

                    };

        this.GridView1.DataSource = query; this.GridView1.DataBind();

    }



}
    protected void Page_Load(object sender, EventArgs e)

    {

        MoviesEntities1 dc = new MoviesEntities1(); var query = from m in dc.Movie

                                                                select m;

        GridView1.DataSource = query.ToList();

        GridView1.DataBind();

    } 
namespace csharp_boolflix.Models;

public class MediaInfo
{
    public int Id { get; set; }
    public string Year { get; set; }
    public bool IsNew { get; set; }

    public List<Actor> Cast { get; set; }

    public List<Genre> Generes { get; set; }//si relazione esterna

    public List<Feature> Features { get; set; } //si relazione esterna

    //1 a 1 su media content (film)
    public int? FilmId { get; set; }
    public Film? Film { get; set; }

    //1 a 1 su media content (serie)
    public int? TVSeriesId { get; set; }
    public TVSeries? Serie { get; set; }


}

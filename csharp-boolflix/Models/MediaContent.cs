namespace csharp_boolflix.Models;
public abstract class MediaContent
{
    public int Id { get; set; }
    public string Title { get; set; }

    //definita in minuti
    public int Durata { get; set; }

    public string Descrizione { get; set; }

    //conteggio delle riproduzioni fatte a frontend
    public int VisualizationCount { get; set; }

}

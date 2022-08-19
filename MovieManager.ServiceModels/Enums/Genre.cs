using System.ComponentModel;

namespace MovieManager.ServiceModels.Enums
{
    public enum Genre
    {
        [Description("Comedy")]
        Comedy = 1,
        [Description("Horror")]
        Horror,
        [Description("Action")]
        Action,
        [Description("Thriller")]
        Thriller,
        [Description("Drama")]
        Drama,
        [Description("Fantasy")]
        Fantasy,
        [Description("Romance")]
        Romance
    }
}

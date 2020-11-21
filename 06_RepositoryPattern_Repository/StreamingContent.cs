using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{

    public enum GenreType //enum - linked to property TypeOfGenre
    {
        Horror = 1,
        Romcom,
        SciFi,
        Documentary,
        Bromance,
        Drama,
        Action
    }
    //POCO - Plain Old C# Object
    public class StreamingContent
    {
        public string Title { get; set; } //property
        public string Description { get; set; } //property
        public string MaturityRating { get; set; } //property

        public double StarRating { get; set; } //property

        public bool IsFamilyFriendly { get; set; } //property

        public GenreType TypeOfGenre { get; set; } //enum property

        public StreamingContent() { } //empty constructor

        public StreamingContent(string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre) // constructor - (list of parameters for constructor) - also called constructor method
        {
            Title = title; // assign properties to parameters
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = genre;


        }


    }
}

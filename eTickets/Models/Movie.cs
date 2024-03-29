﻿using eTickets.Data.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {

        [Key]
        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public string Description { get; set;}

        public double Price { get; set;}

        public string ImageUrl { get; set;}

        public DateTime StartDate { get; set;}  

        public DateTime EndDate { get; set;}

        public MovieCategory MovieCategory { get; set;}


        //Relation
        public List<Actor_Movie> Actors_Movies { get; set; }
            
            //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
            //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Cinema Producer { get; set; }
    
}
}

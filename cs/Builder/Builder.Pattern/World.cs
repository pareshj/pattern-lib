﻿using System.Collections.Generic;
using System;
namespace Builder.Pattern
{
    

    public class World
    {
        public  PlanetType planetType {get;  set;}
        public  bool canLive { get;  set; }
        public  MountainType mountainType { get;  set; }
        public  GrassType grassType { get;  set; }
        public  bool hasTrees { get;  set; }
        public  bool hasRocks { get;  set; }
        public  List<string> species { get;  set; }        

        /*public World(PlanetType planetType,bool canLive,MountainType mountainType,GrassType grassType,bool hasTrees,  
                        bool hasRocks,List<string> species)
        {
            this.planetType =planetType;
            this.canLive = canLive;
            this.mountainType =mountainType;
            this.grassType =grassType; 
            this.hasTrees =hasTrees;
            this.hasRocks =hasRocks;
            this.species = species;
        }*/

        public void Display()
        {
            Console.WriteLine("World is off {0} type", planetType);
            if(canLive)
                Console.WriteLine("Can live");
            if(hasRocks)
                Console.WriteLine("Has rocks");
            if (hasTrees)
                Console.WriteLine("Has trees");
            Console.WriteLine("Species");
            foreach (var s in species)
                Console.WriteLine(" {0}", s);
        }    
        public enum PlanetType { Terrestrial, SuperEarths, Pulsar, Circumbinary }
        public enum MountainType { Volcanoes, Glacial, Sedimentary, Metamorphic, Dome }
        public enum GrassType { Bluegrass, Bentgrass, Ryegrasses, Fescues, RedFescues, FeatherReedGrass }    
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcf2
{
    public class DataHeros
    {
        public static List<Heros> SuperHeros = new List<Heros>
        {
            new Heros{id=0,FirstName="Bruce",LastName="Wayne",HeroName="Batman", PlcaeOfBirth="Gotham City",Combat=85},
            new Heros{id=1,FirstName="Tony",LastName="Stark",HeroName="Iron Man", PlcaeOfBirth="New York",Combat=80},
            new Heros{id=3,FirstName="James",LastName="Howlett",HeroName="Wolverine", PlcaeOfBirth="Canada",Combat=75},
            new Heros{id=4,FirstName="Thor",LastName="Odinson",HeroName="Thor", PlcaeOfBirth="Asgard",Combat=95},
            new Heros{id=5,FirstName="Steve",LastName="Rogers",HeroName="Captain America", PlcaeOfBirth="Brooklyn",Combat=55},
            new Heros{id=6,FirstName="Clark",LastName="Kent",HeroName="SuperMan", PlcaeOfBirth="Planet Krypton",Combat=85},
        };

    }
}
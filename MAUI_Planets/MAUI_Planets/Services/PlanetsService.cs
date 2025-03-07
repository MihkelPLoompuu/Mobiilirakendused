﻿using Models;

namespace Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. Mercury is classified as a terrestrial planet, with roughly the same surface gravity as Mars. The surface of Mercury is heavily cratered, as a result of countless impact events that have accumulated over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/09/spectra-mercury.jpg?w=1024",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Mercury_in_true_color.jpg/800px-Mercury_in_true_color.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth. Venus has by far the densest atmosphere of the terrestrial planets, composed mostly of carbon dioxide with a thick, global sulfuric acid cloud cover. At the surface it has a mean temperature of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's at sea level. These extreme conditions compress carbon dioxide into a supercritical state at Venus's surface.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://imgres?q=venus%20planet&imgurl=https%3A%2F%2Fscience.nasa.gov%2Fwp-content%2Fuploads%2F2024%2F03%2Fvenus-mariner-10-pia23791-fig2-16x9-1.jpg&imgrefurl=https%3A%2F%2Fscience.nasa.gov%2Fvenus%2Fvenus-facts%2F&docid=wmfnVZLI3sBoOM&tbnid=zlNDceAlh17rWM&vet=12ahUKEwibyeisi82LAxXePxAIHXzBDhAQM3oECGUQAA..i&w=1920&h=1080&hcb=2&ved=2ahUKEwibyeisi82LAxXePxAIHXzBDhAQM3oECGUQAA",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/PIA00103_Venus_-_3-D_Perspective_View_of_Lavinia_Planitia.jpg/220px-PIA00103_Venus_-_3-D_Perspective_View_of_Lavinia_Planitia.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Venus_-_December_23_2016.png/220px-Venus_-_December_23_2016.png"

                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description= "Earth is the third planet from the Sun and the only astronomical object known to harbor life. This is enabled by Earth being an ocean world, the only one in the Solar System sustaining liquid surface water. Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust. The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within Earth's land hemisphere. Most of Earth's land is at least somewhat humid and covered by vegetation, while large sheets of ice at Earth's polar deserts retain more water than Earth's groundwater, lakes, rivers, and atmospheric water combined. Earth's crust consists of slowly moving tectonic plates, which interact to produce mountain ranges, volcanoes, and earthquakes. Earth has a liquid outer core that generates a magnetosphere capable of deflecting most of the destructive solar winds and cosmic radiation.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/290px-The_Earth_seen_from_Apollo_17.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/EpicEarth-Globespin-tilt-23.4.gif/290px-EpicEarth-Globespin-tilt-23.4.gif"

                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun. The surface of Mars is orange-red because it is covered in iron(III) oxide dust, giving it the nickname \"the Red Planet\". Mars is among the brightest objects in Earth's sky, and its high-contrast albedo features have made it a common subject for telescope viewing. It is classified as a terrestrial planet and is the second smallest of the Solar System's planets with a diameter of 6,779 km (4,212 mi). In terms of orbital motion, a Martian solar day (sol) is equal to 24.6 hours, and a Martian solar year is equal to 1.88 Earth years (687 Earth days). Mars has two natural satellites that are small and irregular in shape: Phobos and Deimos.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSS3Xbp7bLfUTjKP-6cvZ-XzY5Ddsr_BLflIGGya44KNajshBLeILbVxHg&usqp=CAE&s",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg",
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description ="Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than 2.5 times that of all the other planets in the Solar System combined and slightly less than one-thousandth the mass of the Sun. Its diameter is eleven times that of Earth, and a tenth that of the Sun. Jupiter orbits the Sun at a distance of 5.20 AU (778.5 Gm), with an orbital period of 11.86 years. It is the third-brightest natural object in the Earth's night sky, after the Moon and Venus, and has been observed since prehistoric times. Its name derives from that of Jupiter, the chief deity of ancient Roman religion.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg/290px-Jupiter_and_its_shrunken_Great_Red_Spot.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Jupiter_size.png/220px-Jupiter_size.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/790106-0203_Voyager_58M_to_31M_reduced.gif/220px-790106-0203_Voyager_58M_to_31M_reduced.gif",
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description= "Saturn on kuues planeet Päikesest ja Päikesesüsteemi suuruselt teine planeet. See on hiidplaneet, mis on Maast üheksa korda suurema läbimõõduga. Saturni kõige iseloomulikum tunnus on tema rõngad. Saturn on ainus planeet Päikesesüsteemis, mis on veest hõredam (ligi 30%) ja kuigi Saturni tuum on veest oluliselt tihedam, on planeedi keskmine tihedus vaid 0,69 g/cm3 gaasilise väliskihi tõttu. Saturni mass on 95 Maa massi. Planeedile on antud nimi Vana-Rooma põllutöö ja viljakasvu jumala Saturnuse järgi, kelle sirp meenutab Saturni astronoomilist sümbolit (♄).",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Saturn_during_Equinox.jpg/300px-Saturn_during_Equinox.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Saturn_Storm.jpg/220px-Saturn_Storm.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/f/fe/Saturnoppositions-animated.gif",
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which astronomy calls \"ice\" or volatiles. The planet's atmosphere has a complex layered cloud structure and has the lowest minimum temperature (49 K (−224 °C; −371 °F)) of all the Solar System's planets. It has a marked axial tilt of 82.23° with a retrograde rotation period of 17 hours and 14 minutes. This means that in an 84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, followed by 42 years of continuous darkness.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4d/Adding_to_Uranus%27s_legacy.tif/lossy-page1-220px-Adding_to_Uranus%27s_legacy.tif.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/Uranus_clouds.jpg/170px-Uranus_clouds.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Uranus_Voyager2_color_calibrated.png/290px-Uranus_Voyager2_color_calibrated.png",
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest known planet from the Sun. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17 times the mass of Earth. Compared to its fellow ice giant Uranus, Neptune is slightly more massive, but denser and smaller. Being composed primarily of gases and liquids, it has no well-defined solid surface, and orbits the Sun once every 164.8 years at an orbital distance of 30.1 astronomical units (4.5 billion kilometres; 2.8 billion miles). It is named after the Roman god of the sea and has the astronomical symbol ♆, representing Neptune's trident.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Neptune_Voyager2_color_calibrated.png/290px-Neptune_Voyager2_color_calibrated.png",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Neptune_Full.jpg/200px-Neptune_Full.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Neptune_storms.jpg/220px-Neptune_storms.jpg",
                }
            },

            new()
            {
                Name = "Pluto",
                Subtitle = "The god of the underworld",
                HeroImage = "https://cdn.pixabay.com/photo/2023/09/06/03/15/pluto-8236209_640.png",
                Description = "Pluto, discovered in 1930 by Clyde Tombaugh,"+
                "is a dwarf planet in the outer solar system."+
                "Originally considered the ninth planet, it was reclassified in 2006."+
                "With a diameter of about 1,473 miles,"+
                "Pluto has a thin atmosphere and a complex system of moons, including Charon."+
                "NASA's New Horizons mission in 2015 provided detailed images,"+
                "revealing diverse and geologically active features like icy mountains and plains."+
                "The exploration of Pluto offers insights into the outer solar system.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21863_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA11709_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21026_modest.jpg"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "The goddess of agriculture, fertility, and motherly relationships",
                HeroImage = "https://cdn.pixabay.com/photo/2023/09/06/03/15/ceres-8236207_1280.png",
                Description = "Ceres is the largest object in the asteroid belt between"+
                "Mars and Jupiter and is classified as a dwarf planet."+
                "Discovered by Italian astronomer Giuseppe Piazzi in 1801,"+
                "Ceres has a diameter of about 590 miles (940 kilometers)."+
                "It was the first dwarf planet to be visited by a spacecraft"+
                "when NASA's Dawn mission orbited and studied it from 2015 to 2018."+
                "Ceres is unique for hosting a large, bright area known as Occator Crater,"+
                "which contains bright deposits believed to be composed of sodium carbonate,"+
                "possibly originating from subsurface water."+
                "The dwarf planet is of particular interest to scientists as it provides"+
                "insights into the early solar system and the potential presence of water ice on its surface.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA23017_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21918_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21906_modest.jpg"
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "The Hawaiian goddess of fertility and childbirth",
                HeroImage = "https://cdn.pixabay.com/photo/2023/09/06/03/15/haumea-8236206_1280.png",
                Description = "Haumea is another dwarf planet in the Kuiper Belt,"+
                "discovered in 2004 by a team of astronomers led by Mike Brown."+
                "It is named after the Hawaiian goddess of fertility."+
                "Haumea is distinctive due to its elongated shape, resembling a flattened ellipsoid,"+
                "possibly the result of a rapid rotation. It has two known moons, Hi'iaka and Namaka,"+
                "named after Hawaiian goddesses and discovered in 2005."+
                "Haumea's surface is thought to be composed of crystalline water ice,"+
                "and it displays a relatively high albedo, making it one of the brighter objects in the Kuiper Belt."+
                "The discovery of Haumea and its unique characteristics has contributed to"+
                "our understanding of the diversity of objects in the outer solar system.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/expanse/images/1/1f/Haumea_in_Celestia.jpg/revision/latest?cb=20200206143331"
                }
            },
            new()
            {
                Name = "MakeMake",
                Subtitle = "The deity of creation and fertility",
                HeroImage = "https://cdn.pixabay.com/photo/2023/09/06/03/15/makemake-8236208_1280.png",
                Description = "Makemake is another dwarf planet located in the Kuiper Belt,"+
                "a region of the outer solar system beyond Neptune."+
                "It was discovered in 2005 by astronomers using the Palomar Observatory."+
                "Similar to Pluto and Eris, Makemake is part of the group of trans-Neptunian objects known as dwarf planets."+
                "It is notable for its lack of a significant atmosphere and its relatively high albedo,"+
                "indicating a bright and reflective surface, likely composed of a mixture of frozen methane"+
                "ethane, and nitrogen. Makemake is the second-brightest dwarf planet after Pluto and"+
                "is recognized as one of the largest objects in the Kuiper Belt."+
                "Its discovery contributed to the ongoing understanding and classification of objects in the outer solar system.",
                AccentColorStart = Color.FromArgb("#0c293d"),
    AccentColorEnd = Color.FromArgb("#26abe0"),
    Images = new()
    {
        "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Makemake_and_its_moon.jpg/290px-Makemake_and_its_moon.jpg"
    }
            },

            new()
            {
                Name = "Eris",
                Subtitle = "The goddess of strife, discord, and chaos",
                HeroImage = "https://cdn.pixabay.com/photo/2023/09/06/03/15/eris-8236210_1280.png",
                Description = "Eris, a dwarf planet situated in the scattered disk of the outer solar system,"+
                "was identified in 2005 by astronomers at the Palomar Observatory."+
                "Smaller than Pluto but more massive, Eris ranks among the largest dwarf planets."+
                "Its orbit, more elliptical than Pluto's, places it at a greater average distance from the Sun."+
                "Eris boasts a highly reflective surface, likely comprising a mix of water ice and frozen methane."+
                "The discovery of Eris played a crucial role in the reclassification of Pluto and similar objects,"+
                "leading to the establishment of the \"dwarf planet\" category by the International Astronomical Union (IAU).",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA17307_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA03034_modest.jpg"
                }
            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using WhaleSpotting.Models.Data;

namespace WhaleSpotting.SeedData
{
    public class SeedSpecies
    {
        private readonly WhaleSpottingContext _context;

        public SeedSpecies(WhaleSpottingContext context)
        {
            _context = context;
        }

        private readonly IList<Species> seedSpeciesData = new List<Species>
        {
            new Species()
            {
                SpeciesId = 1,
                SpeciesName = "Antarctic Minke Whale",
                ExampleLink = "https://static.inaturalist.org/photos/221755875/medium.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/11895045/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Humpback_whale",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 2,
                SpeciesName = "Arnoux's Beaked Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/2075454/medium.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Berardius_arnuxii_2.jpg/2880px-Berardius_arnuxii_2.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Arnoux%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 3,
                SpeciesName = "Atlantic Humpback Dolphin",
                ExampleLink = "https://static.inaturalist.org/photos/290804055/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/92845087/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Atlantic_humpback_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 4,
                SpeciesName = "Atlantic Spotted Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/159009687/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/143919536/original.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Atlantic_spotted_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 5,
                SpeciesName = "Atlantic White-sided Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/185377668/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/319991841/original.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Leucopleurus_acutus",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 6,
                SpeciesName = "Australian Humpback Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/81583332/large.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/310626661/original.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Australian_humpback_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 7,
                SpeciesName = "Australian Snubfin Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/186505723/large.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/61764906/original.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Australian_snubfin_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 8,
                SpeciesName = "Baird's Beaked Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/322952635/large.jpg",
                TailPictureLink = "https://upload.wikimedia.org/wikipedia/commons/e/e2/Berardius_bairdii_2.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Baird%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 9,
                SpeciesName = "Beluga",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/66927701/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/1667572/original.JPG",
                WikiLink = "https://en.wikipedia.org/wiki/Beluga_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 10,
                SpeciesName = "Bering Sea Beaked Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/370549860/large.jpg",
                TailPictureLink = "https://upload.wikimedia.org/wikipedia/commons/2/26/Mesoplodon_stejnegeri.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Stejneger%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 11,
                SpeciesName = "Blue Whale",
                ExampleLink = "https://static.inaturalist.org/photos/194385336/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/3801231/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Blue_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 12,
                SpeciesName = "Boto",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/12008956/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/310859551/original.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Amazon_river_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 13,
                SpeciesName = "Bowhead Whale",
                ExampleLink = "https://static.inaturalist.org/photos/47601636/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/12975195/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Bowhead_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 14,
                SpeciesName = "Bryde's Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/361046934/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/361046992/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Balaenoptera_brydei",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 15,
                SpeciesName = "Burmeister's Porpoise",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/334243493/large.png",
                TailPictureLink = "https://static.inaturalist.org/photos/269240704/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Burmeister%27s_porpoise",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 16,
                SpeciesName = "Chilean Dolphin",
                ExampleLink = "https://static.inaturalist.org/photos/30779621/large.jpeg",
                TailPictureLink = "https://static.inaturalist.org/photos/270884012/original.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Chilean_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 17,
                SpeciesName = "Clymene Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/49526516/large.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/390339641/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Clymene_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 18,
                SpeciesName = "Commerson's Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/144049450/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/263390021/original.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Commerson%27s_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 19,
                SpeciesName = "Common Bottlenose Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/211066160/large.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/213278541/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Common_bottlenose_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 20,
                SpeciesName = "Common Dolphin",
                ExampleLink = "https://static.inaturalist.org/photos/135085970/large.jpeg",
                TailPictureLink = "https://static.inaturalist.org/photos/223748458/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Common_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 21,
                SpeciesName = "Common Minke Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/255463958/original.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/255459537/original.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Common_minke_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 22,
                SpeciesName = "Dall's Porpoise",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/22713235/large.jpeg",
                TailPictureLink = "https://static.inaturalist.org/photos/127932012/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Dall%27s_porpoise",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 23,
                SpeciesName = "Dense-beaked Whale",
                ExampleLink = "https://static.inaturalist.org/photos/137858505/large.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Mesoplodon_densirostris.jpg/2880px-Mesoplodon_densirostris.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Blainville%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 24,
                SpeciesName = "Dusky Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/4971507/large.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/189349714/original.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Sagmatias_obscurus",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 25,
                SpeciesName = "Dwarf Sperm Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/198282746/large.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/399171680/original.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Dwarf_sperm_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 26,
                SpeciesName = "East Asian Finless Porpoise",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/28631888/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/381226451/original.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Neophocaena_sunameri",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 27,
                SpeciesName = "Eden's Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/100027687/large.jpeg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/245798931/original.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Balaenoptera_edeni",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 28,
                SpeciesName = "False Killer Whale",
                ExampleLink = "https://static.inaturalist.org/photos/14003994/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/203235049/original.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/False_killer_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 29,
                SpeciesName = "Fin Whale",
                ExampleLink = "https://static.inaturalist.org/photos/194028066/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/224510122/original.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Fin_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 30,
                SpeciesName = "Franciscana",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/98406172/large.jpeg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/253138209/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/La_Plata_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 31,
                SpeciesName = "Fraser's Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/363342020/large.jpeg",
                TailPictureLink = "https://static.inaturalist.org/photos/255228418/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Fraser%27s_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 32,
                SpeciesName = "Ganges River Dolphin",
                ExampleLink = "https://static.inaturalist.org/photos/73811782/large.jpeg",
                TailPictureLink = "https://upload.wikimedia.org/wikipedia/commons/b/b8/GangeticDolphin.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Ganges_river_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 33,
                SpeciesName = "Ginkgo-toothed Beaked Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/315414123/large.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Mesoplodon_ginkgodens_2.jpg/2880px-Mesoplodon_ginkgodens_2.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Ginkgo-toothed_beaked_whale",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 34,
                SpeciesName = "Goose-beaked Whale",
                ExampleLink = "https://static.inaturalist.org/photos/298360229/large.jpeg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/425081926/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Cuvier%27s_beaked_whale",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 35,
                SpeciesName = "Gray's Beaked Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/70667698/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/112649615/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Gray%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 36,
                SpeciesName = "Grey Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/182728835/large.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/1616177/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Gray_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 37,
                SpeciesName = "Gulf Stream Beaked Whale",
                ExampleLink = "https://static.inaturalist.org/photos/97154602/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/224771509/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Gervais%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 38,
                SpeciesName = "Guyana Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/110630841/large.jpeg",
                TailPictureLink = "https://static.inaturalist.org/photos/321306607/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Guiana_dolphin",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 39,
                SpeciesName = "Harbour Porpoise",
                ExampleLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8e/Ecomare_-_bruinvis_Michael_met_penis_%28michael-penis-4580-sd%29.jpg/2880px-Ecomare_-_bruinvis_Michael_met_penis_%28michael-penis-4580-sd%29.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/Ecomare_-_bruinvis_Michael_in_2015_%28bruinvis-michael2015-9313-sw%29.jpg/2560px-Ecomare_-_bruinvis_Michael_in_2015_%28bruinvis-michael2015-9313-sw%29.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Harbour_porpoise",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 40,
                SpeciesName = "Heaviside's Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/109474008/original.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/109474269/original.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Heaviside%27s_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 41,
                SpeciesName = "Hector's Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/187167571/large.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/362689840/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Hector%27s_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 42,
                SpeciesName = "Hourglass Dolphin",
                ExampleLink = "https://upload.wikimedia.org/wikipedia/commons/5/5f/Hourglas_dolphin.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/262693059/original.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Hourglass_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 43,
                SpeciesName = "Hubbs' Beaked Whales",
                ExampleLink =
                    "https://res.cloudinary.com/sagacity/image/upload/c_crop,h_1824,w_2736,x_0,y_0/c_limit,dpr_auto,f_auto,fl_lossy,q_80,w_1080/LG7A0617_jsyir9.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Mesoplodon_carlhubbsi.jpg/2880px-Mesoplodon_carlhubbsi.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Hubbs%27_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 44,
                SpeciesName = "Humpback Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/255461843/original.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/9546242/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Humpback_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 45,
                SpeciesName = "Indian Humpback Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/321066055/medium.jpg",
                TailPictureLink = "https://www.inaturalist.org/observations/66145219",
                WikiLink = "https://en.wikipedia.org/wiki/Indian_Ocean_humpback_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 46,
                SpeciesName = "Indo-Pacific Bottlenose Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/70501058/medium.jpg",
                TailPictureLink = "https://upload.wikimedia.org/wikipedia/commons/b/b0/Dolphins_gesture_language.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Indo-Pacific_bottlenose_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 47,
                SpeciesName = "Indo-Pacific Finless Porpoise",
                ExampleLink =
                    "https://s3.animalia.bio/animals/photos/full/1.25x1/finless-porpoisejfif.webp?id=bbed520184a80e6267625c4fa5c2b13d",
                TailPictureLink = "https://www.inaturalist.org/observations/127774526",
                WikiLink = "https://en.wikipedia.org/wiki/Indo-Pacific_finless_porpoise",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 48,
                SpeciesName = "Indo-Pacific Humpback Dolphin",
                ExampleLink = "https://static.inaturalist.org/photos/231161633/large.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/a/a3/Sousa_chinensis_%283%29_by_Zureks.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Indo-Pacific_humpback_dolphin",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 49,
                SpeciesName = "Indus River Dolphin",
                ExampleLink =
                    "https://upload.wikimedia.org/wikipedia/commons/6/67/A-Platanista-gangetica-showing-the-body-shape-and-especially-the-head-with-a-long-beak.png",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/2075400/medium.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Indus_river_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 50,
                SpeciesName = "Irrawaddy Dolphin",
                ExampleLink =
                    "https://upload.wikimedia.org/wikipedia/commons/a/ae/Irrawaddy_dolphin-Orcaella_brevirostris_by_2eight.jpg",
                TailPictureLink = "https://www.inaturalist.org/observations/130431427",
                WikiLink = "https://en.wikipedia.org/wiki/Irrawaddy_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 51,
                SpeciesName = "Least Beaked Whale",
                ExampleLink = "https://wiseoceans.com/wp-content/uploads/2022/09/header-satos-whale-600x450.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/6/68/Berardius_minimus_illustration.png",
                WikiLink = "https://en.wikipedia.org/wiki/Sato%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 52,
                SpeciesName = "Long-finned Pilot Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/215548410/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/165784656/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Long-finned_pilot_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 53,
                SpeciesName = "Melon-headed Whale",
                ExampleLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/Peponocephala_electra_Mayotte.jpg/2560px-Peponocephala_electra_Mayotte.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/14977151/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Melon-headed_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 54,
                SpeciesName = "Narwhal",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/66927345/medium.jpg",
                TailPictureLink = "https://upload.wikimedia.org/wikipedia/commons/b/be/Narwhal_tail_above_surface.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Narwhal",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 55,
                SpeciesName = "North Atlantic Beaked Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/246320414/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/255464915/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Sowerby%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 56,
                SpeciesName = "North Atlantic Bottlenose Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/213038441/medium.jpeg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/307874636/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Northern_bottlenose_whale",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 57,
                SpeciesName = "North Atlantic Right Whale",
                ExampleLink =
                    "https://upload.wikimedia.org/wikipedia/commons/9/94/GRNMS_-_Right_Whales_%2831361234602%29.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/344319854/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/North_Atlantic_right_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 58,
                SpeciesName = "Northern Right Whale Dolphin",
                ExampleLink = "https://static.inaturalist.org/photos/12599977/medium.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/2/2d/Anim1749_-_Flickr_-_NOAA_Photo_Library.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Northern_right_whale_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 59,
                SpeciesName = "North Pacific Right Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/60883227/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/304590918/medium.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/North_Pacific_right_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 60,
                SpeciesName = "Omura's Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/51082418/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/224044685/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Omura%27s_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 61,
                SpeciesName = "Orca",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/360303852/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/282690940/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Orca",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 62,
                SpeciesName = "Pacific White-sided Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/246061248/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/341204923/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Pacific_white-sided_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 63,
                SpeciesName = "Pantropical Spotted Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/61633355/large.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/190202648/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Pantropical_spotted_dolphin",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 64,
                SpeciesName = "Peale's Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/380921709/large.jpeg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/380921698/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Peale%27s_dolphin",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 65,
                SpeciesName = "Peruvian Beaked Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/155064601/medium.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Mesoplodon_peruvianus.jpg/2880px-Mesoplodon_peruvianus.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Pygmy_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 66,
                SpeciesName = "Pygmy Killer Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/158910691/large.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/291148163/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Pygmy_killer_whale",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 67,
                SpeciesName = "Pygmy Right Whale",
                ExampleLink = "https://upload.wikimedia.org/wikipedia/commons/b/bb/Pygmy_right_whale.png",
                TailPictureLink = "https://upload.wikimedia.org/wikipedia/commons/6/6c/Caperea_marginata_3.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Pygmy_right_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 68,
                SpeciesName = "Pygmy Sperm Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/198282116/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/252669246/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Pygmy_sperm_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 69,
                SpeciesName = "Ramari's Beaked Whale",
                ExampleLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1e/Mesoplodon_eueu.jpg/2880px-Mesoplodon_eueu.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/15842083/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Ramari%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 70,
                SpeciesName = "Rice's Whale",
                ExampleLink = "https://upload.wikimedia.org/wikipedia/commons/e/ec/SEFSC-PAM-Rices-whale.png",
                TailPictureLink = "https://static.inaturalist.org/photos/113240086/large.png",
                WikiLink = "https://en.wikipedia.org/wiki/Rice%27s_whale",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 71,
                SpeciesName = "Risso's Dolphin",
                ExampleLink = "https://static.inaturalist.org/photos/232559687/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/28157072/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Risso%27s_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 72,
                SpeciesName = "Rough-toothed Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/332308271/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/319940746/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Rough-toothed_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 73,
                SpeciesName = "Sei Whale",
                ExampleLink =
                    "https://upload.wikimedia.org/wikipedia/commons/e/e3/Sei_whale_mother_and_calf_Christin_Khan_NOAA.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/321567411/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Sei_whale",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 74,
                SpeciesName = "Shepherd's Beaked Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/243893094/medium.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Tasmacetus_shepherdi.jpg/2880px-Tasmacetus_shepherdi.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Shepherd%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 75,
                SpeciesName = "Short-finned Pilot Whale",
                ExampleLink =
                    "https://upload.wikimedia.org/wikipedia/commons/3/37/Short-finned_pilot_whales_spy-hopping_in_the_waters_off_of_Guam_%28anim252641873%29.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/194024379/medium.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Short-finned_pilot_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 76,
                SpeciesName = "Southern Bottlenose Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/352156493/large.jpeg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Hyperoodon_planifrons.jpg/2880px-Hyperoodon_planifrons.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Southern_bottlenose_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 77,
                SpeciesName = "Southern Right Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/26838108/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/65936175/medium.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Southern_right_whale",
                TotalSightings = 1
            },
            new Species()
            {
                SpeciesId = 78,
                SpeciesName = "Southern Right Whale Dolphin",
                ExampleLink = "https://static.inaturalist.org/photos/169282779/medium.jpg",
                TailPictureLink = "https://static.inaturalist.org/photos/57937079/medium.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Southern_right_whale_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 79,
                SpeciesName = "Spade Toothed Beaked Whale",
                ExampleLink = "https://upload.wikimedia.org/wikipedia/commons/a/ad/Spade-toothedWhale.jpg",
                TailPictureLink = "https://upload.wikimedia.org/wikipedia/commons/a/ad/Spade-toothedWhale.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Spade-toothed_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 80,
                SpeciesName = "Spectacled Porpoise",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/95048913/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/95048913/medium.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Spectacled_porpoise",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 81,
                SpeciesName = "Sperm Whale",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/28629750/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/100408064/medium.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Sperm_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 82,
                SpeciesName = "Spinner Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/83099258/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/58167305/large.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Spinner_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 83,
                SpeciesName = "Strap-toothed Beaked Whale",
                ExampleLink = "https://static.inaturalist.org/photos/338917869/medium.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/Mesoplodon_layardii.jpg/2880px-Mesoplodon_layardii.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Strap-toothed_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 84,
                SpeciesName = "Striped Dolphin",
                ExampleLink = "https://static.inaturalist.org/photos/202798066/medium.jpeg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/Delfine_im_Golf_von_Korinth%2C_Griechenland.jpg/2560px-Delfine_im_Golf_von_Korinth%2C_Griechenland.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Striped_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 85,
                SpeciesName = "Tamanend's Bottlenose Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/422453638/large.jpeg",
                TailPictureLink = "https://static.inaturalist.org/photos/153388812/large.jpeg",
                WikiLink = "https://en.wikipedia.org/wiki/Tamanend%27s_bottlenose_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 86,
                SpeciesName = "True's Beaked Whale",
                ExampleLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Breaching_True%27s_beaked_whales.png/480px-Breaching_True%27s_beaked_whales.png",
                TailPictureLink =
                    "https://media.fisheries.noaa.gov/styles/original/s3/dam-migration/640x427-whale_true%27s_beaked_nb_w.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/True%27s_beaked_whale",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 87,
                SpeciesName = "Tucuxi",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/62092474/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/71638026/medium.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Tucuxi",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 88,
                SpeciesName = "Vaquita",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/209711467/medium.jpg",
                TailPictureLink =
                    "https://u4d2z7k9.rocketcdn.me/wp-content/uploads/2022/04/Untitled-design-2022-04-12T161151.368.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Vaquita",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 89,
                SpeciesName = "White-beaked Dolphin",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/146341190/medium.jpg",
                TailPictureLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/245196519/medium.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/White-beaked_dolphin",
                TotalSightings = 0
            },
            new Species()
            {
                SpeciesId = 90,
                SpeciesName = "Yangtze Finless Porpoise",
                ExampleLink = "https://inaturalist-open-data.s3.amazonaws.com/photos/162435290/medium.jpg",
                TailPictureLink =
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dc/Yangtze_finless_porpoise%2C_10_November_2006.jpg/440px-Yangtze_finless_porpoise%2C_10_November_2006.jpg",
                WikiLink = "https://en.wikipedia.org/wiki/Yangtze_finless_porpoise",
                TotalSightings = 1
            },
        };

        public void Seed()
        {
            if (!_context.Species.Any())
            {
                _context.Species.AddRange(seedSpeciesData);
                _context.SaveChanges();
            }
        }
    }
}

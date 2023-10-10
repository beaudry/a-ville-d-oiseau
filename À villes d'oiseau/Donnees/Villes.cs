using A_villes_d_oiseau.Villes;
using GeoCoordinatePortable;

namespace A_villes_d_oiseau.Donnees
{
    public static class Villes
    {
        public static readonly Ville[] Toutes = new Ville[]
        {
            new Ville
            {
                Nom = "Granby",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Granby-Rue_Principale.jpg/640px-Granby-Rue_Principale.jpg",
                    Position = "right",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.39847624425485,
                    Longitude = -72.72224975237435,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Granby%20(Québec)",
            },
            new Ville
            {
                Nom = "Bromont",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Vue_a%C3%A9rienne_Bromont.jpg/640px-Vue_a%C3%A9rienne_Bromont.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.31910662283246,
                    Longitude = -72.64607641563734,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Bromont",
            },
            new Ville
            {
                Nom = "Waterloo",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Vol_d%27oiseau_Waterloo.jpg/640px-Vol_d%27oiseau_Waterloo.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.344919858143285,
                    Longitude = -72.51561188741492,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Waterloo%20(Québec)",
            },
            new Ville
            {
                Nom = "Farnham",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/Farnham.jpg/640px-Farnham.jpg",
                    Position = "right",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.28380585313681,
                    Longitude = -72.97675915822353,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Farnham%20(Québec)",
            },
            new Ville
            {
            Nom = "Saint-Hyacinthe",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/16/Portedesanciensmaires.jpg/640px-Portedesanciensmaires.jpg",
                    Position = "center",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.62604505076951,
                    Longitude = -72.94658701360687,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Saint-Hyacinthe",
            },
            new Ville
            {
                Nom = "Dunham",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/8/8c/La_Route_des_vins_de_Brome-Missisquoi.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.131222409209855,
                    Longitude = -72.80041848920442,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Dunham",
            },
            new Ville
            {
                Nom = "Sutton",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Vue_du_mont_%C3%89cho.png/640px-Vue_du_mont_%C3%89cho.png",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.10601276278098,
                    Longitude = -72.6157424878401,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Sutton%20(Québec)",
            },
            new Ville
            {
                Nom = "Bedford",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Bedford_%C3%A9glise_Saint-Damien_%28cropped%29.jpg/592px-Bedford_%C3%A9glise_Saint-Damien_%28cropped%29.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.120947639618954,
                    Longitude = -72.98767935844046,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Bedford%20(Québec)",
            },
            new Ville
            {
                Nom = "Saint-Jean-sur-Richelieu",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/St-Jean-Richelieu-coucher_03-08-2008.jpg/360px-St-Jean-Richelieu-coucher_03-08-2008.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.30567820498343,
                    Longitude = -73.25399060618588,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Saint-Jean-sur-Richelieu",
            },
            new Ville
            {
                Nom = "Chambly",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Eglise_Saint-Joseph-de-Chambly.jpg/640px-Eglise_Saint-Joseph-de-Chambly.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.44904625949664,
                    Longitude = -73.29175743926578,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Chambly%20(Québec)",
            },
            new Ville
            {
                Nom = "Magog",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Magog-St-Patrick.jpg/640px-Magog-St-Patrick.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.26498852149322,
                    Longitude = -72.14693675169549,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Magog",
            },
            new Ville
            {
                Nom = "Drummondville",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Rue_Lindsay%2C_Drummondville.jpg/640px-Rue_Lindsay%2C_Drummondville.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.88051023734284,
                    Longitude = -72.4842957831213,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Drummondville",
            },
            new Ville
            {
                Nom = "Longueuil",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Longueuil_2011.jpg/640px-Longueuil_2011.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.51372029403457,
                    Longitude = -73.43130598682187,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Longueuil",
            },
            new Ville
            {
                Nom = "Brossard",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Dix30.jpg/640px-Dix30.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.4553894259322,
                    Longitude = -73.46785152968737,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Brossard%20(ville)",
            },
            /* new Ville
            {
                Nom = "Candiac",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b9/Candiac_QC_1.JPG/800px-Candiac_QC_1.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.394878757926314,
                    Longitude = -73.51914644281416,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Candiac",
            }, */
            new Ville
            {
                Nom = "Saint-Ours",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Church_Saint-Ours_%28Qu%C3%A9bec%29.JPG/457px-Church_Saint-Ours_%28Qu%C3%A9bec%29.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.88947846811169,
                    Longitude = -73.15028251403199,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Saint-Ours_(Québec)",
            },
            new Ville
            {
                Nom = "Sherbrooke",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Sherbrooke_Centreville2.JPG/640px-Sherbrooke_Centreville2.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.404166886248646,
                    Longitude = -71.89306107931212,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Sherbrooke",
            },
            new Ville
            {
                Nom = "Montréal",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/17-08-islcanus-RalfR-DSC_3883.jpg/480px-17-08-islcanus-RalfR-DSC_3883.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.5089172186547,
                    Longitude = -73.55433346786855,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Montréal",
            },
            new Ville
            {
                Nom = "Sorel-Tracy",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Pont_Turcotte.jpg/640px-Pont_Turcotte.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.04385167098284,
                    Longitude = -73.11328424155592,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Sorel-Tracy",
            },
            new Ville
            {
                Nom = "Mascouche",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c2/Manoir_des_Le_Gardeur_de_Repentigny.jpg/640px-Manoir_des_Le_Gardeur_de_Repentigny.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.74559652934551,
                    Longitude = -73.60169263455867,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Mascouche",
            },
            new Ville
            {
                Nom = "Coaticook",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/%C3%89difice_de_la_Vieille_poste%2C_Coaticook%2C_QC.JPG/640px-%C3%89difice_de_la_Vieille_poste%2C_Coaticook%2C_QC.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.1345114850343,
                    Longitude = -71.8047733467019,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Coaticook%20(ville)",
            },
            new Ville
            {
                Nom = "Châteauguay",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/MairiedeCh%C3%A2teauguay.jpg/640px-MairiedeCh%C3%A2teauguay.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.360785128788855,
                    Longitude = -73.7500186798714,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Châteauguay",
            },
            new Ville
            {
                Nom = "Laval",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Papineau-Leblanc_Bridge.jpg/640px-Papineau-Leblanc_Bridge.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.550512549791755,
                    Longitude = -73.74375358949996,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Laval%20(Québec)",
            },
            new Ville
            {
                Nom = "Warwick",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/V%C3%A9lo-gare_de_Warwick.jpg/640px-V%C3%A9lo-gare_de_Warwick.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.94577100301525,
                    Longitude = -71.98933183323668,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Warwick%20(Québec)",
            },
            new Ville
            {
                Nom = "Nicolet",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Cath%C3%A9drale_Saint-Jean-Baptiste_de_Nicolet.jpg/635px-Cath%C3%A9drale_Saint-Jean-Baptiste_de_Nicolet.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.226344047625545,
                    Longitude = -72.61628222625122,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Nicolet",
            },
            new Ville
            {
                Nom = "Victoriaville",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Cycliste_%C3%A0_la_V%C3%A9logare_du_Grand-Tronc.jpg/640px-Cycliste_%C3%A0_la_V%C3%A9logare_du_Grand-Tronc.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.055245161011804,
                    Longitude = -71.95997787109735,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Victoriaville",
            },
            new Ville
            {
                Nom = "Trois-Rivières",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Porte_Pacifique-Duplessis.jpg/640px-Porte_Pacifique-Duplessis.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.343149996763216,
                    Longitude = -72.5430145189136,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Trois-Rivières",
            },
            new Ville
            {
                Nom = "Plessisville",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Centre-ville_de_Plessisville.jpg/640px-Centre-ville_de_Plessisville.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.218786727011064,
                    Longitude = -71.77178411063348,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Plessisville%20(ville)",
            },
            new Ville
            {
                Nom = "Rigaud",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/Rigaud_QC.JPG/640px-Rigaud_QC.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.479946656968416,
                    Longitude = -74.30074113135564,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Rigaud%20(Québec)",
            },
            new Ville
            {
                Nom = "Shawinigan",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/90/Shawinigan_aerial_2011.jpg/640px-Shawinigan_aerial_2011.jpg",
                    Position = "left",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.54107832436057,
                    Longitude = -72.74529519840176,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Shawinigan",
            },
            new Ville
            {
                Nom = "Thetford Mines",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/8/8f/Thetford.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.088933754851645,
                    Longitude = -71.30199918375415,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Thetford%20Mines",
            },
            new Ville
            {
                Nom = "Saint-Tite",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Eglise_st-tite.jpg/360px-Eglise_st-tite.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.72703535283568,
                    Longitude = -72.56466589518135,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Saint-Tite",
            },
            new Ville
            {
                Nom = "Donnacona",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Donnacona2.jpg/800px-Donnacona2.jpg",
                    Position = "right",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.6727266049768,
                    Longitude = -71.73714938562428,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Donnacona%20(Québec)",
            },
            new Ville
            {
                Nom = "Lévis",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c6/L%C3%A9vis_%2843331478522%29.jpg/640px-L%C3%A9vis_%2843331478522%29.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.75817461162562,
                    Longitude = -71.24023578058276,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Lévis",
            },
            new Ville
            {
            Nom = "Québec",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/Chateau_Frontenac_25.JPG/640px-Chateau_Frontenac_25.JPG",
                    Position = "left",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.813826022918036,
                    Longitude = -71.20797742213087,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Québec_(ville)",
            },
            new Ville
            {
                Nom = "Thurso",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Thurso_QC.jpg/640px-Thurso_QC.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.59950568647061,
                    Longitude = -75.24350781659477,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Thurso%20(Québec)",
            },
            new Ville
            {
                Nom = "Lac-Delage",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Lac_Delage14.JPG/800px-Lac_Delage14.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.971086809807595,
                    Longitude = -71.40379420764418,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Lac-Delage",
            },
            new Ville
            {
                Nom = "La Tuque",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/La_Tuque_centre-ville.jpg/800px-La_Tuque_centre-ville.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 47.440888553637144,
                    Longitude = -72.7814617597049,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/La%20Tuque",
            },
            new Ville
            {
                Nom = "Sainte-Anne-de-Beaupré",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/545_-_Beaupre_QC.JPG/800px-545_-_Beaupre_QC.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 47.01610552880398,
                    Longitude = -70.94770036817128,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Sainte-Anne-de-Beaupré",
            },
            new Ville
            {
                Nom = "Gatineau",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Gatineau_-_QC_-_Museum_of_Civilisation3.jpg/800px-Gatineau_-_QC_-_Museum_of_Civilisation3.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 45.42805700431856,
                    Longitude = -75.71074174320961,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Gatineau",
            },
            new Ville
            {
                Nom = "Baie-Saint-Paul",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/Baie-St-Paul.JPG/800px-Baie-St-Paul.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 47.44065666617415,
                    Longitude = -70.50949193556421,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Baie-Saint-Paul",
            },
            new Ville
            {
                Nom = "La Pocatière",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/La_Pocati%C3%A8re%2C_Qu%C3%A9bec.jpg/800px-La_Pocati%C3%A8re%2C_Qu%C3%A9bec.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 47.36977006199157,
                    Longitude = -70.03229557849131,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/La%20Pocatière",
            },
            new Ville
            {
                Nom = "Pohénégamook",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Lac-pohenegamook2.jpg/800px-Lac-pohenegamook2.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 47.45703711655904,
                    Longitude = -69.2400837863807,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Pohénégamook",
            },
            new Ville
            {
                Nom = "Saguenay",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Ville_saguenay_montage.jpg/800px-Ville_saguenay_montage.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.428245852458375,
                    Longitude = -71.06222039456715,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Saguenay%20(ville)",
            },
            new Ville
            {
                Nom = "Saint-Félicien",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Eglise_Saint-F%C3%A9licien.jpg/800px-Eglise_Saint-F%C3%A9licien.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.6528496079535,
                    Longitude = -72.44661684025479,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Saint-Félicien%20(Québec)",
            },
            new Ville
            {
                Nom = "Normandin",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Rue_Saint-Cyrille_Ouest.jpg/800px-Rue_Saint-Cyrille_Ouest.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.83585931423486,
                    Longitude = -72.52819617932087,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Normandin%20(Québec)",
            },
            new Ville
            {
                Nom = "Dégelis",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/D%C3%A9gelis.jpg/800px-D%C3%A9gelis.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 47.54789221971853,
                    Longitude = -68.64715024400076,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Dégelis",
            },
            new Ville
            {
                Nom = "Rimouski",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Rimouski_Montage.jpg/800px-Rimouski_Montage.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.44920737927583,
                    Longitude = -68.52500214903917,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Rimouski",
            },
            new Ville
            {
                Nom = "Val-d'Or",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Ville_de_Val-d%27or.jpg/800px-Ville_de_Val-d%27or.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.10204905278589,
                    Longitude = -77.78939313045444,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Val-d'Or",
            },
            new Ville
            {
                Nom = "Belleterre",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/Belleterre_2004.JPG/800px-Belleterre_2004.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 47.38926759401454,
                    Longitude = -78.70361127102093,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Belleterre",
            },
            new Ville
            {
                Nom = "Métis-sur-Mer",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Metis-Lighthouse_2009.jpg/800px-Metis-Lighthouse_2009.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.683741333050314,
                    Longitude = -67.96347665748331,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Métis-sur-Mer",
            },
            new Ville
            {
                Nom = "Chapais",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/3/30/Chapais.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 49.781783212015206,
                    Longitude = -74.85347012232548,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Chapais%20(Québec)",
            },
            new Ville
            {
                Nom = "Témiscaming",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Carte_Abitibi-T%C3%A9miscamingue.png",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.72157897409265,
                    Longitude = -79.0931661946412,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Témiscaming",
            },
            new Ville
            {
                Nom = "Chibougamau",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Chibougamau2.jpg/800px-Chibougamau2.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 49.913301554033026,
                    Longitude = -74.3685515042512,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Chibougamau",
            },
            new Ville
            {
                Nom = "Lebel-sur-Quévillon",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Lebel_sur_Quevillon_QC.JPG/800px-Lebel_sur_Quevillon_QC.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 49.05223150197099,
                    Longitude = -76.97595398890849,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Lebel-sur-Quévillon",
            },
            new Ville
            {
                Nom = "Amqui",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/J.-Napoleon-Perusse.jpg/800px-J.-Napoleon-Perusse.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.462561830578835,
                    Longitude = -67.43343697103043,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Amqui",
            },
            new Ville
            {
                Nom = "Causapscal",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Causapscal.jpg/800px-Causapscal.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.35478644106692,
                    Longitude = -67.22132864960157,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Causapscal",
            },
            new Ville
            {
                Nom = "Baie-Comeau",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Commerce_boulevard_Lasalle%2C_Baie-Comeau.JPG/800px-Commerce_boulevard_Lasalle%2C_Baie-Comeau.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 49.22095984366846,
                    Longitude = -68.14927960179543,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Baie-Comeau",
            },
            new Ville
            {
                Nom = "Matane",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/2/21/Embouchre.Riviere.Matane.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.84330943694312,
                    Longitude = -67.53025553197125,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Matane",
            },
            new Ville
            {
                Nom = "Rouyn-Noranda",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a1/Poisson-Volant-2021-07-23.jpg/800px-Poisson-Volant-2021-07-23.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.237334843391366,
                    Longitude = -79.01705051899856,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Rouyn-Noranda",
            },
            new Ville
            {
                Nom = "Duparquet",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Duparquet_QC.JPG/800px-Duparquet_QC.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.50552957289692,
                    Longitude = -79.22932001472097,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Duparquet%20(Québec)",
            },
            new Ville
            {
                Nom = "Macamic",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Macamic_QC_1.JPG/800px-Macamic_QC_1.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.75529720820128,
                    Longitude = -79.00174061359594,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Macamic",
            },
            new Ville
            {
                Nom = "Matagami",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Matagamitown.jpg/800px-Matagamitown.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 49.75837382893953,
                    Longitude = -77.62198018946032,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Matagami",
            },
            new Ville
            {
                Nom = "Cap-Chat",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Capchat.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 49.09653236418819,
                    Longitude = -66.68796574260537,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Cap-Chat",
            },
            new Ville
            {
                Nom = "Bonaventure",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Bonaventure1.jpg/800px-Bonaventure1.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.049023517325914,
                    Longitude = -65.49096257412491,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Bonaventure%20(ville)",
            },
            new Ville
            {
                Nom = "Murdochville",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Murdochville.jpg/800px-Murdochville.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.96021470862818,
                    Longitude = -65.49581137989624,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Murdochville",
            },
            new Ville
            {
                Nom = "Chandler",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Ville_de_Chandler.jpg/800px-Ville_de_Chandler.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.348581028235245,
                    Longitude = -64.67833325704737,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Chandler%20(Québec)",
            },
            new Ville
            {
                Nom = "Sept-Îles",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Sept-%C3%8Eles.jpg/800px-Sept-%C3%8Eles.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 50.209948958191234,
                    Longitude = -66.38538156999843,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Sept-Îles",
            },
            new Ville
            {
                Nom = "Gaspé",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/a/ae/Gasp%C3%A9_Centre-ville_Nord.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.824793184217896,
                    Longitude = -64.47599166805504,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Gaspé%20(ville)",
            },
            new Ville
            {
                Nom = "Percé",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/d/d6/Perceville.jpg",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 48.52392244296376,
                    Longitude = -64.21084989012432,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Percé",
            },
            new Ville
            {
                Nom = "Fermont",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/16/Fermont.JPG/800px-Fermont.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 52.797616158698446,
                    Longitude = -67.09061884464177,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Fermont",
            },
            new Ville
            {
                Nom = "Schefferville",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Schefferville_Pierre_Bouchard.JPG/800px-Schefferville_Pierre_Bouchard.JPG",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 54.80047933844688,
                    Longitude = -66.8210367712869,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Schefferville",
            },
            new Ville
            {
                Nom = "Sainte-Croix",
                Image = new Image
                {
                    Chemin = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Vue_a%C3%A9rienne_de_Sainte-Croix_QC_%281%29.jpg/640px-Vue_a%C3%A9rienne_de_Sainte-Croix_QC_%281%29.jpg",
                    Position = "right",
                },
                Coordonnees = new GeoCoordinate
                {
                    Latitude = 46.62272038811359,
                    Longitude = -71.7395679168263,
                },
                LienWikipedia = "https://fr.wikipedia.org/wiki/Sainte-Croix_(Qu%C3%A9bec)",
            },
        };
        public static readonly Dictionary<string, Ville> ParNom = Toutes.ToDictionary(ville => ville.Nom);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using KModkit;
using rnd = UnityEngine.Random;

class Crest {

    // Crest Colors
    public const int OR = 0;
    public const int ARGENT = 1;
    public const int GULES = 2;
    public const int AZURE = 3;
    public const int VERT = 4;
    public const int PURPURE = 5;
    public const int SABLE = 6;
    public const int CELESTE = 7;
    public const int SANGUINE = 8;
    public const int MURREY = 9;
    public const int TENNE = 10;

    // Animal Charges
    public const int LION = 0;
    public const int EAGLE = 1;
    public const int HORSE = 2;
    public const int HOUND = 3;
    public const int BEAR = 4;
    public const int STAG = 5;
    public const int DOLPHIN = 6;
    public const int SERPENT = 7;
    public const int OX = 8;
    public const int BOAR = 9;
    public const int GRIFFIN = 10;
    public const int DRAGON = 11;
    public const int SEAHORSE = 12;
    public const int UNICORN = 13;

    // Cross Charges
    public const int GREEK = 14;
    public const int MOLINE = 15;
    public const int PATONCE = 16;
    public const int FLORY = 17;
    public const int POMMEE = 18;
    public const int CROSSLET = 19;
    public const int POTENT = 20;
    public const int SALTIRE = 21;
    public const int VOIDED = 22;
    public const int FOURCHEE = 23;
    public const int PATTEE = 24;
    public const int MALTESE = 25;
    public const int BOTTONY = 26;

    // Misc Charges
    public const int ROUNDEL = 27;
    public const int ANNULET = 28;
    public const int MULLET = 29;
    public const int MASCLE = 30;
    public const int FLEUR_DE_LIS = 31;
    public const int CROWN = 32;
    public const int LYRE = 33;
    public const int SHELL = 34;
    public const int SUN = 35;
    public const int MOON = 36;
    public const int TOWER = 37;
    public const int KEYS = 38;
    public const int SWORDS = 39;
    public const int FLOWER = 40;
    public const int LEAF = 41;
    public const int HAND = 42;

    // Crest Type
    public const int PLAIN = 0;
    public const int QUARTERLY = 1;
    public const int PILE = 2;
    public const int PARTYPERCHEVRON = 3;
    public const int PARTYPERPALE = 4;
    public const int PARTYPERFESS = 5;
    public const int PARTYPERBEND = 6;
    public const int PARTYPERSALTIRE = 7;
    public const int PALL = 8;
    public const int FESS = 9;
    public const int BEND = 10;
    public const int SALTIRE_DIV = 11;
    public const int CROSS = 12;
    public const int CHIEF = 13;
    public const int PALE = 14;
    public const int CHEVRON = 15;

    static protected readonly int[] allTinctures = Enumerable.Range(0, 11).ToArray();
    static protected readonly int[] metals = { OR, ARGENT };
    static protected readonly int[] stains = { SANGUINE, MURREY, TENNE };
    static protected readonly int[] colors = { GULES, VERT, AZURE, PURPURE, SABLE, CELESTE, SANGUINE, MURREY, TENNE };
    static protected readonly int[] allCharges = Enumerable.Range(0, 43).ToArray();
    static public readonly string[] familyNames = {
        "Arden",
        "Beauchamp",
        "Beauclerk",
        "Beaufort",
        "Beaumont",
        "Bentinck",
        "Berkeley",
        "Bohun",
        "Boleyn",
        "Byron",
        "Bruce",
        "Buccleuch",
        "Campbell",
        "Cavendish",
        "Cecil",
        "De Clare",
        "De Vere",
        "De Warrenne",
        "Douglas",
        "Drummond",
        "Egerton",
        "Fitzjames",
        "Godwin",
        "Gordon",
        "Gough Calthorpe",
        "Hamilton",
        "Hastings",
        "Herbert",
        "Howard",
        "Lancaster",
        "Longe",
        "Lyttelton",
        "Montagu",
        "Mowbray",
        "Neville",
        "Percy",
        "Plantagenet",
        "Russell",
        "Seymour",
        "Spencer",
        "Stanley",
        "Stratford",
        "Strathmore",
        "Stuart",
        "St. Leger",
        "Swinton",
        "Talbot",
        "Tollemache",
        "Tudor",
        "Villiers",
        "Wessex",
        "Windsor",
        "Woodville",
        "York",
        "Albret",
        "Anjou",
        "Armagnac",
        "Aumont",
        "Bauffremont",
        "Baux",
        "Beauharnais",
        "Bethune",
        "Blacas",
        "Blois",
        "Bonaparte",
        "Bourbon",
        "Broglie",
        "Capet",
        "Clermont Tonnerre",
        "Crussol d'Uzes",
        "Courtenay",
        "Foix",
        "Fouche d'Otrante",
        "Gramont",
        "Grimaldi",
        "Guise",
        "Harcourt",
        "La Force",
        "La Rochefoucauld",
        "La Tour d'Auvergne",
        "La Tremoille",
        "Lorraine",
        "Montfort",
        "Montmorency",
        "Monpezat",
        "Noailles",
        "Normandy",
        "Orleans",
        "Poitiers",
        "Polignac",
        "Rohan",
        "Talleyrand Perigord",
        "Valois",
        "Ascania",
        "Amsberg",
        "Auersperg",
        "Battenberg",
        "Bentheim",
        "Bismarck",
        "Clary and Aldringen",
        "Colloredo Mansfeld",
        "Dietrichstein",
        "Dohna",
        "Eltz",
        "Fugger Babenhausen",
        "Furstenberg",
        "Glucksburg",
        "Habsburg",
        "Hanover",
        "Harrach",
        "Henckel von Donnersmarck",
        "Hesse",
        "Hohenberg",
        "Hohenlohe",
        "Hohenzollern",
        "Isenburg",
        "Ketteler",
        "Khevenhuller",
        "Kinsky",
        "Leiningen",
        "Lichnowsky",
        "Liechtenstein",
        "Limburg Stirum",
        "Lippe",
        "Lobkowicz",
        "Lowenstein Wertheim",
        "Luxembourg",
        "Mecklenburg",
        "Metternich",
        "Nassau",
        "Oettingen Oettingen",
        "Oldenburg",
        "Orsini Rosenberg",
        "Pappenheim",
        "Putbus",
        "Reuss",
        "Salm",
        "Saxe Coburg and Gotha",
        "Sayn Wittgenstein",
        "Schonborn",
        "Schonburg",
        "Schwarzburg",
        "Schwarzenberg",
        "Solms Braunfels",
        "Stolberg",
        "Thun and Hohenstein",
        "Thurn and Taxis",
        "Urach",
        "Waldeck and Pyrmont",
        "Welf",
        "Wettin",
        "Wied Neuwied",
        "Windisch Graetz",
        "Wittelsbach",
        "Wurttemberg",
        "Zahringen",
        "Arenberg",
        "Beaufort Spontin",
        "Belgium",
        "Chalon",
        "Chimay",
        "Croy",
        "Dampierre",
        "De Borchgrave",
        "D'Udekem",
        "Egmond",
        "Hornes",
        "Lannoy",
        "Ligne",
        "Looz Corswarem",
        "Merode",
        "Nassau Weilburg",
        "Orange Nassau",
        "Snoy et d'Oppuers",
        "Spoelberch",
        "Trazegnies",
        "Ursel",
        "Valois Burgundy",
        "Van de Werve",
        "Van der Noot",
        "Van Voorst tot Voorst",
        "Aldobrandeschi",
        "Aldobrandini",
        "Altoviti",
        "Barberini",
        "Barbiano di Belgiojoso",
        "Bardi",
        "Boncompagni",
        "Borghese",
        "Borgia",
        "Borromeo",
        "Bourbon Parma",
        "Bourbon Two Sicilies",
        "Caetani",
        "Canossa",
        "Caracciolo",
        "Chigi",
        "Cybo",
        "Colonna",
        "Della Gherardesca",
        "Della Rovere",
        "Della Torre",
        "Doria Pamphili Landi",
        "Erba Odescalchi",
        "Este",
        "Farnese",
        "Fieschi",
        "Gherardini",
        "Gonzaga",
        "Malaspina",
        "Mancini",
        "Massimo",
        "Mattei",
        "Medici",
        "Montefeltro",
        "Orsini",
        "Pallavicini",
        "Pazzi",
        "Pignatelli",
        "Ruffo",
        "Ruspoli",
        "Sacchetti",
        "Salviati",
        "Sanseverino",
        "Savoy",
        "Sforza",
        "Simonetti",
        "Spinola",
        "Strozzi",
        "Torlonia",
        "Ventimiglia",
        "Visconti",
        "Alba",
        "Alburquerque",
        "Alvarez Cuevas",
        "Argavieso",
        "Barcelona",
        "Bettencourt",
        "Braganza",
        "Bourbon Anjou",
        "Cadaval",
        "Camondo",
        "Carrillo",
        "Castro",
        "Correia",
        "Corte Real",
        "Cotoner",
        "Enriquez",
        "Entenca",
        "Goncalves da Camara",
        "Godoy",
        "Haro",
        "Hoyos",
        "Iniguez",
        "Jimenez",
        "La Cerda",
        "Lara",
        "Lasso de la Vega",
        "Lecubarri",
        "Maia",
        "Marcoartu",
        "Medina Sidonia",
        "Medinaceli",
        "Mendez de Sotomayor",
        "Mendoza",
        "Montcada",
        "Moctezuma",
        "Napoles",
        "Narro",
        "Olivares",
        "Osorio",
        "Osuna",
        "Pardo",
        "Santcliment",
        "Silva",
        "Siles Villegas",
        "Sousa",
        "Tagle",
        //"Trastámara",
        "Trastamara",
        "Zuniga",
        "Czartoryski",
        "Czetwertynski",
        "Griffins",
        "Jablonowski",
        "Jagiellon",
        "Kalinowski",
        "Koniecpolski",
        "Krasinski",
        "Leszczynski",
        "Lubomirski",
        "Mielzynski",
        "Mniszech",
        "Piast",
        "Opalinski",
        "Ossolinski",
        "Ostrogski",
        "Poniatowski",
        "Potocki",
        "Radziwill",
        "Sanguszko",
        "Sapieha",
        "Sobieski",
        "Sulkowski",
        "Wisniowiecki",
        "Zamoyski",
        "Zaslawski",
        "Aba",
        "Andrassy",
        "Bathory",
        "Batthyany Strattmann",
        "Draskovic",
        "Esterhazy",
        "Festetics",
        "Frankopan",
        "Garai",
        "Hunyadi",
        "Kalnoky",
        "Nadasdy",
        "Thurzo",
        "Zapolya",
        "Basarab",
        "Baleanu",
        "Bogdan Musat",
        "Brancoveanu",
        "Bratianu",
        "Calimachi",
        "Cantacuzino",
        "Cantemir",
        "Caradja",
        "Cornescu",
        "Craiovesti",
        "Danesti",
        "Draculesti",
        "Dragos",
        "Ghica",
        "Golescu",
        "Hajdau",
        "Hurmuzachi",
        "Juvara",
        "Kogalniceanu",
        "Moruzi",
        "Movila",
        "Racovita",
        "Rosetti",
        "Sturdza",
        "Vacarescu",
        "Ypsilantis",
        "Ahlefeldt",
        "Benkestok",
        "Bernadotte",
        "Bjelke",
        "Danneskiold Samsoe",
        "Estridsen",
        "Essen",
        "Fabritius de Tengnagel",
        "Falkenskiold",
        "Falsen",
        "Gyldenstierne",
        "Guldencrone",
        "Knagenhjelm",
        "Lagergren",
        "Lovenorn",
        "Munso",
        "Munthe af Morgenstierne",
        "Neergaard",
        "Oxenstierna",
        "Reventlow",
        "Rosenkrantz",
        "Stockfleth",
        "Svanenhielm",
        "Vasa",
        "Werenskiold",
        "Amilakhvari",
        "Bagration",
        "Baratashvili",
        "Barclay de Tolly",
        "Chavchavadze",
        "Gorchakov",
        "Guramishvili",
        "Gurgenidze",
        "Dadiani",
        "Dolgorukov",
        "Durnovo",
        "Gagarin",
        "Gelovani",
        "Golitsyn",
        "Karadordevic",
        "Khilkov",
        "Lieven",
        "Menshikov",
        "Obolensky",
        "Orbeliani",
        "Orlov",
        "Pahlen",
        "Petrovic Njegos",
        "Razumovsky",
        "Romanov",
        "Shalikashvili",
        "Sheremetev",
        "Shervashidze",
        "Tolstoy",
        "Yuryevsky",
        "Yusupov",
        "Zubov",
        "Angelos",
        "Bagratuni",
        "Calogera",
        "Chateaudun",
        "Chatillon",
        "De la Roche",
        "Grenier",
        "Gattilusi",
        "Ghisi",
        "Hauteville",
        "Ibelin",
        "Kantakouzenos",
        "Komnenos",
        "Kourkouas",
        "Laskaris",
        "Lusignan",
        "Madi",
        "Maleinos",
        "Mavrocordatos",
        "Montlhery and Le Puiset",
        "Palaiologos",
        "Philanthropenos",
        "Phokas",
        "Rubenid",
        "Saint Omer",
        "Sanudo",
        "Savva",
        "Skleros",
        "Theotokis",
        "Tocco",
        "Toulouse",
        "Vatatzes",
        "Villehardouin",
        "Ypsilantis",
        "O'Conor",
        "O'Neill",
        "O'Brien",
        "O'Donnell",
        "MacMorrough Kavanagh",
        "O'Morchoe",
        "MacDermot",
        "O'Rourke",
        "O'Connell",
        "McGillycuddy"
    };

    static public readonly string[] divisionNames = { "Plain", "Quarterly", "Pile", "Party per Chevron", "Party per Pale", "Party per Fess", "Party per Bend", "Party per Saltire", "Pall", "Fess", "Bend", "Saltire", "Cross", "Chief", "Pale", "Chevron" };
    static public readonly string[] fieldNames = { "Or", "Argent", "Gules", "Azure", "Vert", "Purpure", "Sable", "Celeste", "Sanguine", "Murrey", "Tenne" };
    static public readonly string[] chargeNames = { "Lion", "Eagle", "Horse", "Hound", "Bear", "Stag", "Dolphin", "Serpent", "Ox", "Boar", "Griffin", "Dragon", "Seahorse", "Unicorn", "Greek Cross", "Cross Moline", "Cross Patonce", "Cross Flory", "Cross Pommee", "Cross Crosslet", "Cross Potent", "Cross Saltire", "Voided Cross", "Cross Fourchee", "Cross Pattee", "Maltese Cross", "Cross Bottony", "Roundel", "Annulet", "Mullet", "Mascle", "Fleur-de-Lis", "Crown", "Lyre", "Shell", "Sun", "Moon", "Tower", "Keys", "Swords", "Flower", "Leaf", "Hand" };
    static public readonly string[] chargeNamesMat = { "Lion", "Eagle", "Horse", "Hound", "Bear", "Stag", "Dolphin", "Serpent", "Ox", "Boar", "Griffin", "Dragon", "Seahorse", "Unicorn", "Greek", "Moline", "Patonce", "Flory", "Pommee", "Crosslet", "Potent", "Saltire", "Voided", "Fourchee", "Pattee", "Maltese", "Bottony", "Roundel", "Annulet", "Mullet", "Mascle", "Fleur-de-Lis", "Crown", "Lyre", "Shell", "Sun", "Moon", "Tower", "Keys", "Swords", "Flower", "Leaf", "Hand" };

    protected List<int> fields = new List<int>();
    protected List<int> charges = new List<int>();
    protected List<int> chargeColors = new List<int>();

    protected List<int> validFields;
    protected List<int> validCharges;

    protected bool valid;
    protected bool fake;
    protected bool unicorn;
    protected bool royal;

    public string familyName;

    public virtual string Description()
    {
        return "";
    }

    public virtual void Paint(GameObject shield, Material[] materials)
    {

    }

    public virtual void Generate()
    {

    }

    public virtual IEnumerable<int> GetColors()
    {
        return chargeColors.Concat(fields);
    }
    public virtual List<int> GetCharges()
    {
        return charges;
    }



    public virtual int GetScore(KMBombInfo bomb)
    {
        return -1;
    }

    protected void GenericGenerate()
    {
        charges.Clear();
        chargeColors.Clear();
        fields.Clear();

        familyName = familyNames.OrderBy(x => rnd.Range(0, 100000)).ToList()[0];

        if(royal)
        {
            chargeColors.Add(OR);
            charges.Add(LION);
            fields.Add(GetRandomTincture(metals));
        }
        else if(unicorn)
        {
            chargeColors.Add(ARGENT);
            charges.Add(UNICORN);
            fields.Add(GetRandomTincture(metals));
        }
        else if(fake)
        {
            chargeColors.Add(GetRandomValidTincture(validFields.ToArray(), new int[] {}));
            charges.Add(GetRandomValidCharge(validCharges.ToArray(), new int[] {}));
            if(Array.Exists(metals, x => x == chargeColors[0]))
                fields.Add(GetRandomValidTincture(validFields.ToArray(), colors.Concat(new int[] {chargeColors[0]}).ToArray()));
            else
                fields.Add(GetRandomValidTincture(validFields.ToArray(), metals.Concat(new int[] {chargeColors[0]}).ToArray()));
        }
        else if(valid)
        {
            chargeColors.Add(GetRandomValidTincture(validFields.ToArray(), new int[] {}));
            charges.Add(GetRandomValidCharge(validCharges.ToArray(), new int[] {}));
            if(Array.Exists(colors, x => x == chargeColors[0]))
                fields.Add(GetRandomValidTincture(validFields.ToArray(), colors.Concat(new int[] {chargeColors[0]}).ToArray()));
            else
                fields.Add(GetRandomValidTincture(validFields.ToArray(), metals.Concat(new int[] {chargeColors[0]}).ToArray()));
        }
        else
        {
            if(rnd.Range(0, 2) == 0)
            {
                charges.Add(GetRandomCharge(validCharges.ToArray()));
                chargeColors.Add(GetRandomTincture(new int[] {}));
                if(Array.Exists(colors, x => x == chargeColors[0]))
                    fields.Add(GetRandomTincture(colors.Concat(new int[] {chargeColors[0]}).ToArray()));
                else
                    fields.Add(GetRandomTincture(metals.Concat(new int[] {chargeColors[0]}).ToArray()));
            }
            else
            {
                fields.Add(GetRandomTincture(validFields.ToArray()));
                charges.Add(GetRandomCharge(new int[] {}));
                if(Array.Exists(colors, x => x == fields[0]))
                    chargeColors.Add(GetRandomTincture(colors.Concat(new int[] {fields[0]}).ToArray()));
                else
                    chargeColors.Add(GetRandomTincture(metals.Concat(new int[] {fields[0]}).ToArray()));
            }
        }
    }

    protected int GetRandomTincture(int[] avoid)
    {
        if(rnd.Range(0, 100) < 95 || !Array.Exists(stains, x => !avoid.Contains(x)))
            return allTinctures.Where(x => x < SANGUINE && !avoid.Contains(x)).OrderBy(x => rnd.Range(0, 1000)).ToList()[0];
        else
            return allTinctures.Where(x => x >= SANGUINE && !avoid.Contains(x)).OrderBy(x => rnd.Range(0, 1000)).ToList()[0];
    }

    protected int GetRandomValidTincture(int[] valid, int[] avoid)
    {
        if(rnd.Range(0, 100) < 95 || !Array.Exists(stains, x => !avoid.Contains(x)))
            return allTinctures.Where(x => x < SANGUINE && valid.Contains(x) && !avoid.Contains(x)).OrderBy(x => rnd.Range(0, 1000)).ToList()[0];
        else
            return allTinctures.Where(x => x >= SANGUINE && !avoid.Contains(x)).OrderBy(x => rnd.Range(0, 1000)).ToList()[0];
    }

    protected int GetRandomCharge(int[] avoid)
    {
        return allCharges.Where(x => !avoid.Contains(x)).OrderBy(x => rnd.Range(0, 1000)).ToList()[0];
    }

    protected int GetRandomValidCharge(int[] valid, int[] avoid)
    {
        return allCharges.Where(x => valid.Contains(x) && !avoid.Contains(x)).OrderBy(x => rnd.Range(0, 1000)).ToList()[0];
    }

    public static Crest Build(int crest, List<int> validFields, List<int> validCharges, bool valid, bool fake = false, bool unicorn = false, bool royal = false)
    {
        switch(crest)
        {
            case 0: return new Plain(validFields, validCharges, valid, fake, unicorn, royal);
            case 1: return new Quarterly(validFields, validCharges, valid, fake, unicorn, royal);
            case 2: return new Pile(validFields, validCharges, valid, fake, unicorn, royal);
            case 3: return new PartyPerChevron(validFields, validCharges, valid, fake, unicorn, royal);
            case 4: return new PartyPerPale(validFields, validCharges, valid, fake, unicorn, royal);
            case 5: return new PartyPerFess(validFields, validCharges, valid, fake, unicorn, royal);
            case 6: return new PartyPerBend(validFields, validCharges, valid, fake, unicorn, royal);
            case 7: return new PartyPerSaltire(validFields, validCharges, valid, fake, unicorn, royal);
            case 8: return new Pall(validFields, validCharges, valid, fake, unicorn, royal);
            case 9: return new Fess(validFields, validCharges, valid, fake, unicorn, royal);
            case 10: return new Bend(validFields, validCharges, valid, fake, unicorn, royal);
            case 11: return new Saltire(validFields, validCharges, valid, fake, unicorn, royal);
            case 12: return new Cross(validFields, validCharges, valid, fake, unicorn, royal);
            case 13: return new Chief(validFields, validCharges, valid, fake, unicorn, royal);
            case 14: return new Pale(validFields, validCharges, valid, fake, unicorn, royal);
            case 15: return new Chevron(validFields, validCharges, valid, fake, unicorn, royal);
        }
        
        return null;
    }

    protected bool CheckForbidden()
    {
        for(int i = 0; i < charges.Count; i++)
        {
            if(charges[i] == UNICORN && (chargeColors[i] != ARGENT || !unicorn))
                return true;
            if(charges[i] == LION && chargeColors[i] == OR && !royal)
                return true;
        }

        return false;
    }
}
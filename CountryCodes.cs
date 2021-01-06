using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumControlCustomBrowser
{
    public class CountryCodes
    {
        public List<CountryCode> AllCountries;

        public CountryCodes()
        {
            this.AllCountries = new List<CountryCode>();

            this.AllCountries.Add(new CountryCode("", "", ""));

            this.AllCountries.Add(new CountryCode("Afghanistan", "93", "AF / AFG"));

            this.AllCountries.Add(new CountryCode("Albania", "355", "AL / ALB"));

            this.AllCountries.Add(new CountryCode("Algeria", "213", "DZ / DZA"));

            this.AllCountries.Add(new CountryCode("American Samoa", "1-684", "AS / ASM"));

            this.AllCountries.Add(new CountryCode("Andorra", "376", "AD / AND"));

            this.AllCountries.Add(new CountryCode("Angola", "244", "AO / AGO"));

            this.AllCountries.Add(new CountryCode("Anguilla", "1-264", "AI / AIA"));

            this.AllCountries.Add(new CountryCode("Antarctica", "672", "AQ / ATA"));

            this.AllCountries.Add(new CountryCode("Antigua and Barbuda", "1-268", "AG / ATG"));

            this.AllCountries.Add(new CountryCode("Argentina", "54", "AR / ARG"));

            this.AllCountries.Add(new CountryCode("Armenia", "374", "AM / ARM"));

            this.AllCountries.Add(new CountryCode("Aruba", "297", "AW / ABW"));

            this.AllCountries.Add(new CountryCode("Australia", "61", "AU / AUS"));

            this.AllCountries.Add(new CountryCode("Austria", "43", "AT / AUT"));

            this.AllCountries.Add(new CountryCode("Azerbaijan", "994", "AZ / AZE"));

            this.AllCountries.Add(new CountryCode("Bahamas", "1-242", "BS / BHS"));

            this.AllCountries.Add(new CountryCode("Bahrain", "973", "BH / BHR"));

            this.AllCountries.Add(new CountryCode("Bangladesh", "880", "BD / BGD"));

            this.AllCountries.Add(new CountryCode("Barbados", "1-246", "BB / BRB"));

            this.AllCountries.Add(new CountryCode("Belarus", "375", "BY / BLR"));

            this.AllCountries.Add(new CountryCode("Belgium", "32", "BE / BEL"));

            this.AllCountries.Add(new CountryCode("Belize", "501", "BZ / BLZ"));

            this.AllCountries.Add(new CountryCode("Benin", "229", "BJ / BEN"));

            this.AllCountries.Add(new CountryCode("Bermuda", "1-441", "BM / BMU"));

            this.AllCountries.Add(new CountryCode("Bhutan", "975", "BT / BTN"));

            this.AllCountries.Add(new CountryCode("Bolivia", "591", "BO / BOL"));

            this.AllCountries.Add(new CountryCode("Bosnia and Herzegovina", "387", "BA / BIH"));

            this.AllCountries.Add(new CountryCode("Botswana", "267", "BW / BWA"));

            this.AllCountries.Add(new CountryCode("Brazil", "55", "BR / BRA"));

            this.AllCountries.Add(new CountryCode("British Indian Ocean Territory", "246", "IO / IOT"));

            this.AllCountries.Add(new CountryCode("British Virgin Islands", "1-284", "VG / VGB"));

            this.AllCountries.Add(new CountryCode("Brunei", "673", "BN / BRN"));

            this.AllCountries.Add(new CountryCode("Bulgaria", "359", "BG / BGR"));

            this.AllCountries.Add(new CountryCode("Burkina Faso", "226", "BF / BFA"));

            this.AllCountries.Add(new CountryCode("Burundi", "257", "BI / BDI"));

            this.AllCountries.Add(new CountryCode("Cambodia", "855", "KH / KHM"));

            this.AllCountries.Add(new CountryCode("Cameroon", "237", "CM / CMR"));

            this.AllCountries.Add(new CountryCode("Canada", "1", "CA / CAN"));

            this.AllCountries.Add(new CountryCode("Cape Verde", "238", "CV / CPV"));

            this.AllCountries.Add(new CountryCode("Cayman Islands", "1-345", "KY / CYM"));

            this.AllCountries.Add(new CountryCode("Central African Republic", "236", "CF / CAF"));

            this.AllCountries.Add(new CountryCode("Chad", "235", "TD / TCD"));

            this.AllCountries.Add(new CountryCode("Chile", "56", "CL / CHL"));

            this.AllCountries.Add(new CountryCode("China", "86", "CN / CHN"));

            this.AllCountries.Add(new CountryCode("Christmas Island", "61", "CX / CXR"));

            this.AllCountries.Add(new CountryCode("Cocos Islands", "61", "CC / CCK"));

            this.AllCountries.Add(new CountryCode("Colombia", "57", "CO / COL"));

            this.AllCountries.Add(new CountryCode("Comoros", "269", "KM / COM"));

            this.AllCountries.Add(new CountryCode("Cook Islands", "682", "CK / COK"));

            this.AllCountries.Add(new CountryCode("Costa Rica", "506", "CR / CRI"));

            this.AllCountries.Add(new CountryCode("Croatia", "385", "HR / HRV"));

            this.AllCountries.Add(new CountryCode("Cuba", "53", "CU / CUB"));

            this.AllCountries.Add(new CountryCode("Curacao", "599", "CW / CUW"));

            this.AllCountries.Add(new CountryCode("Cyprus", "357", "CY / CYP"));

            this.AllCountries.Add(new CountryCode("Czech Republic", "420", "CZ / CZE"));

            this.AllCountries.Add(new CountryCode("Democratic Republic of the Congo", "243", "CD / COD"));

            this.AllCountries.Add(new CountryCode("Denmark", "45", "DK / DNK"));

            this.AllCountries.Add(new CountryCode("Djibouti", "253", "DJ / DJI"));

            this.AllCountries.Add(new CountryCode("Dominica", "1-767", "DM / DMA"));

            this.AllCountries.Add(new CountryCode("Dominican Republic", "1-809, 1-829, 1-849", "DO / DOM"));

            this.AllCountries.Add(new CountryCode("East Timor", "670", "TL / TLS"));

            this.AllCountries.Add(new CountryCode("Ecuador", "593", "EC / ECU"));

            this.AllCountries.Add(new CountryCode("Egypt", "20", "EG / EGY"));

            this.AllCountries.Add(new CountryCode("El Salvador", "503", "SV / SLV"));

            this.AllCountries.Add(new CountryCode("Equatorial Guinea", "240", "GQ / GNQ"));

            this.AllCountries.Add(new CountryCode("Eritrea", "291", "ER / ERI"));

            this.AllCountries.Add(new CountryCode("Estonia", "372", "EE / EST"));

            this.AllCountries.Add(new CountryCode("Ethiopia", "251", "ET / ETH"));

            this.AllCountries.Add(new CountryCode("Falkland Islands", "500", "FK / FLK"));

            this.AllCountries.Add(new CountryCode("Faroe Islands", "298", "FO / FRO"));

            this.AllCountries.Add(new CountryCode("Fiji", "679", "FJ / FJI"));

            this.AllCountries.Add(new CountryCode("Finland", "358", "FI / FIN"));

            this.AllCountries.Add(new CountryCode("France", "33", "FR / FRA"));

            this.AllCountries.Add(new CountryCode("French Polynesia", "689", "PF / PYF"));

            this.AllCountries.Add(new CountryCode("Gabon", "241", "GA / GAB"));

            this.AllCountries.Add(new CountryCode("Gambia", "220", "GM / GMB"));

            this.AllCountries.Add(new CountryCode("Georgia", "995", "GE / GEO"));

            this.AllCountries.Add(new CountryCode("Germany", "49", "DE / DEU"));

            this.AllCountries.Add(new CountryCode("Ghana", "233", "GH / GHA"));

            this.AllCountries.Add(new CountryCode("Gibraltar", "350", "GI / GIB"));

            this.AllCountries.Add(new CountryCode("Greece", "30", "GR / GRC"));

            this.AllCountries.Add(new CountryCode("Greenland", "299", "GL / GRL"));

            this.AllCountries.Add(new CountryCode("Grenada", "1-473", "GD / GRD"));

            this.AllCountries.Add(new CountryCode("Guam", "1-671", "GU / GUM"));

            this.AllCountries.Add(new CountryCode("Guatemala", "502", "GT / GTM"));

            this.AllCountries.Add(new CountryCode("Guernsey", "44-1481", "GG / GGY"));

            this.AllCountries.Add(new CountryCode("Guinea", "224", "GN / GIN"));

            this.AllCountries.Add(new CountryCode("Guinea-Bissau", "245", "GW / GNB"));

            this.AllCountries.Add(new CountryCode("Guyana", "592", "GY / GUY"));

            this.AllCountries.Add(new CountryCode("Haiti", "509", "HT / HTI"));

            this.AllCountries.Add(new CountryCode("Honduras", "504", "HN / HND"));

            this.AllCountries.Add(new CountryCode("Hong Kong", "852", "HK / HKG"));

            this.AllCountries.Add(new CountryCode("Hungary", "36", "HU / HUN"));

            this.AllCountries.Add(new CountryCode("Iceland", "354", "IS / ISL"));

            this.AllCountries.Add(new CountryCode("India", "91", "IN / IND"));

            this.AllCountries.Add(new CountryCode("Indonesia", "62", "ID / IDN"));

            this.AllCountries.Add(new CountryCode("Iran", "98", "IR / IRN"));

            this.AllCountries.Add(new CountryCode("Iraq", "964", "IQ / IRQ"));

            this.AllCountries.Add(new CountryCode("Ireland", "353", "IE / IRL"));

            this.AllCountries.Add(new CountryCode("Isle of Man", "44-1624", "IM / IMN"));

            this.AllCountries.Add(new CountryCode("Israel", "972", "IL / ISR"));

            this.AllCountries.Add(new CountryCode("Italy", "39", "IT / ITA"));

            this.AllCountries.Add(new CountryCode("Ivory Coast", "225", "CI / CIV"));

            this.AllCountries.Add(new CountryCode("Jamaica", "1-876", "JM / JAM"));

            this.AllCountries.Add(new CountryCode("Japan", "81", "JP / JPN"));

            this.AllCountries.Add(new CountryCode("Jersey", "44-1534", "JE / JEY"));

            this.AllCountries.Add(new CountryCode("Jordan", "962", "JO / JOR"));

            this.AllCountries.Add(new CountryCode("Kazakhstan", "7", "KZ / KAZ"));

            this.AllCountries.Add(new CountryCode("Kenya", "254", "KE / KEN"));

            this.AllCountries.Add(new CountryCode("Kiribati", "686", "KI / KIR"));

            this.AllCountries.Add(new CountryCode("Kosovo", "383", "XK / XKX"));

            this.AllCountries.Add(new CountryCode("Kuwait", "965", "KW / KWT"));

            this.AllCountries.Add(new CountryCode("Kyrgyzstan", "996", "KG / KGZ"));

            this.AllCountries.Add(new CountryCode("Laos", "856", "LA / LAO"));

            this.AllCountries.Add(new CountryCode("Latvia", "371", "LV / LVA"));

            this.AllCountries.Add(new CountryCode("Lebanon", "961", "LB / LBN"));

            this.AllCountries.Add(new CountryCode("Lesotho", "266", "LS / LSO"));

            this.AllCountries.Add(new CountryCode("Liberia", "231", "LR / LBR"));

            this.AllCountries.Add(new CountryCode("Libya", "218", "LY / LBY"));

            this.AllCountries.Add(new CountryCode("Liechtenstein", "423", "LI / LIE"));

            this.AllCountries.Add(new CountryCode("Lithuania", "370", "LT / LTU"));

            this.AllCountries.Add(new CountryCode("Luxembourg", "352", "LU / LUX"));

            this.AllCountries.Add(new CountryCode("Macau", "853", "MO / MAC"));

            this.AllCountries.Add(new CountryCode("Macedonia", "389", "MK / MKD"));

            this.AllCountries.Add(new CountryCode("Madagascar", "261", "MG / MDG"));

            this.AllCountries.Add(new CountryCode("Malawi", "265", "MW / MWI"));

            this.AllCountries.Add(new CountryCode("Malaysia", "60", "MY / MYS"));

            this.AllCountries.Add(new CountryCode("Maldives", "960", "MV / MDV"));

            this.AllCountries.Add(new CountryCode("Mali", "223", "ML / MLI"));

            this.AllCountries.Add(new CountryCode("Malta", "356", "MT / MLT"));

            this.AllCountries.Add(new CountryCode("Marshall Islands", "692", "MH / MHL"));

            this.AllCountries.Add(new CountryCode("Mauritania", "222", "MR / MRT"));

            this.AllCountries.Add(new CountryCode("Mauritius", "230", "MU / MUS"));

            this.AllCountries.Add(new CountryCode("Mayotte", "262", "YT / MYT"));

            this.AllCountries.Add(new CountryCode("Mexico", "52", "MX / MEX"));

            this.AllCountries.Add(new CountryCode("Micronesia", "691", "FM / FSM"));

            this.AllCountries.Add(new CountryCode("Moldova", "373", "MD / MDA"));

            this.AllCountries.Add(new CountryCode("Monaco", "377", "MC / MCO"));

            this.AllCountries.Add(new CountryCode("Mongolia", "976", "MN / MNG"));

            this.AllCountries.Add(new CountryCode("Montenegro", "382", "ME / MNE"));

            this.AllCountries.Add(new CountryCode("Montserrat", "1-664", "MS / MSR"));

            this.AllCountries.Add(new CountryCode("Morocco", "212", "MA / MAR"));

            this.AllCountries.Add(new CountryCode("Mozambique", "258", "MZ / MOZ"));

            this.AllCountries.Add(new CountryCode("Myanmar", "95", "MM / MMR"));

            this.AllCountries.Add(new CountryCode("Namibia", "264", "NA / NAM"));

            this.AllCountries.Add(new CountryCode("Nauru", "674", "NR / NRU"));

            this.AllCountries.Add(new CountryCode("Nepal", "977", "NP / NPL"));

            this.AllCountries.Add(new CountryCode("Netherlands", "31", "NL / NLD"));

            this.AllCountries.Add(new CountryCode("Netherlands Antilles", "599", "AN / ANT"));

            this.AllCountries.Add(new CountryCode("New Caledonia", "687", "NC / NCL"));

            this.AllCountries.Add(new CountryCode("New Zealand", "64", "NZ / NZL"));

            this.AllCountries.Add(new CountryCode("Nicaragua", "505", "NI / NIC"));

            this.AllCountries.Add(new CountryCode("Niger", "227", "NE / NER"));

            this.AllCountries.Add(new CountryCode("Nigeria", "234", "NG / NGA"));

            this.AllCountries.Add(new CountryCode("Niue", "683", "NU / NIU"));

            this.AllCountries.Add(new CountryCode("North Korea", "850", "KP / PRK"));

            this.AllCountries.Add(new CountryCode("Northern Mariana Islands", "1-670", "MP / MNP"));

            this.AllCountries.Add(new CountryCode("Norway", "47", "NO / NOR"));

            this.AllCountries.Add(new CountryCode("Oman", "968", "OM / OMN"));

            this.AllCountries.Add(new CountryCode("Pakistan", "92", "PK / PAK"));

            this.AllCountries.Add(new CountryCode("Palau", "680", "PW / PLW"));

            this.AllCountries.Add(new CountryCode("Palestine", "970", "PS / PSE"));

            this.AllCountries.Add(new CountryCode("Panama", "507", "PA / PAN"));

            this.AllCountries.Add(new CountryCode("Papua New Guinea", "675", "PG / PNG"));

            this.AllCountries.Add(new CountryCode("Paraguay", "595", "PY / PRY"));

            this.AllCountries.Add(new CountryCode("Peru", "51", "PE / PER"));

            this.AllCountries.Add(new CountryCode("Philippines", "63", "PH / PHL"));

            this.AllCountries.Add(new CountryCode("Pitcairn", "64", "PN / PCN"));

            this.AllCountries.Add(new CountryCode("Poland", "48", "PL / POL"));

            this.AllCountries.Add(new CountryCode("Portugal", "351", "PT / PRT"));

            this.AllCountries.Add(new CountryCode("Puerto Rico", "1-787, 1-939", "PR / PRI"));

            this.AllCountries.Add(new CountryCode("Qatar", "974", "QA / QAT"));

            this.AllCountries.Add(new CountryCode("Republic of the Congo", "242", "CG / COG"));

            this.AllCountries.Add(new CountryCode("Reunion", "262", "RE / REU"));

            this.AllCountries.Add(new CountryCode("Romania", "40", "RO / ROU"));

            this.AllCountries.Add(new CountryCode("Russia", "7", "RU / RUS"));

            this.AllCountries.Add(new CountryCode("Rwanda", "250", "RW / RWA"));

            this.AllCountries.Add(new CountryCode("Saint Barthelemy", "590", "BL / BLM"));

            this.AllCountries.Add(new CountryCode("Saint Helena", "290", "SH / SHN"));

            this.AllCountries.Add(new CountryCode("Saint Kitts and Nevis", "1-869", "KN / KNA"));

            this.AllCountries.Add(new CountryCode("Saint Lucia", "1-758", "LC / LCA"));

            this.AllCountries.Add(new CountryCode("Saint Martin", "590", "MF / MAF"));

            this.AllCountries.Add(new CountryCode("Saint Pierre and Miquelon", "508", "PM / SPM"));

            this.AllCountries.Add(new CountryCode("Saint Vincent and the Grenadines", "1-784", "VC / VCT"));

            this.AllCountries.Add(new CountryCode("Samoa", "685", "WS / WSM"));

            this.AllCountries.Add(new CountryCode("San Marino", "378", "SM / SMR"));

            this.AllCountries.Add(new CountryCode("Sao Tome and Principe", "239", "ST / STP"));

            this.AllCountries.Add(new CountryCode("Saudi Arabia", "966", "SA / SAU"));

            this.AllCountries.Add(new CountryCode("Senegal", "221", "SN / SEN"));

            this.AllCountries.Add(new CountryCode("Serbia", "381", "RS / SRB"));

            this.AllCountries.Add(new CountryCode("Seychelles", "248", "SC / SYC"));

            this.AllCountries.Add(new CountryCode("Sierra Leone", "232", "SL / SLE"));

            this.AllCountries.Add(new CountryCode("Singapore", "65", "SG / SGP"));

            this.AllCountries.Add(new CountryCode("Sint Maarten", "1-721", "SX / SXM"));

            this.AllCountries.Add(new CountryCode("Slovakia", "421", "SK / SVK"));

            this.AllCountries.Add(new CountryCode("Slovenia", "386", "SI / SVN"));

            this.AllCountries.Add(new CountryCode("Solomon Islands", "677", "SB / SLB"));

            this.AllCountries.Add(new CountryCode("Somalia", "252", "SO / SOM"));

            this.AllCountries.Add(new CountryCode("South Africa", "27", "ZA / ZAF"));

            this.AllCountries.Add(new CountryCode("South Korea", "82", "KR / KOR"));

            this.AllCountries.Add(new CountryCode("South Sudan", "211", "SS / SSD"));

            this.AllCountries.Add(new CountryCode("Spain", "34", "ES / ESP"));

            this.AllCountries.Add(new CountryCode("Sri Lanka", "94", "LK / LKA"));

            this.AllCountries.Add(new CountryCode("Sudan", "249", "SD / SDN"));

            this.AllCountries.Add(new CountryCode("Suriname", "597", "SR / SUR"));

            this.AllCountries.Add(new CountryCode("Svalbard and Jan Mayen", "47", "SJ / SJM"));

            this.AllCountries.Add(new CountryCode("Swaziland", "268", "SZ / SWZ"));

            this.AllCountries.Add(new CountryCode("Sweden", "46", "SE / SWE"));

            this.AllCountries.Add(new CountryCode("Switzerland", "41", "CH / CHE"));

            this.AllCountries.Add(new CountryCode("Syria", "963", "SY / SYR"));

            this.AllCountries.Add(new CountryCode("Taiwan", "886", "TW / TWN"));

            this.AllCountries.Add(new CountryCode("Tajikistan", "992", "TJ / TJK"));

            this.AllCountries.Add(new CountryCode("Tanzania", "255", "TZ / TZA"));

            this.AllCountries.Add(new CountryCode("Thailand", "66", "TH / THA"));

            this.AllCountries.Add(new CountryCode("Togo", "228", "TG / TGO"));

            this.AllCountries.Add(new CountryCode("Tokelau", "690", "TK / TKL"));

            this.AllCountries.Add(new CountryCode("Tonga", "676", "TO / TON"));

            this.AllCountries.Add(new CountryCode("Trinidad and Tobago", "1-868", "TT / TTO"));

            this.AllCountries.Add(new CountryCode("Tunisia", "216", "TN / TUN"));

            this.AllCountries.Add(new CountryCode("Turkey", "90", "TR / TUR"));

            this.AllCountries.Add(new CountryCode("Turkmenistan", "993", "TM / TKM"));

            this.AllCountries.Add(new CountryCode("Turks and Caicos Islands", "1-649", "TC / TCA"));

            this.AllCountries.Add(new CountryCode("Tuvalu", "688", "TV / TUV"));

            this.AllCountries.Add(new CountryCode("U.S. Virgin Islands", "1-340", "VI / VIR"));

            this.AllCountries.Add(new CountryCode("Uganda", "256", "UG / UGA"));

            this.AllCountries.Add(new CountryCode("Ukraine", "380", "UA / UKR"));

            this.AllCountries.Add(new CountryCode("United Arab Emirates", "971", "AE / ARE"));

            this.AllCountries.Add(new CountryCode("United Kingdom", "44", "GB / GBR"));

            this.AllCountries.Add(new CountryCode("United States", "1", "US / USA"));

            this.AllCountries.Add(new CountryCode("Uruguay", "598", "UY / URY"));

            this.AllCountries.Add(new CountryCode("Uzbekistan", "998", "UZ / UZB"));

            this.AllCountries.Add(new CountryCode("Vanuatu", "678", "VU / VUT"));

            this.AllCountries.Add(new CountryCode("Vatican", "379", "VA / VAT"));

            this.AllCountries.Add(new CountryCode("Venezuela", "58", "VE / VEN"));

            this.AllCountries.Add(new CountryCode("Vietnam", "84", "VN / VNM"));

            this.AllCountries.Add(new CountryCode("Wallis and Futuna", "681", "WF / WLF"));

            this.AllCountries.Add(new CountryCode("Western Sahara", "212", "EH / ESH"));

            this.AllCountries.Add(new CountryCode("Yemen", "967", "YE / YEM"));

            this.AllCountries.Add(new CountryCode("Zambia", "260", "ZM / ZMB"));

            this.AllCountries.Add(new CountryCode("Zimbabwe", "263", "ZW / ZWE"));

        }
    }

    public class CountryCode
    {
        public string countryName { get; set; }
        public string countryCode { get; set; }
        public string isoCode { get; set; }
        public string isoCode2digits { get; private set; }
        public string isoCode3digits { get; private set; }

        public CountryCode(string countryname, string countryCode, string isoCode)
        {
            this.countryName = countryname;
            this.countryCode = countryCode;
            this.isoCode = isoCode;
            this.isoCode2digits = this.isoCode.Split('/').First().Trim();
            this.isoCode3digits = this.isoCode.Split('/').Last().Trim();
        }
    }
}

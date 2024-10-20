using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;


public class Nationality_Dropdown : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Dropdown countryDropdown;

    private string[] countriesEng = {
    "Afghanistan",
  "Albania",
  "Algeria",
  "Andorra",
  "Angola",
  "Antigua and Barbuda",
  "Argentina",
  "Armenia",
  "Australia",
  "Austria",
  "Azerbaijan",
  "Bahamas",
  "Bahrain",
  "Bangladesh",
  "Barbados",
  "Belarus",
  "Belgium",
  "Belize",
  "Benin",
  "Bhutan",
  "Bolivia",
  "Bosnia and Herzegovina",
  "Botswana",
  "Brazil",
  "Brunei",
  "Bulgaria",
  "Burkina Faso",
  "Burundi",
  "Cabo Verde",
  "Cambodia",
  "Cameroon",
  "Canada",
  "Central African Republic",
  "Chad",
  "Chile",
  "China",
  "Colombia",
  "Comoros",
  "Congo",
  "Costa Rica",
  "Croatia",
  "Cuba",
  "Cyprus",
  "Czech Republic",
  "Democratic Republic of the Congo",
  "Denmark",
  "Djibouti",
  "Dominica",
  "Dominican Republic",
  "East Timor",
  "Ecuador",
  "Egypt",
  "El Salvador",
  "Equatorial Guinea",
  "Eritrea",
  "Estonia",
  "Eswatini",
  "Ethiopia",
  "Fiji",
  "Finland",
  "France",
  "Gabon",
  "Gambia",
  "Georgia",
  "Germany",
  "Ghana",
  "Greece",
  "Grenada",
  "Guatemala",
  "Guinea",
  "Guinea-Bissau",
  "Guyana",
  "Haiti",
  "Honduras",
  "Hungary",
  "Iceland",
  "India",
  "Indonesia",
  "Iran",
  "Iraq",
  "Ireland",
  "Israel",
  "Italy",
  "Ivory Coast",
  "Jamaica",
  "Japan",
  "Jordan",
  "Kazakhstan",
  "Kenya",
  "Kiribati",
  "Kosovo",
  "Kuwait",
  "Kyrgyzstan",
  "Laos",
  "Latvia",
  "Lebanon",
  "Lesotho",
  "Liberia",
  "Libya",
  "Liechtenstein",
  "Lithuania",
  "Luxembourg",
  "Madagascar",
  "Malawi",
  "Malaysia",
  "Maldives",
  "Mali",
  "Malta",
  "Marshall Islands",
  "Mauritania",
  "Mauritius",
  "Mexico",
  "Micronesia",
  "Moldova",
  "Monaco",
  "Mongolia",
  "Montenegro",
  "Morocco",
  "Mozambique",
  "Myanmar",
  "Namibia",
  "Nauru",
  "Nepal",
  "Netherlands",
  "New Zealand",
  "Nicaragua",
  "Niger",
  "Nigeria",
  "North Korea",
  "North Macedonia",
  "Norway",
  "Oman",
  "Pakistan",
  "Palau",
  "Palestine",
  "Panama",
  "Papua New Guinea",
  "Paraguay",
  "Peru",
  "Philippines",
  "Poland",
  "Portugal",
  "Qatar",
  "Romania",
  "Russia",
  "Rwanda",
  "Saint Kitts and Nevis",
  "Saint Lucia",
  "Saint Vincent and the Grenadines",
  "Samoa",
  "San Marino",
  "Sao Tome and Principe",
  "Saudi Arabia",
  "Senegal",
  "Serbia",
  "Seychelles",
  "Sierra Leone",
  "Singapore",
  "Slovakia",
  "Slovenia",
  "Solomon Islands",
  "Somalia",
  "South Africa",
  "South Korea",
  "South Sudan",
  "Spain",
  "Sri Lanka",
  "Sudan",
  "Suriname",
  "Sweden",
  "Switzerland",
  "Syria",
  "Taiwan",
  "Tajikistan",
  "Tanzania",
  "Thailand",
  "Togo",
  "Tonga",
  "Trinidad and Tobago",
  "Tunisia",
  "Turkey",
  "Turkmenistan",
  "Tuvalu",
  "Uganda",
  "Ukraine",
  "United Arab Emirates",
  "United Kingdom",
  "United States",
  "Uruguay",
  "Uzbekistan",
  "Vanuatu",
  "Vatican City",
  "Venezuela",
  "Vietnam",
  "Yemen",
  "Zambia",
  "Zimbabwe"};
    private string[] countriesSpanish = {
  "Afganist�n",
  "Albania",
  "Argelia",
  "Andorra",
  "Angola",
  "Antigua y Barbuda",
  "Argentina",
  "Armenia",
  "Australia",
  "Austria",
  "Azerbaiy�n",
  "Bahamas",
  "Bar�in",
  "Banglad�s",
  "Barbados",
  "Bielorrusia",
  "B�lgica",
  "Belice",
  "Ben�n",
  "But�n",
  "Bolivia",
  "Bosnia y Herzegovina",
  "Botsuana",
  "Brasil",
  "Brun�i",
  "Bulgaria",
  "Burkina Faso",
  "Burundi",
  "Cabo Verde",
  "Camboya",
  "Camer�n",
  "Canad�",
  "Rep�blica Centroafricana",
  "Chad",
  "Chile",
  "China",
  "Colombia",
  "Comoras",
  "Congo",
  "Costa Rica",
  "Croacia",
  "Cuba",
  "Chipre",
  "Rep�blica Checa",
  "Rep�blica Democr�tica del Congo",
  "Dinamarca",
  "Yibuti",
  "Dominica",
  "Rep�blica Dominicana",
  "Timor Oriental",
  "Ecuador",
  "Egipto",
  "El Salvador",
  "Guinea Ecuatorial",
  "Eritrea",
  "Estonia",
  "Esuatini",
  "Etiop�a",
  "Fiyi",
  "Finlandia",
  "Francia",
  "Gab�n",
  "Gambia",
  "Georgia",
  "Alemania",
  "Ghana",
  "Grecia",
  "Granada",
  "Guatemala",
  "Guinea",
  "Guinea-Bis�u",
  "Guyana",
  "Hait�",
  "Honduras",
  "Hungr�a",
  "Islandia",
  "India",
  "Indonesia",
  "Ir�n",
  "Iraq",
  "Irlanda",
  "Israel",
  "Italia",
  "Costa de Marfil",
  "Jamaica",
  "Jap�n",
  "Jordania",
  "Kazajist�n",
  "Kenia",
  "Kiribati",
  "Kosovo",
  "Kuwait",
  "Kirguist�n",
  "Laos",
  "Letonia",
  "L�bano",
  "Lesoto",
  "Liberia",
  "Libia",
  "Liechtenstein",
  "Lituania",
  "Luxemburgo",
  "Madagascar",
  "Malaui",
  "Malasia",
  "Maldivas",
  "Mal�",
  "Malta",
  "Islas Marshall",
  "Mauritania",
  "Mauricio",
  "M�xico",
  "Micronesia",
  "Moldavia",
  "M�naco",
  "Mongolia",
  "Montenegro",
  "Marruecos",
  "Mozambique",
  "Birmania",
  "Namibia",
  "Nauru",
  "Nepal",
  "Pa�ses Bajos",
  "Nueva Zelanda",
  "Nicaragua",
  "N�ger",
  "Nigeria",
  "Corea del Norte",
  "Macedonia del Norte",
  "Noruega",
  "Om�n",
  "Pakist�n",
  "Palaos",
  "Palestina",
  "Panam�",
  "Pap�a Nueva Guinea",
  "Paraguay",
  "Per�",
  "Filipinas",
  "Polonia",
  "Portugal",
  "Catar",
  "Rumania",
  "Rusia",
  "Ruanda",
  "San Crist�bal y Nieves",
  "Santa Luc�a",
  "San Vicente y las Granadinas",
  "Samoa",
  "San Marino",
  "Santo Tom� y Pr�ncipe",
  "Arabia Saudita",
  "Senegal",
  "Serbia",
  "Seychelles",
  "Sierra Leona",
  "Singapur",
  "Eslovaquia",
  "Eslovenia",
  "Islas Salom�n",
  "Somalia",
  "Sud�frica",
  "Corea del Sur",
  "Sud�n del Sur",
  "Espa�a",
  "Sri Lanka",
  "Sud�n",
  "Surinam",
  "Suecia",
  "Suiza",
  "Siria",
  "Taiw�n",
  "Tayikist�n",
  "Tanzania",
  "Tailandia",
  "Togo",
  "Tonga",
  "Trinidad y Tobago",
  "T�nez",
  "Turqu�a",
  "Turkmenist�n",
  "Tuvalu",
  "Uganda",
  "Ucrania",
  "Emiratos �rabes Unidos",
  "Reino Unido",
  "Estados Unidos",
  "Uruguay",
  "Uzbekist�n",
  "Vanuatu",
  "Ciudad del Vaticano",
  "Venezuela",
  "Vietnam",
  "Yemen",
  "Zambia",
  "Zimbabue"
    };

    // You can use the 'countriesSpanish' array in your app for the Spanish version of the country dropdown.



    void Start()
    {

        // Get the language of the current locale
      
        Locale currentLocale = LocalizationSettings.SelectedLocale;


        if (currentLocale != null && currentLocale.Identifier == "es")
        {
            PopulateNames(countriesSpanish, countryDropdown);
        }
        else
        {
            PopulateNames(countriesEng, countryDropdown);
        }

        
       
        
    }

    void PopulateNames(string[] list, TMP_Dropdown dropdown)
    {
        dropdown.ClearOptions(); // Clear any existing options

        // Create a list to hold the dropdown options
        var options = new List<TMP_Dropdown.OptionData>();

        // Populate the options list with names from the array
        foreach (string name in list)
        {
            options.Add(new TMP_Dropdown.OptionData(name));
        }

        // Add the options to the dropdown
        dropdown.AddOptions(options);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

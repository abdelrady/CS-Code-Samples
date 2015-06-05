/* This script and many more are available free online at
The JavaScript Source :: http://javascript.internet.com
Created by: Down Home Consulting :: http://downhomeconsulting.com */

/*
Country State Drop Downs v1.0.
(c) Copyright 2005 Down Home Consulting, Inc.
www.DownHomeConsulting.com

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. The software is provided "as is", without warranty of any kind, express or implied, including but not limited to the warranties of merchantability, itness for a particular purpose and noninfringement. in no event shall the authors or copyright holders be liable for any claim, damages or other liability, whether in an action of contract, tort or otherwise, arising from, out of or in connection with the software or the use or other dealings in the software.

*/

// If you have PHP you can set the post values like this
//var postState = '<?= $_POST["state"] ?>';
//var postCountry = '<?= $_POST["country"] ?>';
var postState = '';
var postCountry = '';

// State table
//
// To edit the list, just delete a line or add a line. Order is important.
// The order displayed here is the order it appears on the drop down.
//
var state = '\
US:AK:Alaska|\
US:AL:Alabama|\
US:AR:Arkansas|\
US:AS:American Samoa|\
US:AZ:Arizona|\
US:CA:California|\
US:CO:Colorado|\
US:CT:Connecticut|\
US:DC:D.C.|\
US:DE:Delaware|\
US:FL:Florida|\
US:FM:Micronesia|\
US:GA:Georgia|\
US:GU:Guam|\
US:HI:Hawaii|\
US:IA:Iowa|\
US:ID:Idaho|\
US:IL:Illinois|\
US:IN:Indiana|\
US:KS:Kansas|\
US:KY:Kentucky|\
US:LA:Louisiana|\
US:MA:Massachusetts|\
US:MD:Maryland|\
US:ME:Maine|\
US:MH:Marshall Islands|\
US:MI:Michigan|\
US:MN:Minnesota|\
US:MO:Missouri|\
US:MP:Marianas|\
US:MS:Mississippi|\
US:MT:Montana|\
US:NC:North Carolina|\
US:ND:North Dakota|\
US:NE:Nebraska|\
US:NH:New Hampshire|\
US:NJ:New Jersey|\
US:NM:New Mexico|\
US:NV:Nevada|\
US:NY:New York|\
US:OH:Ohio|\
US:OK:Oklahoma|\
US:OR:Oregon|\
US:PA:Pennsylvania|\
US:PR:Puerto Rico|\
US:PW:Palau|\
US:RI:Rhode Island|\
US:SC:South Carolina|\
US:SD:South Dakota|\
US:TN:Tennessee|\
US:TX:Texas|\
US:UT:Utah|\
US:VA:Virginia|\
US:VI:Virgin Islands|\
US:VT:Vermont|\
US:WA:Washington|\
US:WI:Wisconsin|\
US:WV:West Virginia|\
US:WY:Wyoming|\
US:AA:Military Americas|\
US:AE:Military Europe/ME/Canada|\
US:AP:Military Pacific|\
CA:Alberta:Alberta|\
CA:Manitoba:Manitoba|\
CA:Alberta:Alberta|\
CA:British Columbia:British Columbia|\
CA:Manitoba:Manitoba|\
CA:New Brunswick:New Brunswick|\
CA:Newfoundland and Labrador:Newfoundland and Labrador|\
CA:Nova Scotia:Nova Scotia|\
CA:Northwest Territories:Northwest Territories|\
CA:Nunavut:Nunavut|\
CA:Ontario:Ontario|\
CA:Prince Edward Island:Prince Edward Island|\
CA:Quebec:Quebec|\
CA:Saskatchewan:Saskatchewan|\
CA:YT:Yukon Territory|\
Australia:Australian Antarctic Territory:Australian Antarctic Territory|\
Australia:Australian Capital Territory:Australian Capital Territory|\
Australia:Northern Territory:Northern Territory|\
Australia:New South Wales:New South Wales|\
Australia:Queensland:Queensland|\
Australia:South Australia:South Australia|\
Australia:Tasmania:Tasmania|\
Australia:Victoria:Victoria|\
Australia:Western Australia:Western Australia|\
BRAZIL:Acre:Acre|\
BRAZIL:Alagoas:Alagoas|\
BRAZIL:Amazonas:Amazonas|\
BRAZIL:Amapa:Amapa|\
BRAZIL:Baia:Baia|\
BRAZIL:Ceara:Ceara|\
BRAZIL:Distrito:Distrito Federal|\
BRAZIL:Espirito Santo:Espirito Santo|\
BRAZIL:Fernando de Noronha:Fernando de Noronha|\
BRAZIL:Goias:Goias|\
BRAZIL:Maranhao:Maranhao|\
BRAZIL:Minas Gerais:Minas Gerais|\
BRAZIL:Mato Grosso do Sul:Mato Grosso do Sul|\
BRAZIL:Mato Grosso:Mato Grosso|\
BRAZIL:Para:Para|\
BRAZIL:Paraiba:Paraiba|\
BRAZIL:Pernambuco:Pernambuco|\
BRAZIL:Piaui:Piaui|\
BRAZIL:Parana:Parana|\
BRAZIL:Rio de Janeiro:Rio de Janeiro|\
BRAZIL:Rio Grande do Norte:Rio Grande do Norte|\
BRAZIL:Rondonia:Rondonia|\
BRAZIL:Roraima:Roraima|\
BRAZIL:Rio Grande do Sul:Rio Grande do Sul|\
BRAZIL:Santa Catarina:Santa Catarina|\
BRAZIL:Sergipe:Sergipe|\
BRAZIL:Sao Paulo:Sao Paulo|\
BRAZIL:Tocatins:Tocatins|\
Netherlands:Drente:Drente|\
Netherlands:Flevoland:Flevoland|\
Netherlands:Friesland:Friesland|\
Netherlands:Gelderland:Gelderland|\
Netherlands:Groningen:Groningen|\
Netherlands:Limburg:Limburg|\
Netherlands:Noord Brabant:Noord Brabant|\
Netherlands:Noord Holland:Noord Holland|\
Netherlands:Overijssel:Overijssel|\
Netherlands:Utrecht:Utrecht|\
Netherlands:Zuid Holland:Zuid Holland|\
Netherlands:Zeeland:Zeeland|\
UK:AVON:Avon|\
UK:BEDS:Bedfordshire|\
UK:BERKS:Berkshire|\
UK:BUCKS:Buckinghamshire|\
UK:CAMBS:Cambridgeshire|\
UK:CHESH:Cheshire|\
UK:CLEVE:Cleveland|\
UK:CORN:Cornwall|\
UK:CUMB:Cumbria|\
UK:DERBY:Derbyshire|\
UK:DEVON:Devon|\
UK:DORSET:Dorset|\
UK:DURHAM:Durham|\
UK:ESSEX:Essex|\
UK:GLOUS:Gloucestershire|\
UK:GLONDON:Greater London|\
UK:GMANCH:Greater Manchester|\
UK:HANTS:Hampshire|\
UK:HERWOR:Hereford & Worcestershire|\
UK:HERTS:Hertfordshire|\
UK:HUMBER:Humberside|\
UK:IOM:Isle of Man|\
UK:IOW:Isle of Wight|\
UK:KENT:Kent|\
UK:LANCS:Lancashire|\
UK:LEICS:Leicestershire|\
UK:LINCS:Lincolnshire|\
UK:MERSEY:Merseyside|\
UK:NORF:Norfolk|\
UK:NHANTS:Northamptonshire|\
UK:NTHUMB:Northumberland|\
UK:NOTTS:Nottinghamshire|\
UK:OXON:Oxfordshire|\
UK:SHROPS:Shropshire|\
UK:SOM:Somerset|\
UK:STAFFS:Staffordshire|\
UK:SUFF:Suffolk|\
UK:SURREY:Surrey|\
UK:SUSS:Sussex|\
UK:WARKS:Warwickshire|\
UK:WMID:West Midlands|\
UK:WILTS:Wiltshire|\
UK:YORK:Yorkshire|\
';

// Country data table
//
// To edit the list, just delete a line or add a line. Order is important.
// The order displayed here is the order it appears on the drop down.
//
var country = '\
Afghanistan:Afghanistan|\
Albania:Albania|\
Algeria:Algeria|\
American Samoa:American Samoa|\
Andorra:Andorra|\
Angola:Angola|\
Anguilla:Anguilla|\
Antarctica:Antarctica|\
Antigua and Barbuda:Antigua and Barbuda|\
Argentina:Argentina|\
Armenia:Armenia|\
Aruba:Aruba|\
Australia:Australia|\
Austria:Austria|\
Azerbaijan:Azerbaijan|\
Azores:Azores|\
Bahamas:Bahamas|\
Bahrain:Bahrain|\
Bangladesh:Bangladesh|\
Barbados:Barbados|\
Belarus:Belarus|\
Belgium:Belgium|\
Belize:Belize|\
Benin:Benin|\
Bermuda:Bermuda|\
Bhutan:Bhutan|\
Bolivia:Bolivia|\
BosniaHerzegowina:Bosnia And Herzegowina|\
Bosnia-Herzegovina:Bosnia-Herzegovina|\
Botswana:Botswana|\
BouvetIsland:Bouvet Island|\
BRAZIL:Brazil|\
IO:British Indian Ocean Territory|\
VG:British Virgin Islands|\
BN:Brunei Darussalam|\
Bulgaria:Bulgaria|\
BF:Burkina Faso|\
Burundi:Burundi|\
Cambodia:Cambodia|\
Cameroon:Cameroon|\
CA:Canada|\
CapeVerde:Cape Verde|\
CaymanIslands:Cayman Islands|\
CF:Central African Republic|\
Chad:Chad|\
Chile:Chile|\
China:China|\
ChristmasIsland:Christmas Island|\
Cocos:Cocos (Keeling) Islands|\
Colombia:Colombia|\
Comoros:Comoros|\
Congo:Congo|\
CongoDemocratic:Congo, The Democratic Republic O|\
CookIslandK:Cook Islands|\
Corsica:Corsica|\
CR:Costa Rica|\
CI:Cote d` Ivoire (Ivory Coast)|\
Croatia:Croatia|\
Cuba:Cuba|\
Cyprus:Cyprus|\
Czech:Czech Republic|\
Denmark:Denmark|\
Djibouti:Djibouti|\
Dominica:Dominica|\
DominicanRepublic:Dominican Republic|\
EastTimor:East Timor|\
Ecuador:Ecuador|\
Egypt:Egypt|\
ElSalvador:El Salvador|\
Equatorial Guinea:Equatorial Guinea|\
Eritrea:Eritrea|\
Estonia:Estonia|\
Ethiopia:Ethiopia|\
FK:Falkland Islands (Malvinas)|\
FO:Faroe Islands|\
Fiji:Fiji|\
Finland:Finland|\
France:France (Includes Monaco)|\
FranceMetro:France, Metropolitan|\
GF:French Guiana|\
PF:French Polynesia|\
TA:French Polynesia (Tahiti)|\
TF:French Southern Territories|\
Gabon:Gabon|\
Gambia:Gambia|\
Georgia:Georgia|\
Germany:Germany|\
Ghana:Ghana|\
Gibraltar:Gibraltar|\
Greece:Greece|\
Greenland:Greenland|\
Grenada:Grenada|\
Guadeloupe:Guadeloupe|\
Guam:Guam|\
Guatemala:Guatemala|\
Guinea:Guinea|\
GuineaBissau:Guinea-Bissau|\
Guyana:Guyana|\
Haiti:Haiti|\
Heard and McDonald:Heard And Mc Donald Islands|\
HolySee:Holy See (Vatican City State)|\
Honduras:Honduras|\
HK:Hong Kong|\
Hungary:Hungary|\
Iceland:Iceland|\
India:India|\
Indonesia:Indonesia|\
Iran:Iran|\
Iraq:Iraq|\
Ireland:Ireland|\
Ireland:Ireland (Eire)|\
Israel:Israel|\
Italy:Italy|\
Jamaica:Jamaica|\
Japan:Japan|\
Jordan:Jordan|\
Kazakhstan:Kazakhstan|\
Kenya:Kenya|\
Kiribati:Kiribati|\
Korea:Korea, Democratic People\'S Repub|\
Kuwait:Kuwait|\
Kyrgyzstan:Kyrgyzstan|\
Laos:Laos|\
Latvia:Latvia|\
Lebanon:Lebanon|\
Lesotho:Lesotho|\
Liberia:Liberia|\
Libya:Libya|\
Liechtenstein:Liechtenstein|\
Lithuania:Lithuania|\
Luxembourg:Luxembourg|\
Macao:Macao|\
Macedonia:Macedonia|\
Madagascar:Madagascar|\
Madeira:Madeira Islands|\
Malawi:Malawi|\
Malaysia:Malaysia|\
Maldives:Maldives|\
Mali:Mali|\
Malta:Malta|\
Marshall:Marshall Islands|\
Martinique:Martinique|\
Mauritania:Mauritania|\
Mauritius:Mauritius|\
Mayotte:Mayotte|\
Mexico:Mexico|\
Micronesia:Micronesia, Federated States Of|\
Moldova:Moldova, Republic Of|\
Monaco:Monaco|\
Mongolia:Mongolia|\
Montserrat:Montserrat|\
Morocco:Morocco|\
Mozambique:Mozambique|\
Myanmar:Myanmar (Burma)|\
Namibia:Namibia|\
Nauru:Nauru|\
Nepal:Nepal|\
Netherlands:Netherlands|\
NetherlandsAntilles:Netherlands Antilles|\
NewCaledonia:New Caledonia|\
NewZealand:New Zealand|\
Nicaragua:Nicaragua|\
Niger:Niger|\
Nigeria:Nigeria|\
Niue:Niue|\
Norfolk :Norfolk Island|\
Northern Mariana Islands:Northern Mariana Islands|\
Norway:Norway|\
Oman:Oman|\
Pakistan:Pakistan|\
Palau:Palau|\
Palestinian Territory, Occupied:Palestinian Territory, Occupied|\
Panama:Panama|\
Papua New Guinea:Papua New Guinea|\
Paraguay:Paraguay|\
Peru:Peru|\
Philippines:Philippines|\
Pitcairn:Pitcairn|\
Poland:Poland|\
Portugal:Portugal|\
Puerto Rico:Puerto Rico|\
Qatar:Qatar|\
Reunion:Reunion|\
Romania:Romania|\
Russian Federation:Russian Federation|\
Rwanda:Rwanda|\
Saint Kitts And Nevis:Saint Kitts And Nevis|\
San Marino:San Marino|\
Sao Tome and Principe:Sao Tome and Principe|\
Saudi Arabia:Saudi Arabia|\
Senegal:Senegal|\
Serbia-Montenegro:Serbia-Montenegro|\
Seychelles:Seychelles|\
Sierra Leone:Sierra Leone|\
Singapore:Singapore|\
Slovak Republic:Slovak Republic|\
Slovenia:Slovenia|\
Solomon Islands:Solomon Islands|\
Somalia:Somalia|\
South Africa:South Africa|\
South Georgia And The South Sand:South Georgia And The South Sand|\
South Korea:South Korea|\
Spain:Spain|\
Sri Lanka:Sri Lanka|\
St Christopher and Nevis:St. Christopher and Nevis|\
St Helena:St. Helena|\
St Lucia:St. Lucia|\
St Pierre and Miquelon:St. Pierre and Miquelon|\
St Vincent and the Grenadines:St. Vincent and the Grenadines|\
Sudan:Sudan|\
Suriname:Suriname|\
Svalbard And Jan Mayen Islands:Svalbard And Jan Mayen Islands|\
Swaziland:Swaziland|\
Sweden:Sweden|\
Switzerland:Switzerland|\
Syrian Arab Republic:Syrian Arab Republic|\
Taiwan:Taiwan|\
Tajikistan:Tajikistan|\
Tanzania:Tanzania|\
Thailand:Thailand|\
Togo:Togo|\
Tokelau:Tokelau|\
Tonga:Tonga|\
Trinidad and Tobago:Trinidad and Tobago|\
Tristan da Cunha:Tristan da Cunha|\
Tunisia:Tunisia|\
Turkey:Turkey|\
Turkmenistan:Turkmenistan|\
Turks and Caicos Islands:Turks and Caicos Islands|\
Tuvalu:Tuvalu|\
Uganda:Uganda|\
Ukraine:Ukraine|\
United Arab Emirates:United Arab Emirates|\
UK:United Kingdom|\
Great Britain:Great Britain|\
US:United States|\
US Outlying Islands:United States Minor Outlying Isl|\
Uruguay:Uruguay|\
Uzbekistan:Uzbekistan|\
Vanuatu:Vanuatu|\
Vatican:Vatican City|\
Venezuela:Venezuela|\
Vietnam:Vietnam|\
Virgin:Virgin Islands (U.S.)|\
Wallis and Furuna Islands:Wallis and Furuna Islands|\
Western Sahara:Western Sahara|\
Western Samoa:Western Samoa|\
Yemen:Yemen|\
Yugoslavia:Yugoslavia|\
Zaire:Zaire|\
Zambia:Zambia|\
Zimbabwe:Zimbabwe|\
';

function TrimString(sInString) {
  if ( sInString ) {
    sInString = sInString.replace( /^\s+/g, "" );// strip leading
    return sInString.replace( /\s+$/g, "" );// strip trailing
  }
}

// Populates the country selected with the counties from the country list
function populateCountry(defaultCountry) {
  if ( postCountry != '' ) {
    defaultCountry = postCountry;
  }
  var countryLineArray = country.split('|');  // Split into lines
  var selObj = document.getElementById('countrySelect');
  selObj.options[0] = new Option('Select Country','');
  selObj.selectedIndex = 0;
  for (var loop = 0; loop < countryLineArray.length; loop++) {
    lineArray = countryLineArray[loop].split(':');
    countryCode  = TrimString(lineArray[0]);
    countryName  = TrimString(lineArray[1]);
    if ( countryCode != '' ) {
      selObj.options[loop + 1] = new Option(countryName, countryCode);
    }
    if ( defaultCountry == countryCode ) {
      selObj.selectedIndex = loop + 1;
    }
  }
}

function populateState() {
  var selObj = document.getElementById('stateSelect');
  var foundState = false;
  // Empty options just in case new drop down is shorter
  if ( selObj.type == 'select-one' ) {
//  if ( selObj.type == 'select-one' ) {
    for (var i = 0; i < selObj.options.length; i++) {
      selObj.options[i] = null;
    }
    selObj.options.length=null;
    selObj.options[0] = new Option('Select State/Province','N/A');
    selObj.selectedIndex = 0;
  }
  // Populate the drop down with states from the selected country
  var stateLineArray = state.split("|");  // Split into lines
  var optionCntr = 1;
  for (var loop = 0; loop < stateLineArray.length; loop++) {
    lineArray = stateLineArray[loop].split(":");
    countryCode  = TrimString(lineArray[0]);
    stateCode    = TrimString(lineArray[1]);
    stateName    = TrimString(lineArray[2]);
  if (document.getElementById('countrySelect').value == countryCode && countryCode != '' ) {
    // If it's a input element, change it to a select
      if ( selObj.type == 'text' ) {
        parentObj = document.getElementById('stateSelect').parentNode;
        parentObj.removeChild(selObj);
        var inputSel = document.createElement("SELECT");
        inputSel.setAttribute("name","state");
        inputSel.setAttribute("id","stateSelect");
        parentObj.appendChild(inputSel) ;
        selObj = document.getElementById('stateSelect');
        selObj.options[0] = new Option('State/Province','N/A');
//        selObj.options[0] = new Option('State/Province','N/A');
        selObj.selectedIndex = 0;
//        selObj.selectedIndex = 0;
// options[0].selected = true;
}
      if ( stateCode != '' ) {
        selObj.options[optionCntr] = new Option(stateName, stateCode);
      }
      // See if it's selected from a previous post
      if ( stateCode == postState && countryCode == postCountry ) {
        selObj.selectedIndex = optionCntr;
      }
      foundState = true;
      optionCntr++
    }
  }
  // If the country has no states, change the select to a text box
  if ( ! foundState ) {
    parentObj = document.getElementById('stateSelect').parentNode;
    parentObj.removeChild(selObj);
  // Create the Input Field
    var inputEl = document.createElement("INPUT");
    inputEl.setAttribute("id", "stateSelect");
    inputEl.setAttribute("type", "text");
    inputEl.setAttribute("name", "state");
    inputEl.setAttribute("size", 1);
    inputEl.setAttribute("width", 25);
    inputEl.setAttribute("visibility","hidden");
    inputEl.setAttribute("value", "N/A");
    parentObj.appendChild(inputEl) ;
  }
}

function initCountry(country) {
  populateCountry(country);
  populateState();
}



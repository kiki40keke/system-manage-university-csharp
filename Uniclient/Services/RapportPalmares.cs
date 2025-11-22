using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RapportPalmares
    {
        public string RapportPalmares1(string Tbody, string NomOption, string NomCours, string NomVacation, string Promotions, string Nomsession, string Nomniveaux) 
        {

            String Head="<!DOCTYPE html>\n" +
"<html lang=\"en\">\n" +
"<head>\n" +
"    <meta charset=\"UTF-8\">\n" +
"    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n" +
"    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n" +
"    <title>Document</title>\n" +
"\n" +
"    <style>\n" +
"        body {\n" +
"   \n" +
"}\n" +
"page {\n" +
"  background: white;\n" +
"  display: block;\n" +
"  margin: 0 auto;\n" +
"  margin-bottom: 0.5cm;\n" +
"  box-shadow: 0 0 0.5cm rgba(0,0,0,0.5);\n" +
"  text-align: center;\n" +
"}\n" +
"page[size=\"A4\"][layout=\"landscape\"] {\n" +
"  width: 29.7cm;\n" +
"  height: 21cm;  \n" +
"}\n" +
"th, td{border: 1px solid black; padding: 10px;}\n" +
"caption{ background-color: #0AD; font-weight: bold;}\n" +
"div.centered \n" +
"{\n" +
"    text-align: center;\n" +
"}\n" +
"\n" +
"div.centered table \n" +
"{\n" +
"    margin: 0 auto; \n" +
"    text-align: left;\n" +
"}\n" +
"@media print {\n" +
"  body, page {\n" +
"    margin: 0;\n" +
"    box-shadow: 0;\n" +
"  }\n" +
"}\n" +
"    </style>\n" +
"</head>";


            string thead="<body>\n" +
"    <page size=\"A4\" layout=\"landscape\">\n" +
"        <div class=\"centered\">\n" +
"      <h1>UI</h1>\n" +
"      <h2>Universite Intense</h2>\n" +
"      <h2>Palmaresse</h2>\n" +
"      <table>\n" +
"        <tr>\n" +
"          <td>Options</td>\n" +
"          <td>"+NomOption+"</td>\n" +
"         <td>Promotions</td>\n" +
"          <td>"+Promotions+"</td>\n" +
"        </tr>\n" +
"        <tr>\n" +
"          <td>Niveau </td>\n" +
"          <td>"+Nomniveaux+"</td>\n" +
"         <td>Session</td>\n" +
"          <td>"+Nomsession+"</td>\n" +
"        </tr>\n" +
"        <tr>\n" +
"          <td>Cours</td>\n" +
"          <td>"+NomCours+"</td>\n" +
"         <td>Vacation</td>\n" +
"          <td>"+NomVacation+"</td>\n" +
"        </tr>\n" +
"      </table>\n" +
"          <table>\n" +
"             \n" +
"              <thead>\n" +
"                  <tr>\n" +
"                     <th>Code </th>\n" +
"                     <th>Nom </th>\n" +
"                     <th>Prenom </th>\n" +
"                     <th>Examen Intra </th>\n" +
"                     <th>Devoir Intra</th>\n" +
"                     <th>Examen Final</th>\n" +
"                     <th>Devoir Final</th>\n" +
"                     <th>Note Final</th>\n" +
"                     <th>Coefficient</th>   \n" +
"                  </tr>\n" +
"              </thead>\n" +
"              <tbody>";

            string footer="</tbody>\n" +
"          </table>\n" +
"        </div>\n" +
"    </page>\n" +
"</body>\n" +
"</html>";

            string Html = Head + thead + Tbody + footer;

            return Html;

        }
}
}

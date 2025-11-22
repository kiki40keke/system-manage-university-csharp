using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
  public  class BulletinHtmlEtudiant
    {
      public string BulletinHtmlEtudiant1(String Options, String Niveau, String Session, String Exercice, String Nom, String Prenom, String Matricule, String Groupe, String Total1, String Total2, String Moyenne, String Tbody)
      {
          //        try {
          String Head = "<!DOCTYPE html>\n" +
                  "<html>\n" +
                  "<head>\n" +
                  "	<meta charset=\"utf-8\">\n" +
                  "	<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n" +
                  "    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n" +
                  "	<title>Bulletin</title>\n" +
                  "	<style type=\"text/css\">\n" +
                  "		 body {\n" +
                  "               background: white; \n" +
                  "              }\n" +
                  "page {\n" +
                  "         background: white;\n" +
                  "         display: block;\n" +
                  "          margin: 0 auto;\n" +
                  "          margin-bottom: 0.5cm;\n" +
                  "          box-shadow: 0 0 0.5cm rgba(0,0,0,0.5);\n" +
                  "          text-align: center;\n" +
                  "  }\n" +
                  "\n" +
                  "  page[size=\"A4\"] {  \n" +
                  "  width: 21cm;\n" +
                  "  height: 29.7cm; \n" +
                  "} \n" +
                  "@media print {\n" +
                  "  body, page {\n" +
                  "    margin: 0;\n" +
                  "    box-shadow: 0;\n" +
                  "\n" +
                  "  }\n" +
                  "}\n" +
                  "	\n" +
                  "	.infoNotes {\n" +
                  "  width: 90%;\n" +
                  "  max-width: 100%;\n" +
                  "  margin-bottom: 10px;\n" +
                  "  border: 1px solid black;\n" +
                  "  padding: 10px;\n" +
                  "}\n" +
                  ".infoPlus table \n" +
                  "{\n" +
                  "    margin: 0 auto; \n" +
                  "    text-align: left;\n" +
                  "}\n" +
                  ".infoPlus.infoNotes th, td{border: 1px solid black; padding: 10px;}\n" +
                  "\n" +
                  "\n" +
                  "hr {\n" +
                  "  box-sizing: content-box;\n" +
                  "  height: 0;\n" +
                  "  overflow: visible;\n" +
                  "}\n" +
                  "table {\n" +
                  "    border-collapse: collapse !important;\n" +
                  "  }\n" +
                  "  table td,\n" +
                  "  table th {\n" +
                  "    background-color: #fff !important;\n" +
                  "  }\n" +
                  "  table th,\n" +
                  "  table td {\n" +
                  "    border: 1px solid #dee2e6 !important;\n" +
                  "  }\n" +
                  "  table {\n" +
                  "    color: inherit;\n" +
                  "  }\n" +
                  "  table th,\n" +
                  "  table td,\n" +
                  "  table thead th,\n" +
                  "  table tbody + tbody {\n" +
                  "    border-color: #dee2e6;\n" +
                  "  }\n" +
                  "  table .thead-dark th {\n" +
                  "    color: inherit;\n" +
                  "    border-color: #dee2e6;\n" +
                  "  }\n" +
                  "\n" +
                  "	</style>\n" +
                  "</head>\n" +
                  "<body>\n" +
                  "	<page size=\"A4\"><br>\n" +
                  "<div>";

          String Head2 = "	<h1>UNIVERSITE INTENSE</h1>\n" +
                  "	<blockquote>2,ruelle Chretien, Jacquet TOTO,Petion Ville, Ouest, Haiti</blockquote>\n" +
                  "	<h2>BULLETIN</h2>\n" +
                  "  <h3>" + Options + "</h3>\n" +
                  "  <h3>" + Niveau + "</h3>\n" +
                  "  <h3>" + Session + "</h3>\n" +
                  "	<h3>Exercice " + Exercice + "</h3>\n" +
                  "	<hr>\n";



          String Head3 = "<div class=\"infoPlus\">\n" +
"    <table class=\"infoNotes\" style=\"padding-left: 40%; \">\n" +
"       <tr>\n" +
"            <td>Nom: " + Nom + "</td>\n" +
"            <td>Prenom: " + Prenom + "</td>\n" +
"            <td>Matricule: " + Matricule + "</td>\n" +
"            <td>Groupe: " + Groupe + " </td>\n" +
"          </tr>    \n" +
"    </table>\n" +
"  </div>\n" +
"  <br>\n" +
"  <br>";

          String Head4 = "	<div class=\"infoPlus\">\n" +
                  "	<table class=\"infoNotes\" style=\"padding-left: 40%; \">\n" +
                  "		 <tr>\n" +
                  "          <td>Matiere</td>\n" +
                  "          <td>Notes</td>\n" +
                  "          <td>Sur</td>\n" +
                  "          <td>Reprise I</td>\n" +
                  "          <td>Reprise II</td>\n" +
                  "        </tr>";



          String Footer1 = "<br>\n" +
"\n" +
"  <div class=\"infoPlus\">\n" +
"    <table class=\"infoNotes\" style=\"padding-left: 40%; \">\n" +
"       <tr>\n" +
"            <td>Total: " + Total1 + "</td>\n" +
"            <td>Sur: " + Total2 + "</td>\n" +
"            <td>Moyenne:" + Moyenne + "</td>\n" +
"            <td>Sur: 10 </td>\n" +
"          </tr>    \n" +
"    </table>\n" +
"  </div>\n" +
"  <br>";

          String Footer2 = "	<div>\n" +
                  "		<tr>\n" +
                  "			<td>Remarques\n" +
                  "				<th>...............................................................................<br>\n" +
                  "					...................................................................................................</th>\n" +
                  "			</td>\n" +
                  "		</tr>\n" +
                  "	</div>\n" +
                  "</div>\n" +
                  "<br>\n" +
                  "<p><b>N.B : </b>0 a 39 <i>\"cours a reprendre\"</i> 40 a 60 <i>\"examen a reprendre\" </i>65 a 100 <i>\"cour Reussi\"</i></p>\n" +
                  "</page></body>\n" +
                  "</html>";


          String Html = Head + Head2 + Head3 + Head4 + Tbody + Footer1 + Footer2;
          return Html;
      }
    }
}

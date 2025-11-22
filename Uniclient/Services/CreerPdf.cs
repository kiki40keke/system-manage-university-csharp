using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel;
using System.IO;
using iText.Html2pdf;


namespace Services
{
    public class CreerPdf
    {
        public string createPdf(string html, string dest)
        {
            string mes = "";

            // Specify the directory you want to manipulate.
            string path = @".\Intense";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    mes = "That path exists already.";
                    Console.WriteLine("That path exists already.");
                     string des =path+ "\\" + dest + ".pdf";
                    mes = creerfichier(des, html);
                    //return;
                }
                else
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
                    mes = "The directory was created successfully at {0}." + Directory.GetCreationTime(path);
                    string des = path + "\\" + dest + ".pdf";
                 mes=   creerfichier(des, html);
                }
                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                mes= "The process failed: {0}"+ e.ToString();
            }
            finally { }
            // string des = "/" + dest + ".pdf";
            //// string Images = Server.MapPath("~/Image/");

           
            
            return mes;
        }

        public string creerfichier(string des,string html) {
            string mes = "";
            int b = 0;
            try
            {
                HtmlConverter.ConvertToPdf(html, new FileStream(des, FileMode.Create));
                mes = "Fichier creer" + des;
                b = 1;

            }
            catch (Exception ex)
            {
                mes = ex.ToString();
                b = 0;
            }

            if (b == 1)

                try
                {
                    // return "li kreye" + dest;
                    System.Diagnostics.Process.Start(des);

                }
                catch (Exception ff)
                {
                    mes = ff.ToString() + des;
                }

            return mes;
        }

    }
}

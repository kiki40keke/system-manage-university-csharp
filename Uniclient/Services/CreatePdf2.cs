using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iText.Kernel.Events;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Services
{
    public class CreatePdf2
    {


        private class PageOrientationsEventHandler : IEventHandler
        {
            private PdfNumber orientation ;

            public void SetOrientation(PdfNumber orientation)
            {
                this.orientation = orientation;
            }

            public void HandleEvent(Event currentEvent)
            {
                PdfDocumentEvent docEvent = (PdfDocumentEvent)currentEvent;
                docEvent.GetPage().Put(PdfName.Rotate, orientation);
            }
        }
    }
}

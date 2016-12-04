using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FeedBackSystem
{
    class PDFfooter : PdfPageEventHelper
    {
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfContentByte cb = writer.DirectContent;
            ColumnText ct = new ColumnText(cb);
            cb.SetColorFill(new BaseColor(Color.Gray));
            cb.BeginText();
            cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED), 5.0f);
            cb.SetTextMatrix(document.BottomMargin, document.BottomMargin);
            cb.ShowText("This is a computer generated printout and no signature is required.");
            cb.EndText();
        }
    }
}

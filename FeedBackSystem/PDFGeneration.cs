using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using iTextSharp.tool.xml;
using Image = iTextSharp.text.Image;

namespace FeedBackSystem
{
    class PDFGeneration
    {
        public static byte[] Generate(Feedback feedback)
        {

            Feedback feed = feedback;

            string htmlString = @"<HTML><TABLE width=""100%"" style=""font-size:80%;""><TR>";

            int counter = 0;

            foreach (HeaderItem item in feed.Header.HeaderItems)
            {
                htmlString += @"<TD style=""white-space: nowrap;padding: 2% 0"">" + item.Title.TrimEnd(':') + "</TD>";
                htmlString += @"<TD style=""white-space: nowrap;padding: 2% 0"">:" + item.ValueChosen + "</TD>";

                counter++;

                if (counter != 3) continue;
                htmlString += @"</TR><TR>";
                counter = 0;
            }

            htmlString += "</TR></TABLE><BR></BR>";

            htmlString += "</HTML>";
            using (MemoryStream stream = new MemoryStream())
            {
                try
                {

                    Document document = new Document();


                    PdfWriter writer = PdfWriter.GetInstance(document, stream);
                    writer.PageEvent = new PDFfooter();

                    document.Open();

                    Image logo = Image.GetInstance("logo.png");
                    logo.Alignment = Element.ALIGN_LEFT;
                    logo.ScalePercent(24f);
                    document.Add(logo);

                    Chunk linebreak =
                        new Chunk(new LineSeparator(1f, 100f, new BaseColor(Color.Black), Element.ALIGN_CENTER, -1));

                    document.Add(new Paragraph(linebreak));

                    document.Add(Chunk.NEWLINE);

                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, new StringReader(htmlString));

                    document.Add(Chunk.NEWLINE);
                    Chunk glue = new Chunk(new VerticalPositionMark());

                    foreach (Section s in feed.Sections)
                    {
                        if (s.IsChecked)
                        {
                            document.Add(new Phrase("Section Title : " + s.Title));
                            document.Add(new Chunk(glue));
                            document.Add(new Phrase("Code Given : " + s.CodeChosen));
                            document.Add(Chunk.NEWLINE);
                            document.Add(new Phrase(s.Comment));
                            document.Add(Chunk.NEWLINE);
                            document.Add(Chunk.NEWLINE);
                        }
                    }

                    document.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                return stream.ToArray();
            }

        }
    }
}

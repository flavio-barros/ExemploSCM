using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ExemploSCM.Dao;
using ExemploSCM.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ExemploSCM.Controllers
{
    public class GerarPDFController : Controller
    {
        IRepository<Entrada> entradaRepository = new EntradaRepository<Entrada>();
        // GET: GerarPDF
        public ActionResult Index()
        {
            /*MemoryStream memoryStream = new MemoryStream();
            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 15);
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, memoryStream);
            pdfDoc.Open();

            //Cabeçalho
            Paragraph paragraph = new Paragraph(new Chunk("MStarSupply", FontFactory.GetFont("Arial", 20)));
            pdfDoc.Add(paragraph);

            paragraph = new Paragraph(
                new Chunk("Sistema de Gerenciamento de Cadeia de Suprimentos", FontFactory.GetFont("Arial", 11, Font.ITALIC)));
            pdfDoc.Add(paragraph);

            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            pdfDoc.Add(line);

            paragraph = new Paragraph(
                new Chunk("Mês de referência: Abril/2019", FontFactory.GetFont("Arial", 14, Font.ITALIC)));
            pdfDoc.Add(paragraph);

            line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            pdfDoc.Add(line);

            paragraph = new Paragraph(
                new Chunk("Entradas", FontFactory.GetFont("Arial", 13, Font.ITALIC)));
            pdfDoc.Add(paragraph);

            //Table
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;
            //0=Left, 1=Centre, 2=Right
            table.HorizontalAlignment = 0;
            table.SpacingBefore = 20f;
            table.SpacingAfter = 30f;

            //Cell no 1
            PdfPCell cell = new PdfPCell();
            cell.Border = 0;

            //Cell no 2
            Chunk chunk = new Chunk("Name: Mrs. Salma Mukherji,\nAddress: Latham Village, Latham, New York, US, \nOccupation: Nurse, \nAge: 35 years", FontFactory.GetFont("Arial", 15, Font.NORMAL, BaseColor.PINK));
            cell = new PdfPCell();
            cell.Border = 0;
            cell.AddElement(chunk);
            table.AddCell(cell);

            //Add table to document
            pdfDoc.Add(table);

            //Table
            table = new PdfPTable(5);
            table.WidthPercentage = 100;
            table.HorizontalAlignment = 0;
            table.SpacingBefore = 20f;
            table.SpacingAfter = 30f;

            cell = new PdfPCell();
            chunk = new Chunk("Mercadoria");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Quantidade");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Data");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Hora");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Local");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            foreach (Entrada e in entradaRepository.Listar())
            {
                table.AddCell(e.Mercadoria.Nome);
                table.AddCell(Convert.ToString(e.Quantidade));
                table.AddCell(e.Data.ToString("dd-MM-yyyy"));
                table.AddCell(e.Hora.ToString("HH:mm"));
                table.AddCell(e.Local);
            }

            pdfDoc.Add(table);

            line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            pdfDoc.Add(line);

            paragraph = new Paragraph(
                new Chunk("Saídas", FontFactory.GetFont("Arial", 13, Font.ITALIC)));
            pdfDoc.Add(paragraph);

            //Table
            table = new PdfPTable(5);
            table.WidthPercentage = 100;
            table.HorizontalAlignment = 0;
            table.SpacingBefore = 20f;
            table.SpacingAfter = 30f;

            cell = new PdfPCell();
            chunk = new Chunk("Mercadoria");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Quantidade");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Data");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Hora");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            cell = new PdfPCell();
            chunk = new Chunk("Local");
            cell.AddElement(chunk);
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(cell);

            foreach (Saida e in getSaidas())
            {
                table.AddCell(e.Mercadoria.Nome);
                table.AddCell(Convert.ToString(e.Quantidade));
                table.AddCell(e.Data.ToString("dd-MM-yyyy"));
                table.AddCell(e.Hora.ToString("HH:mm"));
                table.AddCell(e.Local);
            }

            pdfDoc.Add(table);

            pdfWriter.CloseStream = false;
            pdfDoc.Close();
            //Response.
            Response.ContentType = "application/pdf";
            //Response.AddHeader("content-disposition", "attachment;filename=Relatorio.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Write(pdfDoc);
            Response.End();*/

            return View();
        }
    }
}
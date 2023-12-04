function add(a, b) {
  return a + b;
}

// Get reference to the div where you want to load the PDF
var pdfContainer = document.getElementById("pdf-container");

// URL of the PDF file
var pdfUrl =
  "C:\\Development\\DotNet\\PDFViewer\\PDFViewer\\PDFs\\Lagrange.pdf"; // Replace with the actual path to your PDF file

// Use PDF.js to load and render the PDF
pdfjsLib
  .getDocument(pdfUrl)
  .promise.then(function (pdfDoc) {
    alert("Load");

    // Loop through each page in the PDF
    for (var pageNum = 1; pageNum <= pdfDoc.numPages; pageNum++) {
      // Render the page
      pdfDoc.getPage(pageNum).then(function (page) {
        var canvas = document.createElement("canvas");
        pdfContainer.appendChild(canvas);

        var context = canvas.getContext("2d");
        var viewport = page.getViewport({ scale: 1.5 }); // You can adjust the scale as needed

        canvas.height = viewport.height;
        canvas.width = viewport.width;

        var renderTask = page.render({
          canvasContext: context,
          viewport: viewport,
        });

        renderTask.promise.then(function () {
          // Page has been rendered
          console.log("Page rendered successfully");
        });
      });
    }
  })
  .catch(function (error) {
    // Handle any errors that occurred while loading the PDF
    console.error("Error loading PDF:", error);
  });


function formValidation() {
    var CoverImage = document.getElementById('CoverPhoto');
    var galleryImage = document.getElementById('GalleryPhoto');
    var BookPdf = document.getElementById('BookPdf');
    var coverImagePath = CoverImage.value;
    var galleryImagePath = galleryImage.value;
    var bookPDFPath = BookPdf.value;
    var allowedImageExtensions = /(\.jpg|\.jpeg|\.png|\.gif)$/i;
    var allowedPDFExtensions = /(\.pdf)$/i;
    // allowing file type
    if (CoverImage.files.length > 0) {
        if (!allowedImageExtensions.exec(coverImagePath)) {
            alert('Allow only image for Cover Image!');
            fileInput.value = '';
            return false;
        }
    }
    if (galleryImage.files.length > 0) {
        if (galleryImage.files.length >= 2 && galleryImage.files.length <= 5) {
            if (!allowedImageExtensions.exec(galleryImagePath)) {
                alert('Allow only image for Gallery Image!');
                fileInput.value = '';
                return false;
            }
        }
        else {
            alert('Please choose 2 to 5 Gallery Image!'); 
            fileInput.value = '';
            return false;
        }
    }
    if (BookPdf.files.length > 0) {
        if (!allowedPDFExtensions.exec(bookPDFPath)) {
            alert('Allow only PDF for Book!');
            fileInput.value = '';
            return false;
        }
    }
}


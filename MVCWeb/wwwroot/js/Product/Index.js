

    //document.addEventListener('DOMContentLoaded', function () {
    //var editModal = document.getElementById('editModal');
    //var deleteModal = document.getElementById('deleteModal');

    //editModal.addEventListener('show.bs.modal', function (event) {
    //            var button = event.relatedTarget;
    //var id = button.getAttribute('data-id');
    //var name = button.getAttribute('data-name');
    //var description = button.getAttribute('data-description');
    //var createdBy = button.getAttribute('data-createdby');

    //var modal = bootstrap.Modal.getInstance(editModal);
    //modal.querySelector('#editId').value = id;
    //modal.querySelector('#editProductName').value = name;
    //modal.querySelector('#editProductDescription').value = description;
    //modal.querySelector('#editCreatedBy').value = createdBy;
    //        });

    //deleteModal.addEventListener('show.bs.modal', function (event) {
    //            var button = event.relatedTarget;
    //var id = button.getAttribute('data-id');
    //var name = button.getAttribute('data-name');

    //var modal = bootstrap.Modal.getInstance(deleteModal);
    //modal.querySelector('#deleteId').value = id;
    //modal.querySelector('#deleteProductName').innerText = name;
    //modal.querySelector('#deleteForm').action = '@Url.Action("Delete", "Products")/' + id;
    //        });
    //    });

            //// Create form submission
            // Use Razor to generate the correct URL at runtime
            // Generate the URL using Razor
function submitProduct() {
    alert("event called");
    //const createUrl = '/Products/Create'; // Generate URL at runtime

    //const productName = $('#productName').val();
    //const productDescription = $('#productDescription').val();
    //const createdBy = $('#createdBy').val();

    //$.ajax({
    //    url: createUrl,
    //    type: 'POST',
    //    contentType: 'application/json',
    //    data: JSON.stringify({
    //        productName: productName,
    //        productDescription: productDescription,
    //        createdBy: createdBy
    //    }),
    //    success: function (response) {
    //        // If the request is successful, close the modal and refresh the page
    //        $('#createModal').modal('hide');
    //        location.reload(); // Refresh the page to show the new product
    //    },
    //    error: function (xhr, status, error) {
    //        // Handle errors here
    //        console.error('Failed to create product:', error);
    //    }
    //});
}
    //// Edit form submission
    //document.getElementById('editForm').addEventListener('submit', function (event) {
    //    event.preventDefault();
    //var id = document.getElementById('editId').value;
    //var productName = document.getElementById('editProductName').value;
    //var productDescription = document.getElementById('editProductDescription').value;
    //var createdBy = document.getElementById('editCreatedBy').value;

    //fetch('@Url.Action("Edit", "Products")', {
    //    method: 'POST',
    //headers: {
    //    'Content-Type': 'application/json'
    //            },
    //body: JSON.stringify({
    //    Id: id,
    //ProductName: productName,
    //ProductDescription: productDescription,
    //CreatedBy: createdBy
    //            })
    //        }).then(response => {
    //            if (response.ok) {
    //    location.reload(); // Refresh the page to show the updated product
    //            }
    //        });
    //    });

    //// Delete form submission
    //document.getElementById('deleteForm').addEventListener('submit', function (event) {
    //    event.preventDefault();
    //var id = document.getElementById('deleteId').value;

    //fetch('@Url.Action("Delete", "Products")', {
    //    method: 'POST',
    //headers: {
    //    'Content-Type': 'application/json'
    //            },
    //body: JSON.stringify({Id: id })
    //        }).then(response => {
    //            if (response.ok) {
    //    location.reload(); // Refresh the page to remove the deleted product
    //            }
    //        });
    //    });

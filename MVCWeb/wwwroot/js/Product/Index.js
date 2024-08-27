
alert("file called");
    document.addEventListener('DOMContentLoaded', function () {
    var editModal = document.getElementById('editModal');
    var deleteModal = document.getElementById('deleteModal');

    editModal.addEventListener('show.bs.modal', function (event) {
                var button = event.relatedTarget;
    var id = button.getAttribute('data-id');
    var name = button.getAttribute('data-name');
    var description = button.getAttribute('data-description');
    var createdBy = button.getAttribute('data-createdby');

    var modal = bootstrap.Modal.getInstance(editModal);
    modal.querySelector('#editId').value = id;
    modal.querySelector('#editProductName').value = name;
    modal.querySelector('#editProductDescription').value = description;
    modal.querySelector('#editCreatedBy').value = createdBy;
            });

    deleteModal.addEventListener('show.bs.modal', function (event) {
                var button = event.relatedTarget;
    var id = button.getAttribute('data-id');
    var name = button.getAttribute('data-name');

    var modal = bootstrap.Modal.getInstance(deleteModal);
    modal.querySelector('#deleteId').value = id;
    modal.querySelector('#deleteProductName').innerText = name;
    modal.querySelector('#deleteForm').action = '@Url.Action("Delete", "Products")/' + id;
            });
        });

    // Create form submission
    document.getElementById('createForm').addEventListener('submit', function (event) {
        event.preventDefault();
    var productName = document.getElementById('createProductName').value;
    var productDescription = document.getElementById('createProductDescription').value;
    var createdBy = document.getElementById('createCreatedBy').value;

    fetch('@Url.Action("Create", "Products")', {
        method: 'POST',
    headers: {
        'Content-Type': 'application/json'
                },
    body: JSON.stringify({
        ProductName: productName,
    ProductDescription: productDescription,
    CreatedBy: createdBy
                })
            }).then(response => {
                if (response.ok) {
        location.reload(); // Refresh the page to show the new product
                }
            });
        });

    // Edit form submission
    document.getElementById('editForm').addEventListener('submit', function (event) {
        event.preventDefault();
    var id = document.getElementById('editId').value;
    var productName = document.getElementById('editProductName').value;
    var productDescription = document.getElementById('editProductDescription').value;
    var createdBy = document.getElementById('editCreatedBy').value;

    fetch('@Url.Action("Edit", "Products")', {
        method: 'POST',
    headers: {
        'Content-Type': 'application/json'
                },
    body: JSON.stringify({
        Id: id,
    ProductName: productName,
    ProductDescription: productDescription,
    CreatedBy: createdBy
                })
            }).then(response => {
                if (response.ok) {
        location.reload(); // Refresh the page to show the updated product
                }
            });
        });

    // Delete form submission
    document.getElementById('deleteForm').addEventListener('submit', function (event) {
        event.preventDefault();
    var id = document.getElementById('deleteId').value;

    fetch('@Url.Action("Delete", "Products")', {
        method: 'POST',
    headers: {
        'Content-Type': 'application/json'
                },
    body: JSON.stringify({Id: id })
            }).then(response => {
                if (response.ok) {
        location.reload(); // Refresh the page to remove the deleted product
                }
            });
        });

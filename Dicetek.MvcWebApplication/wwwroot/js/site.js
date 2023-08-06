// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$(document).ready(function () {

    showInPopup = (url, title) => {
        $.ajax({
            type: 'GET',
            url: url,
            success: function (res) {
                $('#form-modal .modal-body').html(res);
                $('#form-modal .modal-title').html(title);
                $('#form-modal').modal('show');

                $("input[name='creditCard']").inputmask("9999-9999-9999-9999");

                $("#ccExpiryDate").datepicker({
                    format: 'mm/yy',
                    autoHide: true,
                    startView: 2,
                }).on('change', function () {
                    $('.datepicker').hide();
                    $(this).valid();
                });

                $("input[name*='ccExpiryDate']")
                    .on("click", function (e) {
                        $("div.datepicker-days").css({ "display": "block" });
                    });
            }
        })
    }

    jQueryAjaxPost = form => {
        try {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (res) {
                    if (res.isValid) {
                        $('#view-all').html(res.html)
                        $('#form-modal .modal-body').html('');
                        $('#form-modal .modal-title').html('');
                        $('#form-modal').modal('hide');
                    }
                    else
                        $('#form-modal .modal-body').html(res.html);
                },
                error: function (err) {
                    console.log(err)
                }
            })
            //to prevent default form submit event
            return false;
        } catch (ex) {
            console.log(ex)
        }
    }


});

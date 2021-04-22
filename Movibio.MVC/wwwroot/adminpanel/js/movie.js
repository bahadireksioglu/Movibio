$(document).ready(function () {
    //$('#js-example-basic-hide-search-multi').select2();

    //$('#js-example-basic-hide-search-multi').on('select2:opening select2:closing', function (event) {
    //    var $searchfield = $(this).parent().find('.select2-search__field');
    //    $searchfield.prop('disabled', true);
    //});

    $(function () {
        const url = '/Admin/Movie/Insert/';
        const placeHolderDiv = $('#modal-placeholder');

        $('#btn-new-movie').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            })
        });

        placeHolderDiv.on('click', '#btn-movie-insert', function (event) {
            event.preventDefault();
            const form = $('#form-movie-insert');
            const actionUrl = form.attr('action');
            const dataToSend = new FormData(form.get(0));
            $.ajax({
                url: actionUrl,
                type: 'POST',
                data: dataToSend,
                processData: false,
                contentType: false,
                success: function (data) {
                    if (data == 0) {
                        Swal.fire({
                            position: 'top-end',
                            icon: 'success',
                            title: 'İşlem Başarılı',
                            showConfirmButton: false,
                            timer: 1000
                        }).then(() => {
                            window.location = '/Admin/Movie/Index/';
                        });
                    }

                    else {
                        Swal.fire({
                            position: 'top-end',
                            icon: 'error',
                            title: 'İşlem Başarısız',
                            text: 'Lütfen tekrar deneyin.',
                            showConfirmButton: false,
                            timer: 1000
                        }).then(() => {
                            window.location = '/Admin/Movie/Index/';
                        });
                    }
                },
                error: function (err) {

                }
            });
        });

        placeHolderDiv.on('click', '#btn-cancel', function (event) {
            placeHolderDiv.find(".modal").modal('hide');
        });
    });

    //$(function () {

    //    const url = '/Admin/Cast/Update/';
    //    const placeHolderDiv = $('#modal-placeholder');

    //    $(document).on('click', '#btn-edit-cast', function () {
    //        const castId = $(this).attr('data-id');
    //        $.ajax({
    //            url: url,
    //            type: 'GET',
    //            data: { castId: castId },
    //            success: function (data) {
    //                placeHolderDiv.html(data);
    //                placeHolderDiv.find(".modal").modal('show');
    //            }
    //        });

    //    });

    //    placeHolderDiv.on('click', '#btn-cast-update', function (event) {
    //        event.preventDefault();
    //        const form = $('#form-cast-edit');
    //        const actionUrl = form.attr('action');
    //        const dataToSend = new FormData(form.get(0));
    //        $.ajax({
    //            url: actionUrl,
    //            type: 'POST',
    //            data: dataToSend,
    //            processData: false,
    //            contentType: false,
    //            success: function (data) {
    //                if (data == 0) {
    //                    Swal.fire({
    //                        position: 'top-end',
    //                        icon: 'success',
    //                        title: 'İşlem Başarılı',
    //                        showConfirmButton: false,
    //                        timer: 1000
    //                    }).then(() => {
    //                        window.location = '/Admin/Cast/Index/';
    //                    });
    //                }

    //                else {
    //                    Swal.fire({
    //                        position: 'top-end',
    //                        icon: 'error',
    //                        title: 'İşlem Başarısız',
    //                        text: 'Lütfen tekrar deneyin.',
    //                        showConfirmButton: false,
    //                        timer: 1000
    //                    }).then(() => {
    //                        window.location = '/Admin/Cast/Index/';
    //                    });
    //                }
    //            },
    //            error: function (err) {

    //            }
    //        });
    //    });
    //});

    //$(function () {
    //    const url = '/Admin/Cast/Delete/';
    //    $(document).on('click', '#btn-delete-cast', function () {
    //        const castId = $(this).attr('data-id');
    //        Swal.fire({
    //            title: 'Silmek istediğinize emin misiniz?',
    //            icon: 'warning',
    //            showCancelButton: true,
    //            confirmButtonColor: '#3085d6',
    //            cancelButtonColor: '#d33',
    //            confirmButtonText: 'Evet',
    //            cancelButtonText: 'Hayır',
    //        }).then((result) => {
    //            if (result.isConfirmed) {
    //                $.ajax({
    //                    url: url,
    //                    type: 'POST',
    //                    data: { castId: castId },
    //                    success: function (data) {
    //                        if (data == 0) {
    //                            Swal.fire({
    //                                position: 'top-end',
    //                                icon: 'success',
    //                                title: 'İşlem Başarılı',
    //                                showConfirmButton: false,
    //                                timer: 1000
    //                            }).then(() => {
    //                                window.location = '/Admin/Cast/Index/';
    //                            });
    //                        }

    //                        else {
    //                            Swal.fire({
    //                                position: 'top-end',
    //                                icon: 'error',
    //                                title: 'İşlem Başarısız',
    //                                text: 'Lütfen tekrar deneyin.',
    //                                showConfirmButton: false,
    //                                timer: 1000
    //                            }).then(() => {
    //                                window.location = '/Admin/Cast/Index/';
    //                            });
    //                        }
    //                    }
    //                });
    //            }
    //        });
    //    });
    //});
});
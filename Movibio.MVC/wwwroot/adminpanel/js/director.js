$(document).ready(function () {
    $(function () {
        const url = '/Admin/Director/Insert/';
        const placeHolderDiv = $('#modal-placeholder');

        $('#btn-new-director').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            })
        });

        placeHolderDiv.on('click', '#btn-director-insert', function (event) {
            event.preventDefault();
            const form = $('#form-director-insert');
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
                            window.location = '/Admin/Director/Index/';
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
                            window.location = '/Admin/Director/Index/';
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

    $(function () {

        const url = '/Admin/Director/Update/';
        const placeHolderDiv = $('#modal-placeholder');

        $(document).on('click', '#btn-edit-director', function () {
            const directorId = $(this).attr('data-id');
            $.ajax({
                url: url,
                type: 'GET',
                data: { directorId: directorId },
                success: function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find(".modal").modal('show');
                }
            });

        });

        placeHolderDiv.on('click', '#btn-director-update', function (event) {
            event.preventDefault();
            const form = $('#form-director-edit');
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
                            window.location = '/Admin/Director/Index/';
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
                            window.location = '/Admin/Director/Index/';
                        });
                    }
                },
                error: function (err) {

                }
            });
        });
    });

    $(function () {
        const url = '/Admin/Director/Delete/';
        $(document).on('click', '#btn-delete-director', function () {
            const directorId = $(this).attr('data-id');
            Swal.fire({
                title: 'Silmek istediğinize emin misiniz?',
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet',
                cancelButtonText: 'Hayır',
            }).then((result) => {
                if (result.isConfirmed) {
                    $.ajax({
                        url: url,
                        type: 'POST',
                        data: { directorId: directorId },
                        success: function (data) {
                            if (data == 0) {
                                Swal.fire({
                                    position: 'top-end',
                                    icon: 'success',
                                    title: 'İşlem Başarılı',
                                    showConfirmButton: false,
                                    timer: 1000
                                }).then(() => {
                                    window.location = '/Admin/Director/Index/';
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
                                    window.location = '/Admin/Director/Index/';
                                });
                            }
                        }
                    });
                }
            });
        });
    });
});
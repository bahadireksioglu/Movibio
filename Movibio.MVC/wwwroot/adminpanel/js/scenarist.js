$(document).ready(function () {
    $(function () {
        const url = '/Admin/Scenarist/Insert/';
        const placeHolderDiv = $('#modal-placeholder');

        $('#btn-new-scenarist').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            })
        });

        placeHolderDiv.on('click', '#btn-scenarist-insert', function (event) {
            event.preventDefault();
            const form = $('#form-scenarist-insert');
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
                            window.location = '/Admin/Scenarist/Index/';
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
                            window.location = '/Admin/Scenarist/Index/';
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

        const url = '/Admin/Scenarist/Update/';
        const placeHolderDiv = $('#modal-placeholder');

        $(document).on('click', '#btn-edit-scenarist', function () {
            const scenaristId = $(this).attr('data-id');
            $.ajax({
                url: url,
                type: 'GET',
                data: { scenaristId: scenaristId },
                success: function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find(".modal").modal('show');
                }
            });

        });

        placeHolderDiv.on('click', '#btn-scenarist-update', function (event) {
            event.preventDefault();
            const form = $('#form-scenarist-edit');
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
                            window.location = '/Admin/Scenarist/Index/';
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
                            window.location = '/Admin/Scenarist/Index/';
                        });
                    }
                },
                error: function (err) {

                }
            });
        });
    });

    $(function () {
        const url = '/Admin/Scenarist/Delete/';
        $(document).on('click', '#btn-delete-scenarist', function () {
            const scenaristId = $(this).attr('data-id');
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
                        data: { scenaristId: scenaristId },
                        success: function (data) {
                            if (data == 0) {
                                Swal.fire({
                                    position: 'top-end',
                                    icon: 'success',
                                    title: 'İşlem Başarılı',
                                    showConfirmButton: false,
                                    timer: 1000
                                }).then(() => {
                                    window.location = '/Admin/Scenarist/Index/';
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
                                    window.location = '/Admin/Scenarist/Index/';
                                });
                            }
                        }
                    });
                }
            });
        });
    });
});
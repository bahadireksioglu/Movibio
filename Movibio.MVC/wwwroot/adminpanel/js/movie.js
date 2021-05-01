$(document).ready(function () {


    $(function () {

        $('#movie-insert-btn').click(function () {
            //const form = $('#form-movie-insert');
            //const actionUrl = form.attr('action');
            //console.log($('#select-casts').val());
            //const dataToSend = new FormData(form.get(0));
            //console.log(dataToSend);

            var files = $('#formFile')[0].files[0];
            //var multiFiles = $('#formFileMultiple')[0].files;
            console.log(files);
            var formData = new FormData();

            

            var Name = $('#film-name').val();
            var ReleaseDate = $('#film-release-date').val();
            var Subject = $('#film-subject').val();
            var Casts = $('#select-casts').val();
            var Scenarists = $('#select-scenarists').val();
            var Directors = $('#select-directors').val();
            var Genres = $('#select-genres').val();
            var Languages = $('#select-language').val();
            
            formData.append("Name", Name);
            formData.append("ReleaseDate", ReleaseDate);
            formData.append("Subject", Subject);

            for (var i = 0; i < Casts.length; i++) {

                formData.append("Casts", Casts[i]);
            }
            for (var i = 0; i < Scenarists.length; i++) {

                formData.append("Scenarists", Scenarists[i]);
            }
            for (var i = 0; i < Directors.length; i++) {

                formData.append("Directors", Directors[i]);
            }
            for (var i = 0; i < Genres.length; i++) {

                formData.append("Genres", Genres[i]);
            }
            for (var i = 0; i < Languages.length; i++) {

                formData.append("Languages", Languages[i]);
            }
            
            formData.append("Poster", files);

            //for (var i = 0; i < multiFiles.length; i++) {

            //    formData.append("PictureFiles", multiFiles[i]);
            //}
            
            $.ajax({
                url: '/Admin/Movie/Insert',
                type: 'POST',
                data: formData,
                processData: false,
                contentType: false,
                /*data: {movieInsertDto:movieInsertDto},*/
                success: function (data) {

                }
            });
        });
        
        //const url = '/Admin/Movie/Insert/';
        //const placeHolderDiv = $('#modal-placeholder');

        //$('#btn-new-movie').click(function () {
        //    $.get(url).done(function (data) {
        //        placeHolderDiv.html(data);
        //        placeHolderDiv.find(".modal").modal('show');
        //    })
        //});

        //placeHolderDiv.on('click', '#btn-movie-insert', function (event) {
        //    event.preventDefault();
        //    const form = $('#form-movie-insert');
        //    const actionUrl = form.attr('action');
        //    const dataToSend = new FormData(form.get(0));
        //    $.ajax({
        //        url: actionUrl,
        //        type: 'POST',
        //        data: dataToSend,
        //        processData: false,
        //        contentType: false,
        //        success: function (data) {
        //            if (data == 0) {
        //                Swal.fire({
        //                    position: 'top-end',
        //                    icon: 'success',
        //                    title: 'İşlem Başarılı',
        //                    showConfirmButton: false,
        //                    timer: 1000
        //                }).then(() => {
        //                    window.location = '/Admin/Movie/Index/';
        //                });
        //            }

        //            else {
        //                Swal.fire({
        //                    position: 'top-end',
        //                    icon: 'error',
        //                    title: 'İşlem Başarısız',
        //                    text: 'Lütfen tekrar deneyin.',
        //                    showConfirmButton: false,
        //                    timer: 1000
        //                }).then(() => {
        //                    window.location = '/Admin/Movie/Index/';
        //                });
        //            }
        //        },
        //        error: function (err) {

        //        }
        //    });
        //});

        //placeHolderDiv.on('click', '#btn-cancel', function (event) {
        //    placeHolderDiv.find(".modal").modal('hide');
        //});
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
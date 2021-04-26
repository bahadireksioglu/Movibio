$(document).ready(function(){
    $(window).scroll(function(){
        if(this.scrollY>20){
            $('.navbar').addClass("sticky");
        }
        else{
            $('.navbar').removeClass("sticky");
        }

        if(this.scrollY>500){
            $('.scroll-up-btn').addClass("show");
        }
        else{
            $('.scroll-up-btn').removeClass("show");
        }
    });

    $('.scroll-up-btn').click(function(){
        $('html').animate({scrollTop: 0});
    });


    $('.menu-btn').click(function(){
        $('.navbar .menu').toggleClass("active");
        $('.menu-btn #ham').toggleClass("active");
    });

    $('.home .carousel').owlCarousel({
        margin:20,
        loop:false,
        autoplayTimeOut: 2000, 
        autoplayHoverPause: true,
        responsive:{
            0:{
                items:1,
                nav:false
            },
            640:{
                items:2,
                nav:false
            },
            960:{
                items:3,
                nav:false
            },
            1280:{
                items:4,
                nav:false
            }            
        }
    })

    $('.team .carousel').owlCarousel({
        margin:15,
        loop:false,
        autoplayTimeOut: 2000, 
        autoplayHoverPause: true,
        responsive:{
            0:{
                items:1,
                nav:false
            },
            425:{
                items:2,
                nav:false
            },
            640:{
                items:3,
                nav:false
            },
            980:{
                items:4,
                nav:false
            },
            1160:{
                items:5,
                nav:false
            },
            1280:{
                items:6,
                nav:false
            }            
        }
    })
});
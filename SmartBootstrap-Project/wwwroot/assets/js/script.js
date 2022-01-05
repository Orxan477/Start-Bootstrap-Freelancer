let header = document.querySelector("#nav");
window.addEventListener('scroll', function () {
    if (scrollY >0) {
        header.classList.remove("navres");
        header.classList.add("navres1");
    }else{
        header.classList.remove("navres1");
        header.classList.add("navres");
    }
})

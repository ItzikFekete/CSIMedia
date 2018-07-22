console.log('test');
//var listOrder = $('.listOrder').get().map(function (el) { return el.value });

/*$('.ascending').click(function () {
    document.querySelector('.ascendingDisplay').innerHTML(listOrder.sort);
});
$('.descending').click(function () {
    document.querySelector('.descendingDisplay').innerHTML(listOrder.reverse);
});*/ 

$(function () {
    var $clone = $('.indexA, indexAInput').clone();
    $('.clonedA').html($clone).text; 
});


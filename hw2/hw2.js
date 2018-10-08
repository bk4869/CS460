
function ipType(ipF, ipS){
    'use strict'
    if(ipF == 192 && ipS == 168) {
        return 'Class C Private IP';
    }else if(ipF == 172 && ipS == 16){
        return 'Class B Private IP';
    }else if(ipF == 10){
        return 'Class A Private IP';
    }else if(ipF == 127){
        return 'Loop Address';     
    }else if(ipF == null){
        return 'Null';
    }else {
        return ipF;
    }
}

function maskToBits

$('div').submit(function (event) {
    event.preventDefault();
    var ipp1 = $('#ip1').val().trim();
    var ipp2 = $('#ip2').val().trim();
    var result = ipType(ipp1,ipp2);

    var p = document.getElementById('resultReturn');
    p.innerHTML = result;
});

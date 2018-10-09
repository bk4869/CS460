
/**
 * Verify IP Type(Public/Private)
 * @param {*} ipF 1st 8bits
 * @param {*} ipS 2nd 8bits
 */
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

/**
 * Return the number of available address.
 * @param {*} mask Network Mask
 */
function addCalc(mask){
        return Math.pow(2,32-mask);
}

var minIP = undefined;
var maxIP = undefined;
var network = undefined;
/**
 * Ip Range based on subnet mask.
 * @param {*} ip1 1st 8bits
 * @param {*} ip2 2nd 8bits 
 * @param {*} ip3 3rd 8bits
 * @param {*} ip4 4th 8bits
 * @param {*} mask Net Mask Bits
 */
function ipRange(ip1,ip2,ip3,ip4,mask){
    var maxCount = 0;
    var avaAddr = addCalc(mask);
    
     if(mask>=24){
        var i;
        for(i = 0; i < 256; i = i + avaAddr)
        {
            if(ip4 < i){
                minIP = ip1+'.'+ip2+'.'+ip3+'.'+(avaAddr-1);
                maxIP = ip1+'.'+ip2+'.'+ip3+'.'+i; 
            }else if(ip4 == i){
                minIP = ip1+'.'+ip2+'.'+ip3+'.'+i;
                maxIP = ip1+'.'+ip2+'.'+ip3+'.'+(i+avaAddr-1);
            }
        }
     }else{
        var ipArray = [ip1,ip2,ip3,ip4]; 
        if(mask<=8){
            network = ip1+'.'+
        }

     }
    
}



$('div').submit(function (event) {
    event.preventDefault();
    //get the ip address  and mask from text
    var ipp1 = $('#ip1').val().trim();
    var ipp2 = $('#ip2').val().trim();
    var ipp3 = $('#ip3').val().trim();
    var ipp4 = $('#ip4').val().trim();
    var mask = $('#mask').val().trim();

    var result = ipType(ipp1,ipp2);
    var number = addCalc(mask);
    //var p = document.getElementById('resultReturn');
    $('#resultReturn').html(result+" "+number);
});

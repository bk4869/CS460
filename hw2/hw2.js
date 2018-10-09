

var minArr = [0,0,0,0];
var maxArr = [0,0,0,0];
var networkArr = [0,0,0,0];
var minIP = undefined;
var maxIP = undefined;
var network = undefined;

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


/**
 * Ip Range based on subnet mask.
 * @param {*} ip1 1st 8bits
 * @param {*} ip2 2nd 8bits 
 * @param {*} ip3 3rd 8bits
 * @param {*} ip4 4th 8bits
 * @param {*} mask Net Mask Bits
 */
function ipRange(ip1,ip2,ip3,ip4,mask){
    //var maxCount = 0;
    var avaAddr = addCalc(mask);
    if(mask===24){
        minIP = ip1+'.'+ip2+'.'+ip3+'.'+0;
        maxIP = ip1+'.'+ip2+'.'+ip3+'.'+255; 
        alert('test123');
    }else if(mask===16){
        minIP = ip1+'.'+ip2+'.'+0+'.'+0;
        maxIP = ip1+'.'+ip2+'.'+255+'.'+255; 
    }else if(ask===8){
        minIP = ip1+'.'+0+'.'+0+'.'+0;
        maxIP = ip1+'.'+255+'.'+255+'.'+255; 
    }else if(mask>24){
        var i;
        for(i = 0; i < 256; i = i + avaAddr)
        {
            minIP = 0;
            maxIP = 0; 

            if(ip4 < i){
                minIP = ip1+'.'+ip2+'.'+ip3+'.'+(i-avaAddr);
                maxIP = ip1+'.'+ip2+'.'+ip3+'.'+(avaAddr-1); 
                break;
            }else if(ip4 == i){
                minIP = ip1+'.'+ip2+'.'+ip3+'.'+i;
                maxIP = ip1+'.'+ip2+'.'+ip3+'.'+(i+avaAddr-1);
                break;
            }
        }
    }else{
        //To binary
        var ip1B = ip1.toString(2);
        var ip2B = ip2.toString(2);
        var ip3B = ip3.toString(2);
        var ip4B = ip4.toString(2);

        if(mask<=8){
           var change = 8-mask;
           minArr[0] = parseInt(binaryZero(ip1B,change),2);
           maxArr[0] = binaryOne(ip1B,change)
           maxArr[1] = 255;
           maxArr[2] = 255;
           maxArr[3] = 255;
        }else if(mask<=16){

        }

     }
    
}
/**
 * Change 1 to 0
 * @param {*} binary needs to change
 * @param {*} number of zero need for tail
 */
function binaryZero(binary,number){

    let zero = Math.pow(10,number);
    let resultBin = Math.floor(binary/zero) * zero;
    let result = parseInt(resultBin,2)  //To Dec

    return result;
 }

 /**
  * Change 0 to 1
  * return Dec
  */
 function binaryOne(binary,number){

    let zero = Math.pow(10,number);
    let resultBin = parseInt(Math.floor(binary/zero)*zero,2);
    let result = resultDec + Math.pow(2,number); 

    return result-1;
 }



$('div').submit(function (event) {
    event.preventDefault();
    //get the ip address  and mask from text
    var ipp1 = $('#ip1').val().trim();
    var ipp2 = $('#ip2').val().trim();
    var ipp3 = $('#ip3').val().trim();
    var ipp4 = $('#ip4').val().trim();
    var mask = $('#mask').val().trim();

    //var result = ipType(ipp1,ipp2);
    //var number = addCalc(mask);
    ipRange(ipp1,ipp2,ipp3,ipp4,mask);
    //var p = document.getElementById('resultReturn');
    var ansMax = minArr[0]+'.'+minArr[1]+'.'+minArr[2]+'.'+minArr[3];
    $("#resultReturn").empty();
    $('#resultReturn').html(minIP+' '+maxIP);
});

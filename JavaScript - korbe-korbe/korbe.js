var kep = document.querySelector('#ittakep');
const szelesseg = window.innerWidth;
const magassag = window.innerHeight;
var fel = 0;
var le = magassag / 100;
var bal = szelesseg / 100;
var jobb = szelesseg / 100;
var megyjobb = 0;
var megyle = 0;
console.log(magassag);
console.log(szelesseg);
kep.innerHTML = '<img id="kep1" src="kepek/teki.png" alt="" style="margin-left: 0px;"></img>';

function bal() {
    if (megyjobb > szelesseg - (jobb * 7) && megyle > magassag - (le * 16)) {
        kep.innerHTML = '<img id="kep1" src="kepek/teki.png" alt="" style="margin-left:' + x + 'px; margin-top:' + y + 'px;"></img>';
        x -= bal;
    }

}

function jobbra() {
    x = szelesseg - (jobb * 6);
    y = magassag - (le * 15);

    if (megyjobb < x) {
        kep.innerHTML = '<img id="kep1" src="kepek/teki.png" alt="" style="margin-left:' + megyjobb + 'px;"></img>';
        megyjobb += jobb;
    }
    else if (megyjobb > szelesseg - (jobb * 7) && megyle < y) {
        kep.innerHTML = '<img id="kep1" src="kepek/teki.png" alt="" style="margin-left:' + x + 'px; margin-top:' + megyle + 'px;"></img>';
        megyle += le;
    }


}

setInterval(jobbra, 10);









var kep = document.querySelector('#ittakep');
const szelesseg = window.innerWidth;
const magassag = window.innerHeight;
var felle = 0;
var jobbbal = 0;


var sheet = window.document.styleSheets[0];
kep.innerHTML = '<img id="kep1" src="kepek/teki.png" alt="" style="margin-left: 0px;"></img>';

function mozgat() {
    x = szelesseg;
    y = magassag;

    if (jobbbal < x -100) {
        jobbbal += 10;
        kep.innerHTML = '<img id="kep1" src="kepek/teki.png" alt="" style="margin-left:' + jobbbal + 'px;"></img>';

}
    console.log(jobbbal);
    if (jobbbal == 1820 && felle < y -100){
        kep.innerHTML = '<img id="kep1" src="kepek/teki.png" alt="" style="margin-left: 1820px; margin-top:'+felle+'px;"></img>';
        felle+=10;


    }
    console.log(felle);
   
}

setInterval(mozgat, 10);
